// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityModel;
using IdentityServer4.Test;
using System.Collections.Generic;
using System.Security.Claims;

namespace LiveIDP
{
    public class TestUsers
    {
        public static List<TestUser> Users = new List<TestUser>
        {
            new TestUser{SubjectId = "42a5c9b2-7116-11ea-bc55-0242ac130003", Username = "alice", Password = "alice", 
                Claims = 
                {
                    new Claim(JwtClaimTypes.GivenName, "Alice"),
                    new Claim(JwtClaimTypes.FamilyName, "Smith"),
                }
            },
            new TestUser{SubjectId = "42a5cbce-7116-11ea-bc55-0242ac130003", Username = "bob", Password = "bob", 
                Claims = 
                {
                    new Claim(JwtClaimTypes.GivenName, "Bob"),
                    new Claim(JwtClaimTypes.FamilyName, "Smith"),
                }
            }
        };
    }
}