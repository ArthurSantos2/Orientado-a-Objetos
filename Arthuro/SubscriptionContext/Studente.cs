using Arthuro.NotificationContext;
using Arthuro.SharedContext;

namespace Arthuro.SubscriptionContext
{
    public class Student : Base
    {
        public Student()
        {
            Subscriptions = new List<Subscription>();
        }

        public string Name { get; set; }
        public string Email { get; set; }
        public User User { get; set; }
        public IList<Subscription> Subscriptions { get; set; }
        //método
        public void CreateSubscription(Subscription subscription)
        {
            if(IsPremium)
            {
                AddNotification(new Notification("Premium", "The student have active subscription"));
                return;
            }

            Subscriptions.Add(subscription);
        }


        public bool IsPremium => Subscriptions.Any(x => !x.IsInactive);
        
    }
}