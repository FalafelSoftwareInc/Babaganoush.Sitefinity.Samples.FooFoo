using Babaganoush.Sitefinity.WebApi.Api.Abstracts;
using Babaganoush.Sitefinity.Samples.FooFoo.Data;
using Babaganoush.Sitefinity.Samples.FooFoo.Models;

namespace Babaganoush.Sitefinity.Samples.FooFoo.Api
{
    public class SpeakersController : BaseDynamicController<SpeakerModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SpeakersController" /> class.
        /// </summary>
        public SpeakersController()
            : base(FooFooManager.Speakers)
        {

        }
    }
}
