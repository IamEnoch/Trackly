using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TracklyApi.Migrations
{
    /// <inheritdoc />
    public partial class AddWorkItemMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Assets_AssetId",
                table: "Tickets");

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("006d935f-783b-47cc-88bf-29399efe949f"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("006fe74c-6264-4943-9f8c-f3e1231aeec5"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("00c90716-85e4-4c2c-9627-7e83eb744903"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("01af8927-df1c-4263-a33b-7f22a389a682"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("03c20223-f7b5-4c5d-8658-6ab927c0062b"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("0541a39a-4d46-4175-8ff8-c80aeed03661"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("05d5ae17-90e3-4e2c-8e6b-775867a238fc"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("066276a4-2d84-4ad5-bdb3-3fcf770f60a8"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("06e24378-6270-482c-a6bf-188d6b7a1f02"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("07c2b519-43ba-49d7-9b84-24ce1d028a83"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("0823ec8d-aff6-49bd-a9e4-78975c5fa536"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("08a27b95-75f3-41f5-b035-1440376efb44"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("097d9f4e-8e76-479e-bbd7-8029edb520f1"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("09c0a8d0-31a0-459a-9df9-3f61fc939353"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("0b520330-6b93-4d2d-b726-169fc6779f2c"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("0c176948-2210-41a2-9d5f-aca01e8845b0"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("0c4bfee2-a4b6-409b-8e04-4eaaee9d0f0f"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("0c51ffc8-46a9-4354-97e7-b88c8df3d4c0"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("0d1c6278-7f55-4209-a54b-2b279ae69a0d"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("0d58df7a-9b9c-47cc-a920-a6797e2e078f"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("0e490fc5-11e5-4ec4-9d22-7dabfd31df40"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("0f560bbb-e1b9-4890-927c-98557985fefc"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("0f5b8b07-22b9-4659-ad64-7466848d895a"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("13309ef0-f755-4ed1-9aa6-ab99478fc2b7"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("14542d85-7107-457d-931f-f91a68341950"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("15d2e310-8ff4-4b44-bdb3-33732c05aabb"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("16e9b652-805c-4043-a4ac-8210b26c8493"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("17629edf-317e-4bdc-94a3-0e7ce4082f99"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("17e4205c-045e-40cc-865d-71eb02dfeda0"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("18958d38-1915-489a-8512-2b9f85b08ab3"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("1941ac86-8609-4fcf-a024-4b3b07dfdc40"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("1a14b86e-2afe-4b0d-8ab3-d2879d4ff98d"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("1af21b41-e47f-48e5-abaf-fa4caae0531c"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("1d305e35-7877-4157-849a-eb3283e67ded"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("1d85ab4f-7e30-4a1f-b819-35b9707e1076"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("20cb3523-5f35-40c7-999b-2f53cc6ccf25"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("23ed8393-95e1-419b-9425-bf731593610a"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("23f3ad4e-66b5-44e4-adcb-b8443533ccd7"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("25a750b2-e2fb-4ab7-ba23-b0fc3008933c"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("26643e10-12f4-4776-aa5d-8938a9a3d55f"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("275d1862-9de0-45c8-9b53-5c5a0262344f"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("2783bb79-946f-4ee1-9d74-cc0206acc81c"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("27d78122-dd13-489f-ac21-886f9778eaec"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("2a295373-2189-4d59-958c-1b069da3b36e"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("2b017a99-2e2e-4ca4-b925-7abf0de0a967"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("2c91ae67-0035-48ec-bee2-531eb1e4a965"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("2cb81c44-36c8-4d1f-92f7-54caa0c44f8e"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("2cdbf13b-75d9-4915-b8bc-b32181252a72"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("2d171506-e60c-404d-917f-fed7604b3158"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("2d5e1a4f-2a9a-4ef6-bc7b-754113f1b04d"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("2dcb63d5-c0a4-44c0-8560-b150bce3516f"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("2e29c80f-ad36-4e94-bc25-80c33a88dd48"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("2ea91f05-7470-4d9b-ace2-93cf1758d748"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("2f4b9dc9-129d-47c0-8aaa-a463a2f9b487"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("316aaf5f-f556-479e-85db-5c62c538ff45"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("32940842-5b12-4f20-be06-1a3de7c6ab24"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("32e3d26e-2763-4411-8464-861869cd8db5"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("336e02d4-2b58-441b-95f0-735c5bedc80f"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("35009cb6-b0e5-4fb4-a0f3-e1cb5e5d3fb4"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("353a34ae-0e6b-4709-8f04-912496dcaab3"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("360fe2ab-b789-47b7-a608-bfd03526bc02"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("37c12c61-30f6-45a3-8d22-cee2d8e5300a"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("39c733c9-5d5d-4c7f-a1cd-7b30a382d133"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("3a6fbc4c-d9ea-4063-9d7f-6211e93e948f"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("3cca5634-1728-4f87-b7c1-992f8f709bb9"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("3e481e46-c6c9-47ae-8360-4ce9f8810d3a"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("3e53d89b-0c9f-4f10-9eb5-6c41ae92d35b"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("3f050ffe-eb9b-4e65-b79a-bca956dfcee1"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("3f478139-137b-4b48-87ed-f1ba5c79c2b3"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("452771ad-0209-4130-9b34-311ef876ee44"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("45d9422f-3d4e-4b77-b12f-d0f3443383ae"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("4602c6d3-ab87-4889-bd91-9df6284d79e2"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("47dbc478-4802-4d3d-a10b-a074ddcfefb2"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("484bd586-64b6-49ed-b3ce-92ff7b1468e9"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("4851f5ce-6be0-41f5-af40-1221069045e7"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("4c2b411d-0c53-4751-9839-c2767d62d42f"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("4df05606-18be-43e3-a06e-3bf43d7d22f2"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("4ee39d6f-0c3d-438f-96fa-9351192eb827"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("4f8b5f37-c92c-4ed2-9db4-0e6a32c9588c"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("4ffe792d-0431-4a91-9f9f-740c572e9811"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("551056a6-adc7-44b6-aacb-d249c5adb583"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("56ac5a5d-239f-489b-9f48-dfaca379378d"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("5765eb91-f1fd-4981-92a8-670fd18fd553"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("582a518a-93e5-4711-bd50-d03749f96f09"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("58c422a5-4e8f-435a-b435-741eb7dc55f6"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("5b296cc3-5637-41ba-b9c1-789fa8d4b034"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("5b5509dc-b1ff-4945-911d-8d1747017199"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("5d5ca17a-a901-4c0e-b2f6-2a3d4bb03871"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("5e3845b0-33ee-424b-9c73-67224e0912e5"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("5f10d95e-0e18-4866-a2af-321ae2d18a7c"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("5f6d06f1-7863-4ba7-919c-690af3ae5554"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("5fc08181-9b52-4328-a1c4-48d06589f30c"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("5fdc3bac-6a70-4f84-9bd7-bef1a66f4d55"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("5fe767e6-415e-452b-a44c-f17c22df84fe"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("6379285e-00ea-4a90-af64-134a2a3f5a8d"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("66abb4c0-9e69-491b-b5c8-3de08d1b61dc"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("67da9472-58e1-4730-a112-2425880ff265"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("67fa4ac3-7810-43ad-9679-9444578ebd89"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("689caab1-bd1a-4a71-ab82-905bdea18c18"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("69b2d0e0-578c-403f-851f-329c35d8a4a2"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("6ad0a2c8-c10e-40d7-95ff-d8ce7f1645f3"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("6e5b1db0-ec30-4317-8a3b-de33e2a2b407"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("6fdf814d-031b-4c78-8511-8b6ab18b50bb"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("7016018a-6073-4afb-942b-d7b3a85d6d8b"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("70401625-9202-40af-b843-dccfdb1941b7"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("711bc991-7b09-4bee-9f76-a6bfc19cb061"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("7172bdfb-ff04-4c51-896d-0bc20f5d28c9"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("725d3614-747e-44df-963b-7fe25fd354d9"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("7269a8f3-0391-4824-a3f8-34b5dc48a2fa"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("7290dd46-6869-4188-9642-fa52f096c4f1"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("7458d79c-cff7-4809-a152-9bf0b3bb51c5"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("75058c42-5406-420b-a18e-7f41a04411f8"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("75297974-15d6-444f-bb74-fcf04c6512fd"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("76695146-822c-4570-be7b-86d0585ad0e9"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("77317039-16c4-4462-9b96-cab9c898ecb2"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("77f1bf66-d7da-4975-a829-c86e2f4efd90"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("77f4483e-a0d9-47a4-86db-4bd3d8150a86"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("7a3fb880-3ed6-4ff3-b046-b9dddbf8bf29"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("7b12b8fa-997b-465d-88d7-cbce4dbb92f3"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("7b6fc154-5bf6-4b31-a2d1-6b099e0c777b"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("7bbcae05-f38b-4c46-8a78-3b74d0fe49ed"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("7bc0b421-e003-4b62-81e5-64ac459ee642"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("7c334335-bc15-4ca8-94b7-f3924dbf89c8"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("7e2da645-f79b-42cb-9ffd-e917f82e546d"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("7eb69017-abfc-4311-b81d-79db0708d6a1"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("800cc738-a107-486b-9d28-5ab53d1ed915"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("8054f66d-83f1-4a30-85a3-562f567ace40"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("8175f047-f098-40d0-b9aa-ebccd68cfbbd"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("8268d706-3b97-43f8-8dc9-42176f354a78"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("83387c08-0e70-4f7b-8a2a-3770e5745fb3"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("8436de63-864e-4a99-9307-cacd55afb4fb"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("8797784b-a98d-4313-bdf3-43b453761309"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("88153926-9e85-4b98-8bb5-0c7500090aa0"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("88d7f251-d07c-4ad0-abda-b969f883da84"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("8b205df0-6c28-4a2b-9482-1b4ac418735e"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("8eb772ac-d712-4cdf-8501-fbd4ba5dfe0c"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("8f907541-d968-42be-bc29-a56a7f2e31ac"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("90bcb132-28dc-4991-92a8-c8349857b51b"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("910508d8-5424-4896-9bd7-37065c7ac21e"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("92dd881c-aa9a-434f-b6c9-1a380aa7b345"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("92ef4282-ef71-4359-b320-2e57f54caa9f"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("939412ad-5785-4d11-b9f3-114587238434"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("94990b08-8db5-4fa0-a2ea-67f71282295b"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("9550ca29-e2af-4877-9ed1-a79b42af6edf"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("96c9e32c-5971-4b7a-b13b-95d02b059ca8"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("97324bc3-667d-44dc-a43b-20e5ee7215e1"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("973bffba-5aa1-43d5-ae51-957f256cc124"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("98595c34-09b5-414a-8d4d-cb7e99d3287b"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("987ccee5-0a7d-4a20-aaff-951b199bc47f"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("98ee36e5-eaca-4395-af6e-086b762b7513"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("9bba74f4-ca10-44e9-855e-d22f9be9d1ef"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("9c3a6eef-afac-4b45-b59a-627d2d54eb1c"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("9e39da96-3040-46bd-a183-aa03f77dad39"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("9e56d741-ac8c-49ce-9cd6-4003f7493469"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("9ee1a6cc-bcaf-45d8-ba0d-dcac0f7d7695"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("a090a51a-c197-4e68-a533-c368816d5093"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("a26441aa-e8a0-4db6-ac97-60a43c82199c"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("a3c4a484-06b4-4116-95e3-9a1638fa933a"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("a55dc37a-e4d7-4109-95b7-31fea871ee7c"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("a579569b-845f-4ea2-ae98-862ef22755b0"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("a64e3867-9af8-4a8b-8ccb-1d53483916d7"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("a6bee6ba-52c0-4275-98cd-d46b3e0e9edf"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("a7eaf67a-b60a-4321-85c1-0a17fc705630"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("a805f567-d215-4eb3-bbce-ddee1bf4078d"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("a8379e54-2ca9-4c37-b8ff-702694105e16"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("a8f8821c-7d27-448e-b5dd-cb930012ca4d"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("a93298cb-562f-46a3-bf03-6da259e89ba0"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("ab0283a2-6cf8-4415-9fbf-2a972a434450"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("ab451a0a-f94b-4060-ace4-a0315c8cf7d4"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("ac2bc8ee-cc28-4a31-84b0-0364ae658eed"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("acae08eb-54cd-4fb1-8059-9e8d0f8470db"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("af62b9ba-2429-412b-860e-d599b70821fc"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("b0fae514-abca-4156-b3db-c34c66aa5115"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("b194ece6-aa94-4ee1-802a-460e8eac34bc"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("b5b137ae-d999-42c1-aa75-2aae353fbdb5"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("b5f8a019-c78f-4c20-b7e1-2c1679777fc3"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("b7bb8674-f9d7-40a4-b733-58fa22648365"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("b9195027-0ec7-4af8-88cd-083e5d19b20c"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("bb247636-37e8-453b-b787-2aaaf08cba95"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("bb67b134-9543-4d33-8261-b45ce3cc41bc"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("bdfa11ce-d367-4bb4-920f-6abeffa04daf"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("be916195-af0c-4429-9049-e4f144ba6812"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("bf918249-7351-404b-a3e7-0713f833a9c1"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("c0eb7830-8149-4478-a003-125118ca1fb2"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("c1eeffc3-9c40-4b3f-b90b-62a2af7d2efe"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("c29fd748-7bb7-4ac7-b11f-46323aa6deb9"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("c3550f18-cae3-4c1e-a6d1-a90ca626eccb"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("c36a59cd-741c-4e6f-b6ea-6f050c7f8108"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("c4377922-ce2d-44e3-bf49-8d16d4316e92"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("c4574873-e7eb-4a7d-a9b5-18738bc3e78d"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("c53a19ca-fa12-4c2f-abb2-778045e9dec0"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("c5f32842-4e51-45e6-9d83-7f073fdb65a8"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("c613fe8d-3684-475b-abbd-401bc53fcb31"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("c856b56b-f3d8-4b9e-8583-b6c4151b8342"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("cb656be5-1195-493a-b638-f16781ee964d"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("cbddaabb-fedd-4bfe-af1e-35aa641b57d6"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("cd37d60b-2e42-40bc-83d0-280bc9947756"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("cd627c83-486b-4333-a661-e733a87c1be2"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("cd7f43d6-d6a7-4142-8784-3c680235df96"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("cdca1628-a124-44de-a57b-682a2719580d"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("d27b089a-71b9-428b-837b-59670a96a2d0"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("d314198f-f1ae-499c-9362-22de37a7a4b9"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("d367b6c2-a4fa-471a-b779-7baa145a18d6"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("d3acf02d-7aba-4170-958a-7bd2502d8498"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("d40f4507-a2d2-436d-84cb-ba39a3780488"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("d444d307-098e-483a-ab75-b9919f69f35a"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("d474a362-92af-406c-a366-c23465338d80"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("d48f3f59-1ff1-468b-aed5-0967f1e99baf"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("d4e31a57-f40e-4493-8ed8-c9e6ce819d10"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("d6409a15-5a30-4252-9867-3100d5c06c9f"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("d647c1bb-bf92-4ade-8ff1-4edf52e2132c"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("d7c9a786-0ff0-4799-a302-a481ff32b8da"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("d7ebcbb2-798e-496d-9758-6149a2476380"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("d99ad138-f44e-4300-b91a-d921ae08ddca"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("da8dd2fe-aa4a-48b6-8a64-b9c67efd1371"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("dc95b19d-baad-4f08-9b54-f7256c3ce53b"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("dcb522c8-4d1a-4df4-a9a5-a0f9c92c7d39"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("deb04eba-414a-4adc-92a2-32de5e29d310"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("df3aff80-6cf4-4ce8-9310-3a4317b57a6a"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("e37dcec4-4d08-459a-a625-f3f840bc9e12"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("e3e21ace-afc0-4ec6-bef2-774dea6704b2"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("e4233a0b-3c62-4dfb-b17e-b3f5a8e79590"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("e4bd9421-646e-41ea-b273-98dd1c8d16b8"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("e52d6e95-c68b-4c5a-8fe0-9af05ddfda90"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("e7ae0153-3e16-4ff4-bf41-5d12eb5c4f75"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("e804067c-014c-49d5-b0f2-492f5178e235"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("e8514c3a-d7ab-4eba-8adc-167472ccce42"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("e87ef97f-778d-41c5-91bf-2e98aeda785e"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("eaf5e29f-ee14-4b67-8ef1-34a2b6421cdb"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("eb300fa2-196b-4d3f-a7c4-55166f1b96bd"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("ee177115-815d-4762-93b5-4c8f4c5fcb84"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("ef002305-0ce2-411c-b04a-884c8fd8d1f0"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("ef5942ab-5a60-41bc-b6f6-b77385cc05e6"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("f061f289-0af6-44ca-84a2-5047810b85f4"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("f15d1284-1c56-4786-9695-e1cf3cd0c518"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("f16fc30c-b95d-483f-906d-1742a04a7e60"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("f261c5e1-5c6e-45a0-84de-f8a524aa720e"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("f557e717-be91-4a5f-aa92-0ede5ce699f0"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("f5ea78ea-2402-4e86-866a-fdf036c899aa"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("f64d0520-ce38-4cf1-9c39-d80d11b0f649"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("f6b45988-e83c-4aac-910b-091ec0a5ecd2"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("f6f85c82-c92d-4cbc-baa3-192f11fd7421"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("f7461cc1-8965-45a1-b956-f2e81d552b96"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("fa52054d-8a05-4232-a805-d5770295df46"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("fa79e56d-3a86-4f57-97d1-574f15e333b4"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("fac116ef-9d63-4741-a6a5-ffe27457f967"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("fbbc9a10-f4ad-44aa-934d-30c3475356f3"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("fc1dd97f-c7a9-45d0-b809-269df7636ac9"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("fe5e7e2d-5a1d-46be-8155-4fc8c972d626"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("ffa953c8-44dd-4018-a981-7f5e325a9781"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("06f9353e-eeab-423c-9735-82b4454675a9"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("09941e69-ab5a-44b3-b2e0-0986f086d0dd"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("0faa3b09-22f7-4bcb-879d-318dd5feaa90"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("13a26cda-8be8-4206-8f65-887e483f5a1d"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("1a43d833-873a-4752-97db-61b0b1b59702"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("1c6e429e-2c3d-4c4f-8e70-af5dab94a8c3"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("1c73cb2f-1f73-4ce1-bd49-87f0af207073"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("1e3afbc0-fa9d-4852-b5ec-c56a37dc530b"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("24586359-b9f9-405f-a929-ddba301dbe98"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("26f8d3ed-9e99-4fbb-b559-28d23f6a676a"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("2ab78932-4034-433f-8c5b-0cffa4663b50"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("31dac8c2-9d51-4be6-bff7-695b62ff08f4"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("347a6236-2321-4acb-93cd-4698dc9d3621"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("36bb8619-bdca-4655-b9b8-083f6081ea20"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("38b82a53-e9f1-407f-b817-928ef4c91167"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("4056026f-38fa-45af-a5dd-f3ded60b3106"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("4ba6808e-661a-4c03-9c0c-12ae20524e19"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("4d2d10a9-dfcf-4f07-81f1-d2718a879728"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("504811be-4045-464f-ad2c-a2ba3e79fd44"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("51cb2992-1e93-4621-b8b6-97eedc8c6b88"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("527532c5-51dc-455f-b8d7-a05d5779dec8"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("5464e1a2-8b5f-46e8-8b63-505ff1fbb232"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("55750880-e659-427e-a261-4f8a90a9f7b9"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("59f9af00-7ca3-4f00-a0d0-3878fde14a8d"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("5b70692e-b4ee-4d05-8e73-060750b092d8"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("652b8b51-8e71-48ae-a308-927936dd50a8"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("6a330060-9807-4a5a-8859-1709b3051a72"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("6a920b94-45d1-4690-999b-a0edcf1f5c66"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("6ad74ff3-fef3-4ff2-81d6-ed3316c6c075"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("6cf43432-8e05-412d-9f41-c89d714baf84"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("6e677047-adf9-4ce2-beb0-bd03fe9b08d3"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("70b540f4-5c60-450f-99d8-b72064e2346b"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("752a1277-9a47-447f-a92e-519a8486c357"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("754c7786-8e68-46fb-ae0c-4e192d7d6388"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("768cf51a-8646-4065-b6c1-03b9b3cfad3e"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("7b8c0315-23f8-4da4-b2ec-8e1b7c9ace01"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("8233ad56-3ba6-49f1-8712-b2c17d381e89"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("852407ca-0e97-4ecc-99cf-dc2b78316d6e"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("863e3618-bd38-4cea-9006-9be4efad9173"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("88f54748-8ba5-408d-ba33-22420eacb1d5"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("8f0c178d-1e96-4570-9640-028bdb40f3de"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("8fca6db5-d842-4211-8c8b-fe521136b85c"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("91ea44e8-7071-4fad-a997-cef68f8f509e"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("9280b565-a852-44c4-8aaa-f53cb2a98401"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("a7551ebf-4921-47f6-ab66-9e438f4d12c8"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("a861a8c3-7bc6-48c0-9322-a6eea7e02619"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("ab41ad29-7967-4a1d-aaf5-b19aace3dc08"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("aeb23e03-9e60-4957-8a46-5928af6ebcab"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("b3810c09-3cd8-4833-b5bd-e72d57ffcd35"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("b76e56bd-f5d1-48c8-a0e8-c527bfc08b18"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("b8573315-482a-4cc1-8c51-6ed5ed8766c7"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("bd728943-50b9-4410-a64c-91a91cf93035"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("bf05c8dd-4904-46f8-ad43-f957f4764985"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("bfd22c7c-d7ec-4d06-be63-495a3c25241b"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("c1a78ac3-1caa-4ae9-a58d-01483c4ae9c1"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("c4e77f53-0dba-4b4d-b189-73d37346da46"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("c5e803d2-a6eb-4a5c-b414-a84ca76ca285"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("c83716ab-0e02-42c2-a930-c3a47e0f7231"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("d0e32629-2158-48ea-a52c-740d81017428"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("d8954ace-9ab5-4737-95f2-c3b12b576633"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("da3640c5-5b26-4ba6-a7a6-2c4623f7ce8e"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("e578bb48-45b7-4485-bf3e-66d32b6669f9"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("ea07d31e-03b4-49bb-9e92-cb19a3f3a3be"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("ec1a445c-c029-41d1-b77f-295797af607a"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("ef2fcdd4-dd6e-4904-ab84-2853ce95085b"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("efcbdc10-a276-40e4-8545-a0fd03bd142a"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("f30f26a8-4c22-4fdc-ab37-dcbda25a2111"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("f473fc6e-f8ab-4a58-8e84-c66d3a3ce20d"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("fd25bbdc-f878-43d1-bfc2-410f511c4ae3"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("fd716492-389a-4c5f-8930-b15db879b9e5"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentID",
                keyValue: new Guid("11575d79-7588-4b04-a4f5-96b56c770989"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentID",
                keyValue: new Guid("61f8de66-b936-47ca-97c3-6b8de82f0bb2"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentID",
                keyValue: new Guid("de47a233-c701-4b11-bfda-02d1a8341ab9"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: new Guid("62ef5012-680b-4d50-9374-273d278a60af"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: new Guid("90063f1d-819e-4206-8379-745ca749cbb1"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: new Guid("cc658aad-8b9b-4a89-9866-47327aff4e9d"));

            migrationBuilder.RenameColumn(
                name: "AssetId",
                table: "Tickets",
                newName: "AssetID");

            migrationBuilder.RenameIndex(
                name: "IX_Tickets_AssetId",
                table: "Tickets",
                newName: "IX_Tickets_AssetID");

            migrationBuilder.CreateTable(
                name: "WorkItems",
                columns: table => new
                {
                    WorkItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    Category = table.Column<int>(type: "int", nullable: false),
                    CreatorUserID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AssetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkItems", x => x.WorkItemId);
                    table.ForeignKey(
                        name: "FK_WorkItems_Assets_AssetId",
                        column: x => x.AssetId,
                        principalTable: "Assets",
                        principalColumn: "AssetID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentID", "DepartmentName" },
                values: new object[,]
                {
                    { new Guid("3cfda5f3-bf5d-4b9c-a0c0-434b50cdca95"), 0 },
                    { new Guid("6a7a3122-1599-4314-86c0-754e95976fe6"), 2 },
                    { new Guid("e28294f2-e9a2-4a73-b902-2f02f2e75e63"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "LocationID", "LocationName" },
                values: new object[,]
                {
                    { new Guid("1dae9f97-b3a3-46d2-b5c7-ce367dfc87fa"), 0 },
                    { new Guid("4d111e8b-d0a5-44f6-9206-03dceaa4e75a"), 1 },
                    { new Guid("8d1436a6-8422-4a31-8d6b-0501bcd44abf"), 2 }
                });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "AssetID", "AssetName", "BarcodeNumber", "Category", "DepartmentID", "LocationID" },
                values: new object[,]
                {
                    { new Guid("0056b30a-e1df-4efd-bc3e-6093120cb871"), "Asset 10", "100000000009", 2, new Guid("3cfda5f3-bf5d-4b9c-a0c0-434b50cdca95"), new Guid("1dae9f97-b3a3-46d2-b5c7-ce367dfc87fa") },
                    { new Guid("04b1b138-6397-4062-9e38-537ca161c1da"), "Asset 17", "100000000016", 2, new Guid("e28294f2-e9a2-4a73-b902-2f02f2e75e63"), new Guid("4d111e8b-d0a5-44f6-9206-03dceaa4e75a") },
                    { new Guid("07a7f193-758c-4d54-8d67-5fefea708497"), "Asset 66", "100000000065", 2, new Guid("6a7a3122-1599-4314-86c0-754e95976fe6"), new Guid("8d1436a6-8422-4a31-8d6b-0501bcd44abf") },
                    { new Guid("0ee57408-a701-4710-9bc6-dba6332335cc"), "Asset 18", "100000000017", 3, new Guid("6a7a3122-1599-4314-86c0-754e95976fe6"), new Guid("8d1436a6-8422-4a31-8d6b-0501bcd44abf") },
                    { new Guid("1b2477b5-e225-4f9a-9b8b-e9684e54aa2c"), "Asset 11", "100000000010", 3, new Guid("e28294f2-e9a2-4a73-b902-2f02f2e75e63"), new Guid("4d111e8b-d0a5-44f6-9206-03dceaa4e75a") },
                    { new Guid("20e09b01-c231-4bb5-b112-9e2b218047da"), "Asset 26", "100000000025", 4, new Guid("e28294f2-e9a2-4a73-b902-2f02f2e75e63"), new Guid("4d111e8b-d0a5-44f6-9206-03dceaa4e75a") },
                    { new Guid("21ba0292-2cd8-4047-ba5d-184d24a29877"), "Asset 58", "100000000057", 1, new Guid("3cfda5f3-bf5d-4b9c-a0c0-434b50cdca95"), new Guid("1dae9f97-b3a3-46d2-b5c7-ce367dfc87fa") },
                    { new Guid("25242f77-fdb8-47d6-80fa-01c226c38a36"), "Asset 67", "100000000066", 3, new Guid("3cfda5f3-bf5d-4b9c-a0c0-434b50cdca95"), new Guid("1dae9f97-b3a3-46d2-b5c7-ce367dfc87fa") },
                    { new Guid("26563f3b-42ff-4eed-8a4a-fb0d03d11ff0"), "Asset 6", "100000000005", 5, new Guid("6a7a3122-1599-4314-86c0-754e95976fe6"), new Guid("8d1436a6-8422-4a31-8d6b-0501bcd44abf") },
                    { new Guid("28349c17-6fd4-4600-a21c-113dbe2647f7"), "Asset 65", "100000000064", 1, new Guid("e28294f2-e9a2-4a73-b902-2f02f2e75e63"), new Guid("4d111e8b-d0a5-44f6-9206-03dceaa4e75a") },
                    { new Guid("28d6de2e-d6e5-43b2-bde5-1f7efab0dafc"), "Asset 40", "100000000039", 4, new Guid("3cfda5f3-bf5d-4b9c-a0c0-434b50cdca95"), new Guid("1dae9f97-b3a3-46d2-b5c7-ce367dfc87fa") },
                    { new Guid("2cb82dbd-8391-4046-acf0-8de663e04f36"), "Asset 52", "100000000051", 2, new Guid("3cfda5f3-bf5d-4b9c-a0c0-434b50cdca95"), new Guid("1dae9f97-b3a3-46d2-b5c7-ce367dfc87fa") },
                    { new Guid("2faace28-cf62-40ad-9ddd-6f1d5ef6f1df"), "Asset 15", "100000000014", 0, new Guid("6a7a3122-1599-4314-86c0-754e95976fe6"), new Guid("8d1436a6-8422-4a31-8d6b-0501bcd44abf") },
                    { new Guid("31630389-f081-42c9-9916-d9e0de380e67"), "Asset 2", "100000000001", 1, new Guid("e28294f2-e9a2-4a73-b902-2f02f2e75e63"), new Guid("4d111e8b-d0a5-44f6-9206-03dceaa4e75a") },
                    { new Guid("3285b21d-9cce-4fe2-bd89-578c31da9e49"), "Asset 45", "100000000044", 2, new Guid("6a7a3122-1599-4314-86c0-754e95976fe6"), new Guid("8d1436a6-8422-4a31-8d6b-0501bcd44abf") },
                    { new Guid("44c62471-a823-4da1-b969-673b33771727"), "Asset 23", "100000000022", 1, new Guid("e28294f2-e9a2-4a73-b902-2f02f2e75e63"), new Guid("4d111e8b-d0a5-44f6-9206-03dceaa4e75a") },
                    { new Guid("46c5c2b0-110c-4187-8e2f-13cd9c047c3d"), "Asset 20", "100000000019", 5, new Guid("e28294f2-e9a2-4a73-b902-2f02f2e75e63"), new Guid("4d111e8b-d0a5-44f6-9206-03dceaa4e75a") },
                    { new Guid("477ae5df-9673-439b-96f6-133ec112527c"), "Asset 64", "100000000063", 0, new Guid("3cfda5f3-bf5d-4b9c-a0c0-434b50cdca95"), new Guid("1dae9f97-b3a3-46d2-b5c7-ce367dfc87fa") },
                    { new Guid("49b158ee-531f-44a6-b4ac-1e5afcc5594b"), "Asset 63", "100000000062", 6, new Guid("6a7a3122-1599-4314-86c0-754e95976fe6"), new Guid("8d1436a6-8422-4a31-8d6b-0501bcd44abf") },
                    { new Guid("4aee48d9-4a25-4d95-a69f-416a46f3e2c8"), "Asset 36", "100000000035", 0, new Guid("6a7a3122-1599-4314-86c0-754e95976fe6"), new Guid("8d1436a6-8422-4a31-8d6b-0501bcd44abf") },
                    { new Guid("51b9e1e7-be46-4c8d-b739-b4d13e0731ec"), "Asset 39", "100000000038", 3, new Guid("6a7a3122-1599-4314-86c0-754e95976fe6"), new Guid("8d1436a6-8422-4a31-8d6b-0501bcd44abf") },
                    { new Guid("544a0ef2-14fb-4e36-a7c3-ba5b433b9a8c"), "Asset 42", "100000000041", 6, new Guid("6a7a3122-1599-4314-86c0-754e95976fe6"), new Guid("8d1436a6-8422-4a31-8d6b-0501bcd44abf") },
                    { new Guid("548e6919-14cc-4658-b787-c78242286c3d"), "Asset 9", "100000000008", 1, new Guid("6a7a3122-1599-4314-86c0-754e95976fe6"), new Guid("8d1436a6-8422-4a31-8d6b-0501bcd44abf") },
                    { new Guid("56e654fc-6fa0-483b-bc85-51b57cc38062"), "Asset 43", "100000000042", 0, new Guid("3cfda5f3-bf5d-4b9c-a0c0-434b50cdca95"), new Guid("1dae9f97-b3a3-46d2-b5c7-ce367dfc87fa") },
                    { new Guid("5bc50449-2015-47d7-b4ff-ea4e7f16b024"), "Asset 19", "100000000018", 4, new Guid("3cfda5f3-bf5d-4b9c-a0c0-434b50cdca95"), new Guid("1dae9f97-b3a3-46d2-b5c7-ce367dfc87fa") },
                    { new Guid("5bc72dba-f0f6-4197-a6fd-3e26d20fb4e6"), "Asset 35", "100000000034", 6, new Guid("e28294f2-e9a2-4a73-b902-2f02f2e75e63"), new Guid("4d111e8b-d0a5-44f6-9206-03dceaa4e75a") },
                    { new Guid("5c4bd001-2790-4490-af94-29729ba2211b"), "Asset 32", "100000000031", 3, new Guid("e28294f2-e9a2-4a73-b902-2f02f2e75e63"), new Guid("4d111e8b-d0a5-44f6-9206-03dceaa4e75a") },
                    { new Guid("5d3ce4a9-dfe1-4ba5-a024-086aa86fdeb9"), "Asset 29", "100000000028", 0, new Guid("e28294f2-e9a2-4a73-b902-2f02f2e75e63"), new Guid("4d111e8b-d0a5-44f6-9206-03dceaa4e75a") },
                    { new Guid("5f34e2a4-69d7-4a73-8c43-8763221e031c"), "Asset 41", "100000000040", 5, new Guid("e28294f2-e9a2-4a73-b902-2f02f2e75e63"), new Guid("4d111e8b-d0a5-44f6-9206-03dceaa4e75a") },
                    { new Guid("5f41bf29-aa96-4460-be16-2a106e0798b2"), "Asset 12", "100000000011", 4, new Guid("6a7a3122-1599-4314-86c0-754e95976fe6"), new Guid("8d1436a6-8422-4a31-8d6b-0501bcd44abf") },
                    { new Guid("6117b27a-03c1-4c40-9ca1-ec69ce505cae"), "Asset 16", "100000000015", 1, new Guid("3cfda5f3-bf5d-4b9c-a0c0-434b50cdca95"), new Guid("1dae9f97-b3a3-46d2-b5c7-ce367dfc87fa") },
                    { new Guid("62471ddb-07f1-4794-9efc-a33626470605"), "Asset 8", "100000000007", 0, new Guid("e28294f2-e9a2-4a73-b902-2f02f2e75e63"), new Guid("4d111e8b-d0a5-44f6-9206-03dceaa4e75a") },
                    { new Guid("656d70d9-65ad-434e-ba33-79515cc93282"), "Asset 50", "100000000049", 0, new Guid("e28294f2-e9a2-4a73-b902-2f02f2e75e63"), new Guid("4d111e8b-d0a5-44f6-9206-03dceaa4e75a") },
                    { new Guid("66229280-def8-4159-b496-63fa6a4b3863"), "Asset 44", "100000000043", 1, new Guid("e28294f2-e9a2-4a73-b902-2f02f2e75e63"), new Guid("4d111e8b-d0a5-44f6-9206-03dceaa4e75a") },
                    { new Guid("6b4b3744-f22f-4a10-b60d-f87cbb676462"), "Asset 57", "100000000056", 0, new Guid("6a7a3122-1599-4314-86c0-754e95976fe6"), new Guid("8d1436a6-8422-4a31-8d6b-0501bcd44abf") },
                    { new Guid("6e276381-7eb8-4567-8477-645fc84e9cef"), "Asset 48", "100000000047", 5, new Guid("6a7a3122-1599-4314-86c0-754e95976fe6"), new Guid("8d1436a6-8422-4a31-8d6b-0501bcd44abf") },
                    { new Guid("78719898-28c7-4e82-ac3c-d7cdbb21b8c4"), "Asset 31", "100000000030", 2, new Guid("3cfda5f3-bf5d-4b9c-a0c0-434b50cdca95"), new Guid("1dae9f97-b3a3-46d2-b5c7-ce367dfc87fa") },
                    { new Guid("7957e8e0-1624-4cfc-9cdc-14909e700120"), "Asset 21", "100000000020", 6, new Guid("6a7a3122-1599-4314-86c0-754e95976fe6"), new Guid("8d1436a6-8422-4a31-8d6b-0501bcd44abf") },
                    { new Guid("7e4d675e-f94a-40cc-afd0-66a20dbd018c"), "Asset 53", "100000000052", 3, new Guid("e28294f2-e9a2-4a73-b902-2f02f2e75e63"), new Guid("4d111e8b-d0a5-44f6-9206-03dceaa4e75a") },
                    { new Guid("81bcca65-038d-4880-9418-ab52a2fe031c"), "Asset 34", "100000000033", 5, new Guid("3cfda5f3-bf5d-4b9c-a0c0-434b50cdca95"), new Guid("1dae9f97-b3a3-46d2-b5c7-ce367dfc87fa") },
                    { new Guid("88a02658-6691-49c9-a617-47a3b9cbaa21"), "Asset 5", "100000000004", 4, new Guid("e28294f2-e9a2-4a73-b902-2f02f2e75e63"), new Guid("4d111e8b-d0a5-44f6-9206-03dceaa4e75a") },
                    { new Guid("8de70f65-1c32-4860-8b60-73b64054e994"), "Asset 46", "100000000045", 3, new Guid("3cfda5f3-bf5d-4b9c-a0c0-434b50cdca95"), new Guid("1dae9f97-b3a3-46d2-b5c7-ce367dfc87fa") },
                    { new Guid("903fde5f-8b2a-40ea-bfad-1c5be5505831"), "Asset 59", "100000000058", 2, new Guid("e28294f2-e9a2-4a73-b902-2f02f2e75e63"), new Guid("4d111e8b-d0a5-44f6-9206-03dceaa4e75a") },
                    { new Guid("9264bfc7-2a04-41e8-8a82-fc212e003efa"), "Asset 1", "100000000000", 0, new Guid("3cfda5f3-bf5d-4b9c-a0c0-434b50cdca95"), new Guid("1dae9f97-b3a3-46d2-b5c7-ce367dfc87fa") },
                    { new Guid("92c83e8d-94b6-4c94-86aa-20b78674a960"), "Asset 38", "100000000037", 2, new Guid("e28294f2-e9a2-4a73-b902-2f02f2e75e63"), new Guid("4d111e8b-d0a5-44f6-9206-03dceaa4e75a") },
                    { new Guid("944ec632-8ed2-4b07-b4d5-d44a50cadceb"), "Asset 47", "100000000046", 4, new Guid("e28294f2-e9a2-4a73-b902-2f02f2e75e63"), new Guid("4d111e8b-d0a5-44f6-9206-03dceaa4e75a") },
                    { new Guid("9d55b16d-14d8-4345-a067-30be4122ccbe"), "Asset 56", "100000000055", 6, new Guid("e28294f2-e9a2-4a73-b902-2f02f2e75e63"), new Guid("4d111e8b-d0a5-44f6-9206-03dceaa4e75a") },
                    { new Guid("9d64707b-ab3f-4516-bce1-bed489adc112"), "Asset 68", "100000000067", 4, new Guid("e28294f2-e9a2-4a73-b902-2f02f2e75e63"), new Guid("4d111e8b-d0a5-44f6-9206-03dceaa4e75a") },
                    { new Guid("a03d5308-2dbb-40af-a138-277771f7deb6"), "Asset 13", "100000000012", 5, new Guid("3cfda5f3-bf5d-4b9c-a0c0-434b50cdca95"), new Guid("1dae9f97-b3a3-46d2-b5c7-ce367dfc87fa") },
                    { new Guid("a0f84582-77e3-462d-860e-66037897df21"), "Asset 25", "100000000024", 3, new Guid("3cfda5f3-bf5d-4b9c-a0c0-434b50cdca95"), new Guid("1dae9f97-b3a3-46d2-b5c7-ce367dfc87fa") },
                    { new Guid("a1a44f62-3095-4a1a-ba87-cadd4f996fb6"), "Asset 33", "100000000032", 4, new Guid("6a7a3122-1599-4314-86c0-754e95976fe6"), new Guid("8d1436a6-8422-4a31-8d6b-0501bcd44abf") },
                    { new Guid("a39366ab-52b4-4353-8149-840f0e65fd53"), "Asset 4", "100000000003", 3, new Guid("3cfda5f3-bf5d-4b9c-a0c0-434b50cdca95"), new Guid("1dae9f97-b3a3-46d2-b5c7-ce367dfc87fa") },
                    { new Guid("a4902ad1-f16a-4186-9291-76caebcf2827"), "Asset 30", "100000000029", 1, new Guid("6a7a3122-1599-4314-86c0-754e95976fe6"), new Guid("8d1436a6-8422-4a31-8d6b-0501bcd44abf") },
                    { new Guid("b09b730f-479d-420a-a4b4-60f0831682a3"), "Asset 61", "100000000060", 4, new Guid("3cfda5f3-bf5d-4b9c-a0c0-434b50cdca95"), new Guid("1dae9f97-b3a3-46d2-b5c7-ce367dfc87fa") },
                    { new Guid("b560b1ab-aa94-477c-957e-b93f96dcf73b"), "Asset 37", "100000000036", 1, new Guid("3cfda5f3-bf5d-4b9c-a0c0-434b50cdca95"), new Guid("1dae9f97-b3a3-46d2-b5c7-ce367dfc87fa") },
                    { new Guid("b5a5c2ef-ba30-45cd-b69a-7542b6e1225d"), "Asset 27", "100000000026", 5, new Guid("6a7a3122-1599-4314-86c0-754e95976fe6"), new Guid("8d1436a6-8422-4a31-8d6b-0501bcd44abf") },
                    { new Guid("b91e96a7-3994-4636-93fb-3afd9eff757a"), "Asset 54", "100000000053", 4, new Guid("6a7a3122-1599-4314-86c0-754e95976fe6"), new Guid("8d1436a6-8422-4a31-8d6b-0501bcd44abf") },
                    { new Guid("be928e80-e187-4c71-8338-5c5f469c14e2"), "Asset 24", "100000000023", 2, new Guid("6a7a3122-1599-4314-86c0-754e95976fe6"), new Guid("8d1436a6-8422-4a31-8d6b-0501bcd44abf") },
                    { new Guid("c1c210aa-03af-41b4-80dc-8a7785eac2bd"), "Asset 69", "100000000068", 5, new Guid("6a7a3122-1599-4314-86c0-754e95976fe6"), new Guid("8d1436a6-8422-4a31-8d6b-0501bcd44abf") },
                    { new Guid("c3ad68a7-8bee-4eeb-94d5-f271809d5b30"), "Asset 14", "100000000013", 6, new Guid("e28294f2-e9a2-4a73-b902-2f02f2e75e63"), new Guid("4d111e8b-d0a5-44f6-9206-03dceaa4e75a") },
                    { new Guid("c5411f95-3578-4056-9ccc-697bdbcb3444"), "Asset 3", "100000000002", 2, new Guid("6a7a3122-1599-4314-86c0-754e95976fe6"), new Guid("8d1436a6-8422-4a31-8d6b-0501bcd44abf") },
                    { new Guid("c7e9d74c-b613-422d-b7ac-6bb8ebd28d59"), "Asset 60", "100000000059", 3, new Guid("6a7a3122-1599-4314-86c0-754e95976fe6"), new Guid("8d1436a6-8422-4a31-8d6b-0501bcd44abf") },
                    { new Guid("cab1cee3-26b2-495f-8b4c-136380a02e63"), "Asset 55", "100000000054", 5, new Guid("3cfda5f3-bf5d-4b9c-a0c0-434b50cdca95"), new Guid("1dae9f97-b3a3-46d2-b5c7-ce367dfc87fa") },
                    { new Guid("cee9a32c-614e-4240-8ab7-caff4d4fdbfd"), "Asset 22", "100000000021", 0, new Guid("3cfda5f3-bf5d-4b9c-a0c0-434b50cdca95"), new Guid("1dae9f97-b3a3-46d2-b5c7-ce367dfc87fa") },
                    { new Guid("d3632d7b-c9e0-4d01-9757-ff659ebbbdd9"), "Asset 28", "100000000027", 6, new Guid("3cfda5f3-bf5d-4b9c-a0c0-434b50cdca95"), new Guid("1dae9f97-b3a3-46d2-b5c7-ce367dfc87fa") },
                    { new Guid("db42d35b-dcbe-4ef0-b306-1c1dda9ecc1e"), "Asset 7", "100000000006", 6, new Guid("3cfda5f3-bf5d-4b9c-a0c0-434b50cdca95"), new Guid("1dae9f97-b3a3-46d2-b5c7-ce367dfc87fa") },
                    { new Guid("dc68b9c0-a916-4b63-ac54-c1b5c5983551"), "Asset 70", "100000000069", 6, new Guid("3cfda5f3-bf5d-4b9c-a0c0-434b50cdca95"), new Guid("1dae9f97-b3a3-46d2-b5c7-ce367dfc87fa") },
                    { new Guid("eaf79b1e-b12a-4ec0-8e48-5e8ff1c3be01"), "Asset 62", "100000000061", 5, new Guid("e28294f2-e9a2-4a73-b902-2f02f2e75e63"), new Guid("4d111e8b-d0a5-44f6-9206-03dceaa4e75a") },
                    { new Guid("f5a92fa3-1709-4f49-b81d-33b5877b158f"), "Asset 51", "100000000050", 1, new Guid("6a7a3122-1599-4314-86c0-754e95976fe6"), new Guid("8d1436a6-8422-4a31-8d6b-0501bcd44abf") },
                    { new Guid("fbb9028f-315e-4ae5-b63e-c93e3406eb71"), "Asset 49", "100000000048", 6, new Guid("3cfda5f3-bf5d-4b9c-a0c0-434b50cdca95"), new Guid("1dae9f97-b3a3-46d2-b5c7-ce367dfc87fa") }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "TicketId", "AssetID", "AssignedUserID", "Category", "CreatedAt", "Description", "Priority", "Status", "Title" },
                values: new object[,]
                {
                    { new Guid("011ca563-252b-45e6-a19d-c64b869eec63"), new Guid("c3ad68a7-8bee-4eeb-94d5-f271809d5b30"), null, 3, new DateTime(2023, 10, 10, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(6102), "Description for Ticket 84", 2, 3, "Ticket 84" },
                    { new Guid("017c5930-0f5f-4bb3-944e-89b6775b35aa"), new Guid("6117b27a-03c1-4c40-9ca1-ec69ce505cae"), null, 1, new DateTime(2023, 5, 21, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(9234), "Description for Ticket 226", 0, 1, "Ticket 226" },
                    { new Guid("03bd545a-6af4-4b58-b564-65e10c7ac151"), new Guid("b09b730f-479d-420a-a4b4-60f0831682a3"), null, 0, new DateTime(2023, 11, 2, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(5715), "Description for Ticket 61", 0, 0, "Ticket 61" },
                    { new Guid("0562bf50-c04c-4c82-9b14-1235ba2c768e"), new Guid("07a7f193-758c-4d54-8d67-5fefea708497"), null, 1, new DateTime(2023, 6, 10, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(8792), "Description for Ticket 206", 1, 1, "Ticket 206" },
                    { new Guid("09ce97a3-7dc1-440e-a8d6-f5965670bb7e"), new Guid("b5a5c2ef-ba30-45cd-b69a-7542b6e1225d"), null, 2, new DateTime(2023, 12, 6, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(5215), "Description for Ticket 27", 2, 2, "Ticket 27" },
                    { new Guid("0a63ea77-5652-4522-958f-f4fe66ecd44b"), new Guid("66229280-def8-4159-b496-63fa6a4b3863"), null, 1, new DateTime(2023, 9, 10, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(7031), "Description for Ticket 114", 2, 1, "Ticket 114" },
                    { new Guid("0beebcce-74bf-4cd8-9c85-47002bfd41a7"), new Guid("548e6919-14cc-4658-b787-c78242286c3d"), null, 2, new DateTime(2023, 10, 15, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(5995), "Description for Ticket 79", 0, 2, "Ticket 79" },
                    { new Guid("0cc988b4-4393-4b38-8ff5-a1291913c693"), new Guid("21ba0292-2cd8-4047-ba5d-184d24a29877"), null, 3, new DateTime(2023, 8, 27, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(7489), "Description for Ticket 128", 1, 3, "Ticket 128" },
                    { new Guid("0d3d796d-275d-465f-b859-c558f21ba9da"), new Guid("a1a44f62-3095-4a1a-ba87-cadd4f996fb6"), null, 2, new DateTime(2023, 9, 21, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(6788), "Description for Ticket 103", 0, 2, "Ticket 103" },
                    { new Guid("0f637ae4-80c4-4986-b5a5-658045a69e0d"), new Guid("5c4bd001-2790-4490-af94-29729ba2211b"), null, 1, new DateTime(2023, 9, 22, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(6779), "Description for Ticket 102", 2, 1, "Ticket 102" },
                    { new Guid("1030e7f4-64f3-4cf6-93b1-82489d2e9d58"), new Guid("548e6919-14cc-4658-b787-c78242286c3d"), null, 2, new DateTime(2023, 5, 28, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(9143), "Description for Ticket 219", 2, 2, "Ticket 219" },
                    { new Guid("10af1276-3fa2-420a-9f99-7ef15806ab58"), new Guid("5c4bd001-2790-4490-af94-29729ba2211b"), null, 1, new DateTime(2023, 5, 5, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(9473), "Description for Ticket 242", 1, 1, "Ticket 242" },
                    { new Guid("10d9e0fc-52de-4441-abdc-21bf8778efa0"), new Guid("5f34e2a4-69d7-4a73-8c43-8763221e031c"), null, 0, new DateTime(2023, 7, 5, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(8397), "Description for Ticket 181", 0, 0, "Ticket 181" },
                    { new Guid("120bfbf8-c7a2-4eac-b158-73d593e92570"), new Guid("b5a5c2ef-ba30-45cd-b69a-7542b6e1225d"), null, 2, new DateTime(2023, 7, 19, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(8168), "Description for Ticket 167", 1, 2, "Ticket 167" },
                    { new Guid("147907a5-fc3c-4550-ad68-652ab5a006e8"), new Guid("548e6919-14cc-4658-b787-c78242286c3d"), null, 0, new DateTime(2023, 8, 6, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(7913), "Description for Ticket 149", 1, 0, "Ticket 149" },
                    { new Guid("192d1341-a2f0-4021-a4c7-00537934bb2b"), new Guid("46c5c2b0-110c-4187-8e2f-13cd9c047c3d"), null, 1, new DateTime(2023, 10, 4, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(6337), "Description for Ticket 90", 2, 1, "Ticket 90" },
                    { new Guid("1c0233fa-57e0-4f8f-af88-be07087eddd0"), new Guid("cab1cee3-26b2-495f-8b4c-136380a02e63"), null, 0, new DateTime(2023, 8, 30, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(7450), "Description for Ticket 125", 1, 0, "Ticket 125" },
                    { new Guid("1eb82d13-b5b0-441a-8286-0e7648241516"), new Guid("51b9e1e7-be46-4c8d-b739-b4d13e0731ec"), null, 0, new DateTime(2023, 4, 28, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(9568), "Description for Ticket 249", 2, 0, "Ticket 249" },
                    { new Guid("1eda4600-1230-4cc9-bf40-024eade57ef5"), new Guid("544a0ef2-14fb-4e36-a7c3-ba5b433b9a8c"), null, 1, new DateTime(2023, 7, 4, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(8410), "Description for Ticket 182", 1, 1, "Ticket 182" },
                    { new Guid("1ee0671d-a62d-4dcc-9dc3-195ca4a0dd61"), new Guid("5bc50449-2015-47d7-b4ff-ea4e7f16b024"), null, 2, new DateTime(2023, 7, 27, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(8051), "Description for Ticket 159", 2, 2, "Ticket 159" },
                    { new Guid("1f2c5a8d-c74b-4a7e-917a-84cacc89831a"), new Guid("62471ddb-07f1-4794-9efc-a33626470605"), null, 3, new DateTime(2023, 8, 7, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(7899), "Description for Ticket 148", 0, 3, "Ticket 148" },
                    { new Guid("1f46c81c-831a-4e54-8adf-0503de33350f"), new Guid("a4902ad1-f16a-4186-9291-76caebcf2827"), null, 1, new DateTime(2023, 7, 16, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(8247), "Description for Ticket 170", 1, 1, "Ticket 170" },
                    { new Guid("20302490-c448-48c4-b9c3-e90694641459"), new Guid("51b9e1e7-be46-4c8d-b739-b4d13e0731ec"), null, 2, new DateTime(2023, 7, 7, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(8368), "Description for Ticket 179", 1, 2, "Ticket 179" },
                    { new Guid("221b1f2b-638e-4f99-97f0-aead23d2a183"), new Guid("9d55b16d-14d8-4345-a067-30be4122ccbe"), null, 3, new DateTime(2023, 11, 7, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(5650), "Description for Ticket 56", 1, 3, "Ticket 56" },
                    { new Guid("2342ebee-a163-418d-b024-25594cdbafa1"), new Guid("62471ddb-07f1-4794-9efc-a33626470605"), null, 1, new DateTime(2023, 10, 16, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(5982), "Description for Ticket 78", 2, 1, "Ticket 78" },
                    { new Guid("256797b5-35e0-48ad-b8e5-d470c69eeeae"), new Guid("92c83e8d-94b6-4c94-86aa-20b78674a960"), null, 3, new DateTime(2023, 4, 29, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(9555), "Description for Ticket 248", 1, 3, "Ticket 248" },
                    { new Guid("262b6145-d7cf-4da7-b706-9dc8fe4cbcf4"), new Guid("0ee57408-a701-4710-9bc6-dba6332335cc"), null, 3, new DateTime(2023, 10, 6, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(6313), "Description for Ticket 88", 0, 3, "Ticket 88" },
                    { new Guid("29325b2a-92c3-40b6-adaa-03206ed7f70c"), new Guid("51b9e1e7-be46-4c8d-b739-b4d13e0731ec"), null, 2, new DateTime(2023, 11, 24, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(5371), "Description for Ticket 39", 2, 2, "Ticket 39" },
                    { new Guid("298a2edc-477b-4d06-b912-7a2f2e16716c"), new Guid("5d3ce4a9-dfe1-4ba5-a024-086aa86fdeb9"), null, 2, new DateTime(2023, 5, 8, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(9433), "Description for Ticket 239", 1, 2, "Ticket 239" },
                    { new Guid("2c5b8f2b-3ed3-46be-8e12-2911ff3148ce"), new Guid("92c83e8d-94b6-4c94-86aa-20b78674a960"), null, 1, new DateTime(2023, 7, 8, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(8355), "Description for Ticket 178", 0, 1, "Ticket 178" },
                    { new Guid("2d613196-7fcb-4cb8-9fc0-9758ce01a831"), new Guid("0ee57408-a701-4710-9bc6-dba6332335cc"), null, 3, new DateTime(2023, 5, 19, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(9262), "Description for Ticket 228", 2, 3, "Ticket 228" },
                    { new Guid("2df71499-4b15-4a5d-92e8-de04750ff8cb"), new Guid("78719898-28c7-4e82-ac3c-d7cdbb21b8c4"), null, 2, new DateTime(2023, 12, 2, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(5267), "Description for Ticket 31", 0, 2, "Ticket 31" },
                    { new Guid("2ffafc4b-b28f-46e8-9fc5-86879fd03a92"), new Guid("20e09b01-c231-4bb5-b112-9e2b218047da"), null, 3, new DateTime(2023, 9, 28, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(6725), "Description for Ticket 96", 2, 3, "Ticket 96" },
                    { new Guid("32107dc2-f6fc-4043-a8b9-3bcbab13dd57"), new Guid("31630389-f081-42c9-9916-d9e0de380e67"), null, 1, new DateTime(2023, 8, 13, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(7782), "Description for Ticket 142", 0, 1, "Ticket 142" },
                    { new Guid("333ce836-4ddd-432c-ab18-9f2b426e7a94"), new Guid("a39366ab-52b4-4353-8149-840f0e65fd53"), null, 3, new DateTime(2023, 12, 29, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(4717), "Description for Ticket 4", 0, 3, "Ticket 4" },
                    { new Guid("33e77004-01ce-41ea-ad9b-e661b5412290"), new Guid("a1a44f62-3095-4a1a-ba87-cadd4f996fb6"), null, 2, new DateTime(2023, 5, 4, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(9485), "Description for Ticket 243", 2, 2, "Ticket 243" },
                    { new Guid("342d7a58-795e-48cc-a50d-f15788769d12"), new Guid("88a02658-6691-49c9-a617-47a3b9cbaa21"), null, 2, new DateTime(2023, 10, 19, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(5939), "Description for Ticket 75", 2, 2, "Ticket 75" },
                    { new Guid("355a4f68-3089-4a9f-a716-d916a4608e90"), new Guid("78719898-28c7-4e82-ac3c-d7cdbb21b8c4"), null, 0, new DateTime(2023, 9, 23, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(6771), "Description for Ticket 101", 1, 0, "Ticket 101" },
                    { new Guid("358f410f-389b-4665-b381-21b4cb3bf4ba"), new Guid("fbb9028f-315e-4ae5-b63e-c93e3406eb71"), null, 0, new DateTime(2023, 6, 27, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(8509), "Description for Ticket 189", 2, 0, "Ticket 189" },
                    { new Guid("3649cfe3-db03-4ada-be74-089d3d1989d9"), new Guid("21ba0292-2cd8-4047-ba5d-184d24a29877"), null, 1, new DateTime(2023, 6, 18, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(8684), "Description for Ticket 198", 2, 1, "Ticket 198" },
                    { new Guid("366f3301-cf8c-4e31-9bd3-6ebdf7aae411"), new Guid("d3632d7b-c9e0-4d01-9757-ff659ebbbdd9"), null, 3, new DateTime(2023, 7, 18, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(8181), "Description for Ticket 168", 2, 3, "Ticket 168" },
                    { new Guid("3773064b-3159-45a1-be7c-08bff1c410cf"), new Guid("81bcca65-038d-4880-9418-ab52a2fe031c"), null, 1, new DateTime(2023, 7, 12, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(8303), "Description for Ticket 174", 2, 1, "Ticket 174" },
                    { new Guid("37b9c5d1-b997-4962-b234-e097e6aa5e0b"), new Guid("5f41bf29-aa96-4460-be16-2a106e0798b2"), null, 1, new DateTime(2023, 5, 25, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(9185), "Description for Ticket 222", 2, 1, "Ticket 222" },
                    { new Guid("397974e3-eb35-4033-98b2-19d41f588194"), new Guid("5d3ce4a9-dfe1-4ba5-a024-086aa86fdeb9"), null, 0, new DateTime(2023, 7, 17, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(8232), "Description for Ticket 169", 0, 0, "Ticket 169" },
                    { new Guid("39abf9de-2086-40dd-b6c9-eee9f6c4d24e"), new Guid("4aee48d9-4a25-4d95-a69f-416a46f3e2c8"), null, 3, new DateTime(2023, 7, 10, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(8330), "Description for Ticket 176", 1, 3, "Ticket 176" },
                    { new Guid("39b5f7f4-34b2-4906-92e9-bc75c4439cc3"), new Guid("2cb82dbd-8391-4046-acf0-8de663e04f36"), null, 3, new DateTime(2023, 6, 24, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(8592), "Description for Ticket 192", 2, 3, "Ticket 192" },
                    { new Guid("3a4a5ff5-2b88-4a76-b0a0-69cf0daf4341"), new Guid("62471ddb-07f1-4794-9efc-a33626470605"), null, 3, new DateTime(2023, 12, 25, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(4876), "Description for Ticket 8", 1, 3, "Ticket 8" },
                    { new Guid("3af36cb1-2c4d-4c5f-a35e-6c18abd33192"), new Guid("62471ddb-07f1-4794-9efc-a33626470605"), null, 1, new DateTime(2023, 5, 29, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(9130), "Description for Ticket 218", 1, 1, "Ticket 218" },
                    { new Guid("3b3e4d11-3316-462b-8f70-a70b52a677bf"), new Guid("477ae5df-9673-439b-96f6-133ec112527c"), null, 3, new DateTime(2023, 6, 12, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(8766), "Description for Ticket 204", 2, 3, "Ticket 204" },
                    { new Guid("3bc05c25-b2f8-4354-85af-6b9693eafbee"), new Guid("78719898-28c7-4e82-ac3c-d7cdbb21b8c4"), null, 2, new DateTime(2023, 7, 15, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(8261), "Description for Ticket 171", 2, 2, "Ticket 171" },
                    { new Guid("3cb6faa1-58b5-4702-a7fa-c43b8028cd0c"), new Guid("46c5c2b0-110c-4187-8e2f-13cd9c047c3d"), null, 3, new DateTime(2023, 12, 13, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(5131), "Description for Ticket 20", 1, 3, "Ticket 20" },
                    { new Guid("3d0a84ab-26ef-4564-a1dc-2808869105fb"), new Guid("a03d5308-2dbb-40af-a138-277771f7deb6"), null, 0, new DateTime(2023, 8, 2, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(7966), "Description for Ticket 153", 2, 0, "Ticket 153" },
                    { new Guid("3d1db4ee-03e6-4d03-86b0-09d977101ce2"), new Guid("b560b1ab-aa94-477c-957e-b93f96dcf73b"), null, 0, new DateTime(2023, 11, 26, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(5347), "Description for Ticket 37", 0, 0, "Ticket 37" },
                    { new Guid("3ed3929c-ed6f-4013-8887-703948ff1de0"), new Guid("49b158ee-531f-44a6-b4ac-1e5afcc5594b"), null, 2, new DateTime(2023, 6, 13, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(8750), "Description for Ticket 203", 1, 2, "Ticket 203" },
                    { new Guid("4170964c-860c-4143-a101-a6bb250fa9d7"), new Guid("5f41bf29-aa96-4460-be16-2a106e0798b2"), null, 3, new DateTime(2023, 8, 3, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(7954), "Description for Ticket 152", 1, 3, "Ticket 152" },
                    { new Guid("435cedb6-8a44-44e4-ad03-f0c04ee7e123"), new Guid("81bcca65-038d-4880-9418-ab52a2fe031c"), null, 3, new DateTime(2023, 5, 3, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(9502), "Description for Ticket 244", 0, 3, "Ticket 244" },
                    { new Guid("44535567-ca6b-4066-a98b-617e00aab0ac"), new Guid("6e276381-7eb8-4567-8477-645fc84e9cef"), null, 3, new DateTime(2023, 11, 15, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(5541), "Description for Ticket 48", 2, 3, "Ticket 48" },
                    { new Guid("44b006d5-5e2f-4b1e-a884-e92439d9d78e"), new Guid("2cb82dbd-8391-4046-acf0-8de663e04f36"), null, 1, new DateTime(2023, 9, 2, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(7399), "Description for Ticket 122", 1, 1, "Ticket 122" },
                    { new Guid("44e4ffb6-7b13-42d4-96a8-0b4f81d57a4f"), new Guid("656d70d9-65ad-434e-ba33-79515cc93282"), null, 3, new DateTime(2023, 9, 4, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(7372), "Description for Ticket 120", 2, 3, "Ticket 120" },
                    { new Guid("45aefb2f-1671-445b-aa80-785bd3a088ab"), new Guid("28d6de2e-d6e5-43b2-bde5-1f7efab0dafc"), null, 1, new DateTime(2023, 9, 14, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(6972), "Description for Ticket 110", 1, 1, "Ticket 110" },
                    { new Guid("4664f4c4-915f-4afe-9ab0-a8b266797e00"), new Guid("5f34e2a4-69d7-4a73-8c43-8763221e031c"), null, 2, new DateTime(2023, 9, 13, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(6987), "Description for Ticket 111", 2, 2, "Ticket 111" },
                    { new Guid("47718485-ea5e-4f21-bc30-6ac06ca4e614"), new Guid("d3632d7b-c9e0-4d01-9757-ff659ebbbdd9"), null, 3, new DateTime(2023, 12, 5, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(5230), "Description for Ticket 28", 0, 3, "Ticket 28" },
                    { new Guid("48270fee-c51c-41c8-b3c1-0e5c26dba326"), new Guid("26563f3b-42ff-4eed-8a4a-fb0d03d11ff0"), null, 1, new DateTime(2023, 8, 9, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(7831), "Description for Ticket 146", 1, 1, "Ticket 146" },
                    { new Guid("4aa8c15f-6c70-4a44-9452-6a3f1d8c9d67"), new Guid("49b158ee-531f-44a6-b4ac-1e5afcc5594b"), null, 0, new DateTime(2023, 8, 22, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(7657), "Description for Ticket 133", 0, 0, "Ticket 133" },
                    { new Guid("4c5db807-222a-4fa0-8f7a-72dd1c8c3c64"), new Guid("cab1cee3-26b2-495f-8b4c-136380a02e63"), null, 2, new DateTime(2023, 6, 21, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(8638), "Description for Ticket 195", 2, 2, "Ticket 195" },
                    { new Guid("4c795b45-4d38-4cde-93b3-53a3dfc9ff0a"), new Guid("c1c210aa-03af-41b4-80dc-8a7785eac2bd"), null, 0, new DateTime(2023, 6, 7, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(8830), "Description for Ticket 209", 1, 0, "Ticket 209" },
                    { new Guid("5039e730-5e0b-4731-a928-6047d0bc96eb"), new Guid("5bc72dba-f0f6-4197-a6fd-3e26d20fb4e6"), null, 0, new DateTime(2023, 9, 19, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(6818), "Description for Ticket 105", 2, 0, "Ticket 105" },
                    { new Guid("512b2e42-142c-45a2-aac1-f485dbc522c4"), new Guid("5bc50449-2015-47d7-b4ff-ea4e7f16b024"), null, 2, new DateTime(2023, 12, 14, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(5114), "Description for Ticket 19", 0, 2, "Ticket 19" },
                    { new Guid("51f128f0-432e-49e5-b59a-2bc8882be4c6"), new Guid("eaf79b1e-b12a-4ec0-8e48-5e8ff1c3be01"), null, 1, new DateTime(2023, 11, 1, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(5728), "Description for Ticket 62", 1, 1, "Ticket 62" },
                    { new Guid("524245d2-0931-4fd1-a3e8-111d05657f77"), new Guid("28d6de2e-d6e5-43b2-bde5-1f7efab0dafc"), null, 1, new DateTime(2023, 4, 27, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(9580), "Description for Ticket 250", 0, 1, "Ticket 250" },
                    { new Guid("5264bce8-a2ff-48d4-bc11-05cf1374a50d"), new Guid("31630389-f081-42c9-9916-d9e0de380e67"), null, 3, new DateTime(2023, 6, 4, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(8871), "Description for Ticket 212", 1, 3, "Ticket 212" },
                    { new Guid("52804f06-371e-4710-a52e-f1b0933b576a"), new Guid("9d55b16d-14d8-4345-a067-30be4122ccbe"), null, 1, new DateTime(2023, 8, 29, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(7463), "Description for Ticket 126", 2, 1, "Ticket 126" },
                    { new Guid("5390433b-eac9-4874-a27a-5acfa79964f5"), new Guid("eaf79b1e-b12a-4ec0-8e48-5e8ff1c3be01"), null, 1, new DateTime(2023, 6, 14, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(8736), "Description for Ticket 202", 0, 1, "Ticket 202" },
                    { new Guid("53a49455-34a2-440e-b47b-ce0e1681a119"), new Guid("5bc72dba-f0f6-4197-a6fd-3e26d20fb4e6"), null, 2, new DateTime(2023, 11, 28, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(5319), "Description for Ticket 35", 1, 2, "Ticket 35" },
                    { new Guid("546a7f40-790a-4d9a-8671-9facddaac0fe"), new Guid("c5411f95-3578-4056-9ccc-697bdbcb3444"), null, 0, new DateTime(2023, 10, 21, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(5912), "Description for Ticket 73", 0, 0, "Ticket 73" },
                    { new Guid("56880c82-1d68-4b54-827a-e87c4db7933f"), new Guid("1b2477b5-e225-4f9a-9b8b-e9684e54aa2c"), null, 2, new DateTime(2023, 8, 4, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(7940), "Description for Ticket 151", 0, 2, "Ticket 151" },
                    { new Guid("56a39e43-5092-4be7-b34e-91bd9cfb7566"), new Guid("5bc50449-2015-47d7-b4ff-ea4e7f16b024"), null, 0, new DateTime(2023, 10, 5, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(6326), "Description for Ticket 89", 1, 0, "Ticket 89" },
                    { new Guid("5767b59d-da15-4ff8-92da-9ea09a0fbdaf"), new Guid("6117b27a-03c1-4c40-9ca1-ec69ce505cae"), null, 3, new DateTime(2023, 7, 30, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(8009), "Description for Ticket 156", 2, 3, "Ticket 156" },
                    { new Guid("583f0dff-9238-4cbc-b636-3b7cddd0ee5f"), new Guid("b91e96a7-3994-4636-93fb-3afd9eff757a"), null, 3, new DateTime(2023, 8, 31, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(7436), "Description for Ticket 124", 0, 3, "Ticket 124" },
                    { new Guid("588af101-54f8-4407-b606-bfab4bf14e1e"), new Guid("5f34e2a4-69d7-4a73-8c43-8763221e031c"), null, 0, new DateTime(2023, 11, 22, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(5447), "Description for Ticket 41", 1, 0, "Ticket 41" },
                    { new Guid("5932678d-41db-4e95-82d0-a52ee890a8d5"), new Guid("66229280-def8-4159-b496-63fa6a4b3863"), null, 3, new DateTime(2023, 11, 19, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(5486), "Description for Ticket 44", 1, 3, "Ticket 44" },
                    { new Guid("5974b5e5-c3f4-44d5-9e40-241ac5d61033"), new Guid("b91e96a7-3994-4636-93fb-3afd9eff757a"), null, 1, new DateTime(2023, 6, 22, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(8623), "Description for Ticket 194", 1, 1, "Ticket 194" },
                    { new Guid("5bb03d24-c128-457f-8fbd-4d56fdd3211e"), new Guid("a03d5308-2dbb-40af-a138-277771f7deb6"), null, 0, new DateTime(2023, 12, 20, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(4963), "Description for Ticket 13", 0, 0, "Ticket 13" },
                    { new Guid("5d145f8a-f195-4cb1-b006-7cea623487b1"), new Guid("c1c210aa-03af-41b4-80dc-8a7785eac2bd"), null, 0, new DateTime(2023, 10, 25, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(5863), "Description for Ticket 69", 2, 0, "Ticket 69" },
                    { new Guid("5da9e056-8850-428e-a512-f91f509ee4ad"), new Guid("944ec632-8ed2-4b07-b4d5-d44a50cadceb"), null, 0, new DateTime(2023, 9, 7, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(7079), "Description for Ticket 117", 2, 0, "Ticket 117" },
                    { new Guid("5e528668-3be3-40ac-a84e-17389f3e1a1e"), new Guid("a39366ab-52b4-4353-8149-840f0e65fd53"), null, 1, new DateTime(2023, 10, 20, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(5926), "Description for Ticket 74", 1, 1, "Ticket 74" },
                    { new Guid("5e8c8512-58b9-4828-a158-2b6210bf43ca"), new Guid("8de70f65-1c32-4860-8b60-73b64054e994"), null, 1, new DateTime(2023, 6, 30, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(8464), "Description for Ticket 186", 2, 1, "Ticket 186" },
                    { new Guid("5ec59bb6-8642-486b-b11c-536e05ae115c"), new Guid("db42d35b-dcbe-4ef0-b306-1c1dda9ecc1e"), null, 2, new DateTime(2023, 8, 8, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(7881), "Description for Ticket 147", 2, 2, "Ticket 147" },
                    { new Guid("6163fbed-0d3f-4f92-9a1d-21195754d7de"), new Guid("a0f84582-77e3-462d-860e-66037897df21"), null, 2, new DateTime(2023, 5, 12, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(9353), "Description for Ticket 235", 0, 2, "Ticket 235" },
                    { new Guid("625ef47a-7344-49e4-9aa0-346345a49cd6"), new Guid("c5411f95-3578-4056-9ccc-697bdbcb3444"), null, 0, new DateTime(2023, 6, 3, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(8884), "Description for Ticket 213", 2, 0, "Ticket 213" },
                    { new Guid("632f9afc-3c0c-4d31-be48-6354314e0397"), new Guid("cee9a32c-614e-4240-8ab7-caff4d4fdbfd"), null, 3, new DateTime(2023, 5, 15, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(9313), "Description for Ticket 232", 0, 3, "Ticket 232" },
                    { new Guid("64b09c0e-2a11-4c38-a9e3-4380d9d49c1e"), new Guid("3285b21d-9cce-4fe2-bd89-578c31da9e49"), null, 0, new DateTime(2023, 7, 1, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(8452), "Description for Ticket 185", 1, 0, "Ticket 185" },
                    { new Guid("64fa5105-d07b-456a-b4ea-fcbfc6d9b513"), new Guid("7957e8e0-1624-4cfc-9cdc-14909e700120"), null, 2, new DateTime(2023, 5, 16, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(9300), "Description for Ticket 231", 2, 2, "Ticket 231" },
                    { new Guid("656f4c98-f08b-4cc7-812f-7e1311db632d"), new Guid("4aee48d9-4a25-4d95-a69f-416a46f3e2c8"), null, 3, new DateTime(2023, 11, 27, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(5335), "Description for Ticket 36", 2, 3, "Ticket 36" },
                    { new Guid("65853766-f1f2-4980-8c66-e0aa623ce2f2"), new Guid("dc68b9c0-a916-4b63-ac54-c1b5c5983551"), null, 1, new DateTime(2023, 10, 24, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(5875), "Description for Ticket 70", 0, 1, "Ticket 70" },
                    { new Guid("65eaa1dc-d50e-408e-b1da-386b248a3399"), new Guid("4aee48d9-4a25-4d95-a69f-416a46f3e2c8"), null, 1, new DateTime(2023, 5, 1, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(9530), "Description for Ticket 246", 2, 1, "Ticket 246" },
                    { new Guid("6601cf96-0662-4bff-88c7-bbd14bf59557"), new Guid("44c62471-a823-4da1-b969-673b33771727"), null, 2, new DateTime(2023, 7, 23, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(8108), "Description for Ticket 163", 0, 2, "Ticket 163" },
                    { new Guid("66520326-8f13-48d6-98a7-a95ba6dda57e"), new Guid("903fde5f-8b2a-40ea-bfad-1c5be5505831"), null, 2, new DateTime(2023, 11, 4, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(5686), "Description for Ticket 59", 1, 2, "Ticket 59" },
                    { new Guid("6709b313-025e-4a74-baa7-7800cf6afd20"), new Guid("b560b1ab-aa94-477c-957e-b93f96dcf73b"), null, 0, new DateTime(2023, 7, 9, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(8343), "Description for Ticket 177", 2, 0, "Ticket 177" },
                    { new Guid("67fa2b00-40b7-47e8-ad92-7def9cbf080a"), new Guid("5f41bf29-aa96-4460-be16-2a106e0798b2"), null, 1, new DateTime(2023, 10, 12, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(6038), "Description for Ticket 82", 0, 1, "Ticket 82" },
                    { new Guid("6ae3327f-d9a9-4aa9-9cf4-8bb9624385f6"), new Guid("7957e8e0-1624-4cfc-9cdc-14909e700120"), null, 0, new DateTime(2023, 7, 25, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(8080), "Description for Ticket 161", 1, 0, "Ticket 161" },
                    { new Guid("6ce58b0d-7ca1-42e4-a125-11151f84ee6b"), new Guid("44c62471-a823-4da1-b969-673b33771727"), null, 2, new DateTime(2023, 12, 10, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(5167), "Description for Ticket 23", 1, 2, "Ticket 23" },
                    { new Guid("6e072a43-8631-45ed-80a8-ade15635e7dc"), new Guid("c7e9d74c-b613-422d-b7ac-6bb8ebd28d59"), null, 3, new DateTime(2023, 6, 16, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(8711), "Description for Ticket 200", 1, 3, "Ticket 200" },
                    { new Guid("6f552db3-3199-44ef-8b03-cc137ea118ee"), new Guid("81bcca65-038d-4880-9418-ab52a2fe031c"), null, 3, new DateTime(2023, 9, 20, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(6801), "Description for Ticket 104", 1, 3, "Ticket 104" },
                    { new Guid("711549eb-8ac8-4f9e-afe0-072a8f3d281f"), new Guid("7e4d675e-f94a-40cc-afd0-66a20dbd018c"), null, 0, new DateTime(2023, 6, 23, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(8608), "Description for Ticket 193", 0, 0, "Ticket 193" },
                    { new Guid("7197b1e8-9848-4316-91c9-e7a975974168"), new Guid("c7e9d74c-b613-422d-b7ac-6bb8ebd28d59"), null, 3, new DateTime(2023, 11, 3, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(5703), "Description for Ticket 60", 2, 3, "Ticket 60" },
                    { new Guid("71cc27af-b576-475e-869a-995f4ed31a8a"), new Guid("dc68b9c0-a916-4b63-ac54-c1b5c5983551"), null, 1, new DateTime(2023, 6, 6, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(8843), "Description for Ticket 210", 2, 1, "Ticket 210" },
                    { new Guid("733d0080-b8ed-4c5e-aba5-2fbb0f9ef85a"), new Guid("7e4d675e-f94a-40cc-afd0-66a20dbd018c"), null, 0, new DateTime(2023, 11, 10, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(5610), "Description for Ticket 53", 1, 0, "Ticket 53" },
                    { new Guid("74c06a7a-6e47-4998-81e3-7dbbc6390eec"), new Guid("7957e8e0-1624-4cfc-9cdc-14909e700120"), null, 0, new DateTime(2023, 12, 12, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(5143), "Description for Ticket 21", 2, 0, "Ticket 21" },
                    { new Guid("74d2c0dc-fb41-4270-9550-8631ddf2750c"), new Guid("0056b30a-e1df-4efd-bc3e-6093120cb871"), null, 3, new DateTime(2023, 10, 14, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(6007), "Description for Ticket 80", 1, 3, "Ticket 80" },
                    { new Guid("752dda90-6b18-4ca2-89ed-7a3a4db928a7"), new Guid("cee9a32c-614e-4240-8ab7-caff4d4fdbfd"), null, 1, new DateTime(2023, 7, 24, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(8094), "Description for Ticket 162", 2, 1, "Ticket 162" },
                    { new Guid("75734812-67a5-4e3f-be72-fb74cf4829a1"), new Guid("5d3ce4a9-dfe1-4ba5-a024-086aa86fdeb9"), null, 2, new DateTime(2023, 9, 25, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(6750), "Description for Ticket 99", 2, 2, "Ticket 99" },
                    { new Guid("76d5b554-44a7-4d4e-8219-de4c9cd67c4e"), new Guid("5c4bd001-2790-4490-af94-29729ba2211b"), null, 3, new DateTime(2023, 7, 14, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(8277), "Description for Ticket 172", 0, 3, "Ticket 172" },
                    { new Guid("77331ff7-6276-4bde-b689-3349b0db17a1"), new Guid("9264bfc7-2a04-41e8-8a82-fc212e003efa"), null, 0, new DateTime(2023, 8, 14, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(7769), "Description for Ticket 141", 2, 0, "Ticket 141" },
                    { new Guid("78271198-421a-4ebd-90f0-771d2d657ee8"), new Guid("477ae5df-9673-439b-96f6-133ec112527c"), null, 1, new DateTime(2023, 8, 21, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(7671), "Description for Ticket 134", 1, 1, "Ticket 134" },
                    { new Guid("786d235f-1d94-4b5d-93be-7714bf439d0e"), new Guid("fbb9028f-315e-4ae5-b63e-c93e3406eb71"), null, 2, new DateTime(2023, 9, 5, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(7357), "Description for Ticket 119", 1, 2, "Ticket 119" },
                    { new Guid("79b47d68-999c-46bb-829c-eea19e88fb73"), new Guid("6e276381-7eb8-4567-8477-645fc84e9cef"), null, 3, new DateTime(2023, 6, 28, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(8494), "Description for Ticket 188", 1, 3, "Ticket 188" },
                    { new Guid("79c06d7e-e626-449a-85a0-694c7e500ea2"), new Guid("92c83e8d-94b6-4c94-86aa-20b78674a960"), null, 3, new DateTime(2023, 9, 16, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(6943), "Description for Ticket 108", 2, 3, "Ticket 108" },
                    { new Guid("7b1409c2-956b-4c16-81be-c949d0b65930"), new Guid("2faace28-cf62-40ad-9ddd-6f1d5ef6f1df"), null, 0, new DateTime(2023, 10, 9, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(6119), "Description for Ticket 85", 0, 0, "Ticket 85" },
                    { new Guid("7ba47b93-2917-4eb9-b3b1-23c1408b7098"), new Guid("49b158ee-531f-44a6-b4ac-1e5afcc5594b"), null, 2, new DateTime(2023, 10, 31, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(5776), "Description for Ticket 63", 2, 2, "Ticket 63" },
                    { new Guid("7bc71534-4e59-49a9-a096-62f55708559a"), new Guid("26563f3b-42ff-4eed-8a4a-fb0d03d11ff0"), null, 3, new DateTime(2023, 10, 18, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(5956), "Description for Ticket 76", 0, 3, "Ticket 76" },
                    { new Guid("80d647f0-ad4e-4a87-9137-2a9278180c22"), new Guid("04b1b138-6397-4062-9e38-537ca161c1da"), null, 2, new DateTime(2023, 10, 7, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(6299), "Description for Ticket 87", 2, 2, "Ticket 87" },
                    { new Guid("81689c88-36aa-46c8-9372-f103d7d0a1e1"), new Guid("5f41bf29-aa96-4460-be16-2a106e0798b2"), null, 3, new DateTime(2023, 12, 21, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(4949), "Description for Ticket 12", 2, 3, "Ticket 12" },
                    { new Guid("823fca7c-635d-442e-8eb8-606e7731aad1"), new Guid("46c5c2b0-110c-4187-8e2f-13cd9c047c3d"), null, 3, new DateTime(2023, 7, 26, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(8067), "Description for Ticket 160", 0, 3, "Ticket 160" },
                    { new Guid("833a2968-eb53-4c99-b501-e63aa714297b"), new Guid("9d64707b-ab3f-4516-bce1-bed489adc112"), null, 3, new DateTime(2023, 6, 8, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(8818), "Description for Ticket 208", 0, 3, "Ticket 208" },
                    { new Guid("84e59391-c8b3-4a27-978b-ce6c5929285f"), new Guid("6117b27a-03c1-4c40-9ca1-ec69ce505cae"), null, 3, new DateTime(2023, 12, 17, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(5004), "Description for Ticket 16", 0, 3, "Ticket 16" },
                    { new Guid("8616354b-25ee-48db-98e3-0f557f28895c"), new Guid("f5a92fa3-1709-4f49-b81d-33b5877b158f"), null, 0, new DateTime(2023, 9, 3, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(7385), "Description for Ticket 121", 0, 0, "Ticket 121" },
                    { new Guid("868e1808-d718-4383-aec8-5f6cacfab4fe"), new Guid("3285b21d-9cce-4fe2-bd89-578c31da9e49"), null, 2, new DateTime(2023, 9, 9, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(7046), "Description for Ticket 115", 0, 2, "Ticket 115" },
                    { new Guid("8b628c40-4cb1-4290-8819-5e887000a76f"), new Guid("944ec632-8ed2-4b07-b4d5-d44a50cadceb"), null, 2, new DateTime(2023, 11, 16, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(5524), "Description for Ticket 47", 1, 2, "Ticket 47" },
                    { new Guid("8ba6ae32-8bab-4b5e-af8c-87ff97d958fc"), new Guid("5bc72dba-f0f6-4197-a6fd-3e26d20fb4e6"), null, 0, new DateTime(2023, 5, 2, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(9516), "Description for Ticket 245", 1, 0, "Ticket 245" },
                    { new Guid("8c1c24dd-ec02-41b1-bc6d-7eb79cc5cccf"), new Guid("b91e96a7-3994-4636-93fb-3afd9eff757a"), null, 1, new DateTime(2023, 11, 9, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(5623), "Description for Ticket 54", 2, 1, "Ticket 54" },
                    { new Guid("8cf2f545-b276-42f4-8e1a-a385cc5dfedb"), new Guid("88a02658-6691-49c9-a617-47a3b9cbaa21"), null, 2, new DateTime(2023, 6, 1, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(9092), "Description for Ticket 215", 1, 2, "Ticket 215" },
                    { new Guid("90ceaae6-cbed-43a3-b7c7-00ead83a6a68"), new Guid("be928e80-e187-4c71-8338-5c5f469c14e2"), null, 3, new DateTime(2023, 12, 9, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(5179), "Description for Ticket 24", 2, 3, "Ticket 24" },
                    { new Guid("944da4df-0c29-4289-be2a-09868a3e70f9"), new Guid("56e654fc-6fa0-483b-bc85-51b57cc38062"), null, 0, new DateTime(2023, 9, 11, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(7016), "Description for Ticket 113", 1, 0, "Ticket 113" },
                    { new Guid("94b63ef4-ed55-42e2-a744-524928f46893"), new Guid("07a7f193-758c-4d54-8d67-5fefea708497"), null, 3, new DateTime(2023, 8, 19, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(7698), "Description for Ticket 136", 0, 3, "Ticket 136" },
                    { new Guid("95bd836b-e7fc-4541-bfd3-b96c10757554"), new Guid("6b4b3744-f22f-4a10-b60d-f87cbb676462"), null, 0, new DateTime(2023, 6, 19, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(8670), "Description for Ticket 197", 1, 0, "Ticket 197" },
                    { new Guid("96b86362-f38e-47d8-8957-3a3dbec577ab"), new Guid("c5411f95-3578-4056-9ccc-697bdbcb3444"), null, 2, new DateTime(2023, 12, 30, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(4698), "Description for Ticket 3", 2, 2, "Ticket 3" },
                    { new Guid("98926671-e215-42d6-a241-34932d4e21fb"), new Guid("2cb82dbd-8391-4046-acf0-8de663e04f36"), null, 3, new DateTime(2023, 11, 11, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(5596), "Description for Ticket 52", 0, 3, "Ticket 52" },
                    { new Guid("9b938d3d-85c1-4f05-8133-dad3b9d5472e"), new Guid("20e09b01-c231-4bb5-b112-9e2b218047da"), null, 1, new DateTime(2023, 12, 7, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(5202), "Description for Ticket 26", 1, 1, "Ticket 26" },
                    { new Guid("9d2aca59-0b71-44fa-8e3c-8a4535620257"), new Guid("eaf79b1e-b12a-4ec0-8e48-5e8ff1c3be01"), null, 3, new DateTime(2023, 8, 23, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(7643), "Description for Ticket 132", 2, 3, "Ticket 132" },
                    { new Guid("9de25fba-1bc0-4bf6-ae3b-90e74464fe4b"), new Guid("903fde5f-8b2a-40ea-bfad-1c5be5505831"), null, 2, new DateTime(2023, 6, 17, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(8698), "Description for Ticket 199", 0, 2, "Ticket 199" },
                    { new Guid("9e8a2f62-8acd-472a-8294-e00f1f41b2ea"), new Guid("9d64707b-ab3f-4516-bce1-bed489adc112"), null, 3, new DateTime(2023, 10, 26, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(5851), "Description for Ticket 68", 1, 3, "Ticket 68" },
                    { new Guid("9fcb5c8d-6d5f-4382-a79a-a7d19090cd1d"), new Guid("656d70d9-65ad-434e-ba33-79515cc93282"), null, 1, new DateTime(2023, 6, 26, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(8525), "Description for Ticket 190", 0, 1, "Ticket 190" },
                    { new Guid("a20ebda2-b092-4499-8d80-550973a7c23b"), new Guid("0056b30a-e1df-4efd-bc3e-6093120cb871"), null, 3, new DateTime(2023, 5, 27, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(9159), "Description for Ticket 220", 0, 3, "Ticket 220" },
                    { new Guid("a2b82ae6-3a04-441f-9d09-1f34be82b6c7"), new Guid("5c4bd001-2790-4490-af94-29729ba2211b"), null, 3, new DateTime(2023, 12, 1, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(5279), "Description for Ticket 32", 1, 3, "Ticket 32" },
                    { new Guid("a3775a8d-d05f-4400-bead-f6cd47f594f5"), new Guid("28349c17-6fd4-4600-a21c-113dbe2647f7"), null, 2, new DateTime(2023, 8, 20, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(7685), "Description for Ticket 135", 2, 2, "Ticket 135" },
                    { new Guid("a6204ab6-28cb-41e7-bc84-41b9d7dcf730"), new Guid("a03d5308-2dbb-40af-a138-277771f7deb6"), null, 2, new DateTime(2023, 5, 24, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(9197), "Description for Ticket 223", 0, 2, "Ticket 223" },
                    { new Guid("a63d1f9a-8fd9-431b-85ff-3cf585b3fa39"), new Guid("fbb9028f-315e-4ae5-b63e-c93e3406eb71"), null, 0, new DateTime(2023, 11, 14, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(5554), "Description for Ticket 49", 0, 0, "Ticket 49" },
                    { new Guid("a6c9c251-eef2-405c-8e7e-b3352171c468"), new Guid("f5a92fa3-1709-4f49-b81d-33b5877b158f"), null, 2, new DateTime(2023, 6, 25, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(8539), "Description for Ticket 191", 1, 2, "Ticket 191" },
                    { new Guid("a7305097-d7ef-4471-8b7f-4a752c029584"), new Guid("548e6919-14cc-4658-b787-c78242286c3d"), null, 0, new DateTime(2023, 12, 24, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(4896), "Description for Ticket 9", 2, 0, "Ticket 9" },
                    { new Guid("a963f362-1985-4a8d-bf6e-8624ffa88f68"), new Guid("8de70f65-1c32-4860-8b60-73b64054e994"), null, 1, new DateTime(2023, 11, 17, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(5511), "Description for Ticket 46", 0, 1, "Ticket 46" },
                    { new Guid("a9ddcc7d-75a9-4e35-93f3-19f1a50317f7"), new Guid("477ae5df-9673-439b-96f6-133ec112527c"), null, 3, new DateTime(2023, 10, 30, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(5792), "Description for Ticket 64", 0, 3, "Ticket 64" },
                    { new Guid("aa1f47ac-8832-45b9-9566-1ef9e01f9e5a"), new Guid("db42d35b-dcbe-4ef0-b306-1c1dda9ecc1e"), null, 0, new DateTime(2023, 10, 17, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(5970), "Description for Ticket 77", 1, 0, "Ticket 77" },
                    { new Guid("aa7c1177-3666-467f-b5a6-989d16203e4e"), new Guid("f5a92fa3-1709-4f49-b81d-33b5877b158f"), null, 2, new DateTime(2023, 11, 12, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(5580), "Description for Ticket 51", 2, 2, "Ticket 51" },
                    { new Guid("ab3147e9-cfff-476a-a2a9-ff58e73426ed"), new Guid("21ba0292-2cd8-4047-ba5d-184d24a29877"), null, 1, new DateTime(2023, 11, 5, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(5675), "Description for Ticket 58", 0, 1, "Ticket 58" },
                    { new Guid("ac7cb728-d9b2-4871-9af5-d4fd3a438d34"), new Guid("9264bfc7-2a04-41e8-8a82-fc212e003efa"), null, 2, new DateTime(2023, 10, 23, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(5887), "Description for Ticket 71", 1, 2, "Ticket 71" },
                    { new Guid("ac8ebe9d-d950-4369-a156-5d0e3dbbb38e"), new Guid("b09b730f-479d-420a-a4b4-60f0831682a3"), null, 2, new DateTime(2023, 8, 24, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(7622), "Description for Ticket 131", 1, 2, "Ticket 131" },
                    { new Guid("ad85c91e-a7ce-4419-a145-4d7cc84726c3"), new Guid("04b1b138-6397-4062-9e38-537ca161c1da"), null, 0, new DateTime(2023, 12, 16, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(5017), "Description for Ticket 17", 1, 0, "Ticket 17" },
                    { new Guid("ae25913a-8c7d-4e38-8a6d-781cfe895316"), new Guid("1b2477b5-e225-4f9a-9b8b-e9684e54aa2c"), null, 0, new DateTime(2023, 10, 13, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(6021), "Description for Ticket 81", 2, 0, "Ticket 81" },
                    { new Guid("aeeb5d14-7c83-414a-a610-8fa13e28d17b"), new Guid("d3632d7b-c9e0-4d01-9757-ff659ebbbdd9"), null, 1, new DateTime(2023, 5, 9, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(9419), "Description for Ticket 238", 0, 1, "Ticket 238" },
                    { new Guid("b05e8886-764b-4aa6-ac89-0905061e3e8a"), new Guid("d3632d7b-c9e0-4d01-9757-ff659ebbbdd9"), null, 1, new DateTime(2023, 9, 26, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(6742), "Description for Ticket 98", 1, 1, "Ticket 98" },
                    { new Guid("b1c3ebaf-8dbd-497e-a6d8-4e0e8bb71d84"), new Guid("c3ad68a7-8bee-4eeb-94d5-f271809d5b30"), null, 1, new DateTime(2023, 12, 19, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(4976), "Description for Ticket 14", 1, 1, "Ticket 14" },
                    { new Guid("b2d2f3c6-e962-4bc2-9352-5c6101b1f4f1"), new Guid("26563f3b-42ff-4eed-8a4a-fb0d03d11ff0"), null, 3, new DateTime(2023, 5, 31, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(9106), "Description for Ticket 216", 2, 3, "Ticket 216" },
                    { new Guid("b2dfbf9b-33ce-43e7-b676-69c74ffc4b7f"), new Guid("1b2477b5-e225-4f9a-9b8b-e9684e54aa2c"), null, 2, new DateTime(2023, 12, 22, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(4929), "Description for Ticket 11", 1, 2, "Ticket 11" },
                    { new Guid("b2e11e21-3e37-41c5-85f2-7c35b320cdbf"), new Guid("656d70d9-65ad-434e-ba33-79515cc93282"), null, 1, new DateTime(2023, 11, 13, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(5568), "Description for Ticket 50", 1, 1, "Ticket 50" },
                    { new Guid("b33ed68e-0100-4de1-91cf-089e1a8b9b7e"), new Guid("46c5c2b0-110c-4187-8e2f-13cd9c047c3d"), null, 1, new DateTime(2023, 5, 17, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(9288), "Description for Ticket 230", 1, 1, "Ticket 230" },
                    { new Guid("b53723e1-1d4f-49a1-a6bd-771493e4cb5d"), new Guid("db42d35b-dcbe-4ef0-b306-1c1dda9ecc1e"), null, 0, new DateTime(2023, 5, 30, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(9118), "Description for Ticket 217", 0, 0, "Ticket 217" },
                    { new Guid("b5b57016-c5c4-45cc-9f8f-ab40427252f7"), new Guid("28d6de2e-d6e5-43b2-bde5-1f7efab0dafc"), null, 3, new DateTime(2023, 11, 23, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(5434), "Description for Ticket 40", 0, 3, "Ticket 40" },
                    { new Guid("b641e944-d789-42d6-b02b-18b7479fae4b"), new Guid("31630389-f081-42c9-9916-d9e0de380e67"), null, 3, new DateTime(2023, 10, 22, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(5900), "Description for Ticket 72", 2, 3, "Ticket 72" },
                    { new Guid("b78b632a-8304-428e-a59f-0d354e059513"), new Guid("a1a44f62-3095-4a1a-ba87-cadd4f996fb6"), null, 0, new DateTime(2023, 11, 30, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(5292), "Description for Ticket 33", 2, 0, "Ticket 33" },
                    { new Guid("b83815bc-eee9-4329-862b-d6cb5cf65fdb"), new Guid("56e654fc-6fa0-483b-bc85-51b57cc38062"), null, 2, new DateTime(2023, 7, 3, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(8425), "Description for Ticket 183", 2, 2, "Ticket 183" },
                    { new Guid("b8a03744-41b6-4d7d-98b7-4a579731ded3"), new Guid("be928e80-e187-4c71-8338-5c5f469c14e2"), null, 1, new DateTime(2023, 9, 30, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(6709), "Description for Ticket 94", 0, 1, "Ticket 94" },
                    { new Guid("ba6eb139-23ce-487b-9a17-4439cad9f7b5"), new Guid("2faace28-cf62-40ad-9ddd-6f1d5ef6f1df"), null, 2, new DateTime(2023, 12, 18, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(4990), "Description for Ticket 15", 2, 2, "Ticket 15" },
                    { new Guid("bafebffa-69ff-4182-aac9-7921c82712e9"), new Guid("20e09b01-c231-4bb5-b112-9e2b218047da"), null, 3, new DateTime(2023, 5, 11, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(9369), "Description for Ticket 236", 1, 3, "Ticket 236" },
                    { new Guid("bb7388c0-406a-4591-97fb-6814bb4a40b7"), new Guid("9264bfc7-2a04-41e8-8a82-fc212e003efa"), null, 0, new DateTime(2024, 1, 1, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(4651), "Description for Ticket 1", 0, 0, "Ticket 1" },
                    { new Guid("bbd6712b-91e4-4e4a-b435-131ce8d330a4"), new Guid("dc68b9c0-a916-4b63-ac54-c1b5c5983551"), null, 3, new DateTime(2023, 8, 15, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(7754), "Description for Ticket 140", 1, 3, "Ticket 140" },
                    { new Guid("bc0a8c1b-c190-4568-9bc9-c9ee4635a26c"), new Guid("7e4d675e-f94a-40cc-afd0-66a20dbd018c"), null, 2, new DateTime(2023, 9, 1, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(7412), "Description for Ticket 123", 2, 2, "Ticket 123" },
                    { new Guid("bc80cce9-8687-4be5-b0e8-3e2929fd291f"), new Guid("5bc50449-2015-47d7-b4ff-ea4e7f16b024"), null, 0, new DateTime(2023, 5, 18, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(9274), "Description for Ticket 229", 0, 0, "Ticket 229" },
                    { new Guid("bc8a24c5-0118-411b-9234-1392d2ea95e8"), new Guid("a03d5308-2dbb-40af-a138-277771f7deb6"), null, 2, new DateTime(2023, 10, 11, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(6051), "Description for Ticket 83", 1, 2, "Ticket 83" },
                    { new Guid("bd8269e7-1a11-4b4a-8d67-3ed7d58c54f8"), new Guid("44c62471-a823-4da1-b969-673b33771727"), null, 0, new DateTime(2023, 5, 14, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(9326), "Description for Ticket 233", 1, 0, "Ticket 233" },
                    { new Guid("bdb27c1f-5e18-4df6-aa9b-ce69047e3460"), new Guid("7957e8e0-1624-4cfc-9cdc-14909e700120"), null, 2, new DateTime(2023, 10, 3, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(6350), "Description for Ticket 91", 0, 2, "Ticket 91" },
                    { new Guid("bdcecf0a-7478-4afc-a40d-514bf64768db"), new Guid("a39366ab-52b4-4353-8149-840f0e65fd53"), null, 1, new DateTime(2023, 6, 2, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(9050), "Description for Ticket 214", 0, 1, "Ticket 214" },
                    { new Guid("bec263b4-d356-4caf-88ed-d9ec8e23496e"), new Guid("0ee57408-a701-4710-9bc6-dba6332335cc"), null, 1, new DateTime(2023, 7, 28, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(8037), "Description for Ticket 158", 1, 1, "Ticket 158" },
                    { new Guid("c1895c5d-6237-4f57-9d12-75546fbc029b"), new Guid("c3ad68a7-8bee-4eeb-94d5-f271809d5b30"), null, 3, new DateTime(2023, 5, 23, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(9209), "Description for Ticket 224", 1, 3, "Ticket 224" },
                    { new Guid("c1dd56f7-2a54-409e-93b1-53b5ee3f7a60"), new Guid("20e09b01-c231-4bb5-b112-9e2b218047da"), null, 1, new DateTime(2023, 7, 20, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(8153), "Description for Ticket 166", 0, 1, "Ticket 166" },
                    { new Guid("c2130614-4843-4593-b448-82a18b77ebd0"), new Guid("544a0ef2-14fb-4e36-a7c3-ba5b433b9a8c"), null, 1, new DateTime(2023, 11, 21, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(5459), "Description for Ticket 42", 2, 1, "Ticket 42" },
                    { new Guid("c3b85311-54b4-485e-aeda-e0e9db54f438"), new Guid("be928e80-e187-4c71-8338-5c5f469c14e2"), null, 3, new DateTime(2023, 7, 22, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(8125), "Description for Ticket 164", 1, 3, "Ticket 164" },
                    { new Guid("c4098849-80b3-4461-bcc2-81b37efb5bb3"), new Guid("a4902ad1-f16a-4186-9291-76caebcf2827"), null, 1, new DateTime(2023, 12, 3, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(5255), "Description for Ticket 30", 2, 1, "Ticket 30" },
                    { new Guid("c417d87d-5e42-4659-8201-4ed028a7a1cb"), new Guid("92c83e8d-94b6-4c94-86aa-20b78674a960"), null, 1, new DateTime(2023, 11, 25, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(5359), "Description for Ticket 38", 1, 1, "Ticket 38" },
                    { new Guid("c453aeb7-a061-42d8-a219-e79cfd112210"), new Guid("b560b1ab-aa94-477c-957e-b93f96dcf73b"), null, 2, new DateTime(2023, 9, 17, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(6846), "Description for Ticket 107", 1, 2, "Ticket 107" },
                    { new Guid("c4f5ec25-8d4e-4fb7-91e7-e453f57f1988"), new Guid("88a02658-6691-49c9-a617-47a3b9cbaa21"), null, 0, new DateTime(2023, 12, 28, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(4731), "Description for Ticket 5", 1, 0, "Ticket 5" },
                    { new Guid("c5009dc3-a9e2-490e-aef5-855a3bcd10a8"), new Guid("a4902ad1-f16a-4186-9291-76caebcf2827"), null, 3, new DateTime(2023, 9, 24, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(6763), "Description for Ticket 100", 0, 3, "Ticket 100" },
                    { new Guid("c573c6f2-4d28-49e5-890f-8b930ae20354"), new Guid("66229280-def8-4159-b496-63fa6a4b3863"), null, 3, new DateTime(2023, 7, 2, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(8438), "Description for Ticket 184", 0, 3, "Ticket 184" },
                    { new Guid("c63d6087-166f-4ab6-bbb7-f57557f238c7"), new Guid("44c62471-a823-4da1-b969-673b33771727"), null, 0, new DateTime(2023, 10, 1, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(6700), "Description for Ticket 93", 2, 0, "Ticket 93" },
                    { new Guid("c63d8a3b-be4f-41ca-9be8-b8160eebb8aa"), new Guid("db42d35b-dcbe-4ef0-b306-1c1dda9ecc1e"), null, 2, new DateTime(2023, 12, 26, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(4758), "Description for Ticket 7", 0, 2, "Ticket 7" },
                    { new Guid("c7d61ae3-f993-4a67-9f28-c0233db5b83f"), new Guid("a0f84582-77e3-462d-860e-66037897df21"), null, 2, new DateTime(2023, 9, 29, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(6717), "Description for Ticket 95", 1, 2, "Ticket 95" },
                    { new Guid("c9115cce-0f33-4ae4-b059-9a80a785b6ad"), new Guid("6117b27a-03c1-4c40-9ca1-ec69ce505cae"), null, 1, new DateTime(2023, 10, 8, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(6132), "Description for Ticket 86", 1, 1, "Ticket 86" },
                    { new Guid("ca66ef5a-d454-42a5-a19e-ab8bd0932d17"), new Guid("28349c17-6fd4-4600-a21c-113dbe2647f7"), null, 0, new DateTime(2023, 6, 11, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(8779), "Description for Ticket 205", 0, 0, "Ticket 205" },
                    { new Guid("cae64ae7-1aa2-43b4-bae1-bd0380196062"), new Guid("544a0ef2-14fb-4e36-a7c3-ba5b433b9a8c"), null, 3, new DateTime(2023, 9, 12, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(7002), "Description for Ticket 112", 0, 3, "Ticket 112" },
                    { new Guid("cdccf910-8aa7-4b34-9901-5f35ae4857ab"), new Guid("a4902ad1-f16a-4186-9291-76caebcf2827"), null, 3, new DateTime(2023, 5, 7, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(9447), "Description for Ticket 240", 2, 3, "Ticket 240" },
                    { new Guid("ce17553e-55e4-4f5e-bbaa-268928ec83fb"), new Guid("25242f77-fdb8-47d6-80fa-01c226c38a36"), null, 2, new DateTime(2023, 10, 27, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(5835), "Description for Ticket 67", 0, 2, "Ticket 67" },
                    { new Guid("ce2b4f9a-5bc9-4c5a-91e6-cf96f2c6a529"), new Guid("04b1b138-6397-4062-9e38-537ca161c1da"), null, 2, new DateTime(2023, 5, 20, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(9246), "Description for Ticket 227", 1, 2, "Ticket 227" },
                    { new Guid("ce6e2ebc-3e33-4bf4-ac0c-877c64d79f0b"), new Guid("944ec632-8ed2-4b07-b4d5-d44a50cadceb"), null, 2, new DateTime(2023, 6, 29, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(8477), "Description for Ticket 187", 0, 2, "Ticket 187" },
                    { new Guid("cf2b7c00-3470-4acb-8f19-06efb16888de"), new Guid("a39366ab-52b4-4353-8149-840f0e65fd53"), null, 3, new DateTime(2023, 8, 11, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(7807), "Description for Ticket 144", 2, 3, "Ticket 144" },
                    { new Guid("cfada576-d255-4e3f-bbc1-b4da144c610c"), new Guid("6b4b3744-f22f-4a10-b60d-f87cbb676462"), null, 0, new DateTime(2023, 11, 6, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(5663), "Description for Ticket 57", 2, 0, "Ticket 57" },
                    { new Guid("d00f3305-9cef-4e76-94aa-9cc1be1b9ff5"), new Guid("c5411f95-3578-4056-9ccc-697bdbcb3444"), null, 2, new DateTime(2023, 8, 12, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(7794), "Description for Ticket 143", 1, 2, "Ticket 143" },
                    { new Guid("d3692c1e-608d-4126-ae17-00724916ebce"), new Guid("cee9a32c-614e-4240-8ab7-caff4d4fdbfd"), null, 3, new DateTime(2023, 10, 2, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(6675), "Description for Ticket 92", 1, 3, "Ticket 92" },
                    { new Guid("d3c36318-e648-4d1c-9c06-732fa1f8a099"), new Guid("c7e9d74c-b613-422d-b7ac-6bb8ebd28d59"), null, 1, new DateTime(2023, 8, 25, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(7607), "Description for Ticket 130", 0, 1, "Ticket 130" },
                    { new Guid("d5e7107c-feb0-48c0-a976-8e106db78363"), new Guid("b09b730f-479d-420a-a4b4-60f0831682a3"), null, 0, new DateTime(2023, 6, 15, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(8724), "Description for Ticket 201", 2, 0, "Ticket 201" },
                    { new Guid("d60df1ea-2ef4-42c0-ac71-40b37e59963a"), new Guid("9d55b16d-14d8-4345-a067-30be4122ccbe"), null, 3, new DateTime(2023, 6, 20, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(8656), "Description for Ticket 196", 0, 3, "Ticket 196" },
                    { new Guid("d6e4c712-a1f9-4342-8069-0414f4237c3a"), new Guid("4aee48d9-4a25-4d95-a69f-416a46f3e2c8"), null, 1, new DateTime(2023, 9, 18, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(6831), "Description for Ticket 106", 0, 1, "Ticket 106" },
                    { new Guid("d89649fe-45df-4621-9856-6ebc92a02c0f"), new Guid("8de70f65-1c32-4860-8b60-73b64054e994"), null, 3, new DateTime(2023, 9, 8, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(7064), "Description for Ticket 116", 1, 3, "Ticket 116" },
                    { new Guid("d92578cf-2af6-4cf0-9415-5c490ea4f8b9"), new Guid("26563f3b-42ff-4eed-8a4a-fb0d03d11ff0"), null, 1, new DateTime(2023, 12, 27, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(4746), "Description for Ticket 6", 2, 1, "Ticket 6" },
                    { new Guid("d9721f48-81c4-4b77-a431-979586c33885"), new Guid("04b1b138-6397-4062-9e38-537ca161c1da"), null, 0, new DateTime(2023, 7, 29, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(8023), "Description for Ticket 157", 0, 0, "Ticket 157" },
                    { new Guid("db6c9ac7-a9f6-4ba2-aec4-eb8643238882"), new Guid("56e654fc-6fa0-483b-bc85-51b57cc38062"), null, 2, new DateTime(2023, 11, 20, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(5470), "Description for Ticket 43", 0, 2, "Ticket 43" },
                    { new Guid("dc70e60b-e345-4bcf-9121-c5597b456f55"), new Guid("1b2477b5-e225-4f9a-9b8b-e9684e54aa2c"), null, 0, new DateTime(2023, 5, 26, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(9172), "Description for Ticket 221", 1, 0, "Ticket 221" },
                    { new Guid("dec7edc1-236b-46da-bc28-7786051955f3"), new Guid("903fde5f-8b2a-40ea-bfad-1c5be5505831"), null, 0, new DateTime(2023, 8, 26, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(7503), "Description for Ticket 129", 2, 0, "Ticket 129" },
                    { new Guid("df21e02d-fbc9-49f1-a826-7d703bde48c3"), new Guid("25242f77-fdb8-47d6-80fa-01c226c38a36"), null, 2, new DateTime(2023, 6, 9, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(8805), "Description for Ticket 207", 2, 2, "Ticket 207" },
                    { new Guid("e039c88e-f7b7-47ac-9047-0deb3e6991ed"), new Guid("cee9a32c-614e-4240-8ab7-caff4d4fdbfd"), null, 1, new DateTime(2023, 12, 11, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(5155), "Description for Ticket 22", 0, 1, "Ticket 22" },
                    { new Guid("e0c1f2bb-eb6e-4bf0-87ca-3fb0e3a8d293"), new Guid("78719898-28c7-4e82-ac3c-d7cdbb21b8c4"), null, 0, new DateTime(2023, 5, 6, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(9460), "Description for Ticket 241", 0, 0, "Ticket 241" },
                    { new Guid("e16bbe16-c753-454b-81ca-7c5b79e09dd3"), new Guid("0056b30a-e1df-4efd-bc3e-6093120cb871"), null, 1, new DateTime(2023, 12, 23, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(4914), "Description for Ticket 10", 0, 1, "Ticket 10" },
                    { new Guid("e1827274-fdd9-4977-822d-ae0f13e6730e"), new Guid("a1a44f62-3095-4a1a-ba87-cadd4f996fb6"), null, 0, new DateTime(2023, 7, 13, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(8291), "Description for Ticket 173", 1, 0, "Ticket 173" },
                    { new Guid("e29c46b8-6aa0-4ddc-a0b1-0d957a63d05b"), new Guid("25242f77-fdb8-47d6-80fa-01c226c38a36"), null, 0, new DateTime(2023, 8, 18, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(7711), "Description for Ticket 137", 1, 0, "Ticket 137" },
                    { new Guid("e3f1d1c0-bcef-4bf7-962b-b628757b4f34"), new Guid("81bcca65-038d-4880-9418-ab52a2fe031c"), null, 1, new DateTime(2023, 11, 29, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(5307), "Description for Ticket 34", 0, 1, "Ticket 34" },
                    { new Guid("e57fbf48-eaef-4bac-9a5d-769c1073caca"), new Guid("31630389-f081-42c9-9916-d9e0de380e67"), null, 1, new DateTime(2023, 12, 31, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(4682), "Description for Ticket 2", 1, 1, "Ticket 2" },
                    { new Guid("e68ce2fa-e62a-478d-b846-c67360a82f83"), new Guid("a0f84582-77e3-462d-860e-66037897df21"), null, 0, new DateTime(2023, 7, 21, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(8140), "Description for Ticket 165", 2, 0, "Ticket 165" },
                    { new Guid("e82995a4-a8d4-40a6-9510-4252d250f21b"), new Guid("2faace28-cf62-40ad-9ddd-6f1d5ef6f1df"), null, 2, new DateTime(2023, 7, 31, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(7992), "Description for Ticket 155", 1, 2, "Ticket 155" },
                    { new Guid("e8921ee4-1fd9-49e5-bdfa-78341c189161"), new Guid("cab1cee3-26b2-495f-8b4c-136380a02e63"), null, 2, new DateTime(2023, 11, 8, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(5637), "Description for Ticket 55", 0, 2, "Ticket 55" },
                    { new Guid("e955fcbf-95a9-468f-b65f-ac352d555f9f"), new Guid("88a02658-6691-49c9-a617-47a3b9cbaa21"), null, 0, new DateTime(2023, 8, 10, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(7819), "Description for Ticket 145", 0, 0, "Ticket 145" },
                    { new Guid("e966d365-bb75-4606-ae5e-1469fe85974d"), new Guid("6e276381-7eb8-4567-8477-645fc84e9cef"), null, 1, new DateTime(2023, 9, 6, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(7293), "Description for Ticket 118", 0, 1, "Ticket 118" },
                    { new Guid("eafc3626-e6ed-46e9-b351-4aaf88f6129a"), new Guid("0ee57408-a701-4710-9bc6-dba6332335cc"), null, 1, new DateTime(2023, 12, 15, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(5100), "Description for Ticket 18", 2, 1, "Ticket 18" },
                    { new Guid("ef022d03-9ba6-4770-9181-a8ad313139c1"), new Guid("b5a5c2ef-ba30-45cd-b69a-7542b6e1225d"), null, 0, new DateTime(2023, 9, 27, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(6733), "Description for Ticket 97", 0, 0, "Ticket 97" },
                    { new Guid("ef1d7b7c-742f-427b-af2e-e03a64d8d09d"), new Guid("be928e80-e187-4c71-8338-5c5f469c14e2"), null, 1, new DateTime(2023, 5, 13, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(9339), "Description for Ticket 234", 2, 1, "Ticket 234" },
                    { new Guid("efddc130-4b78-4cd5-b0fa-f7e22c50c7a8"), new Guid("b5a5c2ef-ba30-45cd-b69a-7542b6e1225d"), null, 0, new DateTime(2023, 5, 10, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(9381), "Description for Ticket 237", 2, 0, "Ticket 237" },
                    { new Guid("f0abba3a-7c03-44cd-9b94-b17d64afcbe8"), new Guid("3285b21d-9cce-4fe2-bd89-578c31da9e49"), null, 0, new DateTime(2023, 11, 18, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(5499), "Description for Ticket 45", 2, 0, "Ticket 45" },
                    { new Guid("f0c4bd33-5520-41eb-88b1-34e05635f153"), new Guid("5d3ce4a9-dfe1-4ba5-a024-086aa86fdeb9"), null, 0, new DateTime(2023, 12, 4, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(5243), "Description for Ticket 29", 1, 0, "Ticket 29" },
                    { new Guid("f21c922a-a311-4ba6-9cb1-693ab6055963"), new Guid("6b4b3744-f22f-4a10-b60d-f87cbb676462"), null, 2, new DateTime(2023, 8, 28, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(7475), "Description for Ticket 127", 0, 2, "Ticket 127" },
                    { new Guid("f2789e59-b14c-48d5-985a-aa3dee9f6a03"), new Guid("9264bfc7-2a04-41e8-8a82-fc212e003efa"), null, 2, new DateTime(2023, 6, 5, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(8855), "Description for Ticket 211", 0, 2, "Ticket 211" },
                    { new Guid("f2a53b02-abda-421f-b084-cd8c97fabe3c"), new Guid("07a7f193-758c-4d54-8d67-5fefea708497"), null, 1, new DateTime(2023, 10, 28, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(5824), "Description for Ticket 66", 2, 1, "Ticket 66" },
                    { new Guid("f4432c35-11a1-43ac-b8e6-6a41b1b88b3e"), new Guid("2faace28-cf62-40ad-9ddd-6f1d5ef6f1df"), null, 0, new DateTime(2023, 5, 22, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(9221), "Description for Ticket 225", 2, 0, "Ticket 225" },
                    { new Guid("f4bdbe20-3ab7-4428-bb32-f91992811328"), new Guid("28349c17-6fd4-4600-a21c-113dbe2647f7"), null, 0, new DateTime(2023, 10, 29, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(5806), "Description for Ticket 65", 1, 0, "Ticket 65" },
                    { new Guid("f54fdc74-ebf0-4339-8bbf-c8ee5a4ad3af"), new Guid("51b9e1e7-be46-4c8d-b739-b4d13e0731ec"), null, 0, new DateTime(2023, 9, 15, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(6958), "Description for Ticket 109", 0, 0, "Ticket 109" },
                    { new Guid("f58757c5-5044-4edb-8b19-83f113e460b9"), new Guid("9d64707b-ab3f-4516-bce1-bed489adc112"), null, 1, new DateTime(2023, 8, 17, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(7725), "Description for Ticket 138", 2, 1, "Ticket 138" },
                    { new Guid("f87fb26f-1d94-4ae2-8c24-669bd911a25f"), new Guid("c1c210aa-03af-41b4-80dc-8a7785eac2bd"), null, 2, new DateTime(2023, 8, 16, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(7738), "Description for Ticket 139", 0, 2, "Ticket 139" },
                    { new Guid("fae91161-b85a-476d-8199-97754b8e1c68"), new Guid("a0f84582-77e3-462d-860e-66037897df21"), null, 0, new DateTime(2023, 12, 8, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(5191), "Description for Ticket 25", 0, 0, "Ticket 25" },
                    { new Guid("fbd73aaa-aa37-4afb-9728-56f30c204b8e"), new Guid("0056b30a-e1df-4efd-bc3e-6093120cb871"), null, 1, new DateTime(2023, 8, 5, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(7927), "Description for Ticket 150", 2, 1, "Ticket 150" },
                    { new Guid("fbfa808f-88ed-4c0e-8d1e-0d86f169f8d7"), new Guid("b560b1ab-aa94-477c-957e-b93f96dcf73b"), null, 2, new DateTime(2023, 4, 30, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(9543), "Description for Ticket 247", 0, 2, "Ticket 247" },
                    { new Guid("fc18e219-60c1-43e5-8689-27e99540e27b"), new Guid("28d6de2e-d6e5-43b2-bde5-1f7efab0dafc"), null, 3, new DateTime(2023, 7, 6, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(8384), "Description for Ticket 180", 2, 3, "Ticket 180" },
                    { new Guid("fc4a2ad4-c1a8-4f90-9092-ec45817cb51b"), new Guid("c3ad68a7-8bee-4eeb-94d5-f271809d5b30"), null, 1, new DateTime(2023, 8, 1, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(7979), "Description for Ticket 154", 0, 1, "Ticket 154" },
                    { new Guid("fd234cfa-cb64-4b0a-97ba-f8f3f4506b30"), new Guid("5bc72dba-f0f6-4197-a6fd-3e26d20fb4e6"), null, 2, new DateTime(2023, 7, 11, 20, 51, 33, 815, DateTimeKind.Local).AddTicks(8316), "Description for Ticket 175", 0, 2, "Ticket 175" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_WorkItems_AssetId",
                table: "WorkItems",
                column: "AssetId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Assets_AssetID",
                table: "Tickets",
                column: "AssetID",
                principalTable: "Assets",
                principalColumn: "AssetID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Assets_AssetID",
                table: "Tickets");

            migrationBuilder.DropTable(
                name: "WorkItems");

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("011ca563-252b-45e6-a19d-c64b869eec63"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("017c5930-0f5f-4bb3-944e-89b6775b35aa"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("03bd545a-6af4-4b58-b564-65e10c7ac151"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("0562bf50-c04c-4c82-9b14-1235ba2c768e"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("09ce97a3-7dc1-440e-a8d6-f5965670bb7e"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("0a63ea77-5652-4522-958f-f4fe66ecd44b"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("0beebcce-74bf-4cd8-9c85-47002bfd41a7"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("0cc988b4-4393-4b38-8ff5-a1291913c693"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("0d3d796d-275d-465f-b859-c558f21ba9da"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("0f637ae4-80c4-4986-b5a5-658045a69e0d"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("1030e7f4-64f3-4cf6-93b1-82489d2e9d58"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("10af1276-3fa2-420a-9f99-7ef15806ab58"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("10d9e0fc-52de-4441-abdc-21bf8778efa0"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("120bfbf8-c7a2-4eac-b158-73d593e92570"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("147907a5-fc3c-4550-ad68-652ab5a006e8"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("192d1341-a2f0-4021-a4c7-00537934bb2b"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("1c0233fa-57e0-4f8f-af88-be07087eddd0"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("1eb82d13-b5b0-441a-8286-0e7648241516"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("1eda4600-1230-4cc9-bf40-024eade57ef5"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("1ee0671d-a62d-4dcc-9dc3-195ca4a0dd61"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("1f2c5a8d-c74b-4a7e-917a-84cacc89831a"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("1f46c81c-831a-4e54-8adf-0503de33350f"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("20302490-c448-48c4-b9c3-e90694641459"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("221b1f2b-638e-4f99-97f0-aead23d2a183"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("2342ebee-a163-418d-b024-25594cdbafa1"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("256797b5-35e0-48ad-b8e5-d470c69eeeae"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("262b6145-d7cf-4da7-b706-9dc8fe4cbcf4"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("29325b2a-92c3-40b6-adaa-03206ed7f70c"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("298a2edc-477b-4d06-b912-7a2f2e16716c"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("2c5b8f2b-3ed3-46be-8e12-2911ff3148ce"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("2d613196-7fcb-4cb8-9fc0-9758ce01a831"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("2df71499-4b15-4a5d-92e8-de04750ff8cb"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("2ffafc4b-b28f-46e8-9fc5-86879fd03a92"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("32107dc2-f6fc-4043-a8b9-3bcbab13dd57"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("333ce836-4ddd-432c-ab18-9f2b426e7a94"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("33e77004-01ce-41ea-ad9b-e661b5412290"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("342d7a58-795e-48cc-a50d-f15788769d12"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("355a4f68-3089-4a9f-a716-d916a4608e90"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("358f410f-389b-4665-b381-21b4cb3bf4ba"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("3649cfe3-db03-4ada-be74-089d3d1989d9"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("366f3301-cf8c-4e31-9bd3-6ebdf7aae411"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("3773064b-3159-45a1-be7c-08bff1c410cf"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("37b9c5d1-b997-4962-b234-e097e6aa5e0b"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("397974e3-eb35-4033-98b2-19d41f588194"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("39abf9de-2086-40dd-b6c9-eee9f6c4d24e"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("39b5f7f4-34b2-4906-92e9-bc75c4439cc3"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("3a4a5ff5-2b88-4a76-b0a0-69cf0daf4341"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("3af36cb1-2c4d-4c5f-a35e-6c18abd33192"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("3b3e4d11-3316-462b-8f70-a70b52a677bf"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("3bc05c25-b2f8-4354-85af-6b9693eafbee"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("3cb6faa1-58b5-4702-a7fa-c43b8028cd0c"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("3d0a84ab-26ef-4564-a1dc-2808869105fb"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("3d1db4ee-03e6-4d03-86b0-09d977101ce2"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("3ed3929c-ed6f-4013-8887-703948ff1de0"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("4170964c-860c-4143-a101-a6bb250fa9d7"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("435cedb6-8a44-44e4-ad03-f0c04ee7e123"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("44535567-ca6b-4066-a98b-617e00aab0ac"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("44b006d5-5e2f-4b1e-a884-e92439d9d78e"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("44e4ffb6-7b13-42d4-96a8-0b4f81d57a4f"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("45aefb2f-1671-445b-aa80-785bd3a088ab"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("4664f4c4-915f-4afe-9ab0-a8b266797e00"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("47718485-ea5e-4f21-bc30-6ac06ca4e614"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("48270fee-c51c-41c8-b3c1-0e5c26dba326"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("4aa8c15f-6c70-4a44-9452-6a3f1d8c9d67"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("4c5db807-222a-4fa0-8f7a-72dd1c8c3c64"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("4c795b45-4d38-4cde-93b3-53a3dfc9ff0a"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("5039e730-5e0b-4731-a928-6047d0bc96eb"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("512b2e42-142c-45a2-aac1-f485dbc522c4"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("51f128f0-432e-49e5-b59a-2bc8882be4c6"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("524245d2-0931-4fd1-a3e8-111d05657f77"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("5264bce8-a2ff-48d4-bc11-05cf1374a50d"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("52804f06-371e-4710-a52e-f1b0933b576a"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("5390433b-eac9-4874-a27a-5acfa79964f5"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("53a49455-34a2-440e-b47b-ce0e1681a119"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("546a7f40-790a-4d9a-8671-9facddaac0fe"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("56880c82-1d68-4b54-827a-e87c4db7933f"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("56a39e43-5092-4be7-b34e-91bd9cfb7566"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("5767b59d-da15-4ff8-92da-9ea09a0fbdaf"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("583f0dff-9238-4cbc-b636-3b7cddd0ee5f"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("588af101-54f8-4407-b606-bfab4bf14e1e"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("5932678d-41db-4e95-82d0-a52ee890a8d5"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("5974b5e5-c3f4-44d5-9e40-241ac5d61033"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("5bb03d24-c128-457f-8fbd-4d56fdd3211e"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("5d145f8a-f195-4cb1-b006-7cea623487b1"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("5da9e056-8850-428e-a512-f91f509ee4ad"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("5e528668-3be3-40ac-a84e-17389f3e1a1e"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("5e8c8512-58b9-4828-a158-2b6210bf43ca"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("5ec59bb6-8642-486b-b11c-536e05ae115c"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("6163fbed-0d3f-4f92-9a1d-21195754d7de"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("625ef47a-7344-49e4-9aa0-346345a49cd6"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("632f9afc-3c0c-4d31-be48-6354314e0397"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("64b09c0e-2a11-4c38-a9e3-4380d9d49c1e"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("64fa5105-d07b-456a-b4ea-fcbfc6d9b513"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("656f4c98-f08b-4cc7-812f-7e1311db632d"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("65853766-f1f2-4980-8c66-e0aa623ce2f2"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("65eaa1dc-d50e-408e-b1da-386b248a3399"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("6601cf96-0662-4bff-88c7-bbd14bf59557"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("66520326-8f13-48d6-98a7-a95ba6dda57e"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("6709b313-025e-4a74-baa7-7800cf6afd20"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("67fa2b00-40b7-47e8-ad92-7def9cbf080a"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("6ae3327f-d9a9-4aa9-9cf4-8bb9624385f6"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("6ce58b0d-7ca1-42e4-a125-11151f84ee6b"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("6e072a43-8631-45ed-80a8-ade15635e7dc"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("6f552db3-3199-44ef-8b03-cc137ea118ee"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("711549eb-8ac8-4f9e-afe0-072a8f3d281f"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("7197b1e8-9848-4316-91c9-e7a975974168"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("71cc27af-b576-475e-869a-995f4ed31a8a"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("733d0080-b8ed-4c5e-aba5-2fbb0f9ef85a"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("74c06a7a-6e47-4998-81e3-7dbbc6390eec"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("74d2c0dc-fb41-4270-9550-8631ddf2750c"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("752dda90-6b18-4ca2-89ed-7a3a4db928a7"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("75734812-67a5-4e3f-be72-fb74cf4829a1"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("76d5b554-44a7-4d4e-8219-de4c9cd67c4e"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("77331ff7-6276-4bde-b689-3349b0db17a1"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("78271198-421a-4ebd-90f0-771d2d657ee8"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("786d235f-1d94-4b5d-93be-7714bf439d0e"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("79b47d68-999c-46bb-829c-eea19e88fb73"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("79c06d7e-e626-449a-85a0-694c7e500ea2"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("7b1409c2-956b-4c16-81be-c949d0b65930"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("7ba47b93-2917-4eb9-b3b1-23c1408b7098"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("7bc71534-4e59-49a9-a096-62f55708559a"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("80d647f0-ad4e-4a87-9137-2a9278180c22"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("81689c88-36aa-46c8-9372-f103d7d0a1e1"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("823fca7c-635d-442e-8eb8-606e7731aad1"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("833a2968-eb53-4c99-b501-e63aa714297b"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("84e59391-c8b3-4a27-978b-ce6c5929285f"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("8616354b-25ee-48db-98e3-0f557f28895c"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("868e1808-d718-4383-aec8-5f6cacfab4fe"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("8b628c40-4cb1-4290-8819-5e887000a76f"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("8ba6ae32-8bab-4b5e-af8c-87ff97d958fc"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("8c1c24dd-ec02-41b1-bc6d-7eb79cc5cccf"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("8cf2f545-b276-42f4-8e1a-a385cc5dfedb"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("90ceaae6-cbed-43a3-b7c7-00ead83a6a68"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("944da4df-0c29-4289-be2a-09868a3e70f9"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("94b63ef4-ed55-42e2-a744-524928f46893"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("95bd836b-e7fc-4541-bfd3-b96c10757554"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("96b86362-f38e-47d8-8957-3a3dbec577ab"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("98926671-e215-42d6-a241-34932d4e21fb"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("9b938d3d-85c1-4f05-8133-dad3b9d5472e"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("9d2aca59-0b71-44fa-8e3c-8a4535620257"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("9de25fba-1bc0-4bf6-ae3b-90e74464fe4b"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("9e8a2f62-8acd-472a-8294-e00f1f41b2ea"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("9fcb5c8d-6d5f-4382-a79a-a7d19090cd1d"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("a20ebda2-b092-4499-8d80-550973a7c23b"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("a2b82ae6-3a04-441f-9d09-1f34be82b6c7"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("a3775a8d-d05f-4400-bead-f6cd47f594f5"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("a6204ab6-28cb-41e7-bc84-41b9d7dcf730"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("a63d1f9a-8fd9-431b-85ff-3cf585b3fa39"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("a6c9c251-eef2-405c-8e7e-b3352171c468"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("a7305097-d7ef-4471-8b7f-4a752c029584"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("a963f362-1985-4a8d-bf6e-8624ffa88f68"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("a9ddcc7d-75a9-4e35-93f3-19f1a50317f7"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("aa1f47ac-8832-45b9-9566-1ef9e01f9e5a"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("aa7c1177-3666-467f-b5a6-989d16203e4e"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("ab3147e9-cfff-476a-a2a9-ff58e73426ed"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("ac7cb728-d9b2-4871-9af5-d4fd3a438d34"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("ac8ebe9d-d950-4369-a156-5d0e3dbbb38e"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("ad85c91e-a7ce-4419-a145-4d7cc84726c3"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("ae25913a-8c7d-4e38-8a6d-781cfe895316"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("aeeb5d14-7c83-414a-a610-8fa13e28d17b"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("b05e8886-764b-4aa6-ac89-0905061e3e8a"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("b1c3ebaf-8dbd-497e-a6d8-4e0e8bb71d84"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("b2d2f3c6-e962-4bc2-9352-5c6101b1f4f1"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("b2dfbf9b-33ce-43e7-b676-69c74ffc4b7f"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("b2e11e21-3e37-41c5-85f2-7c35b320cdbf"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("b33ed68e-0100-4de1-91cf-089e1a8b9b7e"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("b53723e1-1d4f-49a1-a6bd-771493e4cb5d"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("b5b57016-c5c4-45cc-9f8f-ab40427252f7"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("b641e944-d789-42d6-b02b-18b7479fae4b"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("b78b632a-8304-428e-a59f-0d354e059513"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("b83815bc-eee9-4329-862b-d6cb5cf65fdb"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("b8a03744-41b6-4d7d-98b7-4a579731ded3"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("ba6eb139-23ce-487b-9a17-4439cad9f7b5"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("bafebffa-69ff-4182-aac9-7921c82712e9"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("bb7388c0-406a-4591-97fb-6814bb4a40b7"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("bbd6712b-91e4-4e4a-b435-131ce8d330a4"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("bc0a8c1b-c190-4568-9bc9-c9ee4635a26c"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("bc80cce9-8687-4be5-b0e8-3e2929fd291f"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("bc8a24c5-0118-411b-9234-1392d2ea95e8"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("bd8269e7-1a11-4b4a-8d67-3ed7d58c54f8"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("bdb27c1f-5e18-4df6-aa9b-ce69047e3460"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("bdcecf0a-7478-4afc-a40d-514bf64768db"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("bec263b4-d356-4caf-88ed-d9ec8e23496e"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("c1895c5d-6237-4f57-9d12-75546fbc029b"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("c1dd56f7-2a54-409e-93b1-53b5ee3f7a60"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("c2130614-4843-4593-b448-82a18b77ebd0"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("c3b85311-54b4-485e-aeda-e0e9db54f438"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("c4098849-80b3-4461-bcc2-81b37efb5bb3"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("c417d87d-5e42-4659-8201-4ed028a7a1cb"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("c453aeb7-a061-42d8-a219-e79cfd112210"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("c4f5ec25-8d4e-4fb7-91e7-e453f57f1988"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("c5009dc3-a9e2-490e-aef5-855a3bcd10a8"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("c573c6f2-4d28-49e5-890f-8b930ae20354"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("c63d6087-166f-4ab6-bbb7-f57557f238c7"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("c63d8a3b-be4f-41ca-9be8-b8160eebb8aa"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("c7d61ae3-f993-4a67-9f28-c0233db5b83f"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("c9115cce-0f33-4ae4-b059-9a80a785b6ad"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("ca66ef5a-d454-42a5-a19e-ab8bd0932d17"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("cae64ae7-1aa2-43b4-bae1-bd0380196062"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("cdccf910-8aa7-4b34-9901-5f35ae4857ab"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("ce17553e-55e4-4f5e-bbaa-268928ec83fb"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("ce2b4f9a-5bc9-4c5a-91e6-cf96f2c6a529"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("ce6e2ebc-3e33-4bf4-ac0c-877c64d79f0b"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("cf2b7c00-3470-4acb-8f19-06efb16888de"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("cfada576-d255-4e3f-bbc1-b4da144c610c"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("d00f3305-9cef-4e76-94aa-9cc1be1b9ff5"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("d3692c1e-608d-4126-ae17-00724916ebce"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("d3c36318-e648-4d1c-9c06-732fa1f8a099"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("d5e7107c-feb0-48c0-a976-8e106db78363"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("d60df1ea-2ef4-42c0-ac71-40b37e59963a"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("d6e4c712-a1f9-4342-8069-0414f4237c3a"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("d89649fe-45df-4621-9856-6ebc92a02c0f"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("d92578cf-2af6-4cf0-9415-5c490ea4f8b9"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("d9721f48-81c4-4b77-a431-979586c33885"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("db6c9ac7-a9f6-4ba2-aec4-eb8643238882"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("dc70e60b-e345-4bcf-9121-c5597b456f55"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("dec7edc1-236b-46da-bc28-7786051955f3"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("df21e02d-fbc9-49f1-a826-7d703bde48c3"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("e039c88e-f7b7-47ac-9047-0deb3e6991ed"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("e0c1f2bb-eb6e-4bf0-87ca-3fb0e3a8d293"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("e16bbe16-c753-454b-81ca-7c5b79e09dd3"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("e1827274-fdd9-4977-822d-ae0f13e6730e"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("e29c46b8-6aa0-4ddc-a0b1-0d957a63d05b"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("e3f1d1c0-bcef-4bf7-962b-b628757b4f34"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("e57fbf48-eaef-4bac-9a5d-769c1073caca"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("e68ce2fa-e62a-478d-b846-c67360a82f83"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("e82995a4-a8d4-40a6-9510-4252d250f21b"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("e8921ee4-1fd9-49e5-bdfa-78341c189161"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("e955fcbf-95a9-468f-b65f-ac352d555f9f"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("e966d365-bb75-4606-ae5e-1469fe85974d"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("eafc3626-e6ed-46e9-b351-4aaf88f6129a"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("ef022d03-9ba6-4770-9181-a8ad313139c1"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("ef1d7b7c-742f-427b-af2e-e03a64d8d09d"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("efddc130-4b78-4cd5-b0fa-f7e22c50c7a8"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("f0abba3a-7c03-44cd-9b94-b17d64afcbe8"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("f0c4bd33-5520-41eb-88b1-34e05635f153"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("f21c922a-a311-4ba6-9cb1-693ab6055963"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("f2789e59-b14c-48d5-985a-aa3dee9f6a03"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("f2a53b02-abda-421f-b084-cd8c97fabe3c"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("f4432c35-11a1-43ac-b8e6-6a41b1b88b3e"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("f4bdbe20-3ab7-4428-bb32-f91992811328"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("f54fdc74-ebf0-4339-8bbf-c8ee5a4ad3af"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("f58757c5-5044-4edb-8b19-83f113e460b9"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("f87fb26f-1d94-4ae2-8c24-669bd911a25f"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("fae91161-b85a-476d-8199-97754b8e1c68"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("fbd73aaa-aa37-4afb-9728-56f30c204b8e"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("fbfa808f-88ed-4c0e-8d1e-0d86f169f8d7"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("fc18e219-60c1-43e5-8689-27e99540e27b"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("fc4a2ad4-c1a8-4f90-9092-ec45817cb51b"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("fd234cfa-cb64-4b0a-97ba-f8f3f4506b30"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("0056b30a-e1df-4efd-bc3e-6093120cb871"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("04b1b138-6397-4062-9e38-537ca161c1da"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("07a7f193-758c-4d54-8d67-5fefea708497"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("0ee57408-a701-4710-9bc6-dba6332335cc"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("1b2477b5-e225-4f9a-9b8b-e9684e54aa2c"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("20e09b01-c231-4bb5-b112-9e2b218047da"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("21ba0292-2cd8-4047-ba5d-184d24a29877"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("25242f77-fdb8-47d6-80fa-01c226c38a36"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("26563f3b-42ff-4eed-8a4a-fb0d03d11ff0"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("28349c17-6fd4-4600-a21c-113dbe2647f7"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("28d6de2e-d6e5-43b2-bde5-1f7efab0dafc"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("2cb82dbd-8391-4046-acf0-8de663e04f36"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("2faace28-cf62-40ad-9ddd-6f1d5ef6f1df"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("31630389-f081-42c9-9916-d9e0de380e67"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("3285b21d-9cce-4fe2-bd89-578c31da9e49"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("44c62471-a823-4da1-b969-673b33771727"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("46c5c2b0-110c-4187-8e2f-13cd9c047c3d"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("477ae5df-9673-439b-96f6-133ec112527c"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("49b158ee-531f-44a6-b4ac-1e5afcc5594b"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("4aee48d9-4a25-4d95-a69f-416a46f3e2c8"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("51b9e1e7-be46-4c8d-b739-b4d13e0731ec"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("544a0ef2-14fb-4e36-a7c3-ba5b433b9a8c"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("548e6919-14cc-4658-b787-c78242286c3d"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("56e654fc-6fa0-483b-bc85-51b57cc38062"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("5bc50449-2015-47d7-b4ff-ea4e7f16b024"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("5bc72dba-f0f6-4197-a6fd-3e26d20fb4e6"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("5c4bd001-2790-4490-af94-29729ba2211b"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("5d3ce4a9-dfe1-4ba5-a024-086aa86fdeb9"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("5f34e2a4-69d7-4a73-8c43-8763221e031c"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("5f41bf29-aa96-4460-be16-2a106e0798b2"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("6117b27a-03c1-4c40-9ca1-ec69ce505cae"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("62471ddb-07f1-4794-9efc-a33626470605"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("656d70d9-65ad-434e-ba33-79515cc93282"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("66229280-def8-4159-b496-63fa6a4b3863"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("6b4b3744-f22f-4a10-b60d-f87cbb676462"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("6e276381-7eb8-4567-8477-645fc84e9cef"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("78719898-28c7-4e82-ac3c-d7cdbb21b8c4"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("7957e8e0-1624-4cfc-9cdc-14909e700120"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("7e4d675e-f94a-40cc-afd0-66a20dbd018c"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("81bcca65-038d-4880-9418-ab52a2fe031c"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("88a02658-6691-49c9-a617-47a3b9cbaa21"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("8de70f65-1c32-4860-8b60-73b64054e994"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("903fde5f-8b2a-40ea-bfad-1c5be5505831"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("9264bfc7-2a04-41e8-8a82-fc212e003efa"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("92c83e8d-94b6-4c94-86aa-20b78674a960"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("944ec632-8ed2-4b07-b4d5-d44a50cadceb"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("9d55b16d-14d8-4345-a067-30be4122ccbe"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("9d64707b-ab3f-4516-bce1-bed489adc112"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("a03d5308-2dbb-40af-a138-277771f7deb6"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("a0f84582-77e3-462d-860e-66037897df21"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("a1a44f62-3095-4a1a-ba87-cadd4f996fb6"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("a39366ab-52b4-4353-8149-840f0e65fd53"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("a4902ad1-f16a-4186-9291-76caebcf2827"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("b09b730f-479d-420a-a4b4-60f0831682a3"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("b560b1ab-aa94-477c-957e-b93f96dcf73b"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("b5a5c2ef-ba30-45cd-b69a-7542b6e1225d"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("b91e96a7-3994-4636-93fb-3afd9eff757a"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("be928e80-e187-4c71-8338-5c5f469c14e2"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("c1c210aa-03af-41b4-80dc-8a7785eac2bd"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("c3ad68a7-8bee-4eeb-94d5-f271809d5b30"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("c5411f95-3578-4056-9ccc-697bdbcb3444"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("c7e9d74c-b613-422d-b7ac-6bb8ebd28d59"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("cab1cee3-26b2-495f-8b4c-136380a02e63"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("cee9a32c-614e-4240-8ab7-caff4d4fdbfd"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("d3632d7b-c9e0-4d01-9757-ff659ebbbdd9"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("db42d35b-dcbe-4ef0-b306-1c1dda9ecc1e"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("dc68b9c0-a916-4b63-ac54-c1b5c5983551"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("eaf79b1e-b12a-4ec0-8e48-5e8ff1c3be01"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("f5a92fa3-1709-4f49-b81d-33b5877b158f"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetID",
                keyValue: new Guid("fbb9028f-315e-4ae5-b63e-c93e3406eb71"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentID",
                keyValue: new Guid("3cfda5f3-bf5d-4b9c-a0c0-434b50cdca95"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentID",
                keyValue: new Guid("6a7a3122-1599-4314-86c0-754e95976fe6"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentID",
                keyValue: new Guid("e28294f2-e9a2-4a73-b902-2f02f2e75e63"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: new Guid("1dae9f97-b3a3-46d2-b5c7-ce367dfc87fa"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: new Guid("4d111e8b-d0a5-44f6-9206-03dceaa4e75a"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: new Guid("8d1436a6-8422-4a31-8d6b-0501bcd44abf"));

            migrationBuilder.RenameColumn(
                name: "AssetID",
                table: "Tickets",
                newName: "AssetId");

            migrationBuilder.RenameIndex(
                name: "IX_Tickets_AssetID",
                table: "Tickets",
                newName: "IX_Tickets_AssetId");

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentID", "DepartmentName" },
                values: new object[,]
                {
                    { new Guid("11575d79-7588-4b04-a4f5-96b56c770989"), 0 },
                    { new Guid("61f8de66-b936-47ca-97c3-6b8de82f0bb2"), 2 },
                    { new Guid("de47a233-c701-4b11-bfda-02d1a8341ab9"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "LocationID", "LocationName" },
                values: new object[,]
                {
                    { new Guid("62ef5012-680b-4d50-9374-273d278a60af"), 1 },
                    { new Guid("90063f1d-819e-4206-8379-745ca749cbb1"), 0 },
                    { new Guid("cc658aad-8b9b-4a89-9866-47327aff4e9d"), 2 }
                });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "AssetID", "AssetName", "BarcodeNumber", "Category", "DepartmentID", "LocationID" },
                values: new object[,]
                {
                    { new Guid("06f9353e-eeab-423c-9735-82b4454675a9"), "Asset 29", "100000000028", 0, new Guid("de47a233-c701-4b11-bfda-02d1a8341ab9"), new Guid("62ef5012-680b-4d50-9374-273d278a60af") },
                    { new Guid("09941e69-ab5a-44b3-b2e0-0986f086d0dd"), "Asset 13", "100000000012", 5, new Guid("11575d79-7588-4b04-a4f5-96b56c770989"), new Guid("90063f1d-819e-4206-8379-745ca749cbb1") },
                    { new Guid("0faa3b09-22f7-4bcb-879d-318dd5feaa90"), "Asset 9", "100000000008", 1, new Guid("61f8de66-b936-47ca-97c3-6b8de82f0bb2"), new Guid("cc658aad-8b9b-4a89-9866-47327aff4e9d") },
                    { new Guid("13a26cda-8be8-4206-8f65-887e483f5a1d"), "Asset 62", "100000000061", 5, new Guid("de47a233-c701-4b11-bfda-02d1a8341ab9"), new Guid("62ef5012-680b-4d50-9374-273d278a60af") },
                    { new Guid("1a43d833-873a-4752-97db-61b0b1b59702"), "Asset 5", "100000000004", 4, new Guid("de47a233-c701-4b11-bfda-02d1a8341ab9"), new Guid("62ef5012-680b-4d50-9374-273d278a60af") },
                    { new Guid("1c6e429e-2c3d-4c4f-8e70-af5dab94a8c3"), "Asset 39", "100000000038", 3, new Guid("61f8de66-b936-47ca-97c3-6b8de82f0bb2"), new Guid("cc658aad-8b9b-4a89-9866-47327aff4e9d") },
                    { new Guid("1c73cb2f-1f73-4ce1-bd49-87f0af207073"), "Asset 47", "100000000046", 4, new Guid("de47a233-c701-4b11-bfda-02d1a8341ab9"), new Guid("62ef5012-680b-4d50-9374-273d278a60af") },
                    { new Guid("1e3afbc0-fa9d-4852-b5ec-c56a37dc530b"), "Asset 34", "100000000033", 5, new Guid("11575d79-7588-4b04-a4f5-96b56c770989"), new Guid("90063f1d-819e-4206-8379-745ca749cbb1") },
                    { new Guid("24586359-b9f9-405f-a929-ddba301dbe98"), "Asset 66", "100000000065", 2, new Guid("61f8de66-b936-47ca-97c3-6b8de82f0bb2"), new Guid("cc658aad-8b9b-4a89-9866-47327aff4e9d") },
                    { new Guid("26f8d3ed-9e99-4fbb-b559-28d23f6a676a"), "Asset 6", "100000000005", 5, new Guid("61f8de66-b936-47ca-97c3-6b8de82f0bb2"), new Guid("cc658aad-8b9b-4a89-9866-47327aff4e9d") },
                    { new Guid("2ab78932-4034-433f-8c5b-0cffa4663b50"), "Asset 3", "100000000002", 2, new Guid("61f8de66-b936-47ca-97c3-6b8de82f0bb2"), new Guid("cc658aad-8b9b-4a89-9866-47327aff4e9d") },
                    { new Guid("31dac8c2-9d51-4be6-bff7-695b62ff08f4"), "Asset 14", "100000000013", 6, new Guid("de47a233-c701-4b11-bfda-02d1a8341ab9"), new Guid("62ef5012-680b-4d50-9374-273d278a60af") },
                    { new Guid("347a6236-2321-4acb-93cd-4698dc9d3621"), "Asset 11", "100000000010", 3, new Guid("de47a233-c701-4b11-bfda-02d1a8341ab9"), new Guid("62ef5012-680b-4d50-9374-273d278a60af") },
                    { new Guid("36bb8619-bdca-4655-b9b8-083f6081ea20"), "Asset 40", "100000000039", 4, new Guid("11575d79-7588-4b04-a4f5-96b56c770989"), new Guid("90063f1d-819e-4206-8379-745ca749cbb1") },
                    { new Guid("38b82a53-e9f1-407f-b817-928ef4c91167"), "Asset 36", "100000000035", 0, new Guid("61f8de66-b936-47ca-97c3-6b8de82f0bb2"), new Guid("cc658aad-8b9b-4a89-9866-47327aff4e9d") },
                    { new Guid("4056026f-38fa-45af-a5dd-f3ded60b3106"), "Asset 1", "100000000000", 0, new Guid("11575d79-7588-4b04-a4f5-96b56c770989"), new Guid("90063f1d-819e-4206-8379-745ca749cbb1") },
                    { new Guid("4ba6808e-661a-4c03-9c0c-12ae20524e19"), "Asset 16", "100000000015", 1, new Guid("11575d79-7588-4b04-a4f5-96b56c770989"), new Guid("90063f1d-819e-4206-8379-745ca749cbb1") },
                    { new Guid("4d2d10a9-dfcf-4f07-81f1-d2718a879728"), "Asset 31", "100000000030", 2, new Guid("11575d79-7588-4b04-a4f5-96b56c770989"), new Guid("90063f1d-819e-4206-8379-745ca749cbb1") },
                    { new Guid("504811be-4045-464f-ad2c-a2ba3e79fd44"), "Asset 61", "100000000060", 4, new Guid("11575d79-7588-4b04-a4f5-96b56c770989"), new Guid("90063f1d-819e-4206-8379-745ca749cbb1") },
                    { new Guid("51cb2992-1e93-4621-b8b6-97eedc8c6b88"), "Asset 51", "100000000050", 1, new Guid("61f8de66-b936-47ca-97c3-6b8de82f0bb2"), new Guid("cc658aad-8b9b-4a89-9866-47327aff4e9d") },
                    { new Guid("527532c5-51dc-455f-b8d7-a05d5779dec8"), "Asset 38", "100000000037", 2, new Guid("de47a233-c701-4b11-bfda-02d1a8341ab9"), new Guid("62ef5012-680b-4d50-9374-273d278a60af") },
                    { new Guid("5464e1a2-8b5f-46e8-8b63-505ff1fbb232"), "Asset 25", "100000000024", 3, new Guid("11575d79-7588-4b04-a4f5-96b56c770989"), new Guid("90063f1d-819e-4206-8379-745ca749cbb1") },
                    { new Guid("55750880-e659-427e-a261-4f8a90a9f7b9"), "Asset 43", "100000000042", 0, new Guid("11575d79-7588-4b04-a4f5-96b56c770989"), new Guid("90063f1d-819e-4206-8379-745ca749cbb1") },
                    { new Guid("59f9af00-7ca3-4f00-a0d0-3878fde14a8d"), "Asset 50", "100000000049", 0, new Guid("de47a233-c701-4b11-bfda-02d1a8341ab9"), new Guid("62ef5012-680b-4d50-9374-273d278a60af") },
                    { new Guid("5b70692e-b4ee-4d05-8e73-060750b092d8"), "Asset 63", "100000000062", 6, new Guid("61f8de66-b936-47ca-97c3-6b8de82f0bb2"), new Guid("cc658aad-8b9b-4a89-9866-47327aff4e9d") },
                    { new Guid("652b8b51-8e71-48ae-a308-927936dd50a8"), "Asset 46", "100000000045", 3, new Guid("11575d79-7588-4b04-a4f5-96b56c770989"), new Guid("90063f1d-819e-4206-8379-745ca749cbb1") },
                    { new Guid("6a330060-9807-4a5a-8859-1709b3051a72"), "Asset 68", "100000000067", 4, new Guid("de47a233-c701-4b11-bfda-02d1a8341ab9"), new Guid("62ef5012-680b-4d50-9374-273d278a60af") },
                    { new Guid("6a920b94-45d1-4690-999b-a0edcf1f5c66"), "Asset 67", "100000000066", 3, new Guid("11575d79-7588-4b04-a4f5-96b56c770989"), new Guid("90063f1d-819e-4206-8379-745ca749cbb1") },
                    { new Guid("6ad74ff3-fef3-4ff2-81d6-ed3316c6c075"), "Asset 33", "100000000032", 4, new Guid("61f8de66-b936-47ca-97c3-6b8de82f0bb2"), new Guid("cc658aad-8b9b-4a89-9866-47327aff4e9d") },
                    { new Guid("6cf43432-8e05-412d-9f41-c89d714baf84"), "Asset 49", "100000000048", 6, new Guid("11575d79-7588-4b04-a4f5-96b56c770989"), new Guid("90063f1d-819e-4206-8379-745ca749cbb1") },
                    { new Guid("6e677047-adf9-4ce2-beb0-bd03fe9b08d3"), "Asset 17", "100000000016", 2, new Guid("de47a233-c701-4b11-bfda-02d1a8341ab9"), new Guid("62ef5012-680b-4d50-9374-273d278a60af") },
                    { new Guid("70b540f4-5c60-450f-99d8-b72064e2346b"), "Asset 4", "100000000003", 3, new Guid("11575d79-7588-4b04-a4f5-96b56c770989"), new Guid("90063f1d-819e-4206-8379-745ca749cbb1") },
                    { new Guid("752a1277-9a47-447f-a92e-519a8486c357"), "Asset 30", "100000000029", 1, new Guid("61f8de66-b936-47ca-97c3-6b8de82f0bb2"), new Guid("cc658aad-8b9b-4a89-9866-47327aff4e9d") },
                    { new Guid("754c7786-8e68-46fb-ae0c-4e192d7d6388"), "Asset 27", "100000000026", 5, new Guid("61f8de66-b936-47ca-97c3-6b8de82f0bb2"), new Guid("cc658aad-8b9b-4a89-9866-47327aff4e9d") },
                    { new Guid("768cf51a-8646-4065-b6c1-03b9b3cfad3e"), "Asset 21", "100000000020", 6, new Guid("61f8de66-b936-47ca-97c3-6b8de82f0bb2"), new Guid("cc658aad-8b9b-4a89-9866-47327aff4e9d") },
                    { new Guid("7b8c0315-23f8-4da4-b2ec-8e1b7c9ace01"), "Asset 70", "100000000069", 6, new Guid("11575d79-7588-4b04-a4f5-96b56c770989"), new Guid("90063f1d-819e-4206-8379-745ca749cbb1") },
                    { new Guid("8233ad56-3ba6-49f1-8712-b2c17d381e89"), "Asset 59", "100000000058", 2, new Guid("de47a233-c701-4b11-bfda-02d1a8341ab9"), new Guid("62ef5012-680b-4d50-9374-273d278a60af") },
                    { new Guid("852407ca-0e97-4ecc-99cf-dc2b78316d6e"), "Asset 48", "100000000047", 5, new Guid("61f8de66-b936-47ca-97c3-6b8de82f0bb2"), new Guid("cc658aad-8b9b-4a89-9866-47327aff4e9d") },
                    { new Guid("863e3618-bd38-4cea-9006-9be4efad9173"), "Asset 41", "100000000040", 5, new Guid("de47a233-c701-4b11-bfda-02d1a8341ab9"), new Guid("62ef5012-680b-4d50-9374-273d278a60af") },
                    { new Guid("88f54748-8ba5-408d-ba33-22420eacb1d5"), "Asset 10", "100000000009", 2, new Guid("11575d79-7588-4b04-a4f5-96b56c770989"), new Guid("90063f1d-819e-4206-8379-745ca749cbb1") },
                    { new Guid("8f0c178d-1e96-4570-9640-028bdb40f3de"), "Asset 8", "100000000007", 0, new Guid("de47a233-c701-4b11-bfda-02d1a8341ab9"), new Guid("62ef5012-680b-4d50-9374-273d278a60af") },
                    { new Guid("8fca6db5-d842-4211-8c8b-fe521136b85c"), "Asset 35", "100000000034", 6, new Guid("de47a233-c701-4b11-bfda-02d1a8341ab9"), new Guid("62ef5012-680b-4d50-9374-273d278a60af") },
                    { new Guid("91ea44e8-7071-4fad-a997-cef68f8f509e"), "Asset 57", "100000000056", 0, new Guid("61f8de66-b936-47ca-97c3-6b8de82f0bb2"), new Guid("cc658aad-8b9b-4a89-9866-47327aff4e9d") },
                    { new Guid("9280b565-a852-44c4-8aaa-f53cb2a98401"), "Asset 58", "100000000057", 1, new Guid("11575d79-7588-4b04-a4f5-96b56c770989"), new Guid("90063f1d-819e-4206-8379-745ca749cbb1") },
                    { new Guid("a7551ebf-4921-47f6-ab66-9e438f4d12c8"), "Asset 28", "100000000027", 6, new Guid("11575d79-7588-4b04-a4f5-96b56c770989"), new Guid("90063f1d-819e-4206-8379-745ca749cbb1") },
                    { new Guid("a861a8c3-7bc6-48c0-9322-a6eea7e02619"), "Asset 44", "100000000043", 1, new Guid("de47a233-c701-4b11-bfda-02d1a8341ab9"), new Guid("62ef5012-680b-4d50-9374-273d278a60af") },
                    { new Guid("ab41ad29-7967-4a1d-aaf5-b19aace3dc08"), "Asset 20", "100000000019", 5, new Guid("de47a233-c701-4b11-bfda-02d1a8341ab9"), new Guid("62ef5012-680b-4d50-9374-273d278a60af") },
                    { new Guid("aeb23e03-9e60-4957-8a46-5928af6ebcab"), "Asset 15", "100000000014", 0, new Guid("61f8de66-b936-47ca-97c3-6b8de82f0bb2"), new Guid("cc658aad-8b9b-4a89-9866-47327aff4e9d") },
                    { new Guid("b3810c09-3cd8-4833-b5bd-e72d57ffcd35"), "Asset 23", "100000000022", 1, new Guid("de47a233-c701-4b11-bfda-02d1a8341ab9"), new Guid("62ef5012-680b-4d50-9374-273d278a60af") },
                    { new Guid("b76e56bd-f5d1-48c8-a0e8-c527bfc08b18"), "Asset 12", "100000000011", 4, new Guid("61f8de66-b936-47ca-97c3-6b8de82f0bb2"), new Guid("cc658aad-8b9b-4a89-9866-47327aff4e9d") },
                    { new Guid("b8573315-482a-4cc1-8c51-6ed5ed8766c7"), "Asset 22", "100000000021", 0, new Guid("11575d79-7588-4b04-a4f5-96b56c770989"), new Guid("90063f1d-819e-4206-8379-745ca749cbb1") },
                    { new Guid("bd728943-50b9-4410-a64c-91a91cf93035"), "Asset 26", "100000000025", 4, new Guid("de47a233-c701-4b11-bfda-02d1a8341ab9"), new Guid("62ef5012-680b-4d50-9374-273d278a60af") },
                    { new Guid("bf05c8dd-4904-46f8-ad43-f957f4764985"), "Asset 2", "100000000001", 1, new Guid("de47a233-c701-4b11-bfda-02d1a8341ab9"), new Guid("62ef5012-680b-4d50-9374-273d278a60af") },
                    { new Guid("bfd22c7c-d7ec-4d06-be63-495a3c25241b"), "Asset 24", "100000000023", 2, new Guid("61f8de66-b936-47ca-97c3-6b8de82f0bb2"), new Guid("cc658aad-8b9b-4a89-9866-47327aff4e9d") },
                    { new Guid("c1a78ac3-1caa-4ae9-a58d-01483c4ae9c1"), "Asset 18", "100000000017", 3, new Guid("61f8de66-b936-47ca-97c3-6b8de82f0bb2"), new Guid("cc658aad-8b9b-4a89-9866-47327aff4e9d") },
                    { new Guid("c4e77f53-0dba-4b4d-b189-73d37346da46"), "Asset 55", "100000000054", 5, new Guid("11575d79-7588-4b04-a4f5-96b56c770989"), new Guid("90063f1d-819e-4206-8379-745ca749cbb1") },
                    { new Guid("c5e803d2-a6eb-4a5c-b414-a84ca76ca285"), "Asset 56", "100000000055", 6, new Guid("de47a233-c701-4b11-bfda-02d1a8341ab9"), new Guid("62ef5012-680b-4d50-9374-273d278a60af") },
                    { new Guid("c83716ab-0e02-42c2-a930-c3a47e0f7231"), "Asset 64", "100000000063", 0, new Guid("11575d79-7588-4b04-a4f5-96b56c770989"), new Guid("90063f1d-819e-4206-8379-745ca749cbb1") },
                    { new Guid("d0e32629-2158-48ea-a52c-740d81017428"), "Asset 42", "100000000041", 6, new Guid("61f8de66-b936-47ca-97c3-6b8de82f0bb2"), new Guid("cc658aad-8b9b-4a89-9866-47327aff4e9d") },
                    { new Guid("d8954ace-9ab5-4737-95f2-c3b12b576633"), "Asset 60", "100000000059", 3, new Guid("61f8de66-b936-47ca-97c3-6b8de82f0bb2"), new Guid("cc658aad-8b9b-4a89-9866-47327aff4e9d") },
                    { new Guid("da3640c5-5b26-4ba6-a7a6-2c4623f7ce8e"), "Asset 19", "100000000018", 4, new Guid("11575d79-7588-4b04-a4f5-96b56c770989"), new Guid("90063f1d-819e-4206-8379-745ca749cbb1") },
                    { new Guid("e578bb48-45b7-4485-bf3e-66d32b6669f9"), "Asset 65", "100000000064", 1, new Guid("de47a233-c701-4b11-bfda-02d1a8341ab9"), new Guid("62ef5012-680b-4d50-9374-273d278a60af") },
                    { new Guid("ea07d31e-03b4-49bb-9e92-cb19a3f3a3be"), "Asset 53", "100000000052", 3, new Guid("de47a233-c701-4b11-bfda-02d1a8341ab9"), new Guid("62ef5012-680b-4d50-9374-273d278a60af") },
                    { new Guid("ec1a445c-c029-41d1-b77f-295797af607a"), "Asset 52", "100000000051", 2, new Guid("11575d79-7588-4b04-a4f5-96b56c770989"), new Guid("90063f1d-819e-4206-8379-745ca749cbb1") },
                    { new Guid("ef2fcdd4-dd6e-4904-ab84-2853ce95085b"), "Asset 54", "100000000053", 4, new Guid("61f8de66-b936-47ca-97c3-6b8de82f0bb2"), new Guid("cc658aad-8b9b-4a89-9866-47327aff4e9d") },
                    { new Guid("efcbdc10-a276-40e4-8545-a0fd03bd142a"), "Asset 37", "100000000036", 1, new Guid("11575d79-7588-4b04-a4f5-96b56c770989"), new Guid("90063f1d-819e-4206-8379-745ca749cbb1") },
                    { new Guid("f30f26a8-4c22-4fdc-ab37-dcbda25a2111"), "Asset 32", "100000000031", 3, new Guid("de47a233-c701-4b11-bfda-02d1a8341ab9"), new Guid("62ef5012-680b-4d50-9374-273d278a60af") },
                    { new Guid("f473fc6e-f8ab-4a58-8e84-c66d3a3ce20d"), "Asset 7", "100000000006", 6, new Guid("11575d79-7588-4b04-a4f5-96b56c770989"), new Guid("90063f1d-819e-4206-8379-745ca749cbb1") },
                    { new Guid("fd25bbdc-f878-43d1-bfc2-410f511c4ae3"), "Asset 69", "100000000068", 5, new Guid("61f8de66-b936-47ca-97c3-6b8de82f0bb2"), new Guid("cc658aad-8b9b-4a89-9866-47327aff4e9d") },
                    { new Guid("fd716492-389a-4c5f-8930-b15db879b9e5"), "Asset 45", "100000000044", 2, new Guid("61f8de66-b936-47ca-97c3-6b8de82f0bb2"), new Guid("cc658aad-8b9b-4a89-9866-47327aff4e9d") }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "TicketId", "AssetId", "AssignedUserID", "Category", "CreatedAt", "Description", "Priority", "Status", "Title" },
                values: new object[,]
                {
                    { new Guid("006d935f-783b-47cc-88bf-29399efe949f"), new Guid("ec1a445c-c029-41d1-b77f-295797af607a"), null, 3, new DateTime(2023, 11, 7, 22, 0, 10, 815, DateTimeKind.Local).AddTicks(9931), "Description for Ticket 52", 0, 3, "Ticket 52" },
                    { new Guid("006fe74c-6264-4943-9f8c-f3e1231aeec5"), new Guid("38b82a53-e9f1-407f-b817-928ef4c91167"), null, 1, new DateTime(2023, 4, 27, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(8862), "Description for Ticket 246", 2, 1, "Ticket 246" },
                    { new Guid("00c90716-85e4-4c2c-9627-7e83eb744903"), new Guid("504811be-4045-464f-ad2c-a2ba3e79fd44"), null, 0, new DateTime(2023, 10, 29, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(666), "Description for Ticket 61", 0, 0, "Ticket 61" },
                    { new Guid("01af8927-df1c-4263-a33b-7f22a389a682"), new Guid("1c73cb2f-1f73-4ce1-bd49-87f0af207073"), null, 2, new DateTime(2023, 11, 12, 22, 0, 10, 815, DateTimeKind.Local).AddTicks(9756), "Description for Ticket 47", 1, 2, "Ticket 47" },
                    { new Guid("03c20223-f7b5-4c5d-8658-6ab927c0062b"), new Guid("70b540f4-5c60-450f-99d8-b72064e2346b"), null, 3, new DateTime(2023, 12, 25, 22, 0, 10, 815, DateTimeKind.Local).AddTicks(7892), "Description for Ticket 4", 0, 3, "Ticket 4" },
                    { new Guid("0541a39a-4d46-4175-8ff8-c80aeed03661"), new Guid("aeb23e03-9e60-4957-8a46-5928af6ebcab"), null, 0, new DateTime(2023, 10, 5, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(1718), "Description for Ticket 85", 0, 0, "Ticket 85" },
                    { new Guid("05d5ae17-90e3-4e2c-8e6b-775867a238fc"), new Guid("347a6236-2321-4acb-93cd-4698dc9d3621"), null, 2, new DateTime(2023, 7, 31, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(5198), "Description for Ticket 151", 0, 2, "Ticket 151" },
                    { new Guid("066276a4-2d84-4ad5-bdb3-3fcf770f60a8"), new Guid("4ba6808e-661a-4c03-9c0c-12ae20524e19"), null, 3, new DateTime(2023, 12, 13, 22, 0, 10, 815, DateTimeKind.Local).AddTicks(8442), "Description for Ticket 16", 0, 3, "Ticket 16" },
                    { new Guid("06e24378-6270-482c-a6bf-188d6b7a1f02"), new Guid("1c6e429e-2c3d-4c4f-8e70-af5dab94a8c3"), null, 2, new DateTime(2023, 7, 3, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(6277), "Description for Ticket 179", 1, 2, "Ticket 179" },
                    { new Guid("07c2b519-43ba-49d7-9b84-24ce1d028a83"), new Guid("0faa3b09-22f7-4bcb-879d-318dd5feaa90"), null, 0, new DateTime(2023, 8, 2, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(5132), "Description for Ticket 149", 1, 0, "Ticket 149" },
                    { new Guid("0823ec8d-aff6-49bd-a9e4-78975c5fa536"), new Guid("88f54748-8ba5-408d-ba33-22420eacb1d5"), null, 1, new DateTime(2023, 8, 1, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(5165), "Description for Ticket 150", 2, 1, "Ticket 150" },
                    { new Guid("08a27b95-75f3-41f5-b035-1440376efb44"), new Guid("6e677047-adf9-4ce2-beb0-bd03fe9b08d3"), null, 0, new DateTime(2023, 12, 12, 22, 0, 10, 815, DateTimeKind.Local).AddTicks(8476), "Description for Ticket 17", 1, 0, "Ticket 17" },
                    { new Guid("097d9f4e-8e76-479e-bbd7-8029edb520f1"), new Guid("652b8b51-8e71-48ae-a308-927936dd50a8"), null, 1, new DateTime(2023, 6, 26, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(6630), "Description for Ticket 186", 2, 1, "Ticket 186" },
                    { new Guid("09c0a8d0-31a0-459a-9df9-3f61fc939353"), new Guid("efcbdc10-a276-40e4-8545-a0fd03bd142a"), null, 0, new DateTime(2023, 11, 22, 22, 0, 10, 815, DateTimeKind.Local).AddTicks(9416), "Description for Ticket 37", 0, 0, "Ticket 37" },
                    { new Guid("0b520330-6b93-4d2d-b726-169fc6779f2c"), new Guid("ab41ad29-7967-4a1d-aaf5-b19aace3dc08"), null, 1, new DateTime(2023, 5, 13, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(8312), "Description for Ticket 230", 1, 1, "Ticket 230" },
                    { new Guid("0c176948-2210-41a2-9d5f-aca01e8845b0"), new Guid("b76e56bd-f5d1-48c8-a0e8-c527bfc08b18"), null, 3, new DateTime(2023, 7, 30, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(5232), "Description for Ticket 152", 1, 3, "Ticket 152" },
                    { new Guid("0c4bfee2-a4b6-409b-8e04-4eaaee9d0f0f"), new Guid("852407ca-0e97-4ecc-99cf-dc2b78316d6e"), null, 3, new DateTime(2023, 6, 24, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(6696), "Description for Ticket 188", 1, 3, "Ticket 188" },
                    { new Guid("0c51ffc8-46a9-4354-97e7-b88c8df3d4c0"), new Guid("13a26cda-8be8-4206-8f65-887e483f5a1d"), null, 1, new DateTime(2023, 10, 28, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(700), "Description for Ticket 62", 1, 1, "Ticket 62" },
                    { new Guid("0d1c6278-7f55-4209-a54b-2b279ae69a0d"), new Guid("bf05c8dd-4904-46f8-ad43-f957f4764985"), null, 1, new DateTime(2023, 12, 27, 22, 0, 10, 815, DateTimeKind.Local).AddTicks(7821), "Description for Ticket 2", 1, 1, "Ticket 2" },
                    { new Guid("0d58df7a-9b9c-47cc-a920-a6797e2e078f"), new Guid("59f9af00-7ca3-4f00-a0d0-3878fde14a8d"), null, 3, new DateTime(2023, 8, 31, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(3336), "Description for Ticket 120", 2, 3, "Ticket 120" },
                    { new Guid("0e490fc5-11e5-4ec4-9d22-7dabfd31df40"), new Guid("c83716ab-0e02-42c2-a930-c3a47e0f7231"), null, 3, new DateTime(2023, 10, 26, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(765), "Description for Ticket 64", 0, 3, "Ticket 64" },
                    { new Guid("0f560bbb-e1b9-4890-927c-98557985fefc"), new Guid("55750880-e659-427e-a261-4f8a90a9f7b9"), null, 0, new DateTime(2023, 9, 7, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(2840), "Description for Ticket 113", 1, 0, "Ticket 113" },
                    { new Guid("0f5b8b07-22b9-4659-ad64-7466848d895a"), new Guid("ec1a445c-c029-41d1-b77f-295797af607a"), null, 3, new DateTime(2023, 6, 20, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(6830), "Description for Ticket 192", 2, 3, "Ticket 192" },
                    { new Guid("13309ef0-f755-4ed1-9aa6-ab99478fc2b7"), new Guid("31dac8c2-9d51-4be6-bff7-695b62ff08f4"), null, 1, new DateTime(2023, 7, 28, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(5307), "Description for Ticket 154", 0, 1, "Ticket 154" },
                    { new Guid("14542d85-7107-457d-931f-f91a68341950"), new Guid("0faa3b09-22f7-4bcb-879d-318dd5feaa90"), null, 2, new DateTime(2023, 10, 11, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(1510), "Description for Ticket 79", 0, 2, "Ticket 79" },
                    { new Guid("15d2e310-8ff4-4b44-bdb3-33732c05aabb"), new Guid("fd716492-389a-4c5f-8930-b15db879b9e5"), null, 2, new DateTime(2023, 9, 5, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(2915), "Description for Ticket 115", 0, 2, "Ticket 115" },
                    { new Guid("16e9b652-805c-4043-a4ac-8210b26c8493"), new Guid("aeb23e03-9e60-4957-8a46-5928af6ebcab"), null, 2, new DateTime(2023, 12, 14, 22, 0, 10, 815, DateTimeKind.Local).AddTicks(8409), "Description for Ticket 15", 2, 2, "Ticket 15" },
                    { new Guid("17629edf-317e-4bdc-94a3-0e7ce4082f99"), new Guid("b76e56bd-f5d1-48c8-a0e8-c527bfc08b18"), null, 1, new DateTime(2023, 10, 8, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(1618), "Description for Ticket 82", 0, 1, "Ticket 82" },
                    { new Guid("17e4205c-045e-40cc-865d-71eb02dfeda0"), new Guid("91ea44e8-7071-4fad-a997-cef68f8f509e"), null, 0, new DateTime(2023, 6, 15, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(7006), "Description for Ticket 197", 1, 0, "Ticket 197" },
                    { new Guid("18958d38-1915-489a-8512-2b9f85b08ab3"), new Guid("754c7786-8e68-46fb-ae0c-4e192d7d6388"), null, 0, new DateTime(2023, 5, 6, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(8555), "Description for Ticket 237", 2, 0, "Ticket 237" },
                    { new Guid("1941ac86-8609-4fcf-a024-4b3b07dfdc40"), new Guid("36bb8619-bdca-4655-b9b8-083f6081ea20"), null, 3, new DateTime(2023, 7, 2, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(6310), "Description for Ticket 180", 2, 3, "Ticket 180" },
                    { new Guid("1a14b86e-2afe-4b0d-8ab3-d2879d4ff98d"), new Guid("5464e1a2-8b5f-46e8-8b63-505ff1fbb232"), null, 0, new DateTime(2023, 7, 17, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(5792), "Description for Ticket 165", 2, 0, "Ticket 165" },
                    { new Guid("1af21b41-e47f-48e5-abaf-fa4caae0531c"), new Guid("b76e56bd-f5d1-48c8-a0e8-c527bfc08b18"), null, 1, new DateTime(2023, 5, 21, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(7973), "Description for Ticket 222", 2, 1, "Ticket 222" },
                    { new Guid("1d305e35-7877-4157-849a-eb3283e67ded"), new Guid("752a1277-9a47-447f-a92e-519a8486c357"), null, 1, new DateTime(2023, 11, 29, 22, 0, 10, 815, DateTimeKind.Local).AddTicks(8933), "Description for Ticket 30", 2, 1, "Ticket 30" },
                    { new Guid("1d85ab4f-7e30-4a1f-b819-35b9707e1076"), new Guid("ab41ad29-7967-4a1d-aaf5-b19aace3dc08"), null, 3, new DateTime(2023, 12, 9, 22, 0, 10, 815, DateTimeKind.Local).AddTicks(8591), "Description for Ticket 20", 1, 3, "Ticket 20" },
                    { new Guid("20cb3523-5f35-40c7-999b-2f53cc6ccf25"), new Guid("e578bb48-45b7-4485-bf3e-66d32b6669f9"), null, 0, new DateTime(2023, 10, 25, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(798), "Description for Ticket 65", 1, 0, "Ticket 65" },
                    { new Guid("23ed8393-95e1-419b-9425-bf731593610a"), new Guid("31dac8c2-9d51-4be6-bff7-695b62ff08f4"), null, 3, new DateTime(2023, 5, 19, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(8039), "Description for Ticket 224", 1, 3, "Ticket 224" },
                    { new Guid("23f3ad4e-66b5-44e4-adcb-b8443533ccd7"), new Guid("55750880-e659-427e-a261-4f8a90a9f7b9"), null, 2, new DateTime(2023, 6, 29, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(6521), "Description for Ticket 183", 2, 2, "Ticket 183" },
                    { new Guid("25a750b2-e2fb-4ab7-ba23-b0fc3008933c"), new Guid("26f8d3ed-9e99-4fbb-b559-28d23f6a676a"), null, 3, new DateTime(2023, 5, 27, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(7761), "Description for Ticket 216", 2, 3, "Ticket 216" },
                    { new Guid("26643e10-12f4-4776-aa5d-8938a9a3d55f"), new Guid("91ea44e8-7071-4fad-a997-cef68f8f509e"), null, 0, new DateTime(2023, 11, 2, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(169), "Description for Ticket 57", 2, 0, "Ticket 57" },
                    { new Guid("275d1862-9de0-45c8-9b53-5c5a0262344f"), new Guid("bfd22c7c-d7ec-4d06-be63-495a3c25241b"), null, 3, new DateTime(2023, 12, 5, 22, 0, 10, 815, DateTimeKind.Local).AddTicks(8724), "Description for Ticket 24", 2, 3, "Ticket 24" },
                    { new Guid("2783bb79-946f-4ee1-9d74-cc0206acc81c"), new Guid("9280b565-a852-44c4-8aaa-f53cb2a98401"), null, 1, new DateTime(2023, 6, 14, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(7039), "Description for Ticket 198", 2, 1, "Ticket 198" },
                    { new Guid("27d78122-dd13-489f-ac21-886f9778eaec"), new Guid("bd728943-50b9-4410-a64c-91a91cf93035"), null, 1, new DateTime(2023, 12, 3, 22, 0, 10, 815, DateTimeKind.Local).AddTicks(8799), "Description for Ticket 26", 1, 1, "Ticket 26" },
                    { new Guid("2a295373-2189-4d59-958c-1b069da3b36e"), new Guid("bd728943-50b9-4410-a64c-91a91cf93035"), null, 3, new DateTime(2023, 9, 24, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(2090), "Description for Ticket 96", 2, 3, "Ticket 96" },
                    { new Guid("2b017a99-2e2e-4ca4-b925-7abf0de0a967"), new Guid("70b540f4-5c60-450f-99d8-b72064e2346b"), null, 1, new DateTime(2023, 10, 16, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(1344), "Description for Ticket 74", 1, 1, "Ticket 74" },
                    { new Guid("2c91ae67-0035-48ec-bee2-531eb1e4a965"), new Guid("31dac8c2-9d51-4be6-bff7-695b62ff08f4"), null, 1, new DateTime(2023, 12, 15, 22, 0, 10, 815, DateTimeKind.Local).AddTicks(8376), "Description for Ticket 14", 1, 1, "Ticket 14" },
                    { new Guid("2cb81c44-36c8-4d1f-92f7-54caa0c44f8e"), new Guid("347a6236-2321-4acb-93cd-4698dc9d3621"), null, 0, new DateTime(2023, 5, 22, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(7940), "Description for Ticket 221", 1, 0, "Ticket 221" },
                    { new Guid("2cdbf13b-75d9-4915-b8bc-b32181252a72"), new Guid("6e677047-adf9-4ce2-beb0-bd03fe9b08d3"), null, 0, new DateTime(2023, 7, 25, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(5406), "Description for Ticket 157", 0, 0, "Ticket 157" },
                    { new Guid("2d171506-e60c-404d-917f-fed7604b3158"), new Guid("1e3afbc0-fa9d-4852-b5ec-c56a37dc530b"), null, 1, new DateTime(2023, 11, 25, 22, 0, 10, 815, DateTimeKind.Local).AddTicks(9315), "Description for Ticket 34", 0, 1, "Ticket 34" },
                    { new Guid("2d5e1a4f-2a9a-4ef6-bc7b-754113f1b04d"), new Guid("31dac8c2-9d51-4be6-bff7-695b62ff08f4"), null, 3, new DateTime(2023, 10, 6, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(1685), "Description for Ticket 84", 2, 3, "Ticket 84" },
                    { new Guid("2dcb63d5-c0a4-44c0-8560-b150bce3516f"), new Guid("c4e77f53-0dba-4b4d-b189-73d37346da46"), null, 2, new DateTime(2023, 11, 4, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(104), "Description for Ticket 55", 0, 2, "Ticket 55" },
                    { new Guid("2e29c80f-ad36-4e94-bc25-80c33a88dd48"), new Guid("504811be-4045-464f-ad2c-a2ba3e79fd44"), null, 2, new DateTime(2023, 8, 20, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(4035), "Description for Ticket 131", 1, 2, "Ticket 131" },
                    { new Guid("2ea91f05-7470-4d9b-ace2-93cf1758d748"), new Guid("bf05c8dd-4904-46f8-ad43-f957f4764985"), null, 3, new DateTime(2023, 5, 31, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(7628), "Description for Ticket 212", 1, 3, "Ticket 212" },
                    { new Guid("2f4b9dc9-129d-47c0-8aaa-a463a2f9b487"), new Guid("2ab78932-4034-433f-8c5b-0cffa4663b50"), null, 2, new DateTime(2023, 8, 8, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(4915), "Description for Ticket 143", 1, 2, "Ticket 143" },
                    { new Guid("316aaf5f-f556-479e-85db-5c62c538ff45"), new Guid("1a43d833-873a-4752-97db-61b0b1b59702"), null, 2, new DateTime(2023, 10, 15, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(1378), "Description for Ticket 75", 2, 2, "Ticket 75" },
                    { new Guid("32940842-5b12-4f20-be06-1a3de7c6ab24"), new Guid("c83716ab-0e02-42c2-a930-c3a47e0f7231"), null, 3, new DateTime(2023, 6, 8, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(7249), "Description for Ticket 204", 2, 3, "Ticket 204" },
                    { new Guid("32e3d26e-2763-4411-8464-861869cd8db5"), new Guid("852407ca-0e97-4ecc-99cf-dc2b78316d6e"), null, 1, new DateTime(2023, 9, 2, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(3016), "Description for Ticket 118", 0, 1, "Ticket 118" },
                    { new Guid("336e02d4-2b58-441b-95f0-735c5bedc80f"), new Guid("36bb8619-bdca-4655-b9b8-083f6081ea20"), null, 1, new DateTime(2023, 4, 23, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(9190), "Description for Ticket 250", 0, 1, "Ticket 250" },
                    { new Guid("35009cb6-b0e5-4fb4-a0f3-e1cb5e5d3fb4"), new Guid("6a920b94-45d1-4690-999b-a0edcf1f5c66"), null, 2, new DateTime(2023, 10, 23, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(880), "Description for Ticket 67", 0, 2, "Ticket 67" },
                    { new Guid("353a34ae-0e6b-4709-8f04-912496dcaab3"), new Guid("8fca6db5-d842-4211-8c8b-fe521136b85c"), null, 0, new DateTime(2023, 9, 15, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(2564), "Description for Ticket 105", 2, 0, "Ticket 105" },
                    { new Guid("360fe2ab-b789-47b7-a608-bfd03526bc02"), new Guid("5464e1a2-8b5f-46e8-8b63-505ff1fbb232"), null, 2, new DateTime(2023, 9, 25, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(2057), "Description for Ticket 95", 1, 2, "Ticket 95" },
                    { new Guid("37c12c61-30f6-45a3-8d22-cee2d8e5300a"), new Guid("aeb23e03-9e60-4957-8a46-5928af6ebcab"), null, 2, new DateTime(2023, 7, 27, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(5340), "Description for Ticket 155", 1, 2, "Ticket 155" },
                    { new Guid("39c733c9-5d5d-4c7f-a1cd-7b30a382d133"), new Guid("6ad74ff3-fef3-4ff2-81d6-ed3316c6c075"), null, 2, new DateTime(2023, 4, 30, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(8762), "Description for Ticket 243", 2, 2, "Ticket 243" },
                    { new Guid("3a6fbc4c-d9ea-4063-9d7f-6211e93e948f"), new Guid("51cb2992-1e93-4621-b8b6-97eedc8c6b88"), null, 2, new DateTime(2023, 6, 21, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(6797), "Description for Ticket 191", 1, 2, "Ticket 191" },
                    { new Guid("3cca5634-1728-4f87-b7c1-992f8f709bb9"), new Guid("bfd22c7c-d7ec-4d06-be63-495a3c25241b"), null, 3, new DateTime(2023, 7, 18, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(5759), "Description for Ticket 164", 1, 3, "Ticket 164" },
                    { new Guid("3e481e46-c6c9-47ae-8360-4ce9f8810d3a"), new Guid("fd716492-389a-4c5f-8930-b15db879b9e5"), null, 0, new DateTime(2023, 6, 27, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(6587), "Description for Ticket 185", 1, 0, "Ticket 185" },
                    { new Guid("3e53d89b-0c9f-4f10-9eb5-6c41ae92d35b"), new Guid("6cf43432-8e05-412d-9f41-c89d714baf84"), null, 0, new DateTime(2023, 11, 10, 22, 0, 10, 815, DateTimeKind.Local).AddTicks(9822), "Description for Ticket 49", 0, 0, "Ticket 49" },
                    { new Guid("3f050ffe-eb9b-4e65-b79a-bca956dfcee1"), new Guid("24586359-b9f9-405f-a929-ddba301dbe98"), null, 3, new DateTime(2023, 8, 15, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(4294), "Description for Ticket 136", 0, 3, "Ticket 136" },
                    { new Guid("3f478139-137b-4b48-87ed-f1ba5c79c2b3"), new Guid("ef2fcdd4-dd6e-4904-ab84-2853ce95085b"), null, 1, new DateTime(2023, 6, 18, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(6906), "Description for Ticket 194", 1, 1, "Ticket 194" },
                    { new Guid("452771ad-0209-4130-9b34-311ef876ee44"), new Guid("d0e32629-2158-48ea-a52c-740d81017428"), null, 1, new DateTime(2023, 6, 30, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(6486), "Description for Ticket 182", 1, 1, "Ticket 182" },
                    { new Guid("45d9422f-3d4e-4b77-b12f-d0f3443383ae"), new Guid("efcbdc10-a276-40e4-8545-a0fd03bd142a"), null, 0, new DateTime(2023, 7, 5, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(6201), "Description for Ticket 177", 2, 0, "Ticket 177" },
                    { new Guid("4602c6d3-ab87-4889-bd91-9df6284d79e2"), new Guid("a861a8c3-7bc6-48c0-9322-a6eea7e02619"), null, 3, new DateTime(2023, 11, 15, 22, 0, 10, 815, DateTimeKind.Local).AddTicks(9657), "Description for Ticket 44", 1, 3, "Ticket 44" },
                    { new Guid("47dbc478-4802-4d3d-a10b-a074ddcfefb2"), new Guid("8fca6db5-d842-4211-8c8b-fe521136b85c"), null, 0, new DateTime(2023, 4, 28, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(8828), "Description for Ticket 245", 1, 0, "Ticket 245" },
                    { new Guid("484bd586-64b6-49ed-b3ce-92ff7b1468e9"), new Guid("5464e1a2-8b5f-46e8-8b63-505ff1fbb232"), null, 0, new DateTime(2023, 12, 4, 22, 0, 10, 815, DateTimeKind.Local).AddTicks(8756), "Description for Ticket 25", 0, 0, "Ticket 25" },
                    { new Guid("4851f5ce-6be0-41f5-af40-1221069045e7"), new Guid("f30f26a8-4c22-4fdc-ab37-dcbda25a2111"), null, 3, new DateTime(2023, 7, 10, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(6035), "Description for Ticket 172", 0, 3, "Ticket 172" },
                    { new Guid("4c2b411d-0c53-4751-9839-c2767d62d42f"), new Guid("26f8d3ed-9e99-4fbb-b559-28d23f6a676a"), null, 1, new DateTime(2023, 8, 5, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(5028), "Description for Ticket 146", 1, 1, "Ticket 146" },
                    { new Guid("4df05606-18be-43e3-a06e-3bf43d7d22f2"), new Guid("b76e56bd-f5d1-48c8-a0e8-c527bfc08b18"), null, 3, new DateTime(2023, 12, 17, 22, 0, 10, 815, DateTimeKind.Local).AddTicks(8309), "Description for Ticket 12", 2, 3, "Ticket 12" },
                    { new Guid("4ee39d6f-0c3d-438f-96fa-9351192eb827"), new Guid("6ad74ff3-fef3-4ff2-81d6-ed3316c6c075"), null, 2, new DateTime(2023, 9, 17, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(2497), "Description for Ticket 103", 0, 2, "Ticket 103" },
                    { new Guid("4f8b5f37-c92c-4ed2-9db4-0e6a32c9588c"), new Guid("504811be-4045-464f-ad2c-a2ba3e79fd44"), null, 0, new DateTime(2023, 6, 11, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(7139), "Description for Ticket 201", 2, 0, "Ticket 201" },
                    { new Guid("4ffe792d-0431-4a91-9f9f-740c572e9811"), new Guid("863e3618-bd38-4cea-9006-9be4efad9173"), null, 0, new DateTime(2023, 11, 18, 22, 0, 10, 815, DateTimeKind.Local).AddTicks(9549), "Description for Ticket 41", 1, 0, "Ticket 41" },
                    { new Guid("551056a6-adc7-44b6-aacb-d249c5adb583"), new Guid("527532c5-51dc-455f-b8d7-a05d5779dec8"), null, 3, new DateTime(2023, 4, 25, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(8933), "Description for Ticket 248", 1, 3, "Ticket 248" },
                    { new Guid("56ac5a5d-239f-489b-9f48-dfaca379378d"), new Guid("1a43d833-873a-4752-97db-61b0b1b59702"), null, 0, new DateTime(2023, 8, 6, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(4984), "Description for Ticket 145", 0, 0, "Ticket 145" },
                    { new Guid("5765eb91-f1fd-4981-92a8-670fd18fd553"), new Guid("1e3afbc0-fa9d-4852-b5ec-c56a37dc530b"), null, 3, new DateTime(2023, 4, 29, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(8795), "Description for Ticket 244", 0, 3, "Ticket 244" },
                    { new Guid("582a518a-93e5-4711-bd50-d03749f96f09"), new Guid("1c6e429e-2c3d-4c4f-8e70-af5dab94a8c3"), null, 0, new DateTime(2023, 9, 11, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(2707), "Description for Ticket 109", 0, 0, "Ticket 109" },
                    { new Guid("58c422a5-4e8f-435a-b435-741eb7dc55f6"), new Guid("b3810c09-3cd8-4833-b5bd-e72d57ffcd35"), null, 2, new DateTime(2023, 12, 6, 22, 0, 10, 815, DateTimeKind.Local).AddTicks(8691), "Description for Ticket 23", 1, 2, "Ticket 23" },
                    { new Guid("5b296cc3-5637-41ba-b9c1-789fa8d4b034"), new Guid("88f54748-8ba5-408d-ba33-22420eacb1d5"), null, 3, new DateTime(2023, 10, 10, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(1543), "Description for Ticket 80", 1, 3, "Ticket 80" },
                    { new Guid("5b5509dc-b1ff-4945-911d-8d1747017199"), new Guid("c5e803d2-a6eb-4a5c-b414-a84ca76ca285"), null, 3, new DateTime(2023, 6, 16, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(6972), "Description for Ticket 196", 0, 3, "Ticket 196" },
                    { new Guid("5d5ca17a-a901-4c0e-b2f6-2a3d4bb03871"), new Guid("c1a78ac3-1caa-4ae9-a58d-01483c4ae9c1"), null, 3, new DateTime(2023, 10, 2, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(1816), "Description for Ticket 88", 0, 3, "Ticket 88" },
                    { new Guid("5e3845b0-33ee-424b-9c73-67224e0912e5"), new Guid("8f0c178d-1e96-4570-9640-028bdb40f3de"), null, 1, new DateTime(2023, 10, 12, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(1478), "Description for Ticket 78", 2, 1, "Ticket 78" },
                    { new Guid("5f10d95e-0e18-4866-a2af-321ae2d18a7c"), new Guid("ef2fcdd4-dd6e-4904-ab84-2853ce95085b"), null, 1, new DateTime(2023, 11, 5, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(69), "Description for Ticket 54", 2, 1, "Ticket 54" },
                    { new Guid("5f6d06f1-7863-4ba7-919c-690af3ae5554"), new Guid("1e3afbc0-fa9d-4852-b5ec-c56a37dc530b"), null, 1, new DateTime(2023, 7, 8, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(6101), "Description for Ticket 174", 2, 1, "Ticket 174" },
                    { new Guid("5fc08181-9b52-4328-a1c4-48d06589f30c"), new Guid("2ab78932-4034-433f-8c5b-0cffa4663b50"), null, 0, new DateTime(2023, 10, 17, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(1298), "Description for Ticket 73", 0, 0, "Ticket 73" },
                    { new Guid("5fdc3bac-6a70-4f84-9bd7-bef1a66f4d55"), new Guid("2ab78932-4034-433f-8c5b-0cffa4663b50"), null, 2, new DateTime(2023, 12, 26, 22, 0, 10, 815, DateTimeKind.Local).AddTicks(7859), "Description for Ticket 3", 2, 2, "Ticket 3" },
                    { new Guid("5fe767e6-415e-452b-a44c-f17c22df84fe"), new Guid("70b540f4-5c60-450f-99d8-b72064e2346b"), null, 1, new DateTime(2023, 5, 29, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(7695), "Description for Ticket 214", 0, 1, "Ticket 214" },
                    { new Guid("6379285e-00ea-4a90-af64-134a2a3f5a8d"), new Guid("ea07d31e-03b4-49bb-9e92-cb19a3f3a3be"), null, 2, new DateTime(2023, 8, 28, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(3537), "Description for Ticket 123", 2, 2, "Ticket 123" },
                    { new Guid("66abb4c0-9e69-491b-b5c8-3de08d1b61dc"), new Guid("a7551ebf-4921-47f6-ab66-9e438f4d12c8"), null, 1, new DateTime(2023, 5, 5, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(8589), "Description for Ticket 238", 0, 1, "Ticket 238" },
                    { new Guid("67da9472-58e1-4730-a112-2425880ff265"), new Guid("24586359-b9f9-405f-a929-ddba301dbe98"), null, 1, new DateTime(2023, 10, 24, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(846), "Description for Ticket 66", 2, 1, "Ticket 66" },
                    { new Guid("67fa4ac3-7810-43ad-9679-9444578ebd89"), new Guid("8f0c178d-1e96-4570-9640-028bdb40f3de"), null, 3, new DateTime(2023, 12, 21, 22, 0, 10, 815, DateTimeKind.Local).AddTicks(8157), "Description for Ticket 8", 1, 3, "Ticket 8" },
                    { new Guid("689caab1-bd1a-4a71-ab82-905bdea18c18"), new Guid("6a330060-9807-4a5a-8859-1709b3051a72"), null, 3, new DateTime(2023, 10, 22, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(914), "Description for Ticket 68", 1, 3, "Ticket 68" },
                    { new Guid("69b2d0e0-578c-403f-851f-329c35d8a4a2"), new Guid("8233ad56-3ba6-49f1-8712-b2c17d381e89"), null, 2, new DateTime(2023, 6, 13, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(7072), "Description for Ticket 199", 0, 2, "Ticket 199" },
                    { new Guid("6ad0a2c8-c10e-40d7-95ff-d8ce7f1645f3"), new Guid("1a43d833-873a-4752-97db-61b0b1b59702"), null, 2, new DateTime(2023, 5, 28, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(7727), "Description for Ticket 215", 1, 2, "Ticket 215" },
                    { new Guid("6e5b1db0-ec30-4317-8a3b-de33e2a2b407"), new Guid("09941e69-ab5a-44b3-b2e0-0986f086d0dd"), null, 0, new DateTime(2023, 7, 29, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(5265), "Description for Ticket 153", 2, 0, "Ticket 153" },
                    { new Guid("6fdf814d-031b-4c78-8511-8b6ab18b50bb"), new Guid("da3640c5-5b26-4ba6-a7a6-2c4623f7ce8e"), null, 2, new DateTime(2023, 12, 10, 22, 0, 10, 815, DateTimeKind.Local).AddTicks(8557), "Description for Ticket 19", 0, 2, "Ticket 19" },
                    { new Guid("7016018a-6073-4afb-942b-d7b3a85d6d8b"), new Guid("fd25bbdc-f878-43d1-bfc2-410f511c4ae3"), null, 0, new DateTime(2023, 10, 21, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(946), "Description for Ticket 69", 2, 0, "Ticket 69" },
                    { new Guid("70401625-9202-40af-b843-dccfdb1941b7"), new Guid("2ab78932-4034-433f-8c5b-0cffa4663b50"), null, 0, new DateTime(2023, 5, 30, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(7661), "Description for Ticket 213", 2, 0, "Ticket 213" },
                    { new Guid("711bc991-7b09-4bee-9f76-a6bfc19cb061"), new Guid("6cf43432-8e05-412d-9f41-c89d714baf84"), null, 2, new DateTime(2023, 9, 1, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(3054), "Description for Ticket 119", 1, 2, "Ticket 119" },
                    { new Guid("7172bdfb-ff04-4c51-896d-0bc20f5d28c9"), new Guid("26f8d3ed-9e99-4fbb-b559-28d23f6a676a"), null, 1, new DateTime(2023, 12, 23, 22, 0, 10, 815, DateTimeKind.Local).AddTicks(7964), "Description for Ticket 6", 2, 1, "Ticket 6" },
                    { new Guid("725d3614-747e-44df-963b-7fe25fd354d9"), new Guid("ab41ad29-7967-4a1d-aaf5-b19aace3dc08"), null, 1, new DateTime(2023, 9, 30, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(1891), "Description for Ticket 90", 2, 1, "Ticket 90" },
                    { new Guid("7269a8f3-0391-4824-a3f8-34b5dc48a2fa"), new Guid("6e677047-adf9-4ce2-beb0-bd03fe9b08d3"), null, 2, new DateTime(2023, 5, 16, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(8148), "Description for Ticket 227", 1, 2, "Ticket 227" },
                    { new Guid("7290dd46-6869-4188-9642-fa52f096c4f1"), new Guid("f30f26a8-4c22-4fdc-ab37-dcbda25a2111"), null, 1, new DateTime(2023, 5, 1, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(8729), "Description for Ticket 242", 1, 1, "Ticket 242" },
                    { new Guid("7458d79c-cff7-4809-a152-9bf0b3bb51c5"), new Guid("b8573315-482a-4cc1-8c51-6ed5ed8766c7"), null, 3, new DateTime(2023, 5, 11, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(8378), "Description for Ticket 232", 0, 3, "Ticket 232" },
                    { new Guid("75058c42-5406-420b-a18e-7f41a04411f8"), new Guid("1e3afbc0-fa9d-4852-b5ec-c56a37dc530b"), null, 3, new DateTime(2023, 9, 16, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(2531), "Description for Ticket 104", 1, 3, "Ticket 104" },
                    { new Guid("75297974-15d6-444f-bb74-fcf04c6512fd"), new Guid("6e677047-adf9-4ce2-beb0-bd03fe9b08d3"), null, 2, new DateTime(2023, 10, 3, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(1783), "Description for Ticket 87", 2, 2, "Ticket 87" },
                    { new Guid("76695146-822c-4570-be7b-86d0585ad0e9"), new Guid("a7551ebf-4921-47f6-ab66-9e438f4d12c8"), null, 3, new DateTime(2023, 7, 14, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(5892), "Description for Ticket 168", 2, 3, "Ticket 168" },
                    { new Guid("77317039-16c4-4462-9b96-cab9c898ecb2"), new Guid("8f0c178d-1e96-4570-9640-028bdb40f3de"), null, 1, new DateTime(2023, 5, 25, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(7838), "Description for Ticket 218", 1, 1, "Ticket 218" },
                    { new Guid("77f1bf66-d7da-4975-a829-c86e2f4efd90"), new Guid("7b8c0315-23f8-4da4-b2ec-8e1b7c9ace01"), null, 3, new DateTime(2023, 8, 11, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(4812), "Description for Ticket 140", 1, 3, "Ticket 140" },
                    { new Guid("77f4483e-a0d9-47a4-86db-4bd3d8150a86"), new Guid("06f9353e-eeab-423c-9735-82b4454675a9"), null, 0, new DateTime(2023, 11, 30, 22, 0, 10, 815, DateTimeKind.Local).AddTicks(8899), "Description for Ticket 29", 1, 0, "Ticket 29" },
                    { new Guid("7a3fb880-3ed6-4ff3-b046-b9dddbf8bf29"), new Guid("06f9353e-eeab-423c-9735-82b4454675a9"), null, 2, new DateTime(2023, 5, 4, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(8621), "Description for Ticket 239", 1, 2, "Ticket 239" },
                    { new Guid("7b12b8fa-997b-465d-88d7-cbce4dbb92f3"), new Guid("ef2fcdd4-dd6e-4904-ab84-2853ce95085b"), null, 3, new DateTime(2023, 8, 27, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(3596), "Description for Ticket 124", 0, 3, "Ticket 124" },
                    { new Guid("7b6fc154-5bf6-4b31-a2d1-6b099e0c777b"), new Guid("da3640c5-5b26-4ba6-a7a6-2c4623f7ce8e"), null, 2, new DateTime(2023, 7, 23, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(5579), "Description for Ticket 159", 2, 2, "Ticket 159" },
                    { new Guid("7bbcae05-f38b-4c46-8a78-3b74d0fe49ed"), new Guid("59f9af00-7ca3-4f00-a0d0-3878fde14a8d"), null, 1, new DateTime(2023, 6, 22, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(6764), "Description for Ticket 190", 0, 1, "Ticket 190" },
                    { new Guid("7bc0b421-e003-4b62-81e5-64ac459ee642"), new Guid("36bb8619-bdca-4655-b9b8-083f6081ea20"), null, 3, new DateTime(2023, 11, 19, 22, 0, 10, 815, DateTimeKind.Local).AddTicks(9516), "Description for Ticket 40", 0, 3, "Ticket 40" },
                    { new Guid("7c334335-bc15-4ca8-94b7-f3924dbf89c8"), new Guid("4056026f-38fa-45af-a5dd-f3ded60b3106"), null, 2, new DateTime(2023, 10, 19, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(1012), "Description for Ticket 71", 1, 2, "Ticket 71" },
                    { new Guid("7e2da645-f79b-42cb-9ffd-e917f82e546d"), new Guid("8fca6db5-d842-4211-8c8b-fe521136b85c"), null, 2, new DateTime(2023, 11, 24, 22, 0, 10, 815, DateTimeKind.Local).AddTicks(9349), "Description for Ticket 35", 1, 2, "Ticket 35" },
                    { new Guid("7eb69017-abfc-4311-b81d-79db0708d6a1"), new Guid("c1a78ac3-1caa-4ae9-a58d-01483c4ae9c1"), null, 1, new DateTime(2023, 12, 11, 22, 0, 10, 815, DateTimeKind.Local).AddTicks(8523), "Description for Ticket 18", 2, 1, "Ticket 18" },
                    { new Guid("800cc738-a107-486b-9d28-5ab53d1ed915"), new Guid("d0e32629-2158-48ea-a52c-740d81017428"), null, 1, new DateTime(2023, 11, 17, 22, 0, 10, 815, DateTimeKind.Local).AddTicks(9592), "Description for Ticket 42", 2, 1, "Ticket 42" },
                    { new Guid("8054f66d-83f1-4a30-85a3-562f567ace40"), new Guid("347a6236-2321-4acb-93cd-4698dc9d3621"), null, 2, new DateTime(2023, 12, 18, 22, 0, 10, 815, DateTimeKind.Local).AddTicks(8276), "Description for Ticket 11", 1, 2, "Ticket 11" },
                    { new Guid("8175f047-f098-40d0-b9aa-ebccd68cfbbd"), new Guid("b3810c09-3cd8-4833-b5bd-e72d57ffcd35"), null, 2, new DateTime(2023, 7, 19, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(5726), "Description for Ticket 163", 0, 2, "Ticket 163" },
                    { new Guid("8268d706-3b97-43f8-8dc9-42176f354a78"), new Guid("768cf51a-8646-4065-b6c1-03b9b3cfad3e"), null, 2, new DateTime(2023, 5, 12, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(8345), "Description for Ticket 231", 2, 2, "Ticket 231" },
                    { new Guid("83387c08-0e70-4f7b-8a2a-3770e5745fb3"), new Guid("6cf43432-8e05-412d-9f41-c89d714baf84"), null, 0, new DateTime(2023, 6, 23, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(6731), "Description for Ticket 189", 2, 0, "Ticket 189" },
                    { new Guid("8436de63-864e-4a99-9307-cacd55afb4fb"), new Guid("06f9353e-eeab-423c-9735-82b4454675a9"), null, 2, new DateTime(2023, 9, 21, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(2362), "Description for Ticket 99", 2, 2, "Ticket 99" },
                    { new Guid("8797784b-a98d-4313-bdf3-43b453761309"), new Guid("c1a78ac3-1caa-4ae9-a58d-01483c4ae9c1"), null, 3, new DateTime(2023, 5, 15, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(8245), "Description for Ticket 228", 2, 3, "Ticket 228" },
                    { new Guid("88153926-9e85-4b98-8bb5-0c7500090aa0"), new Guid("4056026f-38fa-45af-a5dd-f3ded60b3106"), null, 0, new DateTime(2023, 8, 10, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(4847), "Description for Ticket 141", 2, 0, "Ticket 141" },
                    { new Guid("88d7f251-d07c-4ad0-abda-b969f883da84"), new Guid("752a1277-9a47-447f-a92e-519a8486c357"), null, 3, new DateTime(2023, 9, 20, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(2397), "Description for Ticket 100", 0, 3, "Ticket 100" },
                    { new Guid("8b205df0-6c28-4a2b-9482-1b4ac418735e"), new Guid("347a6236-2321-4acb-93cd-4698dc9d3621"), null, 0, new DateTime(2023, 10, 9, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(1576), "Description for Ticket 81", 2, 0, "Ticket 81" },
                    { new Guid("8eb772ac-d712-4cdf-8501-fbd4ba5dfe0c"), new Guid("863e3618-bd38-4cea-9006-9be4efad9173"), null, 2, new DateTime(2023, 9, 9, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(2774), "Description for Ticket 111", 2, 2, "Ticket 111" },
                    { new Guid("8f907541-d968-42be-bc29-a56a7f2e31ac"), new Guid("38b82a53-e9f1-407f-b817-928ef4c91167"), null, 3, new DateTime(2023, 7, 6, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(6167), "Description for Ticket 176", 1, 3, "Ticket 176" },
                    { new Guid("90bcb132-28dc-4991-92a8-c8349857b51b"), new Guid("6ad74ff3-fef3-4ff2-81d6-ed3316c6c075"), null, 0, new DateTime(2023, 11, 26, 22, 0, 10, 815, DateTimeKind.Local).AddTicks(9260), "Description for Ticket 33", 2, 0, "Ticket 33" },
                    { new Guid("910508d8-5424-4896-9bd7-37065c7ac21e"), new Guid("d0e32629-2158-48ea-a52c-740d81017428"), null, 3, new DateTime(2023, 9, 8, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(2808), "Description for Ticket 112", 0, 3, "Ticket 112" },
                    { new Guid("92dd881c-aa9a-434f-b6c9-1a380aa7b345"), new Guid("4056026f-38fa-45af-a5dd-f3ded60b3106"), null, 2, new DateTime(2023, 6, 1, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(7595), "Description for Ticket 211", 0, 2, "Ticket 211" },
                    { new Guid("92ef4282-ef71-4359-b320-2e57f54caa9f"), new Guid("752a1277-9a47-447f-a92e-519a8486c357"), null, 3, new DateTime(2023, 5, 3, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(8654), "Description for Ticket 240", 2, 3, "Ticket 240" },
                    { new Guid("939412ad-5785-4d11-b9f3-114587238434"), new Guid("38b82a53-e9f1-407f-b817-928ef4c91167"), null, 1, new DateTime(2023, 9, 14, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(2607), "Description for Ticket 106", 0, 1, "Ticket 106" },
                    { new Guid("94990b08-8db5-4fa0-a2ea-67f71282295b"), new Guid("06f9353e-eeab-423c-9735-82b4454675a9"), null, 0, new DateTime(2023, 7, 13, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(5925), "Description for Ticket 169", 0, 0, "Ticket 169" },
                    { new Guid("9550ca29-e2af-4877-9ed1-a79b42af6edf"), new Guid("26f8d3ed-9e99-4fbb-b559-28d23f6a676a"), null, 3, new DateTime(2023, 10, 14, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(1412), "Description for Ticket 76", 0, 3, "Ticket 76" },
                    { new Guid("96c9e32c-5971-4b7a-b13b-95d02b059ca8"), new Guid("ec1a445c-c029-41d1-b77f-295797af607a"), null, 1, new DateTime(2023, 8, 29, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(3481), "Description for Ticket 122", 1, 1, "Ticket 122" },
                    { new Guid("97324bc3-667d-44dc-a43b-20e5ee7215e1"), new Guid("527532c5-51dc-455f-b8d7-a05d5779dec8"), null, 1, new DateTime(2023, 11, 21, 22, 0, 10, 815, DateTimeKind.Local).AddTicks(9449), "Description for Ticket 38", 1, 1, "Ticket 38" },
                    { new Guid("973bffba-5aa1-43d5-ae51-957f256cc124"), new Guid("f473fc6e-f8ab-4a58-8e84-c66d3a3ce20d"), null, 2, new DateTime(2023, 12, 22, 22, 0, 10, 815, DateTimeKind.Local).AddTicks(7997), "Description for Ticket 7", 0, 2, "Ticket 7" },
                    { new Guid("98595c34-09b5-414a-8d4d-cb7e99d3287b"), new Guid("527532c5-51dc-455f-b8d7-a05d5779dec8"), null, 3, new DateTime(2023, 9, 12, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(2674), "Description for Ticket 108", 2, 3, "Ticket 108" },
                    { new Guid("987ccee5-0a7d-4a20-aaff-951b199bc47f"), new Guid("4d2d10a9-dfcf-4f07-81f1-d2718a879728"), null, 0, new DateTime(2023, 5, 2, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(8687), "Description for Ticket 241", 0, 0, "Ticket 241" },
                    { new Guid("98ee36e5-eaca-4395-af6e-086b762b7513"), new Guid("6ad74ff3-fef3-4ff2-81d6-ed3316c6c075"), null, 0, new DateTime(2023, 7, 9, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(6068), "Description for Ticket 173", 1, 0, "Ticket 173" },
                    { new Guid("9bba74f4-ca10-44e9-855e-d22f9be9d1ef"), new Guid("88f54748-8ba5-408d-ba33-22420eacb1d5"), null, 1, new DateTime(2023, 12, 19, 22, 0, 10, 815, DateTimeKind.Local).AddTicks(8242), "Description for Ticket 10", 0, 1, "Ticket 10" },
                    { new Guid("9c3a6eef-afac-4b45-b59a-627d2d54eb1c"), new Guid("ea07d31e-03b4-49bb-9e92-cb19a3f3a3be"), null, 0, new DateTime(2023, 11, 6, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(36), "Description for Ticket 53", 1, 0, "Ticket 53" },
                    { new Guid("9e39da96-3040-46bd-a183-aa03f77dad39"), new Guid("13a26cda-8be8-4206-8f65-887e483f5a1d"), null, 1, new DateTime(2023, 6, 10, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(7182), "Description for Ticket 202", 0, 1, "Ticket 202" },
                    { new Guid("9e56d741-ac8c-49ce-9cd6-4003f7493469"), new Guid("bd728943-50b9-4410-a64c-91a91cf93035"), null, 1, new DateTime(2023, 7, 16, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(5826), "Description for Ticket 166", 0, 1, "Ticket 166" },
                    { new Guid("9ee1a6cc-bcaf-45d8-ba0d-dcac0f7d7695"), new Guid("c4e77f53-0dba-4b4d-b189-73d37346da46"), null, 2, new DateTime(2023, 6, 17, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(6940), "Description for Ticket 195", 2, 2, "Ticket 195" },
                    { new Guid("a090a51a-c197-4e68-a533-c368816d5093"), new Guid("88f54748-8ba5-408d-ba33-22420eacb1d5"), null, 3, new DateTime(2023, 5, 23, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(7907), "Description for Ticket 220", 0, 3, "Ticket 220" },
                    { new Guid("a26441aa-e8a0-4db6-ac97-60a43c82199c"), new Guid("768cf51a-8646-4065-b6c1-03b9b3cfad3e"), null, 0, new DateTime(2023, 12, 8, 22, 0, 10, 815, DateTimeKind.Local).AddTicks(8624), "Description for Ticket 21", 2, 0, "Ticket 21" },
                    { new Guid("a3c4a484-06b4-4116-95e3-9a1638fa933a"), new Guid("e578bb48-45b7-4485-bf3e-66d32b6669f9"), null, 2, new DateTime(2023, 8, 16, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(4255), "Description for Ticket 135", 2, 2, "Ticket 135" },
                    { new Guid("a55dc37a-e4d7-4109-95b7-31fea871ee7c"), new Guid("ea07d31e-03b4-49bb-9e92-cb19a3f3a3be"), null, 0, new DateTime(2023, 6, 19, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(6863), "Description for Ticket 193", 0, 0, "Ticket 193" },
                    { new Guid("a579569b-845f-4ea2-ae98-862ef22755b0"), new Guid("1c73cb2f-1f73-4ce1-bd49-87f0af207073"), null, 0, new DateTime(2023, 9, 3, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(2983), "Description for Ticket 117", 2, 0, "Ticket 117" },
                    { new Guid("a64e3867-9af8-4a8b-8ccb-1d53483916d7"), new Guid("c4e77f53-0dba-4b4d-b189-73d37346da46"), null, 0, new DateTime(2023, 8, 26, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(3654), "Description for Ticket 125", 1, 0, "Ticket 125" },
                    { new Guid("a6bee6ba-52c0-4275-98cd-d46b3e0e9edf"), new Guid("b3810c09-3cd8-4833-b5bd-e72d57ffcd35"), null, 0, new DateTime(2023, 5, 10, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(8410), "Description for Ticket 233", 1, 0, "Ticket 233" },
                    { new Guid("a7eaf67a-b60a-4321-85c1-0a17fc705630"), new Guid("0faa3b09-22f7-4bcb-879d-318dd5feaa90"), null, 2, new DateTime(2023, 5, 24, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(7874), "Description for Ticket 219", 2, 2, "Ticket 219" },
                    { new Guid("a805f567-d215-4eb3-bbce-ddee1bf4078d"), new Guid("bf05c8dd-4904-46f8-ad43-f957f4764985"), null, 1, new DateTime(2023, 8, 9, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(4881), "Description for Ticket 142", 0, 1, "Ticket 142" },
                    { new Guid("a8379e54-2ca9-4c37-b8ff-702694105e16"), new Guid("efcbdc10-a276-40e4-8545-a0fd03bd142a"), null, 2, new DateTime(2023, 9, 13, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(2640), "Description for Ticket 107", 1, 2, "Ticket 107" },
                    { new Guid("a8f8821c-7d27-448e-b5dd-cb930012ca4d"), new Guid("4d2d10a9-dfcf-4f07-81f1-d2718a879728"), null, 0, new DateTime(2023, 9, 19, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(2430), "Description for Ticket 101", 1, 0, "Ticket 101" },
                    { new Guid("a93298cb-562f-46a3-bf03-6da259e89ba0"), new Guid("a861a8c3-7bc6-48c0-9322-a6eea7e02619"), null, 3, new DateTime(2023, 6, 28, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(6554), "Description for Ticket 184", 0, 3, "Ticket 184" },
                    { new Guid("ab0283a2-6cf8-4415-9fbf-2a972a434450"), new Guid("1c73cb2f-1f73-4ce1-bd49-87f0af207073"), null, 2, new DateTime(2023, 6, 25, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(6663), "Description for Ticket 187", 0, 2, "Ticket 187" },
                    { new Guid("ab451a0a-f94b-4060-ace4-a0315c8cf7d4"), new Guid("c5e803d2-a6eb-4a5c-b414-a84ca76ca285"), null, 3, new DateTime(2023, 11, 3, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(136), "Description for Ticket 56", 1, 3, "Ticket 56" },
                    { new Guid("ac2bc8ee-cc28-4a31-84b0-0364ae658eed"), new Guid("fd25bbdc-f878-43d1-bfc2-410f511c4ae3"), null, 2, new DateTime(2023, 8, 12, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(4775), "Description for Ticket 139", 0, 2, "Ticket 139" },
                    { new Guid("acae08eb-54cd-4fb1-8059-9e8d0f8470db"), new Guid("da3640c5-5b26-4ba6-a7a6-2c4623f7ce8e"), null, 0, new DateTime(2023, 5, 14, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(8279), "Description for Ticket 229", 0, 0, "Ticket 229" },
                    { new Guid("af62b9ba-2429-412b-860e-d599b70821fc"), new Guid("bfd22c7c-d7ec-4d06-be63-495a3c25241b"), null, 1, new DateTime(2023, 9, 26, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(2024), "Description for Ticket 94", 0, 1, "Ticket 94" },
                    { new Guid("b0fae514-abca-4156-b3db-c34c66aa5115"), new Guid("4d2d10a9-dfcf-4f07-81f1-d2718a879728"), null, 2, new DateTime(2023, 11, 28, 22, 0, 10, 815, DateTimeKind.Local).AddTicks(9192), "Description for Ticket 31", 0, 2, "Ticket 31" },
                    { new Guid("b194ece6-aa94-4ee1-802a-460e8eac34bc"), new Guid("9280b565-a852-44c4-8aaa-f53cb2a98401"), null, 1, new DateTime(2023, 11, 1, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(211), "Description for Ticket 58", 0, 1, "Ticket 58" },
                    { new Guid("b5b137ae-d999-42c1-aa75-2aae353fbdb5"), new Guid("e578bb48-45b7-4485-bf3e-66d32b6669f9"), null, 0, new DateTime(2023, 6, 7, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(7384), "Description for Ticket 205", 0, 0, "Ticket 205" },
                    { new Guid("b5f8a019-c78f-4c20-b7e1-2c1679777fc3"), new Guid("d8954ace-9ab5-4737-95f2-c3b12b576633"), null, 3, new DateTime(2023, 6, 12, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(7106), "Description for Ticket 200", 1, 3, "Ticket 200" },
                    { new Guid("b7bb8674-f9d7-40a4-b733-58fa22648365"), new Guid("f30f26a8-4c22-4fdc-ab37-dcbda25a2111"), null, 3, new DateTime(2023, 11, 27, 22, 0, 10, 815, DateTimeKind.Local).AddTicks(9226), "Description for Ticket 32", 1, 3, "Ticket 32" },
                    { new Guid("b9195027-0ec7-4af8-88cd-083e5d19b20c"), new Guid("a861a8c3-7bc6-48c0-9322-a6eea7e02619"), null, 1, new DateTime(2023, 9, 6, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(2882), "Description for Ticket 114", 2, 1, "Ticket 114" },
                    { new Guid("bb247636-37e8-453b-b787-2aaaf08cba95"), new Guid("1c6e429e-2c3d-4c4f-8e70-af5dab94a8c3"), null, 2, new DateTime(2023, 11, 20, 22, 0, 10, 815, DateTimeKind.Local).AddTicks(9484), "Description for Ticket 39", 2, 2, "Ticket 39" },
                    { new Guid("bb67b134-9543-4d33-8261-b45ce3cc41bc"), new Guid("d8954ace-9ab5-4737-95f2-c3b12b576633"), null, 3, new DateTime(2023, 10, 30, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(633), "Description for Ticket 60", 2, 3, "Ticket 60" },
                    { new Guid("bdfa11ce-d367-4bb4-920f-6abeffa04daf"), new Guid("a7551ebf-4921-47f6-ab66-9e438f4d12c8"), null, 1, new DateTime(2023, 9, 22, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(2328), "Description for Ticket 98", 1, 1, "Ticket 98" },
                    { new Guid("be916195-af0c-4429-9049-e4f144ba6812"), new Guid("13a26cda-8be8-4206-8f65-887e483f5a1d"), null, 3, new DateTime(2023, 8, 19, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(4090), "Description for Ticket 132", 2, 3, "Ticket 132" },
                    { new Guid("bf918249-7351-404b-a3e7-0713f833a9c1"), new Guid("1a43d833-873a-4752-97db-61b0b1b59702"), null, 0, new DateTime(2023, 12, 24, 22, 0, 10, 815, DateTimeKind.Local).AddTicks(7926), "Description for Ticket 5", 1, 0, "Ticket 5" },
                    { new Guid("c0eb7830-8149-4478-a003-125118ca1fb2"), new Guid("6a330060-9807-4a5a-8859-1709b3051a72"), null, 1, new DateTime(2023, 8, 13, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(4546), "Description for Ticket 138", 2, 1, "Ticket 138" },
                    { new Guid("c1eeffc3-9c40-4b3f-b90b-62a2af7d2efe"), new Guid("5464e1a2-8b5f-46e8-8b63-505ff1fbb232"), null, 2, new DateTime(2023, 5, 8, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(8487), "Description for Ticket 235", 0, 2, "Ticket 235" },
                    { new Guid("c29fd748-7bb7-4ac7-b11f-46323aa6deb9"), new Guid("55750880-e659-427e-a261-4f8a90a9f7b9"), null, 2, new DateTime(2023, 11, 16, 22, 0, 10, 815, DateTimeKind.Local).AddTicks(9624), "Description for Ticket 43", 0, 2, "Ticket 43" },
                    { new Guid("c3550f18-cae3-4c1e-a6d1-a90ca626eccb"), new Guid("fd716492-389a-4c5f-8930-b15db879b9e5"), null, 0, new DateTime(2023, 11, 14, 22, 0, 10, 815, DateTimeKind.Local).AddTicks(9689), "Description for Ticket 45", 2, 0, "Ticket 45" },
                    { new Guid("c36a59cd-741c-4e6f-b6ea-6f050c7f8108"), new Guid("38b82a53-e9f1-407f-b817-928ef4c91167"), null, 3, new DateTime(2023, 11, 23, 22, 0, 10, 815, DateTimeKind.Local).AddTicks(9382), "Description for Ticket 36", 2, 3, "Ticket 36" },
                    { new Guid("c4377922-ce2d-44e3-bf49-8d16d4316e92"), new Guid("f30f26a8-4c22-4fdc-ab37-dcbda25a2111"), null, 1, new DateTime(2023, 9, 18, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(2463), "Description for Ticket 102", 2, 1, "Ticket 102" },
                    { new Guid("c4574873-e7eb-4a7d-a9b5-18738bc3e78d"), new Guid("b3810c09-3cd8-4833-b5bd-e72d57ffcd35"), null, 0, new DateTime(2023, 9, 27, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(1989), "Description for Ticket 93", 2, 0, "Ticket 93" },
                    { new Guid("c53a19ca-fa12-4c2f-abb2-778045e9dec0"), new Guid("5b70692e-b4ee-4d05-8e73-060750b092d8"), null, 2, new DateTime(2023, 10, 27, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(732), "Description for Ticket 63", 2, 2, "Ticket 63" },
                    { new Guid("c5f32842-4e51-45e6-9d83-7f073fdb65a8"), new Guid("4ba6808e-661a-4c03-9c0c-12ae20524e19"), null, 1, new DateTime(2023, 5, 17, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(8114), "Description for Ticket 226", 0, 1, "Ticket 226" },
                    { new Guid("c613fe8d-3684-475b-abbd-401bc53fcb31"), new Guid("5b70692e-b4ee-4d05-8e73-060750b092d8"), null, 2, new DateTime(2023, 6, 9, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(7216), "Description for Ticket 203", 1, 2, "Ticket 203" },
                    { new Guid("c856b56b-f3d8-4b9e-8583-b6c4151b8342"), new Guid("a7551ebf-4921-47f6-ab66-9e438f4d12c8"), null, 3, new DateTime(2023, 12, 1, 22, 0, 10, 815, DateTimeKind.Local).AddTicks(8866), "Description for Ticket 28", 0, 3, "Ticket 28" },
                    { new Guid("cb656be5-1195-493a-b638-f16781ee964d"), new Guid("9280b565-a852-44c4-8aaa-f53cb2a98401"), null, 3, new DateTime(2023, 8, 23, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(3826), "Description for Ticket 128", 1, 3, "Ticket 128" },
                    { new Guid("cbddaabb-fedd-4bfe-af1e-35aa641b57d6"), new Guid("da3640c5-5b26-4ba6-a7a6-2c4623f7ce8e"), null, 0, new DateTime(2023, 10, 1, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(1849), "Description for Ticket 89", 1, 0, "Ticket 89" },
                    { new Guid("cd37d60b-2e42-40bc-83d0-280bc9947756"), new Guid("b8573315-482a-4cc1-8c51-6ed5ed8766c7"), null, 1, new DateTime(2023, 7, 20, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(5693), "Description for Ticket 162", 2, 1, "Ticket 162" },
                    { new Guid("cd627c83-486b-4333-a661-e733a87c1be2"), new Guid("d8954ace-9ab5-4737-95f2-c3b12b576633"), null, 1, new DateTime(2023, 8, 21, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(3977), "Description for Ticket 130", 0, 1, "Ticket 130" },
                    { new Guid("cd7f43d6-d6a7-4142-8784-3c680235df96"), new Guid("51cb2992-1e93-4621-b8b6-97eedc8c6b88"), null, 2, new DateTime(2023, 11, 8, 22, 0, 10, 815, DateTimeKind.Local).AddTicks(9898), "Description for Ticket 51", 2, 2, "Ticket 51" },
                    { new Guid("cdca1628-a124-44de-a57b-682a2719580d"), new Guid("754c7786-8e68-46fb-ae0c-4e192d7d6388"), null, 2, new DateTime(2023, 12, 2, 22, 0, 10, 815, DateTimeKind.Local).AddTicks(8832), "Description for Ticket 27", 2, 2, "Ticket 27" },
                    { new Guid("d27b089a-71b9-428b-837b-59670a96a2d0"), new Guid("fd25bbdc-f878-43d1-bfc2-410f511c4ae3"), null, 0, new DateTime(2023, 6, 3, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(7519), "Description for Ticket 209", 1, 0, "Ticket 209" },
                    { new Guid("d314198f-f1ae-499c-9362-22de37a7a4b9"), new Guid("70b540f4-5c60-450f-99d8-b72064e2346b"), null, 3, new DateTime(2023, 8, 7, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(4950), "Description for Ticket 144", 2, 3, "Ticket 144" },
                    { new Guid("d367b6c2-a4fa-471a-b779-7baa145a18d6"), new Guid("8233ad56-3ba6-49f1-8712-b2c17d381e89"), null, 0, new DateTime(2023, 8, 22, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(3890), "Description for Ticket 129", 2, 0, "Ticket 129" },
                    { new Guid("d3acf02d-7aba-4170-958a-7bd2502d8498"), new Guid("6a920b94-45d1-4690-999b-a0edcf1f5c66"), null, 0, new DateTime(2023, 8, 14, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(4497), "Description for Ticket 137", 1, 0, "Ticket 137" },
                    { new Guid("d40f4507-a2d2-436d-84cb-ba39a3780488"), new Guid("c83716ab-0e02-42c2-a930-c3a47e0f7231"), null, 1, new DateTime(2023, 8, 17, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(4205), "Description for Ticket 134", 1, 1, "Ticket 134" },
                    { new Guid("d444d307-098e-483a-ab75-b9919f69f35a"), new Guid("8233ad56-3ba6-49f1-8712-b2c17d381e89"), null, 2, new DateTime(2023, 10, 31, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(593), "Description for Ticket 59", 1, 2, "Ticket 59" },
                    { new Guid("d474a362-92af-406c-a366-c23465338d80"), new Guid("09941e69-ab5a-44b3-b2e0-0986f086d0dd"), null, 2, new DateTime(2023, 10, 7, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(1652), "Description for Ticket 83", 1, 2, "Ticket 83" },
                    { new Guid("d48f3f59-1ff1-468b-aed5-0967f1e99baf"), new Guid("6a920b94-45d1-4690-999b-a0edcf1f5c66"), null, 2, new DateTime(2023, 6, 5, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(7452), "Description for Ticket 207", 2, 2, "Ticket 207" },
                    { new Guid("d4e31a57-f40e-4493-8ed8-c9e6ce819d10"), new Guid("f473fc6e-f8ab-4a58-8e84-c66d3a3ce20d"), null, 0, new DateTime(2023, 10, 13, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(1445), "Description for Ticket 77", 1, 0, "Ticket 77" },
                    { new Guid("d6409a15-5a30-4252-9867-3100d5c06c9f"), new Guid("c5e803d2-a6eb-4a5c-b414-a84ca76ca285"), null, 1, new DateTime(2023, 8, 25, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(3712), "Description for Ticket 126", 2, 1, "Ticket 126" },
                    { new Guid("d647c1bb-bf92-4ade-8ff1-4edf52e2132c"), new Guid("1c6e429e-2c3d-4c4f-8e70-af5dab94a8c3"), null, 0, new DateTime(2023, 4, 24, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(8966), "Description for Ticket 249", 2, 0, "Ticket 249" },
                    { new Guid("d7c9a786-0ff0-4799-a302-a481ff32b8da"), new Guid("bfd22c7c-d7ec-4d06-be63-495a3c25241b"), null, 1, new DateTime(2023, 5, 9, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(8453), "Description for Ticket 234", 2, 1, "Ticket 234" },
                    { new Guid("d7ebcbb2-798e-496d-9758-6149a2476380"), new Guid("4ba6808e-661a-4c03-9c0c-12ae20524e19"), null, 3, new DateTime(2023, 7, 26, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(5374), "Description for Ticket 156", 2, 3, "Ticket 156" },
                    { new Guid("d99ad138-f44e-4300-b91a-d921ae08ddca"), new Guid("7b8c0315-23f8-4da4-b2ec-8e1b7c9ace01"), null, 1, new DateTime(2023, 6, 2, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(7562), "Description for Ticket 210", 2, 1, "Ticket 210" },
                    { new Guid("da8dd2fe-aa4a-48b6-8a64-b9c67efd1371"), new Guid("754c7786-8e68-46fb-ae0c-4e192d7d6388"), null, 2, new DateTime(2023, 7, 15, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(5859), "Description for Ticket 167", 1, 2, "Ticket 167" },
                    { new Guid("dc95b19d-baad-4f08-9b54-f7256c3ce53b"), new Guid("51cb2992-1e93-4621-b8b6-97eedc8c6b88"), null, 0, new DateTime(2023, 8, 30, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(3401), "Description for Ticket 121", 0, 0, "Ticket 121" },
                    { new Guid("dcb522c8-4d1a-4df4-a9a5-a0f9c92c7d39"), new Guid("24586359-b9f9-405f-a929-ddba301dbe98"), null, 1, new DateTime(2023, 6, 6, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(7419), "Description for Ticket 206", 1, 1, "Ticket 206" },
                    { new Guid("deb04eba-414a-4adc-92a2-32de5e29d310"), new Guid("6a330060-9807-4a5a-8859-1709b3051a72"), null, 3, new DateTime(2023, 6, 4, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(7484), "Description for Ticket 208", 0, 3, "Ticket 208" },
                    { new Guid("df3aff80-6cf4-4ce8-9310-3a4317b57a6a"), new Guid("bf05c8dd-4904-46f8-ad43-f957f4764985"), null, 3, new DateTime(2023, 10, 18, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(1046), "Description for Ticket 72", 2, 3, "Ticket 72" },
                    { new Guid("e37dcec4-4d08-459a-a625-f3f840bc9e12"), new Guid("8fca6db5-d842-4211-8c8b-fe521136b85c"), null, 2, new DateTime(2023, 7, 7, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(6134), "Description for Ticket 175", 0, 2, "Ticket 175" },
                    { new Guid("e3e21ace-afc0-4ec6-bef2-774dea6704b2"), new Guid("4056026f-38fa-45af-a5dd-f3ded60b3106"), null, 0, new DateTime(2023, 12, 28, 22, 0, 10, 815, DateTimeKind.Local).AddTicks(7720), "Description for Ticket 1", 0, 0, "Ticket 1" },
                    { new Guid("e4233a0b-3c62-4dfb-b17e-b3f5a8e79590"), new Guid("91ea44e8-7071-4fad-a997-cef68f8f509e"), null, 2, new DateTime(2023, 8, 24, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(3767), "Description for Ticket 127", 0, 2, "Ticket 127" },
                    { new Guid("e4bd9421-646e-41ea-b273-98dd1c8d16b8"), new Guid("4d2d10a9-dfcf-4f07-81f1-d2718a879728"), null, 2, new DateTime(2023, 7, 11, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(6001), "Description for Ticket 171", 2, 2, "Ticket 171" },
                    { new Guid("e52d6e95-c68b-4c5a-8fe0-9af05ddfda90"), new Guid("59f9af00-7ca3-4f00-a0d0-3878fde14a8d"), null, 1, new DateTime(2023, 11, 9, 22, 0, 10, 815, DateTimeKind.Local).AddTicks(9864), "Description for Ticket 50", 1, 1, "Ticket 50" },
                    { new Guid("e7ae0153-3e16-4ff4-bf41-5d12eb5c4f75"), new Guid("aeb23e03-9e60-4957-8a46-5928af6ebcab"), null, 0, new DateTime(2023, 5, 18, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(8072), "Description for Ticket 225", 2, 0, "Ticket 225" },
                    { new Guid("e804067c-014c-49d5-b0f2-492f5178e235"), new Guid("09941e69-ab5a-44b3-b2e0-0986f086d0dd"), null, 2, new DateTime(2023, 5, 20, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(8006), "Description for Ticket 223", 0, 2, "Ticket 223" },
                    { new Guid("e8514c3a-d7ab-4eba-8adc-167472ccce42"), new Guid("852407ca-0e97-4ecc-99cf-dc2b78316d6e"), null, 3, new DateTime(2023, 11, 11, 22, 0, 10, 815, DateTimeKind.Local).AddTicks(9788), "Description for Ticket 48", 2, 3, "Ticket 48" },
                    { new Guid("e87ef97f-778d-41c5-91bf-2e98aeda785e"), new Guid("863e3618-bd38-4cea-9006-9be4efad9173"), null, 0, new DateTime(2023, 7, 1, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(6347), "Description for Ticket 181", 0, 0, "Ticket 181" },
                    { new Guid("eaf5e29f-ee14-4b67-8ef1-34a2b6421cdb"), new Guid("bd728943-50b9-4410-a64c-91a91cf93035"), null, 3, new DateTime(2023, 5, 7, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(8521), "Description for Ticket 236", 1, 3, "Ticket 236" },
                    { new Guid("eb300fa2-196b-4d3f-a7c4-55166f1b96bd"), new Guid("ab41ad29-7967-4a1d-aaf5-b19aace3dc08"), null, 3, new DateTime(2023, 7, 22, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(5616), "Description for Ticket 160", 0, 3, "Ticket 160" },
                    { new Guid("ee177115-815d-4762-93b5-4c8f4c5fcb84"), new Guid("527532c5-51dc-455f-b8d7-a05d5779dec8"), null, 1, new DateTime(2023, 7, 4, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(6244), "Description for Ticket 178", 0, 1, "Ticket 178" },
                    { new Guid("ef002305-0ce2-411c-b04a-884c8fd8d1f0"), new Guid("c1a78ac3-1caa-4ae9-a58d-01483c4ae9c1"), null, 1, new DateTime(2023, 7, 24, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(5439), "Description for Ticket 158", 1, 1, "Ticket 158" },
                    { new Guid("ef5942ab-5a60-41bc-b6f6-b77385cc05e6"), new Guid("5b70692e-b4ee-4d05-8e73-060750b092d8"), null, 0, new DateTime(2023, 8, 18, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(4149), "Description for Ticket 133", 0, 0, "Ticket 133" },
                    { new Guid("f061f289-0af6-44ca-84a2-5047810b85f4"), new Guid("754c7786-8e68-46fb-ae0c-4e192d7d6388"), null, 0, new DateTime(2023, 9, 23, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(2285), "Description for Ticket 97", 0, 0, "Ticket 97" },
                    { new Guid("f15d1284-1c56-4786-9695-e1cf3cd0c518"), new Guid("768cf51a-8646-4065-b6c1-03b9b3cfad3e"), null, 2, new DateTime(2023, 9, 29, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(1924), "Description for Ticket 91", 0, 2, "Ticket 91" },
                    { new Guid("f16fc30c-b95d-483f-906d-1742a04a7e60"), new Guid("768cf51a-8646-4065-b6c1-03b9b3cfad3e"), null, 0, new DateTime(2023, 7, 21, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(5650), "Description for Ticket 161", 1, 0, "Ticket 161" },
                    { new Guid("f261c5e1-5c6e-45a0-84de-f8a524aa720e"), new Guid("b8573315-482a-4cc1-8c51-6ed5ed8766c7"), null, 3, new DateTime(2023, 9, 28, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(1956), "Description for Ticket 92", 1, 3, "Ticket 92" },
                    { new Guid("f557e717-be91-4a5f-aa92-0ede5ce699f0"), new Guid("f473fc6e-f8ab-4a58-8e84-c66d3a3ce20d"), null, 2, new DateTime(2023, 8, 4, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(5063), "Description for Ticket 147", 2, 2, "Ticket 147" },
                    { new Guid("f5ea78ea-2402-4e86-866a-fdf036c899aa"), new Guid("652b8b51-8e71-48ae-a308-927936dd50a8"), null, 1, new DateTime(2023, 11, 13, 22, 0, 10, 815, DateTimeKind.Local).AddTicks(9723), "Description for Ticket 46", 0, 1, "Ticket 46" },
                    { new Guid("f64d0520-ce38-4cf1-9c39-d80d11b0f649"), new Guid("8f0c178d-1e96-4570-9640-028bdb40f3de"), null, 3, new DateTime(2023, 8, 3, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(5097), "Description for Ticket 148", 0, 3, "Ticket 148" },
                    { new Guid("f6b45988-e83c-4aac-910b-091ec0a5ecd2"), new Guid("652b8b51-8e71-48ae-a308-927936dd50a8"), null, 3, new DateTime(2023, 9, 4, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(2949), "Description for Ticket 116", 1, 3, "Ticket 116" },
                    { new Guid("f6f85c82-c92d-4cbc-baa3-192f11fd7421"), new Guid("b8573315-482a-4cc1-8c51-6ed5ed8766c7"), null, 1, new DateTime(2023, 12, 7, 22, 0, 10, 815, DateTimeKind.Local).AddTicks(8657), "Description for Ticket 22", 0, 1, "Ticket 22" },
                    { new Guid("f7461cc1-8965-45a1-b956-f2e81d552b96"), new Guid("09941e69-ab5a-44b3-b2e0-0986f086d0dd"), null, 0, new DateTime(2023, 12, 16, 22, 0, 10, 815, DateTimeKind.Local).AddTicks(8343), "Description for Ticket 13", 0, 0, "Ticket 13" },
                    { new Guid("fa52054d-8a05-4232-a805-d5770295df46"), new Guid("f473fc6e-f8ab-4a58-8e84-c66d3a3ce20d"), null, 0, new DateTime(2023, 5, 26, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(7793), "Description for Ticket 217", 0, 0, "Ticket 217" },
                    { new Guid("fa79e56d-3a86-4f57-97d1-574f15e333b4"), new Guid("0faa3b09-22f7-4bcb-879d-318dd5feaa90"), null, 0, new DateTime(2023, 12, 20, 22, 0, 10, 815, DateTimeKind.Local).AddTicks(8193), "Description for Ticket 9", 2, 0, "Ticket 9" },
                    { new Guid("fac116ef-9d63-4741-a6a5-ffe27457f967"), new Guid("7b8c0315-23f8-4da4-b2ec-8e1b7c9ace01"), null, 1, new DateTime(2023, 10, 20, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(979), "Description for Ticket 70", 0, 1, "Ticket 70" },
                    { new Guid("fbbc9a10-f4ad-44aa-934d-30c3475356f3"), new Guid("4ba6808e-661a-4c03-9c0c-12ae20524e19"), null, 1, new DateTime(2023, 10, 4, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(1750), "Description for Ticket 86", 1, 1, "Ticket 86" },
                    { new Guid("fc1dd97f-c7a9-45d0-b809-269df7636ac9"), new Guid("36bb8619-bdca-4655-b9b8-083f6081ea20"), null, 1, new DateTime(2023, 9, 10, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(2741), "Description for Ticket 110", 1, 1, "Ticket 110" },
                    { new Guid("fe5e7e2d-5a1d-46be-8155-4fc8c972d626"), new Guid("efcbdc10-a276-40e4-8545-a0fd03bd142a"), null, 2, new DateTime(2023, 4, 26, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(8900), "Description for Ticket 247", 0, 2, "Ticket 247" },
                    { new Guid("ffa953c8-44dd-4018-a981-7f5e325a9781"), new Guid("752a1277-9a47-447f-a92e-519a8486c357"), null, 1, new DateTime(2023, 7, 12, 22, 0, 10, 816, DateTimeKind.Local).AddTicks(5968), "Description for Ticket 170", 1, 1, "Ticket 170" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Assets_AssetId",
                table: "Tickets",
                column: "AssetId",
                principalTable: "Assets",
                principalColumn: "AssetID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
