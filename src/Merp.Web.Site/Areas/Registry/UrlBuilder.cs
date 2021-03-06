﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Merp.Web.Site.Areas.Registry
{
    public class UrlBuilder
    {
        private const string areaName = "Registry";

        public static class Registry
        {
            public static string Company()
            {
                return $"/{areaName}/Company";
            }

            public static string CompanyAddEntry()
            {
                return $"/{areaName}/Company/AddEntry";
            }

            public static string CompanyInfo(Guid companyId)
            {
                return $"/{areaName}/Company/Info/{companyId}";
            }

            public static string CompanyChangeName(Guid companyId)
            {
                return $"/{areaName}/Company/ChangeName/{companyId}";
            }

            public static string CompanyChangeLegalAddress(Guid companyId)
            {
                return $"/{areaName}/Company/ChangeLegalAddress/{companyId}";
            }

            public static string CompanyChangeShippingAddress(Guid companyId)
            {
                return $"/{areaName}/Company/ChangeShippingAddress/{companyId}";
            }

            public static string CompanyChangeBillingAddress(Guid companyId)
            {
                return $"/{areaName}/Company/ChangeBillingAddress/{companyId}";
            }

            public static string CompanyAssociateAdministrativeContact(Guid companyId)
            {
                return $"/{areaName}/Company/AssociateAdministrativeContact/{companyId}";
            }

            public static string CompanyAssociateMainContact(Guid companyId)
            {
                return $"/{areaName}/Company/AssociateMainContact/{companyId}";
            }

            public static string CompanyChangeContactInfo(Guid companyId)
            {
                return $"/{areaName}/Company/ChangeContactInfo/{companyId}";
            }

            public static string PersonAddEntry()
            {
                return $"/{areaName}/Person/AddEntry";
            }

            public static string PersonInfo(Guid personId)
            {
                return $"/{areaName}/Person/Info/{personId}";
            }

            public static string PersonChangeAddress(Guid personId)
            {
                return $"/{areaName}/Person/ChangeAddress/{personId}";
            }

            public static string PersonChangeContactInfo(Guid personId)
            {
                return $"/{areaName}/Person/ChangeContactInfo/{personId}";
            }

            public static string Search()
            {
                return $"/{areaName}/Party/Search";
            }
        }
    }
}
