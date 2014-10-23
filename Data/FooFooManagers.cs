using Babaganoush.Sitefinity.Samples.FooFoo.Content.Managers;

namespace Babaganoush.Sitefinity.Samples.FooFoo.Data
{
    public class FooFooManagers
    {
        public static SpeakersManager Speakers { get { return SpeakersManager.Instance; } }
        public static SessionsManager Sessions { get { return SessionsManager.Instance; } }
    }
}
