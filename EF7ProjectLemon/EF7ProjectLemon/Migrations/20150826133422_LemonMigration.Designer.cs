using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations.Infrastructure;
using EF7ProjectLemon;

namespace EF7ProjectLemonMigrations
{
    [ContextType(typeof(LemonContext))]
    partial class LemonMigration
    {
        public override string Id
        {
            get { return "20150826133422_LemonMigration"; }
        }

        public override string ProductVersion
        {
            get { return "7.0.0-beta6-13815"; }
        }

        public override void BuildTargetModel(ModelBuilder builder)
        {
            builder
                .Annotation("ProductVersion", "7.0.0-beta6-13815");

            builder.Entity("EF7ProjectLemon.Auth", b =>
                {
                    b.Property<int>("AuthId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Login");

                    b.Key("AuthId");
                });

            builder.Entity("EF7ProjectLemon.Person", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Key("PersonId");
                });
        }
    }
}
