using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TracklyApi.Migrations
{
    /// <inheritdoc />
    public partial class ClassesUpdateMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "AssignedUserID",
                table: "Tickets",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentID", "DepartmentName" },
                values: new object[,]
                {
                    { new Guid("5e6b841c-f835-450a-b7b8-e5bd15d16baa"), 2 },
                    { new Guid("ac0dbc58-5e9b-43b8-b85d-65eaf44af85e"), 1 },
                    { new Guid("e1e781d1-d8d5-4ccb-8a52-119a3e9f0005"), 0 }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "LocationID", "LocationName" },
                values: new object[,]
                {
                    { new Guid("76e3c408-dd32-4567-a8e9-1abfbbeaff38"), 1 },
                    { new Guid("b75ee5b7-fe82-4fdf-8579-a98d5751520d"), 2 },
                    { new Guid("e03c4e15-77b7-4926-ba33-b167d90f3115"), 0 }
                });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "AssetID", "AssetName", "BarcodeNumber", "Category", "DepartmentID", "LocationID" },
                values: new object[,]
                {
                    { new Guid("027fc934-87bf-455f-a888-b1eee80db06c"), "Asset 47", "100000000046", 4, new Guid("ac0dbc58-5e9b-43b8-b85d-65eaf44af85e"), new Guid("76e3c408-dd32-4567-a8e9-1abfbbeaff38") },
                    { new Guid("0dd2ea81-25aa-4309-863a-b525e10d7160"), "Asset 13", "100000000012", 5, new Guid("e1e781d1-d8d5-4ccb-8a52-119a3e9f0005"), new Guid("e03c4e15-77b7-4926-ba33-b167d90f3115") },
                    { new Guid("0f2e0084-19a9-46a6-bf4c-c353e51bf150"), "Asset 49", "100000000048", 6, new Guid("e1e781d1-d8d5-4ccb-8a52-119a3e9f0005"), new Guid("e03c4e15-77b7-4926-ba33-b167d90f3115") },
                    { new Guid("114e42ae-b774-4e25-a99a-1f18dfdef8ff"), "Asset 27", "100000000026", 5, new Guid("5e6b841c-f835-450a-b7b8-e5bd15d16baa"), new Guid("b75ee5b7-fe82-4fdf-8579-a98d5751520d") },
                    { new Guid("140658dd-ec46-4063-86be-f030a3ff5444"), "Asset 39", "100000000038", 3, new Guid("5e6b841c-f835-450a-b7b8-e5bd15d16baa"), new Guid("b75ee5b7-fe82-4fdf-8579-a98d5751520d") },
                    { new Guid("17ffde7e-6ae5-45ee-8bc0-f59ebb1fb5b9"), "Asset 30", "100000000029", 1, new Guid("5e6b841c-f835-450a-b7b8-e5bd15d16baa"), new Guid("b75ee5b7-fe82-4fdf-8579-a98d5751520d") },
                    { new Guid("1860eecd-d80c-46a1-814c-e08a32f4405d"), "Asset 32", "100000000031", 3, new Guid("ac0dbc58-5e9b-43b8-b85d-65eaf44af85e"), new Guid("76e3c408-dd32-4567-a8e9-1abfbbeaff38") },
                    { new Guid("18d66df6-fe6f-4fbf-9929-7c4bdcf30974"), "Asset 68", "100000000067", 4, new Guid("ac0dbc58-5e9b-43b8-b85d-65eaf44af85e"), new Guid("76e3c408-dd32-4567-a8e9-1abfbbeaff38") },
                    { new Guid("1acaab62-c14e-4e99-b662-e4810572dcf3"), "Asset 16", "100000000015", 1, new Guid("e1e781d1-d8d5-4ccb-8a52-119a3e9f0005"), new Guid("e03c4e15-77b7-4926-ba33-b167d90f3115") },
                    { new Guid("1cd4cb1a-0c02-44b1-9922-e6719a44c2f6"), "Asset 61", "100000000060", 4, new Guid("e1e781d1-d8d5-4ccb-8a52-119a3e9f0005"), new Guid("e03c4e15-77b7-4926-ba33-b167d90f3115") },
                    { new Guid("2068321b-f4c2-47ee-853d-298dba676ab8"), "Asset 7", "100000000006", 6, new Guid("e1e781d1-d8d5-4ccb-8a52-119a3e9f0005"), new Guid("e03c4e15-77b7-4926-ba33-b167d90f3115") },
                    { new Guid("21f12b7c-b699-48d7-88af-a79e48eea75d"), "Asset 22", "100000000021", 0, new Guid("e1e781d1-d8d5-4ccb-8a52-119a3e9f0005"), new Guid("e03c4e15-77b7-4926-ba33-b167d90f3115") },
                    { new Guid("2826706c-9e41-4b31-97d8-642d1f55f519"), "Asset 36", "100000000035", 0, new Guid("5e6b841c-f835-450a-b7b8-e5bd15d16baa"), new Guid("b75ee5b7-fe82-4fdf-8579-a98d5751520d") },
                    { new Guid("2b6e0017-67dc-478e-af07-be3d4257e24d"), "Asset 23", "100000000022", 1, new Guid("ac0dbc58-5e9b-43b8-b85d-65eaf44af85e"), new Guid("76e3c408-dd32-4567-a8e9-1abfbbeaff38") },
                    { new Guid("2f59c1b4-aa71-451a-be9c-1cfd23673305"), "Asset 3", "100000000002", 2, new Guid("5e6b841c-f835-450a-b7b8-e5bd15d16baa"), new Guid("b75ee5b7-fe82-4fdf-8579-a98d5751520d") },
                    { new Guid("30d23da0-3af0-480f-b55b-73fb05a33134"), "Asset 38", "100000000037", 2, new Guid("ac0dbc58-5e9b-43b8-b85d-65eaf44af85e"), new Guid("76e3c408-dd32-4567-a8e9-1abfbbeaff38") },
                    { new Guid("35487d71-7908-447d-a94f-2f8345b9e3a0"), "Asset 40", "100000000039", 4, new Guid("e1e781d1-d8d5-4ccb-8a52-119a3e9f0005"), new Guid("e03c4e15-77b7-4926-ba33-b167d90f3115") },
                    { new Guid("3a709247-02c1-4c9e-ac17-251fdff5e14a"), "Asset 50", "100000000049", 0, new Guid("ac0dbc58-5e9b-43b8-b85d-65eaf44af85e"), new Guid("76e3c408-dd32-4567-a8e9-1abfbbeaff38") },
                    { new Guid("3ec157a3-930b-47e3-b80e-0e81decb0caa"), "Asset 60", "100000000059", 3, new Guid("5e6b841c-f835-450a-b7b8-e5bd15d16baa"), new Guid("b75ee5b7-fe82-4fdf-8579-a98d5751520d") },
                    { new Guid("45f9036e-e4bb-45a3-a68e-7577f2c94dd9"), "Asset 18", "100000000017", 3, new Guid("5e6b841c-f835-450a-b7b8-e5bd15d16baa"), new Guid("b75ee5b7-fe82-4fdf-8579-a98d5751520d") },
                    { new Guid("4c8de5a4-ae88-479a-b2ec-7d251382f6c8"), "Asset 34", "100000000033", 5, new Guid("e1e781d1-d8d5-4ccb-8a52-119a3e9f0005"), new Guid("e03c4e15-77b7-4926-ba33-b167d90f3115") },
                    { new Guid("51b6fd0f-aabe-43a3-ade5-33c3c254c8e9"), "Asset 1", "100000000000", 0, new Guid("e1e781d1-d8d5-4ccb-8a52-119a3e9f0005"), new Guid("e03c4e15-77b7-4926-ba33-b167d90f3115") },
                    { new Guid("53a75513-1196-409c-8f32-9dae9efd1c24"), "Asset 28", "100000000027", 6, new Guid("e1e781d1-d8d5-4ccb-8a52-119a3e9f0005"), new Guid("e03c4e15-77b7-4926-ba33-b167d90f3115") },
                    { new Guid("544cb425-ff69-41fd-8682-e3fbadd8983d"), "Asset 33", "100000000032", 4, new Guid("5e6b841c-f835-450a-b7b8-e5bd15d16baa"), new Guid("b75ee5b7-fe82-4fdf-8579-a98d5751520d") },
                    { new Guid("550e5af8-81a3-4dff-8299-afe5bd2fa9c0"), "Asset 67", "100000000066", 3, new Guid("e1e781d1-d8d5-4ccb-8a52-119a3e9f0005"), new Guid("e03c4e15-77b7-4926-ba33-b167d90f3115") },
                    { new Guid("5555f45f-fb76-4b95-a3ed-35618522abd8"), "Asset 57", "100000000056", 0, new Guid("5e6b841c-f835-450a-b7b8-e5bd15d16baa"), new Guid("b75ee5b7-fe82-4fdf-8579-a98d5751520d") },
                    { new Guid("5613d2de-c16d-4cdc-830e-2e4773614f48"), "Asset 9", "100000000008", 1, new Guid("5e6b841c-f835-450a-b7b8-e5bd15d16baa"), new Guid("b75ee5b7-fe82-4fdf-8579-a98d5751520d") },
                    { new Guid("5a16f00f-1174-4b81-90e7-ed55ea586764"), "Asset 65", "100000000064", 1, new Guid("ac0dbc58-5e9b-43b8-b85d-65eaf44af85e"), new Guid("76e3c408-dd32-4567-a8e9-1abfbbeaff38") },
                    { new Guid("5cc0e93e-fbc8-4068-9d92-2b33cd72b30f"), "Asset 14", "100000000013", 6, new Guid("ac0dbc58-5e9b-43b8-b85d-65eaf44af85e"), new Guid("76e3c408-dd32-4567-a8e9-1abfbbeaff38") },
                    { new Guid("60503af3-7b14-4d38-81ba-7a0998563ef7"), "Asset 37", "100000000036", 1, new Guid("e1e781d1-d8d5-4ccb-8a52-119a3e9f0005"), new Guid("e03c4e15-77b7-4926-ba33-b167d90f3115") },
                    { new Guid("627b0b34-7836-4a70-be6f-af0d79c89723"), "Asset 15", "100000000014", 0, new Guid("5e6b841c-f835-450a-b7b8-e5bd15d16baa"), new Guid("b75ee5b7-fe82-4fdf-8579-a98d5751520d") },
                    { new Guid("690df44e-f789-43b7-8903-65cc75d91a7b"), "Asset 35", "100000000034", 6, new Guid("ac0dbc58-5e9b-43b8-b85d-65eaf44af85e"), new Guid("76e3c408-dd32-4567-a8e9-1abfbbeaff38") },
                    { new Guid("69dbd27c-4a8c-4a7f-8434-d8d0497b16d7"), "Asset 53", "100000000052", 3, new Guid("ac0dbc58-5e9b-43b8-b85d-65eaf44af85e"), new Guid("76e3c408-dd32-4567-a8e9-1abfbbeaff38") },
                    { new Guid("6f57fee9-f4b0-483c-8ee6-5f427787e997"), "Asset 63", "100000000062", 6, new Guid("5e6b841c-f835-450a-b7b8-e5bd15d16baa"), new Guid("b75ee5b7-fe82-4fdf-8579-a98d5751520d") },
                    { new Guid("74200675-537f-401a-bd14-9ea38d0ff550"), "Asset 20", "100000000019", 5, new Guid("ac0dbc58-5e9b-43b8-b85d-65eaf44af85e"), new Guid("76e3c408-dd32-4567-a8e9-1abfbbeaff38") },
                    { new Guid("76bb6409-8a56-44be-b7bf-57941b0a643f"), "Asset 31", "100000000030", 2, new Guid("e1e781d1-d8d5-4ccb-8a52-119a3e9f0005"), new Guid("e03c4e15-77b7-4926-ba33-b167d90f3115") },
                    { new Guid("7928b3da-ab4e-483b-9a2a-dbbb42bc074e"), "Asset 52", "100000000051", 2, new Guid("e1e781d1-d8d5-4ccb-8a52-119a3e9f0005"), new Guid("e03c4e15-77b7-4926-ba33-b167d90f3115") },
                    { new Guid("7caecff8-071f-42ab-a774-3008779c4faa"), "Asset 59", "100000000058", 2, new Guid("ac0dbc58-5e9b-43b8-b85d-65eaf44af85e"), new Guid("76e3c408-dd32-4567-a8e9-1abfbbeaff38") },
                    { new Guid("7fdf665d-cb16-438f-a6b9-0821dacaa467"), "Asset 58", "100000000057", 1, new Guid("e1e781d1-d8d5-4ccb-8a52-119a3e9f0005"), new Guid("e03c4e15-77b7-4926-ba33-b167d90f3115") },
                    { new Guid("80f5219a-867d-487b-a386-86c0b227d645"), "Asset 66", "100000000065", 2, new Guid("5e6b841c-f835-450a-b7b8-e5bd15d16baa"), new Guid("b75ee5b7-fe82-4fdf-8579-a98d5751520d") },
                    { new Guid("810a0307-e4b4-4628-a81c-eec6c5f1d66d"), "Asset 8", "100000000007", 0, new Guid("ac0dbc58-5e9b-43b8-b85d-65eaf44af85e"), new Guid("76e3c408-dd32-4567-a8e9-1abfbbeaff38") },
                    { new Guid("81504d3d-ca25-402b-b635-16c80801d0f5"), "Asset 29", "100000000028", 0, new Guid("ac0dbc58-5e9b-43b8-b85d-65eaf44af85e"), new Guid("76e3c408-dd32-4567-a8e9-1abfbbeaff38") },
                    { new Guid("8400ca54-619f-4339-9f5a-07a2268f3541"), "Asset 24", "100000000023", 2, new Guid("5e6b841c-f835-450a-b7b8-e5bd15d16baa"), new Guid("b75ee5b7-fe82-4fdf-8579-a98d5751520d") },
                    { new Guid("8753f5c5-2f3e-4f38-97f4-2864a1735c85"), "Asset 11", "100000000010", 3, new Guid("ac0dbc58-5e9b-43b8-b85d-65eaf44af85e"), new Guid("76e3c408-dd32-4567-a8e9-1abfbbeaff38") },
                    { new Guid("896b7942-9e6e-4897-8ed6-dfcf8656263c"), "Asset 42", "100000000041", 6, new Guid("5e6b841c-f835-450a-b7b8-e5bd15d16baa"), new Guid("b75ee5b7-fe82-4fdf-8579-a98d5751520d") },
                    { new Guid("8d1abc59-c589-461f-9b97-37c2f934a5db"), "Asset 51", "100000000050", 1, new Guid("5e6b841c-f835-450a-b7b8-e5bd15d16baa"), new Guid("b75ee5b7-fe82-4fdf-8579-a98d5751520d") },
                    { new Guid("989c5ee8-b4c6-4051-ba87-97848184a088"), "Asset 64", "100000000063", 0, new Guid("e1e781d1-d8d5-4ccb-8a52-119a3e9f0005"), new Guid("e03c4e15-77b7-4926-ba33-b167d90f3115") },
                    { new Guid("9ba06a74-bacc-493e-beac-e8bb4a26c4b2"), "Asset 19", "100000000018", 4, new Guid("e1e781d1-d8d5-4ccb-8a52-119a3e9f0005"), new Guid("e03c4e15-77b7-4926-ba33-b167d90f3115") },
                    { new Guid("9d7e87f1-bede-4f1b-80c6-dd2e9a825c26"), "Asset 62", "100000000061", 5, new Guid("ac0dbc58-5e9b-43b8-b85d-65eaf44af85e"), new Guid("76e3c408-dd32-4567-a8e9-1abfbbeaff38") },
                    { new Guid("a015f1b9-9f51-4fcf-9d24-ffc40efbd469"), "Asset 26", "100000000025", 4, new Guid("ac0dbc58-5e9b-43b8-b85d-65eaf44af85e"), new Guid("76e3c408-dd32-4567-a8e9-1abfbbeaff38") },
                    { new Guid("a14cd5f7-3a9f-46e4-bc5b-da9e53e8d4cc"), "Asset 54", "100000000053", 4, new Guid("5e6b841c-f835-450a-b7b8-e5bd15d16baa"), new Guid("b75ee5b7-fe82-4fdf-8579-a98d5751520d") },
                    { new Guid("b03606a9-d74e-48ad-9d50-310f182ceb35"), "Asset 41", "100000000040", 5, new Guid("ac0dbc58-5e9b-43b8-b85d-65eaf44af85e"), new Guid("76e3c408-dd32-4567-a8e9-1abfbbeaff38") },
                    { new Guid("c0cf60f6-3100-4d07-ae50-c93d13d657b8"), "Asset 25", "100000000024", 3, new Guid("e1e781d1-d8d5-4ccb-8a52-119a3e9f0005"), new Guid("e03c4e15-77b7-4926-ba33-b167d90f3115") },
                    { new Guid("c3093c85-90fc-4943-9a5f-514ec11e005b"), "Asset 17", "100000000016", 2, new Guid("ac0dbc58-5e9b-43b8-b85d-65eaf44af85e"), new Guid("76e3c408-dd32-4567-a8e9-1abfbbeaff38") },
                    { new Guid("c9fb754e-37b6-433f-90c2-14d3596f7daa"), "Asset 48", "100000000047", 5, new Guid("5e6b841c-f835-450a-b7b8-e5bd15d16baa"), new Guid("b75ee5b7-fe82-4fdf-8579-a98d5751520d") },
                    { new Guid("cb7993e1-355c-4af1-9acc-bd7d49b96177"), "Asset 4", "100000000003", 3, new Guid("e1e781d1-d8d5-4ccb-8a52-119a3e9f0005"), new Guid("e03c4e15-77b7-4926-ba33-b167d90f3115") },
                    { new Guid("d397155b-40b1-40e1-9ec4-422b9c6178f6"), "Asset 55", "100000000054", 5, new Guid("e1e781d1-d8d5-4ccb-8a52-119a3e9f0005"), new Guid("e03c4e15-77b7-4926-ba33-b167d90f3115") },
                    { new Guid("d3b9948b-c027-4e96-bf0f-6e0cf8609313"), "Asset 56", "100000000055", 6, new Guid("ac0dbc58-5e9b-43b8-b85d-65eaf44af85e"), new Guid("76e3c408-dd32-4567-a8e9-1abfbbeaff38") },
                    { new Guid("d7ada6a1-084e-412c-8037-ea84bad83ef3"), "Asset 2", "100000000001", 1, new Guid("ac0dbc58-5e9b-43b8-b85d-65eaf44af85e"), new Guid("76e3c408-dd32-4567-a8e9-1abfbbeaff38") },
                    { new Guid("e2b099a8-b23f-4607-87fa-61852fe7e1a0"), "Asset 21", "100000000020", 6, new Guid("5e6b841c-f835-450a-b7b8-e5bd15d16baa"), new Guid("b75ee5b7-fe82-4fdf-8579-a98d5751520d") },
                    { new Guid("e30b1963-42cf-47d3-9926-f8e4ffbe1021"), "Asset 6", "100000000005", 5, new Guid("5e6b841c-f835-450a-b7b8-e5bd15d16baa"), new Guid("b75ee5b7-fe82-4fdf-8579-a98d5751520d") },
                    { new Guid("e6b0147b-083c-426b-af19-ef8ab0afda67"), "Asset 10", "100000000009", 2, new Guid("e1e781d1-d8d5-4ccb-8a52-119a3e9f0005"), new Guid("e03c4e15-77b7-4926-ba33-b167d90f3115") },
                    { new Guid("e755ae09-7715-4a9c-b311-9cab13534e59"), "Asset 5", "100000000004", 4, new Guid("ac0dbc58-5e9b-43b8-b85d-65eaf44af85e"), new Guid("76e3c408-dd32-4567-a8e9-1abfbbeaff38") },
                    { new Guid("e76f38c0-a41d-4ae2-ae16-fef88a01939e"), "Asset 45", "100000000044", 2, new Guid("5e6b841c-f835-450a-b7b8-e5bd15d16baa"), new Guid("b75ee5b7-fe82-4fdf-8579-a98d5751520d") },
                    { new Guid("ea076f57-798a-4b54-bae9-d4571d1f8b2d"), "Asset 43", "100000000042", 0, new Guid("e1e781d1-d8d5-4ccb-8a52-119a3e9f0005"), new Guid("e03c4e15-77b7-4926-ba33-b167d90f3115") },
                    { new Guid("ed8af95e-97d0-4f28-84aa-bf2389426964"), "Asset 70", "100000000069", 6, new Guid("e1e781d1-d8d5-4ccb-8a52-119a3e9f0005"), new Guid("e03c4e15-77b7-4926-ba33-b167d90f3115") },
                    { new Guid("f219cd48-ed87-4198-a54c-58aa1ca36c41"), "Asset 46", "100000000045", 3, new Guid("e1e781d1-d8d5-4ccb-8a52-119a3e9f0005"), new Guid("e03c4e15-77b7-4926-ba33-b167d90f3115") },
                    { new Guid("f5129329-1cc5-4df9-b145-ae555e95e8f6"), "Asset 12", "100000000011", 4, new Guid("5e6b841c-f835-450a-b7b8-e5bd15d16baa"), new Guid("b75ee5b7-fe82-4fdf-8579-a98d5751520d") },
                    { new Guid("f8879e79-f94f-4d08-8a2d-6c8d33e849eb"), "Asset 69", "100000000068", 5, new Guid("5e6b841c-f835-450a-b7b8-e5bd15d16baa"), new Guid("b75ee5b7-fe82-4fdf-8579-a98d5751520d") },
                    { new Guid("fee00f91-b440-4ec0-83f6-e45d864444d5"), "Asset 44", "100000000043", 1, new Guid("ac0dbc58-5e9b-43b8-b85d-65eaf44af85e"), new Guid("76e3c408-dd32-4567-a8e9-1abfbbeaff38") }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "TicketId", "AssetId", "AssignedUserID", "Category", "Description", "Priority", "Status", "Title" },
                values: new object[,]
                {
                    { new Guid("0c3237e3-fcd1-4f10-8f20-c7e6d53c2330"), new Guid("e6b0147b-083c-426b-af19-ef8ab0afda67"), null, 1, "Description for Ticket 10", 0, 1, "Ticket 10" },
                    { new Guid("0d9debc4-699e-438f-a58d-58a67a571ebf"), new Guid("8753f5c5-2f3e-4f38-97f4-2864a1735c85"), null, 2, "Description for Ticket 11", 1, 2, "Ticket 11" },
                    { new Guid("10ec5dcf-f67f-4985-94b1-eebda8912478"), new Guid("2f59c1b4-aa71-451a-be9c-1cfd23673305"), null, 0, "Description for Ticket 33", 2, 0, "Ticket 33" },
                    { new Guid("1a48c1cc-f065-4127-8d3e-75cef6d15d49"), new Guid("51b6fd0f-aabe-43a3-ade5-33c3c254c8e9"), null, 0, "Description for Ticket 1", 0, 0, "Ticket 1" },
                    { new Guid("22d33b6c-172a-4db2-bd0e-4f26d4e8d934"), new Guid("e755ae09-7715-4a9c-b311-9cab13534e59"), null, 0, "Description for Ticket 5", 1, 0, "Ticket 5" },
                    { new Guid("23f6a18c-3dbf-4bd8-a417-ef71ffbf5712"), new Guid("5cc0e93e-fbc8-4068-9d92-2b33cd72b30f"), null, 1, "Description for Ticket 14", 1, 1, "Ticket 14" },
                    { new Guid("24890e19-24a8-466d-99b4-6c0e9fb50181"), new Guid("74200675-537f-401a-bd14-9ea38d0ff550"), null, 3, "Description for Ticket 20", 1, 3, "Ticket 20" },
                    { new Guid("2ca7cfa0-7a51-4288-86c1-6a3992358d06"), new Guid("2f59c1b4-aa71-451a-be9c-1cfd23673305"), null, 2, "Description for Ticket 3", 2, 2, "Ticket 3" },
                    { new Guid("3471833d-bc8a-4597-82aa-c4dc700f8cd5"), new Guid("e2b099a8-b23f-4607-87fa-61852fe7e1a0"), null, 0, "Description for Ticket 21", 2, 0, "Ticket 21" },
                    { new Guid("35bfea52-5858-4421-8aa8-87f297feca4c"), new Guid("f5129329-1cc5-4df9-b145-ae555e95e8f6"), null, 1, "Description for Ticket 42", 2, 1, "Ticket 42" },
                    { new Guid("3e5fa133-5f32-4b25-b261-4272a29a19a4"), new Guid("0dd2ea81-25aa-4309-863a-b525e10d7160"), null, 0, "Description for Ticket 13", 0, 0, "Ticket 13" },
                    { new Guid("3ecf50f0-e345-402a-8a22-aaaca7d626dc"), new Guid("8400ca54-619f-4339-9f5a-07a2268f3541"), null, 3, "Description for Ticket 24", 2, 3, "Ticket 24" },
                    { new Guid("3f413184-be9d-48cc-95b2-a20af93017d7"), new Guid("5613d2de-c16d-4cdc-830e-2e4773614f48"), null, 0, "Description for Ticket 9", 2, 0, "Ticket 9" },
                    { new Guid("4596c74a-ec71-4cc5-a168-85ad50ba56d8"), new Guid("45f9036e-e4bb-45a3-a68e-7577f2c94dd9"), null, 3, "Description for Ticket 48", 2, 3, "Ticket 48" },
                    { new Guid("465a7b14-36ae-4d04-9860-27e03d4ba1b8"), new Guid("53a75513-1196-409c-8f32-9dae9efd1c24"), null, 3, "Description for Ticket 28", 0, 3, "Ticket 28" },
                    { new Guid("482acade-9072-4ed3-8386-96de1b6ac4e8"), new Guid("45f9036e-e4bb-45a3-a68e-7577f2c94dd9"), null, 1, "Description for Ticket 18", 2, 1, "Ticket 18" },
                    { new Guid("4af5199f-25b2-472a-828c-a0197a1b741d"), new Guid("9ba06a74-bacc-493e-beac-e8bb4a26c4b2"), null, 2, "Description for Ticket 19", 0, 2, "Ticket 19" },
                    { new Guid("50557b5f-84f1-4694-ae00-e0b998f5b352"), new Guid("0dd2ea81-25aa-4309-863a-b525e10d7160"), null, 2, "Description for Ticket 43", 0, 2, "Ticket 43" },
                    { new Guid("557b578a-4a21-4436-ab62-95c0da93f208"), new Guid("e30b1963-42cf-47d3-9926-f8e4ffbe1021"), null, 3, "Description for Ticket 36", 2, 3, "Ticket 36" },
                    { new Guid("57946686-25df-4191-8470-1b47a43a7014"), new Guid("d7ada6a1-084e-412c-8037-ea84bad83ef3"), null, 1, "Description for Ticket 2", 1, 1, "Ticket 2" },
                    { new Guid("5819c316-5131-4966-ab20-14305690148a"), new Guid("114e42ae-b774-4e25-a99a-1f18dfdef8ff"), null, 2, "Description for Ticket 27", 2, 2, "Ticket 27" },
                    { new Guid("5f7540a8-31db-4f03-bc4b-a19a76dc44b3"), new Guid("1acaab62-c14e-4e99-b662-e4810572dcf3"), null, 1, "Description for Ticket 46", 0, 1, "Ticket 46" },
                    { new Guid("6248667a-0b07-4bf1-a489-03e7f15595ac"), new Guid("2068321b-f4c2-47ee-853d-298dba676ab8"), null, 2, "Description for Ticket 7", 0, 2, "Ticket 7" },
                    { new Guid("63c5b7ea-8e90-4f7c-81f4-355cac7f17f6"), new Guid("e755ae09-7715-4a9c-b311-9cab13534e59"), null, 2, "Description for Ticket 35", 1, 2, "Ticket 35" },
                    { new Guid("6980f2d5-698c-489b-a973-36b8309ce54a"), new Guid("cb7993e1-355c-4af1-9acc-bd7d49b96177"), null, 3, "Description for Ticket 4", 0, 3, "Ticket 4" },
                    { new Guid("72966a4a-6375-4bd3-b415-ad838d400c76"), new Guid("2068321b-f4c2-47ee-853d-298dba676ab8"), null, 0, "Description for Ticket 37", 0, 0, "Ticket 37" },
                    { new Guid("776bb8ac-2a28-40c3-bd2e-3a9a7a44d1c8"), new Guid("21f12b7c-b699-48d7-88af-a79e48eea75d"), null, 1, "Description for Ticket 22", 0, 1, "Ticket 22" },
                    { new Guid("7a34b037-06f3-4813-8e19-6c8c73da3040"), new Guid("627b0b34-7836-4a70-be6f-af0d79c89723"), null, 0, "Description for Ticket 45", 2, 0, "Ticket 45" },
                    { new Guid("7d6142fa-beaa-461c-8750-43eca60588b5"), new Guid("8753f5c5-2f3e-4f38-97f4-2864a1735c85"), null, 0, "Description for Ticket 41", 1, 0, "Ticket 41" },
                    { new Guid("81590bc9-a311-4c5c-9aff-fad2f6bb8b7a"), new Guid("d7ada6a1-084e-412c-8037-ea84bad83ef3"), null, 3, "Description for Ticket 32", 1, 3, "Ticket 32" },
                    { new Guid("830eb981-dc4b-48c7-9520-45ca261bda75"), new Guid("a015f1b9-9f51-4fcf-9d24-ffc40efbd469"), null, 1, "Description for Ticket 26", 1, 1, "Ticket 26" },
                    { new Guid("856f2cbd-c49a-4feb-8a15-92d58b65e00e"), new Guid("810a0307-e4b4-4628-a81c-eec6c5f1d66d"), null, 1, "Description for Ticket 38", 1, 1, "Ticket 38" },
                    { new Guid("8821222c-4396-4fd2-b279-202ef19dab35"), new Guid("2b6e0017-67dc-478e-af07-be3d4257e24d"), null, 2, "Description for Ticket 23", 1, 2, "Ticket 23" },
                    { new Guid("8e920974-3f62-41b6-8423-178e7b23646f"), new Guid("81504d3d-ca25-402b-b635-16c80801d0f5"), null, 0, "Description for Ticket 29", 1, 0, "Ticket 29" },
                    { new Guid("90cacad0-8a1b-44b1-b66e-7b8e9be0645b"), new Guid("c0cf60f6-3100-4d07-ae50-c93d13d657b8"), null, 0, "Description for Ticket 25", 0, 0, "Ticket 25" },
                    { new Guid("990d7c9c-9a59-4e87-935a-896bd2cc723f"), new Guid("810a0307-e4b4-4628-a81c-eec6c5f1d66d"), null, 3, "Description for Ticket 8", 1, 3, "Ticket 8" },
                    { new Guid("9ebd1b50-5db9-4a86-b4f0-57391f1e70e6"), new Guid("c3093c85-90fc-4943-9a5f-514ec11e005b"), null, 0, "Description for Ticket 17", 1, 0, "Ticket 17" },
                    { new Guid("a3896533-1e15-4c5c-846f-dbd66317b70c"), new Guid("f5129329-1cc5-4df9-b145-ae555e95e8f6"), null, 3, "Description for Ticket 12", 2, 3, "Ticket 12" },
                    { new Guid("a9e4c904-0c59-4e09-a076-d26141cd4e2d"), new Guid("74200675-537f-401a-bd14-9ea38d0ff550"), null, 1, "Description for Ticket 50", 1, 1, "Ticket 50" },
                    { new Guid("ae07ed93-153e-4431-89f6-8140b4630cb8"), new Guid("627b0b34-7836-4a70-be6f-af0d79c89723"), null, 2, "Description for Ticket 15", 2, 2, "Ticket 15" },
                    { new Guid("bdaa10fc-be58-4b02-a1cc-c658dff4dcc8"), new Guid("cb7993e1-355c-4af1-9acc-bd7d49b96177"), null, 1, "Description for Ticket 34", 0, 1, "Ticket 34" },
                    { new Guid("bf84b3ae-d5cd-42f4-b237-4b1f8eb63581"), new Guid("9ba06a74-bacc-493e-beac-e8bb4a26c4b2"), null, 0, "Description for Ticket 49", 0, 0, "Ticket 49" },
                    { new Guid("c8428bd9-c0e9-4a2a-91cf-47aa8e3ead6b"), new Guid("51b6fd0f-aabe-43a3-ade5-33c3c254c8e9"), null, 2, "Description for Ticket 31", 0, 2, "Ticket 31" },
                    { new Guid("cdabb399-a717-496a-a08c-cefc926c03b9"), new Guid("1acaab62-c14e-4e99-b662-e4810572dcf3"), null, 3, "Description for Ticket 16", 0, 3, "Ticket 16" },
                    { new Guid("d5a13926-9ddf-465b-a21b-bc59c949bf4d"), new Guid("c3093c85-90fc-4943-9a5f-514ec11e005b"), null, 2, "Description for Ticket 47", 1, 2, "Ticket 47" },
                    { new Guid("dd1f4dcc-910e-4e38-a975-8ef2fa627d38"), new Guid("5613d2de-c16d-4cdc-830e-2e4773614f48"), null, 2, "Description for Ticket 39", 2, 2, "Ticket 39" },
                    { new Guid("e136ff1e-c63b-48f3-ad68-5b4203108acc"), new Guid("5cc0e93e-fbc8-4068-9d92-2b33cd72b30f"), null, 3, "Description for Ticket 44", 1, 3, "Ticket 44" },
                    { new Guid("f0d4ee4d-4926-40be-a5e8-ac3917260ada"), new Guid("17ffde7e-6ae5-45ee-8bc0-f59ebb1fb5b9"), null, 1, "Description for Ticket 30", 2, 1, "Ticket 30" },
                    { new Guid("ffea308c-b5df-4aec-83ec-7678310fdc0d"), new Guid("e6b0147b-083c-426b-af19-ef8ab0afda67"), null, 3, "Description for Ticket 40", 0, 3, "Ticket 40" },
                    { new Guid("fff07359-b12b-4d89-8f8b-950c972e6dd0"), new Guid("e30b1963-42cf-47d3-9926-f8e4ffbe1021"), null, 1, "Description for Ticket 6", 2, 1, "Ticket 6" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("027fc934-87bf-455f-a888-b1eee80db06c"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("0f2e0084-19a9-46a6-bf4c-c353e51bf150"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("140658dd-ec46-4063-86be-f030a3ff5444"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("1860eecd-d80c-46a1-814c-e08a32f4405d"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("18d66df6-fe6f-4fbf-9929-7c4bdcf30974"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("1cd4cb1a-0c02-44b1-9922-e6719a44c2f6"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("2826706c-9e41-4b31-97d8-642d1f55f519"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("30d23da0-3af0-480f-b55b-73fb05a33134"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("35487d71-7908-447d-a94f-2f8345b9e3a0"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("3a709247-02c1-4c9e-ac17-251fdff5e14a"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("3ec157a3-930b-47e3-b80e-0e81decb0caa"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("4c8de5a4-ae88-479a-b2ec-7d251382f6c8"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("544cb425-ff69-41fd-8682-e3fbadd8983d"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("550e5af8-81a3-4dff-8299-afe5bd2fa9c0"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("5555f45f-fb76-4b95-a3ed-35618522abd8"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("5a16f00f-1174-4b81-90e7-ed55ea586764"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("60503af3-7b14-4d38-81ba-7a0998563ef7"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("690df44e-f789-43b7-8903-65cc75d91a7b"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("69dbd27c-4a8c-4a7f-8434-d8d0497b16d7"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("6f57fee9-f4b0-483c-8ee6-5f427787e997"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("76bb6409-8a56-44be-b7bf-57941b0a643f"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("7928b3da-ab4e-483b-9a2a-dbbb42bc074e"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("7caecff8-071f-42ab-a774-3008779c4faa"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("7fdf665d-cb16-438f-a6b9-0821dacaa467"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("80f5219a-867d-487b-a386-86c0b227d645"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("896b7942-9e6e-4897-8ed6-dfcf8656263c"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("8d1abc59-c589-461f-9b97-37c2f934a5db"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("989c5ee8-b4c6-4051-ba87-97848184a088"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("9d7e87f1-bede-4f1b-80c6-dd2e9a825c26"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("a14cd5f7-3a9f-46e4-bc5b-da9e53e8d4cc"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("b03606a9-d74e-48ad-9d50-310f182ceb35"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("c9fb754e-37b6-433f-90c2-14d3596f7daa"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("d397155b-40b1-40e1-9ec4-422b9c6178f6"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("d3b9948b-c027-4e96-bf0f-6e0cf8609313"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("e76f38c0-a41d-4ae2-ae16-fef88a01939e"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("ea076f57-798a-4b54-bae9-d4571d1f8b2d"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("ed8af95e-97d0-4f28-84aa-bf2389426964"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("f219cd48-ed87-4198-a54c-58aa1ca36c41"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("f8879e79-f94f-4d08-8a2d-6c8d33e849eb"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("fee00f91-b440-4ec0-83f6-e45d864444d5"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("0c3237e3-fcd1-4f10-8f20-c7e6d53c2330"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("0d9debc4-699e-438f-a58d-58a67a571ebf"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("10ec5dcf-f67f-4985-94b1-eebda8912478"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("1a48c1cc-f065-4127-8d3e-75cef6d15d49"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("22d33b6c-172a-4db2-bd0e-4f26d4e8d934"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("23f6a18c-3dbf-4bd8-a417-ef71ffbf5712"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("24890e19-24a8-466d-99b4-6c0e9fb50181"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("2ca7cfa0-7a51-4288-86c1-6a3992358d06"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("3471833d-bc8a-4597-82aa-c4dc700f8cd5"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("35bfea52-5858-4421-8aa8-87f297feca4c"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("3e5fa133-5f32-4b25-b261-4272a29a19a4"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("3ecf50f0-e345-402a-8a22-aaaca7d626dc"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("3f413184-be9d-48cc-95b2-a20af93017d7"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("4596c74a-ec71-4cc5-a168-85ad50ba56d8"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("465a7b14-36ae-4d04-9860-27e03d4ba1b8"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("482acade-9072-4ed3-8386-96de1b6ac4e8"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("4af5199f-25b2-472a-828c-a0197a1b741d"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("50557b5f-84f1-4694-ae00-e0b998f5b352"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("557b578a-4a21-4436-ab62-95c0da93f208"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("57946686-25df-4191-8470-1b47a43a7014"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("5819c316-5131-4966-ab20-14305690148a"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("5f7540a8-31db-4f03-bc4b-a19a76dc44b3"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("6248667a-0b07-4bf1-a489-03e7f15595ac"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("63c5b7ea-8e90-4f7c-81f4-355cac7f17f6"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("6980f2d5-698c-489b-a973-36b8309ce54a"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("72966a4a-6375-4bd3-b415-ad838d400c76"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("776bb8ac-2a28-40c3-bd2e-3a9a7a44d1c8"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("7a34b037-06f3-4813-8e19-6c8c73da3040"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("7d6142fa-beaa-461c-8750-43eca60588b5"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("81590bc9-a311-4c5c-9aff-fad2f6bb8b7a"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("830eb981-dc4b-48c7-9520-45ca261bda75"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("856f2cbd-c49a-4feb-8a15-92d58b65e00e"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("8821222c-4396-4fd2-b279-202ef19dab35"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("8e920974-3f62-41b6-8423-178e7b23646f"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("90cacad0-8a1b-44b1-b66e-7b8e9be0645b"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("990d7c9c-9a59-4e87-935a-896bd2cc723f"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("9ebd1b50-5db9-4a86-b4f0-57391f1e70e6"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("a3896533-1e15-4c5c-846f-dbd66317b70c"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("a9e4c904-0c59-4e09-a076-d26141cd4e2d"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("ae07ed93-153e-4431-89f6-8140b4630cb8"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("bdaa10fc-be58-4b02-a1cc-c658dff4dcc8"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("bf84b3ae-d5cd-42f4-b237-4b1f8eb63581"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("c8428bd9-c0e9-4a2a-91cf-47aa8e3ead6b"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("cdabb399-a717-496a-a08c-cefc926c03b9"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("d5a13926-9ddf-465b-a21b-bc59c949bf4d"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("dd1f4dcc-910e-4e38-a975-8ef2fa627d38"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("e136ff1e-c63b-48f3-ad68-5b4203108acc"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("f0d4ee4d-4926-40be-a5e8-ac3917260ada"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("ffea308c-b5df-4aec-83ec-7678310fdc0d"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("fff07359-b12b-4d89-8f8b-950c972e6dd0"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("0dd2ea81-25aa-4309-863a-b525e10d7160"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("114e42ae-b774-4e25-a99a-1f18dfdef8ff"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("17ffde7e-6ae5-45ee-8bc0-f59ebb1fb5b9"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("1acaab62-c14e-4e99-b662-e4810572dcf3"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("2068321b-f4c2-47ee-853d-298dba676ab8"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("21f12b7c-b699-48d7-88af-a79e48eea75d"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("2b6e0017-67dc-478e-af07-be3d4257e24d"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("2f59c1b4-aa71-451a-be9c-1cfd23673305"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("45f9036e-e4bb-45a3-a68e-7577f2c94dd9"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("51b6fd0f-aabe-43a3-ade5-33c3c254c8e9"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("53a75513-1196-409c-8f32-9dae9efd1c24"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("5613d2de-c16d-4cdc-830e-2e4773614f48"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("5cc0e93e-fbc8-4068-9d92-2b33cd72b30f"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("627b0b34-7836-4a70-be6f-af0d79c89723"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("74200675-537f-401a-bd14-9ea38d0ff550"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("810a0307-e4b4-4628-a81c-eec6c5f1d66d"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("81504d3d-ca25-402b-b635-16c80801d0f5"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("8400ca54-619f-4339-9f5a-07a2268f3541"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("8753f5c5-2f3e-4f38-97f4-2864a1735c85"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("9ba06a74-bacc-493e-beac-e8bb4a26c4b2"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("a015f1b9-9f51-4fcf-9d24-ffc40efbd469"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("c0cf60f6-3100-4d07-ae50-c93d13d657b8"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("c3093c85-90fc-4943-9a5f-514ec11e005b"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("cb7993e1-355c-4af1-9acc-bd7d49b96177"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("d7ada6a1-084e-412c-8037-ea84bad83ef3"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("e2b099a8-b23f-4607-87fa-61852fe7e1a0"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("e30b1963-42cf-47d3-9926-f8e4ffbe1021"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("e6b0147b-083c-426b-af19-ef8ab0afda67"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("e755ae09-7715-4a9c-b311-9cab13534e59"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("f5129329-1cc5-4df9-b145-ae555e95e8f6"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentID",
                keyValue: new Guid("5e6b841c-f835-450a-b7b8-e5bd15d16baa"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentID",
                keyValue: new Guid("ac0dbc58-5e9b-43b8-b85d-65eaf44af85e"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentID",
                keyValue: new Guid("e1e781d1-d8d5-4ccb-8a52-119a3e9f0005"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: new Guid("76e3c408-dd32-4567-a8e9-1abfbbeaff38"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: new Guid("b75ee5b7-fe82-4fdf-8579-a98d5751520d"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: new Guid("e03c4e15-77b7-4926-ba33-b167d90f3115"));

            migrationBuilder.AlterColumn<Guid>(
                name: "AssignedUserID",
                table: "Tickets",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);
        }
    }
}
