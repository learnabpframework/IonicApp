using System;
using System.Collections.Generic;
using System.Text;
using IonicApp.Localization;
using Volo.Abp.Application.Services;

namespace IonicApp;

/* Inherit your application services from this class.
 */
public abstract class IonicAppAppService : ApplicationService
{
    protected IonicAppAppService()
    {
        LocalizationResource = typeof(IonicAppResource);
    }
}
