using System.Collections.Generic;

namespace Test.Web.Infrastructure.Services
{
    class TargetsPropertiesCacheService : ITargetsPropertiesCacheService
    {
        private List<string> data = new() {
            "department",
            "position",

            "manageremail",

            "gbu",

            "city",

            "country",

            "group",

            "division",

            "dasid",

            "email",

            "firstname",

            "lastname",

            "testgroup",

            "countrycode",

            "language",

            "gs",

            "admin",
        };

        public IEnumerable<string> GetTargetProperties()
        {
            return data;
        }
    }
}