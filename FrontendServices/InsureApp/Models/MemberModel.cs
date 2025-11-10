using System.ComponentModel.DataAnnotations;

namespace InsureApp.web.Models
{
    public class MemberModel
    {
        public int  MemberId { get; set; }  // Assuming this will be auto-generated, no validation needed

        //[Required(ErrorMessage = "Name name is required.")]
        //[StringLength(50, ErrorMessage = "Name cannot be longer than 50 characters.")]
        //public string Name { get; set; }

        //[Required(ErrorMessage = "Age is required.")]        
        //public int  Age { get; set; }

        //[Required(ErrorMessage = "Date of birth  is required.")]        
        //public DateOnly DateOfBirth { get; set; }

        //[Required(ErrorMessage = "Occupation is required.")]       
        //public string Occupation { get; set; }

        //[Required(ErrorMessage = "SumInsured is required.")]        
        //public decimal SumInsured  { get; set; }


        public int Id { get; set; }

        public string Name { get; set; }

        public DateOnly DateOfBirth { get; set; }

        public byte AgeNextBirthDay { get; set; }

        public int OccupationId { get; set; }

        public decimal SumInsured { get; set; }
    }
}
