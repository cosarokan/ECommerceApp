using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Application.Features.Brands.Queries.GetBrandById
{
    /// <summary>
    /// BrandDetailDto
    /// </summary>
    public class BrandDetailDto
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; } = null!;
    }
}
