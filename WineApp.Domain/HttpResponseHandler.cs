﻿using Newtonsoft.Json;
using System.Net;

namespace WineApp.Domain
{
    public static class HttpResponseHandler
    {
        public static async Task<Result<T>> HandleError<T>(HttpResponseMessage response)
        {
            var error = await HandleHttpError(response).ConfigureAwait(false);
            return new Result<T>(error, false, response.StatusCode);
        }

        public static async Task<Result> HandleError(HttpResponseMessage response)
        {
            var error = await HandleHttpError(response).ConfigureAwait(false);
            return new Result(error, response.IsSuccessStatusCode, response.StatusCode);
        }

        private static async Task<string> HandleHttpError(HttpResponseMessage response)
        {
            if (response.StatusCode == HttpStatusCode.BadRequest)
            {
                return await GetError(response).ConfigureAwait(false);
            }

            if (response.StatusCode == HttpStatusCode.InternalServerError)
            {
                return "Something went wrong, please try again. If the issue persists, please contact support";
            }

            if (response.StatusCode == HttpStatusCode.NotFound)
            {
                return "Not found";
            }

            return "Ooops, something isn't working as expected.";
        }

        private static async Task<string> GetError(HttpResponseMessage response)
        {
            var responseString = await response.Content.ReadAsStringAsync();
            var errors = JsonConvert.DeserializeObject<Dictionary<string, List<string>>>(responseString);

            var errorMessage = string.Empty;

            foreach (var error in errors)
            {
                var errorString = string.Empty;

                foreach (var err in error.Value)
                {
                    errorString = string.Join(".", err);
                }

                errorMessage = string.IsNullOrEmpty(errorMessage) ? errorString : errorMessage + "," + errorString;
            }

            return errorMessage;
        }
    }
}
