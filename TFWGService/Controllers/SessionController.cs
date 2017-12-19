using Microsoft.Azure.Mobile.Server;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.OData;
using TFWGService.DataObjects;
using TFWGService.Models;

namespace TFWGService.Controllers
{
    public class SessionController:TableController<Session>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            TFWGContext context = new TFWGContext();
            this.DomainManager = new EntityDomainManager<Session>(context,Request);
        }

        public async Task AddNewSession()
        {
            await PostSession(new Session() { Name = "test",Status = true });
        }


        // GET tables/Session
        public IQueryable<Session> GetAllSessions()
        {
            return Query();
        }

        // GET tables/User/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<Session> GetSession(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/User/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<Session> PatchSession(string id,Delta<Session> patch)
        {
            return UpdateAsync(id,patch);
        }

        // POST tables/User
        public async Task<IHttpActionResult> PostSession(Session item)
        {
            Session current = await InsertAsync(item);
            return CreatedAtRoute("Tables",new { id = current.Id },current);
        }

        // DELETE tables/User/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteUser(string id)
        {
            return DeleteAsync(id);
        }
    }
}
