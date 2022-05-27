using IonicApp.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace IonicApp.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class IonicAppController : AbpControllerBase
{
    protected IonicAppController()
    {
        LocalizationResource = typeof(IonicAppResource);
    }
}
