﻿using Babaganoush.Sitefinity.WebApi.Api.Abstracts;
using Babaganoush.Sitefinity.Samples.FooFoo.Data;
using Babaganoush.Sitefinity.Samples.FooFoo.Models;
using Telerik.Sitefinity.Security;

namespace Babaganoush.Sitefinity.Samples.FooFoo.Api
{
    public class SpeakersController : BaseDynamicController<SpeakerModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SpeakersController" /> class.
        /// </summary>
        public SpeakersController()
            : base(FooFooManagers.Speakers)
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
