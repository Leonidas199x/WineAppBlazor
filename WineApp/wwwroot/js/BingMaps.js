function getMap(latitude, longitude) {
    var map = new Microsoft.Maps.Map('#myMap', {
        credentials: 'Your Bing Maps Key',
        center: new Microsoft.Maps.Location(latitude, longitude)
    });
}