using Babaganoush.Sitefinity.WebApi.Api.Abstracts;
using Babaganoush.Sitefinity.Samples.FooFoo.Data;
using Babaganoush.Sitefinity.Samples.FooFoo.Models;
using Telerik.Sitefinity.Security;

namespace Babaganoush.Sitefinity.Samples.FooFoo.Api
{
    public class SessionsController : BaseDynamicController<SessionModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SessionsController" /> class.
        /// </summary>
        public SessionsController()
            : base(FooFooManagers.Sessions)
        {

        }

        /// <summary>
        /// Query if this user is authenticated. This will apply across all web services.
        /// </summary>
        ///
        /// <returns>
        /// true if authenticated, false if not.
        /// </returns>
        //public override bool IsAuthenticated()
        //{
        //    return SecurityManager.IsBackendUser();
        //}
    }
}
