using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RESTAPIASP.Migrations
{
    /// <inheritdoc />
    public partial class spGetCityById : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string procedure = @"CREATE PROC SpGetCityById @cityId INT
                                    AS
	                                    BEGIN
	                                        SELECT * FROM Cities
	                                        WHERE CityId = @cityId
	                                END";
            migrationBuilder.Sql(procedure);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            string procedure = @"DROP PROC SpGetCityById";
            migrationBuilder.Sql(procedure);
        }
    }
}
