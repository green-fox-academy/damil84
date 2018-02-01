using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PallidaOrientationExamReTake.Models;
using PallidaOrientationExamReTake.Entities;

namespace PallidaOrientationExamReTake.Repositories
{
    public class WebShopRepository
    {
        private WebStoreContext webStoreContext;

        public WebShopRepository(WebStoreContext webStoreContext)
        {
            this.webStoreContext = webStoreContext;
        }
    }
}
