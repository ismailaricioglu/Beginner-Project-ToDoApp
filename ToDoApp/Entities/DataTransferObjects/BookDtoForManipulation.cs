using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DataTransferObjects
{
    public abstract record BookDtoForManipulation
    {
        [Required(ErrorMessage = ("Text is a required field"))]
        [MinLength(2, ErrorMessage = "Text must consist of at least 2 characters")]
        [MaxLength(50, ErrorMessage = "Text must consist of at maximum 50 characters")]
        public String Text { get; init; }

        [Required(ErrorMessage = ("DateTime is a required field"))]
        public DateTime DateTime { get; init; }

        [Required(ErrorMessage = "Cete goryId is required.")]
        public int CategoryId { get; init; }
    }
}
