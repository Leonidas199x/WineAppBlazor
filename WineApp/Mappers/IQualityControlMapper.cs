using DataContract;
using WineApp.ViewModels;

namespace WineApp.Mappers
{
    public interface IQualityControlMapper
    {
        QualityControl Map(QualityControlViewModel value);

        QualityControlViewModel Map(QualityControl value);

        QualityControlCreate MapNew(QualityControlViewModel value);
    }
}