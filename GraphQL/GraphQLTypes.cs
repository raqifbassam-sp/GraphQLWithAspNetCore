﻿using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeGraphServer.Models;

namespace TimeGraphServer.GraphQL
{
    public class ProjectType : ObjectType<Project>
    {
    }

    public class TimeLogType : ObjectType<TimeLog>
    {
        protected override void Configure(IObjectTypeDescriptor<TimeLog> descriptor)
        {
            descriptor.Authorize();
        }
    }
}
