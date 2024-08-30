using System.ComponentModel.DataAnnotations;

namespace DotLearn.Models
{
    public class TechConcept
    {
        //TopicName Description TechnologyID DifficultyLevel CreatedDate LastUpdatedDate Tags Remarks CategoryID TopicID

        [Key]
        public int TopicID { get; set; }
        public string TopicName { get; set; }
        public string Description { get; set; }
        public int TechnologyID { get; set; }
        public string DifficultyLevel { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public string Tags { get; set; }
        public string Remarks { get; set; }
        public int CategoryID { get; set; }
    }

}

