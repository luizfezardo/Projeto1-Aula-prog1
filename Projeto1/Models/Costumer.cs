namespace Projeto1.Models
{
    public class Costumer
    {
        public int CostumerId { get; set; }
        public string? EmailAdress{ get; set; }
        public string? firstName { get; set; }
        public string? lastName { get; set; }
        public bool Validate()
        {
            if (string.IsNullOrEmpty(EmailAdress)
                || string.IsNullOrEmpty(firstName)
                || string.IsNullOrEmpty(lastName)
                )

                return false;

            return true;
                
           }
        }    
    }
