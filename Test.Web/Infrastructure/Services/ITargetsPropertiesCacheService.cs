using System.Collections.Generic;

namespace Test.Web.Infrastructure.Services
{
    public interface ITargetsPropertiesCacheService
    {
        public IEnumerable<string> GetTargetProperties();   
    }
}
