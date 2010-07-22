﻿using Orchard.ContentManagement.MetaData;
using Orchard.Data.Migration;

namespace Orchard.Pages.DataMigrations {
    public class PageDataMigration : DataMigrationImpl {

        public int Create() {

            ContentDefinitionManager.AlterTypeDefinition("Page",
              cfg => cfg
                  .WithPart("Page")
                  .WithPart("CommonAspect")
                  .WithPart("IsRoutable")
                  .WithPart("BodyAspect")
               );
            
            return 1;
        }
    }
}