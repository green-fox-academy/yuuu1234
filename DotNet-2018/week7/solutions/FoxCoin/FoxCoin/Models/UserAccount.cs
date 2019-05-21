using System.ComponentModel.DataAnnotations;

namespace FoxCoin.Models
{
    public class UserAccount
    {
        public long Id { get; set; }

        public string Username { get; set; }

        [ConcurrencyCheck]
        public decimal Balance { get; set; }

        protected bool Equals(UserAccount other)
        {
            return Id == other.Id;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((UserAccount) obj);
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}