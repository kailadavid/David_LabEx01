using Abp.AspNetCore.Mvc.ViewComponents;

namespace David_LabEx01.Web.Views
{
    public abstract class David_LabEx01ViewComponent : AbpViewComponent
    {
        protected David_LabEx01ViewComponent()
        {
            LocalizationSourceName = David_LabEx01Consts.LocalizationSourceName;
        }
    }
}
