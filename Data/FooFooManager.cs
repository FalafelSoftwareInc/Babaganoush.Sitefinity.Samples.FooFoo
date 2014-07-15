using Babaganoush.Sitefinity.Samples.FooFoo.Content.Managers;

namespace Babaganoush.Sitefinity.Samples.FooFoo.Data
{
    public class FooFooManager
    {
        public static SpeakersManager Speakers { get { return SpeakersManager.Instance; } }
    }
}
