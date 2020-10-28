namespace KumovskiLearningCenter.Web.Areas.Administration.Controllers
{
    using KumovskiLearningCenter.Common;
    using KumovskiLearningCenter.Web.Controllers;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
    [Area("Administration")]
    public class AdministrationController : BaseController
    {
    }
}
