/*---------------------------------------------------------------------------------------------
 *  Copyright (c) 2017-2018 The International Federation of Red Cross and Red Crescent Societies. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using System;
using Dolittle.Commands;
using Concepts.Projects;

namespace Domain.Projects
{
    public class CreateProject : ICommand
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public Guid NationalSocietyId { get; set; }

        public Guid DataOwnerId { get; set; }
        
        public ProjectSurveillanceContext SurveillanceContext { get; set; }
    }
}
