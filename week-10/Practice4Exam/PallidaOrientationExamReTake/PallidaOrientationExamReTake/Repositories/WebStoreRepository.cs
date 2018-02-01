using PallidaOrientationExamReTake.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PallidaOrientationExamReTake.Repositories
{
    public class WebStoreRepository
    {
        private WebStoreContext webStoreContext;

        public WebStoreRepository(WebStoreContext webStoreContext)
        {
            this.webStoreContext = webStoreContext;
        }
    }
}
