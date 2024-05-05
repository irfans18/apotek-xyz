using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WinFormsApp1.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "m_stuffs",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_m_stuffs", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "m_users",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_m_users", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "t_orders",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    faktur_no = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    faktur_date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_orders", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "t_order_details",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    order_id = table.Column<int>(type: "int", nullable: false),
                    stuff_id = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    price = table.Column<int>(type: "int", nullable: false),
                    qty = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_order_details", x => x.id);
                    table.ForeignKey(
                        name: "FK_t_order_details_m_stuffs_stuff_id",
                        column: x => x.stuff_id,
                        principalTable: "m_stuffs",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_t_order_details_t_orders_order_id",
                        column: x => x.order_id,
                        principalTable: "t_orders",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_t_order_details_order_id",
                table: "t_order_details",
                column: "order_id");

            migrationBuilder.CreateIndex(
                name: "IX_t_order_details_stuff_id",
                table: "t_order_details",
                column: "stuff_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "m_users");

            migrationBuilder.DropTable(
                name: "t_order_details");

            migrationBuilder.DropTable(
                name: "m_stuffs");

            migrationBuilder.DropTable(
                name: "t_orders");
        }
    }
}
