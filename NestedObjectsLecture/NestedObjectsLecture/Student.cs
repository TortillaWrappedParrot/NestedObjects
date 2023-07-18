using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#nullable disable
namespace NestedObjectsLecture
{
    /// <summary>
    /// Represents a individual college student
    /// </summary>
    public class Student
    {
        /// <summary>
        /// The legal first name
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// The legal last name
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// The asigned school email address
        /// </summary>
        public string SchoolEmail { get; set; }
        /// <summary>
        /// The student's chosen phone number
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// School designated advisor
        /// </summary>
        public Advisor AssignedAdvisor { get; set; }
    }
}
