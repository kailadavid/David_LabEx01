using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace David_LabEx01.Web.Views
{
    public abstract class David_LabEx01RazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected David_LabEx01RazorPage()
        {
            LocalizationSourceName = David_LabEx01Consts.LocalizationSourceName;
        }
    }
}
