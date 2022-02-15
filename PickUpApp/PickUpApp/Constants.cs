using System;
using System.Collections.Generic;
using System.Text;

namespace PickUpApp
{
    public static class Constants
    {
        public static readonly string tenantName = "authpaket";
        public static readonly string tenantId = "authpaket.onmicrosoft.com";
        public static readonly string clientId = "1d77a1d9-8399-406d-aebb-26b0440af720";
        public static readonly string policySignin = "B2C_1_RegistrierungAnmeldung";
        public static readonly string policyPasswordReset = "B2C_1_RegistrierungAnmeldung";
        public static readonly string IosKeychainSecurityGroups;

        public static IEnumerable<string> Scopes { get; internal set; }
    }
}
