using Breeze.ContextProvider;
using Breeze.ContextProvider.EF6;
using Breeze.WebApi2;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Appraisal
{
    [BreezeController]
    public class AppraisalController : ApiController
    {
        readonly EFContextProvider<AppraisalEntities> _contextProvider =
         new EFContextProvider<AppraisalEntities>();

        // ~/breeze/todos/Metadata 
        [HttpGet]
        public string Metadata()
        {
            return _contextProvider.Metadata();
        }

        // ~/breeze/todos/Todos
        // ~/breeze/todos/Todos?$filter=IsArchived eq false&$orderby=CreatedAt 
        [HttpGet]
        public IQueryable<Property> Property()
        {
            return _contextProvider.Context.Property;
        }


        [HttpGet]
        public IQueryable<Review> Review()
        {
            return _contextProvider.Context.Review;
        }


        // ~/breeze/todos/SaveChanges
        [HttpPost]
        public SaveResult SaveChanges(JObject saveBundle)
        {
            return _contextProvider.SaveChanges(saveBundle);
        }

    }
}