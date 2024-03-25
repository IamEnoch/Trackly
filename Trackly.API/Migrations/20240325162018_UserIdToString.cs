using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TracklyApi.Migrations
{
    /// <inheritdoc />
    public partial class UserIdToString : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("0210230f-9bf7-498c-b4da-85da7b5183c3"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("02d926b5-390a-493e-8b1c-98df335bcd67"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("036f790e-0142-4ed8-895b-b8c145ea18cd"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("044daefe-1522-4483-8f75-4bd17007c84e"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("0458a3bb-7b65-40ff-ab79-75e472117404"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("0518856f-64a8-40e2-87cd-27ef7e0e46dd"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("0531bbe8-9b17-4dc0-9397-646af45ad6c3"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("05660d29-9b1a-4d9e-8b09-82d6d974b2f1"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("05cf80ed-7192-4f04-80cf-d8df5350db44"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("066fe6e9-d45d-4b3e-b1f4-1862d43acf06"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("08f4cf01-4c11-4de3-a502-916a6032c999"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("09358b70-5d0b-4f3b-97d8-0ec0916739a6"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("0c9bc8b3-6f24-420c-aafc-2b6b1345a23a"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("0d444183-8503-4e8b-a8b0-78d6244bbd5b"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("0e6f90ac-ec68-4575-96c4-c94eddd610c8"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("0ea5007e-0d9d-4e5d-95b0-0d729ea1bf73"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("0eae5363-b78b-4722-980f-b5eb0eaf640b"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("0f11948e-f8b7-452e-ab4f-ab3564c2d4d3"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("0fa76c5f-b097-4306-a539-df963a30ef3d"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("11907ca2-6a26-42bc-be0b-b5d4de566eea"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("13f7f623-7690-4c34-90ec-4670e877f4e9"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("14a7612c-5461-4085-b06a-f94f5588a2c1"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("15918950-88bb-4555-bbbb-d85c1c185e7d"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("1763df8e-6d46-4792-ae83-348e2ee5d77d"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("18b4f9dd-8462-4e57-be67-862c322e1162"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("18e98cfa-750e-4c5e-a17d-73c85880c908"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("198b53fc-29ec-4fcf-b28d-72ebd2abf210"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("1a714042-1116-4b17-82f7-c6e2cde9edc2"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("1a8dc0da-b121-4773-873f-ff0e32adc9e0"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("1b05536c-7916-439e-99dd-97fd6eb6fdf3"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("1b1dc502-0fa6-4929-922b-2c5d9364840e"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("1b9c83a2-6cb3-4844-994c-5cbe3fe07e9e"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("1ea72b8a-c0b5-447d-a945-6778e8f8b223"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("1fde8785-8122-45b3-bfc6-7b67683d71ce"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("2006a614-c186-4862-85bf-6c67fae96d7f"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("223a7398-a2c0-4501-a8fb-98b942faed40"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("238fc481-91c6-43be-b894-95f00f67ea78"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("2670a2f5-64d3-498e-938e-d2e5d3c627b0"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("26e4676e-c30a-443f-be5d-934f9b7fbb4f"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("26f3177c-c64a-4a0e-8d89-611227ec2d6e"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("29569a59-5535-4457-a853-245748274a71"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("2b4c3e47-0e8a-465b-99ed-9699a2456858"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("2c098b94-5f33-4141-bda9-f37cfb59d173"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("2d5b2125-6771-48b1-a4c7-aedb6f444f4b"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("2d912b7a-71cc-4cae-ab32-07290d034fe3"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("303ff197-8246-46ac-b1ad-2ba7d9916711"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("30e7c614-7bf9-4298-9cf4-2f39f5701dd9"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("315d54cc-4acb-4aec-bd4c-65430e1f5bb6"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("315dc7d7-78ba-438a-93fc-d2ddccac28e8"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("330927f9-77c8-45ef-a08c-b3fbd1ef461c"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("35154e40-6c54-463d-b821-c614b4fa9d33"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("358ac71b-c813-4252-9445-03e2a4a20082"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("362f4259-106a-4ef6-8667-b06a9926d4ca"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("3936b4d9-0b50-4b25-8e38-1b895c479671"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("398f60e8-cdf2-45a6-8e1f-c5629c5d024b"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("3b83a203-07ac-4329-b3e8-7adc4578bd7c"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("3b8e8107-236b-4d1a-993f-d7ec093b85f2"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("3bdeec1d-c068-4b31-b682-970ba5da1241"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("3c611382-d8a6-4c70-b5b3-c27e8f7f8b21"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("3cb7683b-c7be-45cd-9729-050e68ba4ccd"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("3e9776f4-99d9-4ada-97c1-273f2d5d52fa"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("3fc65a9e-531b-408e-9c41-42fe4febdc48"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("423d8190-ee85-4c2f-9278-15da79f49764"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("43db3af1-1da5-4dda-9752-4845e781de69"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("4526dbfe-0f9b-4242-8bca-fcd4d43f446d"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("454fbaec-0dda-4b7e-8349-e066ec2ac562"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("45906c36-edaa-4604-bf82-9405c8796758"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("45be12c2-0134-4bb1-8f62-188e12d6007b"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("46c710da-23d7-4bfa-8be1-c182b3b8c8c5"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("4752231c-b3c7-432f-824f-444649fc9071"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("48503f0c-e86b-4433-a4ab-b56e9b3b2756"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("490ad268-c15f-4cac-85e0-9614deb9f1ce"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("4a98dc3c-0dac-489e-a3fb-527e65989f06"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("4b152663-0bcf-4d02-90a7-428ec7bd21dd"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("4b4eb5d9-ae89-4239-b24c-bb7bd21e45df"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("4b5f763b-9393-4fc9-8ad2-18adab9708f8"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("4bcdc2ad-e28c-4644-9c5d-cb43d6658000"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("4c2de52a-aa9c-49c6-a7e8-90912cc5f326"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("4d93f3a0-cc5b-473d-be13-53da718768af"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("4db17a23-cdde-4de1-9393-932fb7b1e1a7"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("4dbf5073-85a1-42db-be56-9d1e44de9724"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("4e95202e-1a84-42c6-af8c-29da929fc437"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("4f5df65a-f573-4da6-899a-0db914a12b12"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("538e79f8-1fc2-4509-b0b5-d818a8bde32f"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("54f469d2-b4ff-45c9-9a1c-d2428eaae452"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("568d2810-3283-42af-8b4c-98a654892551"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("56dc156e-3042-4762-9799-fbf2d7421bd5"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("58a63b86-cb9f-4ac5-8d4d-51178642612c"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("5c52803f-0173-45f9-80ae-81f278490dda"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("5c6b6564-85cd-4e3c-8818-9201a6ec0ba0"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("5d310819-76d5-46df-a152-195f59be6bea"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("5dd04f77-598e-45e0-8953-7326ab015c32"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("5e0623aa-e39a-428d-8b9e-0718f688ba02"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("5e22619c-5d21-4554-9857-97300877870c"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("5edc3205-ae54-4189-b407-eaa3347b62b0"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("5fbbeffe-b57c-4d87-9cfd-4efd1bb1f9c1"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("607cf0ca-25df-45b6-b0c1-4150dafb5ab9"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("61645fa6-1489-4f37-b17e-2d512ccc643c"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("61f71815-0a23-4b58-8a69-aca55c5d86ae"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("62ca4a77-d856-4f6a-b6a8-d7ad18de298d"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("64e30aee-3e26-49b7-87b5-df12751bdc5e"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("6513a94b-f4cc-451c-a895-92f2507c25ca"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("65196d3f-8896-4f4e-a682-d2f967e9a4d9"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("68abc370-59d4-44f1-bef7-9810c0b8812d"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("6a7055c1-a001-4ff1-bf24-40601c5a6a2c"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("6af0d6f1-cb10-41aa-b478-d01ea8c5c7ae"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("6ca90119-e9f5-4aab-b863-ba7cb616b9db"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("6cff3d7b-abda-4dfd-adc2-f7902d21d3ba"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("6d46e1b3-b57b-40c1-9dca-25d4243d9b40"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("6f26047b-ff36-4183-ba4f-d983f577d79f"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("6f47b94c-455a-4ed6-8e7d-b208a6e14999"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("6ffd4dfd-0be2-455d-b396-bf41a02dbef4"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("701fefae-aaea-4f51-a9d6-e9bb9fc7c4a0"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("7087fc18-9834-40ad-a914-82f0e8afd78a"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("7168ed6c-05d2-4cb7-8a62-e99a18a874c6"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("717519bb-40e8-4730-b165-37448153e32c"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("71d843fa-8eaa-4aa1-b40c-97fe3553a81f"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("723d6320-d3d6-4b2f-bd19-4e7606d91f50"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("7494b310-e933-438f-a526-88e148fd9c55"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("74be00cf-f7c9-46da-acf2-3ce29e82df30"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("754e4228-0c6c-4172-b2a2-84b25671ab5c"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("75512f49-0a50-4849-8562-76fe73a1b18d"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("75d35157-5768-4487-be15-ad559de36891"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("75e3931a-1304-4876-ba48-02e3bf1068ff"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("764e9c8b-818c-4849-9478-a7eb0b46ed5f"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("7706d538-5c26-4cd3-9da9-c101c266c451"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("77b72de2-94ed-4c76-86a4-43a9f0ed94d1"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("77d8da4e-95f9-4e46-9a7d-a74604de99c6"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("784731d6-3a9a-4c94-8a9e-596dc0bea65f"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("7e1b7ce5-88de-4ec2-a780-bda66c44365b"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("7f5ed0f1-d56a-442b-a2d6-a43da44fb113"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("80c6be63-b5dd-4c1b-a82b-0626c42609b0"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("823ab545-ffab-4d11-9ba7-ead97061fecf"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("83e676b5-d7aa-42cd-a5d7-350fda7de208"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("84871031-ab82-484f-8721-a04cbbeef123"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("84b35de1-153b-4164-8d7e-a7d3e818ed12"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("87e9bbe7-1804-42da-93c8-0e80ce4f0637"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("88da8d56-19b8-4fe0-bbbc-e72a12c6bc98"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("8906757c-d4a1-4f13-9f74-7dc6c539fdea"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("8b842875-dc9b-480f-bbb2-4061936922d1"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("8cd41583-a8e7-4686-9ae4-dc165892a862"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("91e43a39-eedb-4f61-8ea4-3aec9b7dbcca"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("930097b2-2ad8-4149-a5e8-abf81dab0814"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("93c4d9c1-945e-4839-8d0c-a3eb17b28f9b"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("94ce7f7f-1716-41a6-9bb0-0f45f605f839"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("953b1e14-1ac0-44c7-aa2a-35a20b40a5e9"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("9643fa35-0259-437a-b46b-4451e266a4c5"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("9763f4ea-c72f-48cc-9056-ad303101741d"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("97cc0d65-a16f-4046-92c0-b050dbdb56ce"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("9b8280b1-ff60-4473-a228-6d39b2262363"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("9b8948c1-210e-4bff-b601-315d38c0d0ba"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("9c09830f-cbc5-45a6-bf8e-35d3d0e28dd9"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("9c361ab3-4d67-4463-a3bb-851d06623499"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("9c8fa75d-2115-4891-8e19-8ae7ad6be82f"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("9da838ef-d19d-4ec5-b5b2-218d95c5b221"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("9dc6f71b-df30-4539-8a5d-e55081914ce7"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("9e3b9cb1-1881-47c4-91ba-98d864ea44a1"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("a04174ca-5f69-44f1-a7d0-af4aa2278d7c"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("a14367bc-1771-4911-b7ec-483f31f3d611"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("a16157c6-cbbb-4ad8-a4f1-b0b1bd076d8a"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("a20de620-edc4-4cb7-b4d0-bc7b48f2e7b0"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("a611ad99-ed62-4a52-9e35-a7e6c56d2411"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("a6c743c7-dd5c-46d6-85e4-3cde7105bc3b"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("a723be10-b63e-4fc3-9c62-1dcb9a44a9e8"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("a7b86e32-69a2-4dea-8136-3b2c202a9fac"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("a8ee9e70-42b2-4b2b-9774-b779e78026f3"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("aa07ea74-81dd-440f-9256-424a4dd0d012"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("aa49dc0a-138d-4adb-872a-0e74107d146d"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("af2498d2-58b4-46f5-8796-874203b282cf"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("b0767f96-a80b-471a-b424-586921dc4e14"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("b0addd21-cc6c-4074-89f3-e9f0f3604377"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("b13c5b91-bbd0-43cd-95cd-ef3b88ec9931"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("b13c93aa-51e6-441d-93eb-b556237441b9"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("b1bc0231-2ce1-4a44-9a9c-f52833c882b6"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("b20ae896-6bc8-4aaa-adb0-8631307364f8"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("b2c3fca5-a190-4d4c-a7a0-1226659e5552"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("b3309991-0577-42f6-a306-23ad29bc4691"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("b487c611-fc61-4cad-861e-20c0b825c346"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("b4c391bc-09cc-4119-8213-32ce455acbed"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("b502a48b-0537-4089-b42f-90c38d78a7f8"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("b528507e-a2a4-49de-a029-98e646aedb4c"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("b5aa360f-ab6b-45ba-9bd8-bdcdad2f1a17"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("b6796ff1-71f9-4ea9-934a-bbbb55c5a7ba"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("b690e652-fab2-4f37-825a-028cb7beee4b"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("b7d6090f-774a-447f-8c22-704e28d53f3f"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("b976a391-fc4d-4384-ac7a-c1183547ca1b"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("baacdaf2-2768-4c9e-a8ae-20ddf0b852e5"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("be11c36a-87e3-41e1-9938-9bb8f6a390d7"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("c0d2aeb1-d08a-4cc9-859c-fd39dab96e65"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("c1265de9-2c27-4663-89b2-510312b21e6c"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("c315a5b2-bff8-4804-ac20-7f563f5524e8"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("c33c8a8a-7792-4ebc-83df-316bc034e033"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("c3b46176-b849-496f-a287-80020121d996"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("c46a97ea-b559-4bda-af4c-1655a0606423"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("c67dca86-0809-4f80-b6e8-db39c10a4022"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("c7c7296e-fb8f-4ecc-8e30-aa849f7031f3"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("c9a0290f-b7c5-48bd-b518-ee956391ccb2"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("ca768ae5-2286-44f8-9fe2-27cb145a3696"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("caf4537f-2f9b-4693-bb35-ea2347d26929"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("cb1a8980-0909-42bd-99ee-0d3bf0c54022"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("cbf32950-b3dc-4206-b6e7-44fcd8421fc9"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("ccf98062-3ca3-4582-8743-921531fdbae5"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("cec6d855-d016-4530-bff1-1936a89e1f19"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("d040e385-cec1-43de-8509-e093554439d9"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("d20eb112-a12b-467c-b9a5-8f2513c0d05e"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("d3772c29-27b7-42ff-a37e-4d18697eeda7"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("d476a426-31af-4fa2-bff0-117ebba8eb89"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("d4be3cd5-c1d5-4335-9e55-c692fed59338"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("d538413f-84e7-425b-a75b-cb17ac86713c"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("d5431c23-d031-4179-8c1b-1d089e4cdd03"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("d5f6351a-ac4d-43c8-8229-eca8fc419eba"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("d78006f5-83da-4d71-8bac-7d2123bcbf44"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("d832c188-0fe5-42e7-b2ff-80a1dbcd30af"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("d934f527-7858-4ba6-89e2-ff3ce48e859e"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("d94df552-de29-4946-a896-a4e3900d9468"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("db706122-1927-4c03-8fad-f5e01eea87f8"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("dd030cdb-f609-4ff5-a873-321f05cb9d36"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("dd8e63bf-5d81-4286-b38a-3604ef839d1b"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("df01eaba-1281-443f-8601-d53560669ec0"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("df22c8a7-4e34-4c68-8ef7-a965c7c637fa"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("df7480c2-1c99-4806-a698-ede532f51644"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("e0519965-8390-4917-8538-2beac71a1a24"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("e118ecbe-0a2d-4bd3-94a7-4f1d86ce4f10"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("e1350227-1437-4379-8e6e-e4f9c92d0cbc"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("e3307c29-8357-417f-b3a2-fceb5e2a4a72"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("e3bd2c87-7823-4c3e-b8cb-2f2cb56c8dea"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("e47ce070-1995-4d5d-a29a-8905cff46abc"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("e5422985-b1c2-45a3-a083-4cdbb4a77b89"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("e6eca911-8c25-4b59-997b-3dda18e501e6"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("e83f57e5-5f7e-41ce-8fc0-95fb43f4ac5c"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("e862befe-9df6-4a9f-b432-48eb26454679"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("eb0ec2ca-0382-49b9-8c9b-5f3bccdf87e6"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("ec83dd8f-4b22-4c7e-8a63-123b906c4ebd"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("ecc1fe9c-1df1-436c-8a92-187d201a5ee9"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("ecf1d828-721f-4d98-8287-c0c47209bbe4"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("ed096333-fc8f-42ff-a120-b8b80d9cfe3a"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("ed4c2c84-ce87-4945-a8f8-6e293c025f33"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("edd772df-29fa-45ed-8111-3d32d6566292"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("ee524f40-9fa4-41ef-84a6-c365cb2be4cd"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("f18e0d1b-cb7a-4e58-812c-f6ce644e52e9"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("f1d83101-29c8-44fd-8bcf-a8d93a349e9c"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("f1de93db-eabd-47a1-8a3e-41a8cced0354"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("f30e3b7a-4f26-4ae9-9f6b-28b0cd71e17c"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("f5a528ad-a755-41ad-8b9e-ae83045d420f"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("f6bf61e6-2bcb-4166-bdab-5f477c677501"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("f8ddaa23-a519-4d2c-9d35-3f0e6b6f6e94"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("f91bfab7-0175-4a9e-bd86-291efa067693"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("fc371362-fe16-4280-b6c3-1b8184658e8c"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("fd36f5a8-a5d6-46db-a0d0-73f41b3e9c1f"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("ff0c42fd-3ed2-4639-8dbe-ae33fdc68f52"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("00274522-6779-4670-aa2e-1b5e398cbada"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("0066af0c-85b9-45b8-a320-b8f6b6f4871a"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("020197b7-0f27-40ca-b596-7fee9c2936c1"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("04d64fc0-737b-4d36-a1d6-dd288a6f88aa"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("04dd1eef-d934-48a9-82ef-197d7d965573"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("056af4b4-6dbf-4f86-a312-d7352ba2cb06"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("06b30e34-fcaf-4aa1-b0ba-9735652e1ac2"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("06f4d678-58d4-4e62-b1b0-7fd3bec1b601"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("096406ff-e537-4633-9025-39af89c2991f"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("0a0c4470-4ba9-439a-a3dd-1cd23b718b44"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("0ae39b71-3c93-4586-a114-8bd1fee62b9e"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("0af4cd0c-8196-40e8-9e88-361003f23f39"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("0b0f7114-7fd2-4aed-a7b9-799aa35fd865"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("0b58a7fb-dc38-4d66-ab3a-9cafb3ad7273"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("0b6c05a9-f8df-47ad-83fe-6b518f7b5ddd"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("0b8b0283-cc85-45bc-ba45-1bef6ca17b42"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("0d01acb6-ed11-42b5-9cc4-b1b2faebeef6"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("0d1790c4-3942-40a8-b32a-2799c3ad9e63"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("0d4463e6-ecf2-41ff-bbf0-ad23bc7675f4"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("0d58bd0e-118b-42a3-b4de-64d6bbdc3db0"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("0d93413d-ea17-4399-b682-39728b5efc32"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("0d9b7335-fc5b-4773-b60f-4f1bd2882e0e"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("0dcfe411-3434-4579-9250-959d6e5251ea"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("0dea9af7-5032-4d51-b92e-1af6a465b599"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("0dff5e84-a5e6-42d2-8190-e447256b96f9"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("0eba909c-8826-4435-8f48-d039f2f858aa"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("0fabf1e9-6d71-470c-b2c9-a85e4816345f"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("10e5a9f6-32fe-4c87-9cd7-61cf96dc8611"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("1119bd10-4014-4a33-9e4a-8cf945687e2c"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("11608204-5fff-44d6-acaa-36dbfdf2393d"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("11dd19d1-e254-4f4b-87b1-f5baeea457e1"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("1249e2a5-0bf9-4068-b9c4-c31dd0ad6161"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("13532568-80b7-45a9-bfd0-c8502e513c46"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("13c11abb-70a0-44f6-ab20-1df2a10ced33"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("14da849f-0971-4f0e-ab32-799c2dd25266"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("1629497b-eef7-4f47-8f1b-307ea94e1b8f"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("166fef83-8a0c-4051-ac97-a029245a1fba"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("176a6f54-1ecd-44f2-83a4-fd0e494f3e25"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("18714ebd-cb5a-49ed-803c-5e19bb37965e"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("1890b4fa-47c0-454b-8e24-8d600ddf9556"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("199a5ded-c2df-4b46-af76-2f11087f1d1a"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("1a5a523c-dc4f-4fce-aa18-4981aa515c4a"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("1a81a92e-3f5c-4dbb-b46e-3efb25b18636"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("1adbe246-4441-4521-813c-44f04691e6f1"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("1e0e05ad-c8e8-46cf-b4a0-790b78940fee"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("1f452251-1333-457d-b620-8d4f29ac79c4"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("1f80429f-de08-4363-99e9-72ded19328ab"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("1fd28826-e1f3-40f2-9225-c1e684066ba2"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("201bfd80-79d8-4d91-a0a6-9e6ffa357dff"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("21e7236b-09e7-41d9-a620-084950372123"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("226a686d-6014-4f8c-8b78-be3f2760a464"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("2277f968-bc13-4caf-a1f4-5e1889225679"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("22d035b3-290c-4b54-8e32-dd81d70d5ffd"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("235c18e9-06dd-44c0-8b23-fa1e5c603538"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("239dfef3-c58a-4929-ae57-e05539033664"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("2495f995-c510-4d1a-b75b-e69bfe4ef746"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("26704d99-897d-47c0-bc74-673bc0435817"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("2698e504-b583-40b9-b324-3a8391ba20ea"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("26d66ea8-c714-4304-bb15-7b091fe4d5f5"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("27c1ffe3-90d9-4b77-94ed-4c6e71c5e120"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("28bcdaa4-a000-4881-b980-eb414e48a1e2"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("294ff628-31f5-4dda-8732-84eb4372d364"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("29cdb81f-3908-4b70-9054-3a4f64c5815d"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("2a398d1a-d3af-43ce-8cc7-cc41b989978d"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("2a68054f-2134-4ec2-8f9a-1f8e0d87c840"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("2b3ddd32-e163-48e5-b630-d031a6be8716"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("2be76daa-0242-4359-833b-00fc4c96883c"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("2cd9151d-c94f-4258-91dc-8f8b5390e632"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("2dbd02b3-965a-444d-8aec-b619929235cc"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("2e0420dc-bd4a-4c8e-9884-989e08449596"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("2e3292a4-4780-4274-80df-35b5e8ee3173"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("2e8f7740-abf2-4521-a6d9-8b4951ef576f"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("2ec8f860-6329-4544-8a3a-51abf86e4bbc"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("2f0e5432-b50a-493a-bf5d-919a4fb4d49c"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("315dd608-9778-4e0d-a265-fe603530160b"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("3210e13b-33a9-4288-977c-9da195191518"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("324b080e-ffc0-4e63-90f7-f77e5bcbf97c"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("32622a76-a823-4b9c-8b2e-e150fd25e23d"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("3280208b-7883-4684-9f49-471543084270"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("32b6831c-5caf-4f63-b42c-f35eaa83d14c"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("3315e88c-e2c5-4146-a405-7725574d8d25"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("342ccf5d-5747-4cd5-a6e4-9e0a1cefb0c0"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("342e0e11-feb2-476c-aac6-e5e691626f5d"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("35c96b87-99aa-4364-abc3-1ccab16384b8"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("3697126e-a6b6-4a7d-b479-b84f08c089f0"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("36b958c4-a68e-4a38-910e-7d1802ab084b"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("36f3ad56-bf22-4f6e-8254-12e13a2814d6"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("3756340b-c93f-434f-b940-c89df27ee4f3"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("3777fccf-cc40-41f3-bcca-21e98c0e37fb"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("3797fc94-6de9-439a-8304-e281b48c0a52"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("383beebd-60e0-49b5-a4c7-1fa58c2b5b79"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("3860d915-6743-4d6e-8de1-b022dd7646a1"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("386aa0c8-a16a-4e00-9d5b-e99bf0406fe6"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("3883cc0c-3de5-4d99-9e87-da8ac3b9fefc"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("39790876-34df-4d5b-92de-99050ad68a9a"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("3a633fc4-33d6-4e30-b9dd-1f1fe7eec93e"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("3ada162a-5b77-4fa4-bcdf-e09ff91275f7"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("3b46f5f9-149b-41d4-a1de-a4851c815493"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("3b8786fa-ae3a-4d6a-9b69-ec548206991c"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("3cf36022-48bc-499f-8dea-4a7ae2fac61d"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("40db7cba-ee70-4d23-8b86-011dddd65b93"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("41a38dde-84b0-4b1c-b644-7a9801f2218c"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("41f4d36a-b74a-4b4b-aad6-533a604635e6"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("41f91d78-d799-4c7b-b9e6-9d25f7fa8840"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("431f58d0-45b7-4293-b960-dca5e2d96cb5"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("437656cf-7854-4c4e-851a-d2189053128e"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("43c651d7-837f-413d-a25d-43f3f7295ce7"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("43c99d57-375a-4113-a4cd-1a43386f6ffa"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("43cfc99e-fb26-467f-b04a-15c7ae4113ce"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("446b6b31-abe9-41ad-80c6-bcbcb6c194f3"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("446e7b1e-7684-468a-8e97-9e39dfd97797"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("450a0c7c-475b-4e5f-90f9-10b85f656e3b"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("4515606e-cda1-4710-8903-d01b9870e341"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("468aa9e2-d39c-4347-a4f9-e801bb47c3f2"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("48156b26-8979-46f7-a924-8093219623d7"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("488a517c-0d66-4ad9-ac6e-c5642df56ad0"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("4aaf4435-e8aa-4b2e-bd8c-433b4b1bed42"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("4bac4888-e6db-4048-9853-f35c0018fd17"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("4c181510-b402-4bf1-a4dc-67f417135546"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("4dbd766e-0096-4786-88eb-1d3dd292e17b"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("4e04f705-bd09-48fc-aff8-428d57ae3fcb"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("4e0def21-8b27-455f-a6a6-0706c3c8d620"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("4e5ef874-4766-45a5-9717-1c68c00da7ff"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("4eac4aa7-26b2-4a90-b43a-6f9f67634f9c"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("4f0e1649-9639-4856-8991-da31125a1e69"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("4fd20eaf-260a-468c-88c0-9d5b653becf3"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("50635bc7-48d6-44d9-ac51-4a60f52b79a3"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("50e0104f-67d0-465c-b577-98347b50287b"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("5414dd47-5a42-4058-95b6-788af615e506"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("54e06e6f-1033-4790-b7cf-0e3ee2ff79dc"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("55a0b64d-ac3b-4ba7-a97e-42453eaff262"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("55c019f2-c86a-4844-9d28-f566c162c8bb"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("55c93e6c-c2a2-4ce5-9cfa-ed4de1301143"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("55d6e6df-0dbf-4d4e-9651-48993adb5840"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("55e3d923-0509-4921-bbd9-4b953613b3b6"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("5628a8a8-a1aa-432e-9b51-591b12a846d2"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("579546a8-3cc2-4ec6-b9b0-ba4c11a2d155"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("57ad8e2b-ce67-4080-becc-c4bfb215c5e8"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("57f0de39-d91e-4648-8ef9-09130c194dc4"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("57f768c3-f82d-40cb-a02e-189f8e932f03"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("58686e24-0f2c-47ce-843f-1b67423fe31d"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("5881ae92-1013-4480-b56b-cb3f84f4af47"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("5894bc69-ae07-4ba7-974e-ceb3a7e845fd"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("58e53507-c56d-412d-8b06-e51c67547c60"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("5910680a-cfd1-49ae-891f-0f15e0a59a7c"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("595fe7a4-5790-424e-8cea-a1deb88c419d"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("597c30fd-a873-4094-854e-df28643aa4ae"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("5984b5ee-e077-4302-81d7-09c44ee941e3"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("5a2e070e-1fe9-4fc7-beaa-3438ca82be33"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("5a565365-98b9-4e44-ab3b-9c72ccedb5a9"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("5a748229-4529-4d4b-b860-bcb60f58344d"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("5ab59726-f5b6-485a-83d9-a8a7dc51cb90"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("5bb18418-87fb-46c3-af3f-70c01c9d76f5"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("5de2db75-31b8-49df-bb44-a828c5471126"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("5e15b07c-a3fb-4837-b454-68f20ca882b5"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("5e1de1bb-5d31-4571-933e-4140ba369709"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("5e6b06e4-4722-43a4-b5ca-3f2ed134c65c"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("5e6d8637-b3d8-4554-a552-572d1dd3036f"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("5fc83abf-9f14-4284-9eb8-5247d091ca78"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("6146a8b4-67fd-4a7d-bbbc-1b5eb2db9451"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("622dc443-2d06-4cd9-bb17-551b962bfe49"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("631be7e5-ac5b-4044-91b0-40aee8d80850"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("636b37df-a598-407a-821e-d2f916e4eb91"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("645e1fdd-2255-40fc-b85e-515ecb84b61b"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("64897f68-be95-4a4e-b42a-70dca56cb57a"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("64b30c79-2c22-42a6-8eb6-12636a74b7e8"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("65184fa4-8146-43ab-acb6-3df1dd30c492"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("65fe4f07-6c31-45b0-8bfa-7d3397435a3a"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("6818cbb2-8d88-421e-aa6a-a0cba054ddfb"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("6917903b-bcd1-42f7-ab95-20bcdff6c564"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("69b4a0ba-8f2f-4531-a067-f65844b36adc"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("6ac20a66-55c7-4cf9-8076-684420ecc365"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("6b8dbe55-ea2b-414d-b43d-3990e06c05d8"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("6c5ddc94-4bab-410e-88e0-4eb23ff30eac"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("6c97aa50-73f7-421e-998d-ce143594e51a"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("6df6a8f4-536b-4051-94ab-e5c2a62fb567"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("6eb8b968-3b5e-4c43-a7ce-0b9dbd15fa4d"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("6ef355f9-1ad2-4f12-bdc1-842835c9f52e"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("6f0a0ad0-6763-4000-bd57-87c15507cb03"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("6f245011-eeea-445a-ad76-33b00dda25df"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("70dba8e8-7f96-4db2-ae79-8d14b1c529a5"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("724827b0-8f75-4248-ada7-97e092e03e5e"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("7300ef28-baad-4c18-8109-c695785f960f"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("7466a019-e51f-48b0-834d-c7d4978bc83b"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("74b0890c-f96e-45bb-8c91-53e73f651cc0"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("74e662d2-878c-4f39-b1b1-117447419145"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("76cc983f-46ab-435b-9636-98100db4a565"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("79905e01-57e1-4ddc-b566-eaca3b2ae35d"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("7a418217-4f10-49e5-af8b-766b9a7db121"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("7aabbe74-be86-47bc-b6fa-0025e5ddcbc5"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("7ba235e7-6826-42c6-8346-573b95df8cd3"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("7bf5fb7e-830e-44ef-858c-c1f625fa7bac"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("7df7b948-adcf-4142-bfec-0af6749e84dd"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("7e20e104-49c7-4580-b3c3-b07d20e3a898"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("7eab2bf3-d421-4e9c-879d-4380cb932ce3"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("7ee7a27a-2eb3-480c-825d-978c47a15fb4"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("7f738a52-8b29-49fc-850e-68f5a31e8896"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("7fba2447-841a-41dc-b16f-7db6447af801"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("80913a3a-374a-4928-bada-bcdcc17ffc43"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("81b5be4e-1da8-4dd5-8098-26f6f6fdad44"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("82e63caf-efcc-4134-953f-cfde75603c01"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("83e41a5d-7a67-42e4-bd41-01536e5528d0"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("84c0623b-cf4d-4e74-b6fa-69029db0933a"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("851129b0-b2d9-4fda-b3ec-cefa55a5d319"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("85155185-b17b-41da-aa17-b267c6f10784"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("86f91357-24d3-4758-abb9-3d028622fbef"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("87d022d2-9996-4ed4-bc57-17360d958c1f"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("87e4ef4a-9172-46fb-b249-80e1ccc53a6e"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("8814a4b7-101d-4dba-9f36-f70582b938d5"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("8836d170-eadf-4694-9e90-5fc2ff52393f"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("886cdef3-cc84-4aee-9a0b-a868f80e7ac8"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("8882e419-ae78-4256-917f-283457920410"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("88f75e65-aee7-459b-a520-5ae58d7db047"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("895defd0-abaf-45a2-8045-f52dcd2ca82b"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("8a4a905b-9d54-43ef-82b6-4144e7deb477"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("8a84391c-3eb8-4a3d-b4ba-0339f1d55e6d"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("8b086f92-3cdf-4df5-acc1-4b21f3844501"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("8b8552bb-6fb7-44d1-bd93-3e4e30616932"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("8b9a2f2c-c1c5-42bb-9ce2-fc22afa29ffe"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("8c2e0277-530d-4469-9864-545173569ea6"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("8c79a4ef-4d0b-478e-b7a0-91c61367179b"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("8caf2e9a-f328-4313-8c26-7cc4a8e7eda5"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("8cd1d299-a456-4135-90c6-854e2a1a860f"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("8dd4131b-5afb-439e-afd8-0f40d20777d6"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("8e8aceb0-e599-49a6-b920-e27b780cfdf1"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("8ec8adcb-0489-426f-8604-44e59a8971e7"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("90232ca4-582f-4948-bcb0-4ffe777a6806"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("904bb8ab-eb00-4ae3-ab74-ea0e423d382e"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("908ebe8b-2a7b-4240-a27a-c202eebd0368"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("913963b9-252d-47b3-ab73-12f33476e8ac"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("92302cad-c9e6-4f0b-becd-4ecfe3d9b2b1"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("92a40eb3-8e14-4fff-b86a-499968fbb354"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("9319896a-cc8e-47a8-a1cb-82c0d36f55b0"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("93d71e88-2be5-4f96-b2e0-5cd885d3e014"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("94139b15-56e2-433f-9e7d-1021e72f51b2"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("94c0a277-be58-4ae3-b661-76f21e40207d"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("94dc80f0-aba5-4e48-ac03-dcae07fa78d3"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("9629c21e-dfd9-4bbb-8614-be41a30735b2"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("9668c1f5-f61d-440f-b2b1-82e41ecf5326"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("9670e5d3-9890-4f23-95a0-7d2b2164d228"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("97ea3c81-acb5-4503-9543-e64273c6cdfe"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("97fd09c3-7a17-4dce-bed2-fc12fd62e482"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("996ce3ff-4f18-43a8-9034-45e7befabac9"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("9a7f4e95-40ae-4ff9-afb6-ab9da06adb04"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("9af5aa24-ad68-402a-8d9e-a8c32cd06184"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("9b3fe80f-07d0-4375-9b6e-d1a619e8c285"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("9b49fa98-c944-4254-bcc9-b2e287468cb8"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("9cd9c4c3-c94c-4680-9034-2779e5013ec7"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("9e8a3d8f-62c8-4b10-b2e7-7a2f5d39afd7"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("9f6382a8-ec6d-4f8f-b7ad-4fa83730f24e"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("9f8e4b2f-e1df-465f-960c-1c26d0aa1817"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("9ff0514d-0e55-4bf4-b2a8-f4d6f9b00770"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("a2522926-1fbc-4db8-83c2-7923a7be88a2"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("a254365a-1e7e-4be7-9f54-99fc0d530e52"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("a254f2bf-b71a-4678-8e4b-3838f26982b2"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("a27288fe-ef5f-4861-9e47-d2a546a04678"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("a28f6e01-0a4c-41fb-9fb2-0995f54b82ba"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("a2c2b5a5-7abb-4755-8846-a09762b00467"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("a43e81e6-cd3c-451d-802c-78f52b46b415"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("a45833dc-275d-46be-9951-e1e6fead2eb0"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("a51dc3d2-2e24-43c3-8213-99855d719851"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("a6688d56-4c9a-4a16-bf65-b195036e67f1"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("a675faa5-bc04-4e0e-bf9c-38eefce4ccc6"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("a6b607cb-6d62-41da-b99b-4ff2f85af88e"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("a6b86e2d-8872-4487-ada8-36fbf8f440a8"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("a6f4e97f-aa31-47a8-83f5-591e32b3cad5"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("a707827f-3e0f-42af-ba73-d46687998892"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("a7308067-bdce-4812-8ef5-c12f340a2977"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("a744497f-667d-416e-adb8-f8e03a5b2d79"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("a7d972df-5361-437c-a534-571033ad35ec"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("a9031e83-2c32-441e-abdd-a35c63eb66e0"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("a950a7d6-2b21-4b31-ac57-16249242d95d"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("a9899a80-688f-498c-bcff-1a426371a55d"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("abba923a-a264-4b50-b9d5-cbf38da49349"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("ac0ef4e2-de04-476c-a082-9f30aaf4a95c"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("ac3df463-e8c1-43b0-9471-61958d047fe6"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("adb3d9be-126e-48c4-83a8-9993f5da86f3"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("aeb97e9f-8c1f-4c32-bc76-a44d0180a34d"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("afa39378-027e-4fce-856a-735085af8440"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("b1473a3f-6b78-4620-bab9-150d67e3dbe0"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("b152efb5-792c-42ba-9578-9d64c6dbc761"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("b1560388-7654-4f10-b7ce-ed24b66662b5"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("b15d8daf-deae-4551-8f85-fa077ab30517"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("b2583228-61c7-45ec-bf3d-03b97e648442"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("b41c22f8-0623-4762-b970-126a267ded60"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("b4313a35-5a1d-4f8b-b978-0f347d13625c"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("b507d958-3afd-488b-91fa-d6c71f9e862a"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("b5414af7-4c0e-4d27-9fd4-2f9aa73fa6c2"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("b57e747a-2e04-4206-96f9-87e3dad3788c"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("b5b2afe4-aa6b-4ce0-ba6c-eec6e215269a"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("b5fe1bd1-1d5b-4250-b83c-ae7a5093003b"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("b915ba37-d534-4824-89a2-29d16bc65a01"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("b9196348-618f-4d02-88f4-53272d95ca00"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("b91addce-0524-454f-a5c0-387bfa6633e8"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("baa4652d-e252-48cb-b384-9dbc22e7c670"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("bb35a898-b03b-4ff9-b527-9408860f5dce"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("bba8b411-30a5-4002-88f6-f019318c355a"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("bc83ac07-791e-444a-ac68-4e62ed90cd41"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("bc99cf60-7daa-4e97-bdb5-603dd5d82214"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("bd2afcac-dfc2-4665-a3ff-f38b6009aeca"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("be639491-bd40-4af4-881a-16eda1d11b89"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("bf31b651-8b94-48da-a521-bc2bc01b636a"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("bf525c40-57b7-4ab8-9454-0a0a4caf33ac"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("bf70c38f-5130-4a4b-b3c7-6f15475245b6"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("bf9cf5f9-4577-49b2-aa84-d4d4763fd6d8"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("c0b5aa31-0aed-4038-b277-0e11fd063de5"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("c12e274b-cb6d-4bbd-8c3f-b43d47ebf851"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("c139846f-d0ce-45a7-801b-c3eb30f46260"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("c16be343-0871-4f13-9e0e-71dd619e1e4b"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("c2122e77-5732-403e-abb2-efa857e4e352"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("c2689b2c-ebb2-4b33-9d78-0014b6d6d37b"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("c29f4783-6369-4104-b8b6-85b484455faf"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("c2bb90b3-60c8-4ef9-9ecf-90bade59117a"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("c3c60f5c-c7a5-43bf-9a97-789201f266bf"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("c41918d3-dd02-47af-8a5a-70ebc1100716"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("c425b139-2113-47cf-bb7c-3b2fffa92422"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("c4855a58-f9e2-4365-96e4-63a1dee12d90"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("c4d6f83e-db60-4919-b7f4-da5c6a5ed4d6"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("c5266161-90c6-46c9-a773-c5444c9d9849"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("c57ad425-3b49-49c9-bf6e-b5a346ac4391"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("c5917cb4-4ffb-4e46-81bf-cdaf74833a10"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("c65ba102-001f-4a00-8b0e-d93ba8afcee6"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("c6633c0a-38dc-4fcb-b28d-afa0143b211a"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("c74015ca-a7f9-4dfe-8193-fdb4ff7d4c8b"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("cad5299b-d095-4c17-ae7d-4ba0bae0f9e4"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("cb31d85a-8b41-4b5a-adb1-f101f800c046"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("cb87dd91-eb88-41ee-93cc-d761f8b5cfc6"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("cc71c4d4-fe85-4f84-8f9b-6d837d8e93eb"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("cd629872-694c-44ce-b8d7-0483e2c65404"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("ce5d5868-e36c-4e1a-9c08-d1d30679a276"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("cf761fc2-d38c-4d04-b768-1ba292275640"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("cf8c50aa-815b-45e1-94d6-b563e0666b29"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("d1a98a9c-356a-4702-99de-2adeb3291d3e"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("d26a0b86-f69b-419a-a7cf-c32fa90cf29d"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("d27a3e16-f443-4e76-80e8-676de9980e85"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("d2b9cc1a-b4de-4343-b8cc-b5acd47f7377"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("d2f8ec68-65c9-4c0e-a5dc-a0f2343f49b7"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("d31811f9-c3be-410e-b7db-3691f40d431e"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("d36a18d1-915c-4293-935c-af24ac616bff"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("d4836b55-a0f2-44a5-90b7-5550830a07c1"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("d4bb26ed-25e1-4bfd-8c16-e7d79c8edfdb"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("d5e144f0-d057-46fd-8ecf-acd3792947da"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("d69da735-62db-4303-b4d4-3bd7e77ddf98"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("d75822bc-a73e-4bf5-a3f7-fccd9110745d"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("d79be886-df4f-4896-8f34-e5486e1638f3"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("d8fe5dcc-b310-403c-9825-355af589257b"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("d9637d08-906d-470f-8dfe-f0cd778d58da"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("d9f01300-c7b8-4da6-aefb-f9c3f1e06069"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("da1400f3-6519-46bc-9d74-e3f696f2cc67"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("dad8040e-d302-4bfe-b7db-0d51ff21eb96"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("db21371a-3b47-4383-8ce6-c11d34274a72"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("dbd6940e-cfc1-460b-a82b-41b379a941e6"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("dc1158a0-6d35-4b3b-8b69-04488515230f"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("dc13ed98-3271-47ff-b080-6513afdfed49"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("dd133657-4a83-4231-9b80-e63b5024094e"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("dd3e52a4-9f54-46bc-8f9d-9b0b1569c29d"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("df25a9b6-3b96-492e-baa3-616aecb54fb0"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("dfc0ab9b-5b88-49d2-be56-bbb540c3a540"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("e0d6666f-348d-4484-ad61-ab6d1886d7bd"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("e2e45766-78a1-4e3a-9b3b-3be9abbd6b52"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("e2edd2c6-159b-4660-8f18-181cf52c5bcf"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("e3f4ceac-0aff-456e-9193-8e1a4b7031a5"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("e434429d-d913-4e66-8889-5f98210e29ac"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("e5ada032-63bd-4421-9f1b-55dec00d612b"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("e754636f-6d24-46aa-b33d-e5d67fa512e1"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("e754c6fb-c258-4914-ab11-62726e4a16a1"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("e86a8008-5d5b-40c8-8d09-305e14e82375"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("e8e06c13-43d1-4ce7-a172-dc8c5a9682c5"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("eabb2552-b7f3-4247-8a34-b2133c88c114"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("eb109f43-7ce4-4719-8fe4-be6e4491be5d"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("ec51efb8-fdb7-420d-abc0-da5e8edce576"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("ecd6f40a-b3c8-461b-ba37-8d36bf14a546"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("ed7469ab-bb4d-41f1-b490-a9e85676da97"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("ed76db1d-d4a9-4edf-979d-119488978dc1"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("eda0c6b1-5a0a-424a-b188-663115156722"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("ef45c622-2132-40b8-9ca2-061d8f8cc396"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("f095015b-6566-46f0-890c-63517e4c15d2"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("f0aec23a-aebc-4ffc-b751-0df87ebc693e"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("f153ed32-81f3-43b5-8836-28d974518cbc"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("f164f61c-9cef-4384-972b-af564c37ce77"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("f1b5977b-999b-4ffa-a2a4-7fdee62ddfee"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("f3065cf0-0735-45a2-be39-7d7986ef77e5"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("f3416b54-6169-4d1c-a8b5-bfd22fcefad9"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("f34878fb-5512-4a6d-8e13-107d6e62a8cd"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("f414bfdf-98b9-494c-bf84-b0bf1f421574"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("f8730b62-f8ab-48c5-bfbb-464974a225b1"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("f8ab6715-ac6e-4e96-a217-e9b699b32a16"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("f9620e33-0f00-4dd6-b7a8-a27ed1107e8b"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("f96e2f9d-826a-4515-a7cd-56ed1e05a129"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("f9a59d7b-a82d-4555-a039-d7dac38cc7cf"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("f9fce8f1-9876-4561-9b56-c84e8a920f33"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("fab2d0e0-9f7a-42cc-a4a7-212c892c0bfd"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("fb5e3f6a-3319-42f3-bd1b-78252d70e670"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("fd7ad9f8-eee9-4d63-9fa8-bb7a1fcd3dc5"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("fdb42e9c-2e94-4958-b5f1-1ebd656e1a98"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("fdcaf659-53db-4414-b26b-e6baed64989b"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("ff67aab0-6b5f-4504-9357-65ca6e1d5e4d"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("ff73c887-edb1-4797-801b-3f3573319a70"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("ff87768f-c581-437e-afe9-af29569d366b"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("ffac674b-3d6a-472e-9d5a-a587fc283ca4"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("0186db38-7113-4142-a1e1-9dee806daeb2"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("05f24951-e653-4a66-bf9c-a7fc974790af"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("071c3cc5-02b0-432f-8f41-ba673225e1c8"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("0d968db3-960d-4fda-8ebb-adc1a3a50999"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("1ad928bb-4612-4cbd-b795-f4d9e05d0b73"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("1df30ac9-724a-4ace-a5bd-cbb579e7ca2c"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("2069b475-a494-48bb-8f1e-5077e9fc0c29"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("2448cee6-eacf-4b8c-b35f-47e61b43d7cf"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("2918bf65-e859-411e-85cf-4dee00fe7f73"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("2c48c132-38e2-43d7-bf83-2e78dc062be2"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("2e7474a0-28d5-4c9e-b838-61db8782cc92"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("3f747ed7-980b-4e92-acdf-ec1102d4a0af"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("4fb29223-242d-434d-9437-2927203619ea"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("6246fb7d-c2f9-425b-a185-98350aa9da3e"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("63092697-3fcc-4e41-9969-c783a15e768f"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("65aa9a7c-d370-42ae-bfd4-c73044970716"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("6ccb1d85-1dbd-465d-a425-f22ec75c4b85"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("6d8e062e-c71e-4b72-bcc6-a7066bc54f25"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("734b123e-c217-49d1-8478-561ba7973cab"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("798f6fce-fb81-402f-b76e-33049b892820"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("81faf274-2a02-4780-82ef-53dbf6359121"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("8276c361-4485-4daa-b78b-a41b042d9dde"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("82d28eab-12af-4ad5-bc6f-ca265703df62"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("84376aa5-1faa-43c2-bdc9-2a5d90a4cabc"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("8567c826-3630-44ef-9744-6f70d74b335f"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("87f80008-d28d-4881-986c-34fecb6c962a"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("8ab8775a-fe1e-42bb-84a8-0664c8726d13"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("8b6d3ded-2544-419e-ade6-a9fa14d48681"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("94e65e9f-ade5-41ea-b16d-73b1823d0d7a"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("a1eaf5d0-9721-4d6b-976d-10a18744d0bf"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("a44ff748-7c83-4bc6-808a-4e35747cae73"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("a50f16ea-c203-4219-bb6b-3b9c5a789348"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("a5c99e92-69fc-4047-bcaf-f2ce22dfffbd"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("a911f2dc-8c99-42ea-a817-d1b909d08b9e"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("ac8bf8bb-b749-4e5f-803e-8ad389810274"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("b2b37aff-c7d5-412a-9559-891792fe803d"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("b2f07e84-6d04-42ab-8f9a-5c95ba4329c9"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("b450cb81-decd-48e5-96c6-109074706ea9"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("b609c356-cb1a-4aff-b8ff-13fcd0368559"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("b65a3653-e9ea-43b7-83a6-715eeb60b5bd"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("b884b195-1fa6-434a-b3a0-af1ac1de7c60"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("bbae71f3-a79a-4426-9918-bdb57bb58806"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("bcdc779a-4026-43d3-83d9-aee099e3c6f5"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("be6f513b-8ff6-422e-902e-4adb53186100"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("c0fe8045-0fce-443f-aadb-845cf60f63e2"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("c2700fff-b0f8-4e3f-9450-3a0e8b523083"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("c27af898-42af-4eff-bf56-a4377b6e09a6"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("c414843f-d8ec-4c9e-a0be-9d9d2443f8bb"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("c420b659-be54-4a28-b131-5344c7ac07f3"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("c681cf14-e1ff-4bfe-bacb-07eb14d4729d"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("c706c8cd-d2c5-400a-8aa8-3b537e7cb9c6"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("c7890c8e-8c49-481f-862d-0a7fdc855718"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("c8ad0841-4379-47b7-b33e-dd6e0806faeb"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("cad7fa03-3cbb-46f0-ae04-daa69d04a856"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("d044d52f-3014-43fb-9b7a-6e27125b6c47"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("d17c1c16-81a0-419e-80b9-7d6c871843d6"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("d8cd2124-fd7a-46ad-8feb-0df7b06c412e"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("d8f28655-14fd-4a8c-8276-d4a4b7d8e952"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("d94f2c8e-c9b2-4bff-8c53-c86cc41b5a26"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("e0a864e1-5e4e-48db-8bdd-64cbbefa5046"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("e0c1a02a-4bc4-48cb-9556-a617e2c84023"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("e1c16561-23d0-410f-88c4-f687d0c550e3"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("e3a2cf71-676b-4685-9fee-de6a276c9e35"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("e688f1d2-81f7-4b8f-812c-06edd73834a0"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("e706872a-f6f2-4693-b445-2dd37bc26b0e"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("e89c0901-ee96-4e2d-a2f4-f558336276e9"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("e8ddd435-2464-4c9d-a43f-388b1975f901"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("ec1afd48-270c-4eae-9b2f-1938e675a234"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("fb548886-ac24-4da8-9730-6e47711de250"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("fe51f92f-b49f-4cfb-a98d-739e4f57503e"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: new Guid("3d526281-eadc-4787-b905-b124b02448c9"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: new Guid("488bc0e5-f891-4ceb-b029-5d6744d830c3"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: new Guid("fcf5a7fd-caea-4fbc-b605-77441b9eca6f"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: new Guid("19c8195d-37c1-4d89-9d39-07bf5842e69d"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: new Guid("b582da51-20dd-4fde-aed6-d2f5b1c5b7ab"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: new Guid("f7b8f18b-b6f4-48eb-93aa-afc0e38c435e"));

            migrationBuilder.AlterColumn<string>(
                name: "AssignedUserID",
                table: "Tickets",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentId", "DepartmentName" },
                values: new object[,]
                {
                    { new Guid("1ac4c6a1-8e9d-4a3d-ac88-bab0f5a6a24b"), 0 },
                    { new Guid("2f1abaf1-c572-4a35-8c6a-174a37e73b66"), 2 },
                    { new Guid("7b6ac48d-3a5b-4627-8492-e027489d8147"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "LocationID", "LocationName" },
                values: new object[,]
                {
                    { new Guid("6446f0c3-48cb-4574-850f-1bb231b493dd"), 0 },
                    { new Guid("e3ae9810-d5d6-4623-9fc7-0b1e96ca5f10"), 1 },
                    { new Guid("e8b19c5b-1acd-42f1-a90a-d3092c22054b"), 2 }
                });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "AssetId", "AssetName", "AssignedTo", "BarcodeNumber", "Category", "Condition", "CreatedAt", "DeletedAt", "DepartmentId", "Description", "LocationId", "Processor", "PurchaseCost", "PurchaseDate", "Ram", "SerialNumber", "Storage", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0026da90-a1a9-41fa-933e-576ad76ffbf7"), "Asset 6", "auth0|65a4f8d7364ff592a0792a42", "100000000005", 5, 0, new DateTime(2024, 3, 20, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(991), null, new Guid("2f1abaf1-c572-4a35-8c6a-174a37e73b66"), "Description for Asset 6", new Guid("e8b19c5b-1acd-42f1-a90a-d3092c22054b"), "Intel Core i8", 600m, new DateTime(2024, 3, 20, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(990), "6 GB", "FFFF00006", "6 TB", null },
                    { new Guid("01610c7a-9e93-41c4-88bf-65ff2ed11f50"), "Asset 18", "auth0|65a4f8d7364ff592a0792a42", "100000000017", 3, 2, new DateTime(2024, 3, 8, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(1384), null, new Guid("2f1abaf1-c572-4a35-8c6a-174a37e73b66"), "Description for Asset 18", new Guid("e8b19c5b-1acd-42f1-a90a-d3092c22054b"), "Intel Core i20", 1800m, new DateTime(2024, 3, 8, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(1384), "18 GB", "RRRR00018", "18 TB", null },
                    { new Guid("054b5698-5d00-4f55-9132-ce0f5ea666bd"), "Asset 58", "auth0|65a4f8d7364ff592a0792a42", "100000000057", 1, 2, new DateTime(2024, 1, 28, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(2142), null, new Guid("1ac4c6a1-8e9d-4a3d-ac88-bab0f5a6a24b"), "Description for Asset 58", new Guid("6446f0c3-48cb-4574-850f-1bb231b493dd"), "Intel Core i60", 5800m, new DateTime(2024, 1, 28, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(2141), "58 GB", "FFFF00058", "58 TB", null },
                    { new Guid("0ddf2d45-9f40-4fcd-80a2-5286ec667ad1"), "Asset 46", "auth0|65a4f8d7364ff592a0792a42", "100000000045", 3, 0, new DateTime(2024, 2, 9, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(1923), null, new Guid("1ac4c6a1-8e9d-4a3d-ac88-bab0f5a6a24b"), "Description for Asset 46", new Guid("6446f0c3-48cb-4574-850f-1bb231b493dd"), "Intel Core i48", 4600m, new DateTime(2024, 2, 9, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(1922), "46 GB", "TTTT00046", "46 TB", null },
                    { new Guid("0f50b1be-1daa-4064-9e83-c4ded856a098"), "Asset 9", "auth0|65b7dee72e02f54da98cd265", "100000000008", 1, 3, new DateTime(2024, 3, 17, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(1205), null, new Guid("2f1abaf1-c572-4a35-8c6a-174a37e73b66"), "Description for Asset 9", new Guid("e8b19c5b-1acd-42f1-a90a-d3092c22054b"), "Intel Core i11", 900m, new DateTime(2024, 3, 17, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(1204), "9 GB", "IIII00009", "9 TB", null },
                    { new Guid("0f5e4c81-1dee-4681-9e74-62f77ae22cb4"), "Asset 4", "auth0|65a4fd318d9d565392c4972a", "100000000003", 3, 3, new DateTime(2024, 3, 22, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(957), null, new Guid("1ac4c6a1-8e9d-4a3d-ac88-bab0f5a6a24b"), "Description for Asset 4", new Guid("6446f0c3-48cb-4574-850f-1bb231b493dd"), "Intel Core i6", 400m, new DateTime(2024, 3, 22, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(956), "4 GB", "DDDD00004", "4 TB", null },
                    { new Guid("1106ab56-1576-4138-8521-a0ca8d9492e2"), "Asset 36", "auth0|65a4fd318d9d565392c4972a", "100000000035", 0, 0, new DateTime(2024, 2, 19, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(1717), null, new Guid("2f1abaf1-c572-4a35-8c6a-174a37e73b66"), "Description for Asset 36", new Guid("e8b19c5b-1acd-42f1-a90a-d3092c22054b"), "Intel Core i38", 3600m, new DateTime(2024, 2, 19, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(1717), "36 GB", "JJJJ00036", "36 TB", null },
                    { new Guid("110f2ffa-2825-4b68-b584-707b9c7cc472"), "Asset 47", "auth0|65b7de875bf9ce48b47eedaa", "100000000046", 4, 1, new DateTime(2024, 2, 8, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(1937), null, new Guid("7b6ac48d-3a5b-4627-8492-e027489d8147"), "Description for Asset 47", new Guid("e3ae9810-d5d6-4623-9fc7-0b1e96ca5f10"), "Intel Core i49", 4700m, new DateTime(2024, 2, 8, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(1937), "47 GB", "UUUU00047", "47 TB", null },
                    { new Guid("13a41e4c-47b5-4393-8b01-110462a3d083"), "Asset 32", "auth0|65a4fd318d9d565392c4972a", "100000000031", 3, 1, new DateTime(2024, 2, 23, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(1652), null, new Guid("7b6ac48d-3a5b-4627-8492-e027489d8147"), "Description for Asset 32", new Guid("e3ae9810-d5d6-4623-9fc7-0b1e96ca5f10"), "Intel Core i34", 3200m, new DateTime(2024, 2, 23, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(1651), "32 GB", "FFFF00032", "32 TB", null },
                    { new Guid("1ef348d3-6cef-40c0-8d21-e1b3ac8ba85d"), "Asset 27", "auth0|65b7de875bf9ce48b47eedaa", "100000000026", 5, 1, new DateTime(2024, 2, 28, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(1522), null, new Guid("2f1abaf1-c572-4a35-8c6a-174a37e73b66"), "Description for Asset 27", new Guid("e8b19c5b-1acd-42f1-a90a-d3092c22054b"), "Intel Core i29", 2700m, new DateTime(2024, 2, 28, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(1521), "27 GB", "AAAA00027", "27 TB", null },
                    { new Guid("1f43dce8-8941-4536-bcae-59b78ad071f8"), "Asset 15", "auth0|65b7de875bf9ce48b47eedaa", "100000000014", 0, 4, new DateTime(2024, 3, 11, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(1301), null, new Guid("2f1abaf1-c572-4a35-8c6a-174a37e73b66"), "Description for Asset 15", new Guid("e8b19c5b-1acd-42f1-a90a-d3092c22054b"), "Intel Core i17", 1500m, new DateTime(2024, 3, 11, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(1301), "15 GB", "OOOO00015", "15 TB", null },
                    { new Guid("210513be-95f9-46ce-a1e8-3b5ea08231c7"), "Asset 51", "auth0|65b7de875bf9ce48b47eedaa", "100000000050", 1, 0, new DateTime(2024, 2, 4, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(1998), new DateTime(2024, 2, 4, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(1999), new Guid("2f1abaf1-c572-4a35-8c6a-174a37e73b66"), "Description for Asset 51", new Guid("e8b19c5b-1acd-42f1-a90a-d3092c22054b"), "Intel Core i53", 5100m, new DateTime(2024, 2, 4, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(1997), "51 GB", "YYYY00051", "51 TB", null },
                    { new Guid("22dbcf5e-49f3-451d-8f68-a70d36d5eafc"), "Asset 56", "auth0|65a4fd318d9d565392c4972a", "100000000055", 6, 0, new DateTime(2024, 1, 30, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(2110), null, new Guid("7b6ac48d-3a5b-4627-8492-e027489d8147"), "Description for Asset 56", new Guid("e3ae9810-d5d6-4623-9fc7-0b1e96ca5f10"), "Intel Core i58", 5600m, new DateTime(2024, 1, 30, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(2109), "56 GB", "DDDD00056", "56 TB", null },
                    { new Guid("341f9b78-ce17-42e9-9091-dbefeba89d3b"), "Asset 38", "auth0|65a4f8d7364ff592a0792a42", "100000000037", 2, 2, new DateTime(2024, 2, 17, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(1746), null, new Guid("7b6ac48d-3a5b-4627-8492-e027489d8147"), "Description for Asset 38", new Guid("e3ae9810-d5d6-4623-9fc7-0b1e96ca5f10"), "Intel Core i40", 3800m, new DateTime(2024, 2, 17, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(1745), "38 GB", "LLLL00038", "38 TB", null },
                    { new Guid("414b5098-3cf1-42e8-a3b0-c8648922eb21"), "Asset 55", "auth0|65b7de875bf9ce48b47eedaa", "100000000054", 5, 4, new DateTime(2024, 1, 31, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(2095), null, new Guid("1ac4c6a1-8e9d-4a3d-ac88-bab0f5a6a24b"), "Description for Asset 55", new Guid("6446f0c3-48cb-4574-850f-1bb231b493dd"), "Intel Core i57", 5500m, new DateTime(2024, 1, 31, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(2094), "55 GB", "CCCC00055", "55 TB", null },
                    { new Guid("4610a824-5bae-4dce-ad57-22e6d63ecd30"), "Asset 34", "auth0|65a4f8d7364ff592a0792a42", "100000000033", 5, 3, new DateTime(2024, 2, 21, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(1688), null, new Guid("1ac4c6a1-8e9d-4a3d-ac88-bab0f5a6a24b"), "Description for Asset 34", new Guid("6446f0c3-48cb-4574-850f-1bb231b493dd"), "Intel Core i36", 3400m, new DateTime(2024, 2, 21, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(1687), "34 GB", "HHHH00034", "34 TB", null },
                    { new Guid("4cafe1b0-6478-4509-9433-80cc2a331b22"), "Asset 7", "auth0|65b7de875bf9ce48b47eedaa", "100000000006", 6, 1, new DateTime(2024, 3, 19, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(1122), null, new Guid("1ac4c6a1-8e9d-4a3d-ac88-bab0f5a6a24b"), "Description for Asset 7", new Guid("6446f0c3-48cb-4574-850f-1bb231b493dd"), "Intel Core i9", 700m, new DateTime(2024, 3, 19, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(1121), "7 GB", "GGGG00007", "7 TB", null },
                    { new Guid("4f7996f8-66bb-49c9-875e-2cddf0c6dd31"), "Asset 60", "auth0|65a4fd318d9d565392c4972a", "100000000059", 3, 4, new DateTime(2024, 1, 26, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(2170), null, new Guid("2f1abaf1-c572-4a35-8c6a-174a37e73b66"), "Description for Asset 60", new Guid("e8b19c5b-1acd-42f1-a90a-d3092c22054b"), "Intel Core i62", 6000m, new DateTime(2024, 1, 26, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(2170), "60 GB", "HHHH00060", "60 TB", null },
                    { new Guid("53b1cab2-6315-4281-800d-1338b8df64d8"), "Asset 63", "auth0|65b7de875bf9ce48b47eedaa", "100000000062", 6, 2, new DateTime(2024, 1, 23, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(2215), null, new Guid("2f1abaf1-c572-4a35-8c6a-174a37e73b66"), "Description for Asset 63", new Guid("e8b19c5b-1acd-42f1-a90a-d3092c22054b"), "Intel Core i65", 6300m, new DateTime(2024, 1, 23, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(2214), "63 GB", "KKKK00063", "63 TB", null },
                    { new Guid("57c29b52-3614-4f45-80da-9f9f0c0be1cc"), "Asset 50", "auth0|65a4f8d7364ff592a0792a42", "100000000049", 0, 4, new DateTime(2024, 2, 5, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(1984), null, new Guid("7b6ac48d-3a5b-4627-8492-e027489d8147"), "Description for Asset 50", new Guid("e3ae9810-d5d6-4623-9fc7-0b1e96ca5f10"), "Intel Core i52", 5000m, new DateTime(2024, 2, 5, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(1983), "50 GB", "XXXX00050", "50 TB", null },
                    { new Guid("5a9cd035-c05b-484a-b4da-ee400ac432b2"), "Asset 24", "auth0|65a4fd318d9d565392c4972a", "100000000023", 2, 3, new DateTime(2024, 3, 2, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(1474), null, new Guid("2f1abaf1-c572-4a35-8c6a-174a37e73b66"), "Description for Asset 24", new Guid("e8b19c5b-1acd-42f1-a90a-d3092c22054b"), "Intel Core i26", 2400m, new DateTime(2024, 3, 2, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(1473), "24 GB", "XXXX00024", "24 TB", null },
                    { new Guid("5cea12db-210f-424f-9310-a9594619b930"), "Asset 69", "auth0|65b7dee72e02f54da98cd265", "100000000068", 5, 3, new DateTime(2024, 1, 17, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(2332), null, new Guid("2f1abaf1-c572-4a35-8c6a-174a37e73b66"), "Description for Asset 69", new Guid("e8b19c5b-1acd-42f1-a90a-d3092c22054b"), "Intel Core i71", 6900m, new DateTime(2024, 1, 17, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(2331), "69 GB", "QQQQ00069", "69 TB", null },
                    { new Guid("5da46ea0-bac0-4152-b19d-5aec098d62ae"), "Asset 66", "auth0|65a4f8d7364ff592a0792a42", "100000000065", 2, 0, new DateTime(2024, 1, 20, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(2289), null, new Guid("2f1abaf1-c572-4a35-8c6a-174a37e73b66"), "Description for Asset 66", new Guid("e8b19c5b-1acd-42f1-a90a-d3092c22054b"), "Intel Core i68", 6600m, new DateTime(2024, 1, 20, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(2288), "66 GB", "NNNN00066", "66 TB", null },
                    { new Guid("63f070ef-1274-4658-b44a-96cc2c6ea907"), "Asset 20", "auth0|65a4fd318d9d565392c4972a", "100000000019", 5, 4, new DateTime(2024, 3, 6, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(1416), null, new Guid("7b6ac48d-3a5b-4627-8492-e027489d8147"), "Description for Asset 20", new Guid("e3ae9810-d5d6-4623-9fc7-0b1e96ca5f10"), "Intel Core i22", 2000m, new DateTime(2024, 3, 6, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(1415), "20 GB", "TTTT00020", "20 TB", null },
                    { new Guid("64b45b41-2ae7-4798-93cd-b226d2340502"), "Asset 54", "auth0|65a4f8d7364ff592a0792a42", "100000000053", 4, 3, new DateTime(2024, 2, 1, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(2080), null, new Guid("2f1abaf1-c572-4a35-8c6a-174a37e73b66"), "Description for Asset 54", new Guid("e8b19c5b-1acd-42f1-a90a-d3092c22054b"), "Intel Core i56", 5400m, new DateTime(2024, 2, 1, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(2079), "54 GB", "BBBB00054", "54 TB", null },
                    { new Guid("66fa74a2-72e3-4847-ad07-51c4f5daeb40"), "Asset 45", "auth0|65b7dee72e02f54da98cd265", "100000000044", 2, 4, new DateTime(2024, 2, 10, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(1909), null, new Guid("2f1abaf1-c572-4a35-8c6a-174a37e73b66"), "Description for Asset 45", new Guid("e8b19c5b-1acd-42f1-a90a-d3092c22054b"), "Intel Core i47", 4500m, new DateTime(2024, 2, 10, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(1908), "45 GB", "SSSS00045", "45 TB", null },
                    { new Guid("696346f6-5cf4-4bcf-997b-f7541af90e31"), "Asset 13", "auth0|65b7dee72e02f54da98cd265", "100000000012", 5, 2, new DateTime(2024, 3, 13, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(1273), null, new Guid("1ac4c6a1-8e9d-4a3d-ac88-bab0f5a6a24b"), "Description for Asset 13", new Guid("6446f0c3-48cb-4574-850f-1bb231b493dd"), "Intel Core i15", 1300m, new DateTime(2024, 3, 13, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(1272), "13 GB", "MMMM00013", "13 TB", null },
                    { new Guid("6b414c7d-3fed-4932-a291-c7af0a50d852"), "Asset 31", "auth0|65b7de875bf9ce48b47eedaa", "100000000030", 2, 0, new DateTime(2024, 2, 24, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(1636), new DateTime(2024, 2, 24, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(1637), new Guid("1ac4c6a1-8e9d-4a3d-ac88-bab0f5a6a24b"), "Description for Asset 31", new Guid("6446f0c3-48cb-4574-850f-1bb231b493dd"), "Intel Core i33", 3100m, new DateTime(2024, 2, 24, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(1634), "31 GB", "EEEE00031", "31 TB", null },
                    { new Guid("72e10416-635b-4d83-a77b-d572193637da"), "Asset 44", "auth0|65a4fd318d9d565392c4972a", "100000000043", 1, 3, new DateTime(2024, 2, 11, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(1894), null, new Guid("7b6ac48d-3a5b-4627-8492-e027489d8147"), "Description for Asset 44", new Guid("e3ae9810-d5d6-4623-9fc7-0b1e96ca5f10"), "Intel Core i46", 4400m, new DateTime(2024, 2, 11, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(1893), "44 GB", "RRRR00044", "44 TB", null },
                    { new Guid("76b28a73-a636-49f8-8b00-e9beb754a1d0"), "Asset 53", "auth0|65b7dee72e02f54da98cd265", "100000000052", 3, 2, new DateTime(2024, 2, 2, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(2029), null, new Guid("7b6ac48d-3a5b-4627-8492-e027489d8147"), "Description for Asset 53", new Guid("e3ae9810-d5d6-4623-9fc7-0b1e96ca5f10"), "Intel Core i55", 5300m, new DateTime(2024, 2, 2, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(2028), "53 GB", "AAAA00053", "53 TB", null },
                    { new Guid("7e0d6368-b609-43da-ad5f-1be2ebaa2301"), "Asset 10", "auth0|65a4f8d7364ff592a0792a42", "100000000009", 2, 4, new DateTime(2024, 3, 16, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(1228), null, new Guid("1ac4c6a1-8e9d-4a3d-ac88-bab0f5a6a24b"), "Description for Asset 10", new Guid("6446f0c3-48cb-4574-850f-1bb231b493dd"), "Intel Core i12", 1000m, new DateTime(2024, 3, 16, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(1227), "10 GB", "JJJJ00010", "10 TB", null },
                    { new Guid("7e6932ef-fe3a-4e22-bf03-be4c9fb40b68"), "Asset 17", "auth0|65b7dee72e02f54da98cd265", "100000000016", 2, 1, new DateTime(2024, 3, 9, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(1331), null, new Guid("7b6ac48d-3a5b-4627-8492-e027489d8147"), "Description for Asset 17", new Guid("e3ae9810-d5d6-4623-9fc7-0b1e96ca5f10"), "Intel Core i19", 1700m, new DateTime(2024, 3, 9, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(1330), "17 GB", "QQQQ00017", "17 TB", null },
                    { new Guid("7ec48e58-03e0-42ef-b69d-3ca5d36a540d"), "Asset 28", "auth0|65a4fd318d9d565392c4972a", "100000000027", 6, 2, new DateTime(2024, 2, 27, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(1536), null, new Guid("1ac4c6a1-8e9d-4a3d-ac88-bab0f5a6a24b"), "Description for Asset 28", new Guid("6446f0c3-48cb-4574-850f-1bb231b493dd"), "Intel Core i30", 2800m, new DateTime(2024, 2, 27, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(1535), "28 GB", "BBBB00028", "28 TB", null },
                    { new Guid("8503793e-1bda-496e-a1da-3cf84041704b"), "Asset 11", "auth0|65b7de875bf9ce48b47eedaa", "100000000010", 3, 0, new DateTime(2024, 3, 15, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(1242), new DateTime(2024, 3, 15, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(1243), new Guid("7b6ac48d-3a5b-4627-8492-e027489d8147"), "Description for Asset 11", new Guid("e3ae9810-d5d6-4623-9fc7-0b1e96ca5f10"), "Intel Core i13", 1100m, new DateTime(2024, 3, 15, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(1242), "11 GB", "KKKK00011", "11 TB", null },
                    { new Guid("85ce4a6a-a305-426a-9e29-f817f44c98a8"), "Asset 67", "auth0|65b7de875bf9ce48b47eedaa", "100000000066", 3, 1, new DateTime(2024, 1, 19, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(2303), null, new Guid("1ac4c6a1-8e9d-4a3d-ac88-bab0f5a6a24b"), "Description for Asset 67", new Guid("6446f0c3-48cb-4574-850f-1bb231b493dd"), "Intel Core i69", 6700m, new DateTime(2024, 1, 19, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(2302), "67 GB", "OOOO00067", "67 TB", null },
                    { new Guid("86af32ca-f862-4f98-a7c2-e7ba19619301"), "Asset 23", "auth0|65b7de875bf9ce48b47eedaa", "100000000022", 1, 2, new DateTime(2024, 3, 3, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(1460), null, new Guid("7b6ac48d-3a5b-4627-8492-e027489d8147"), "Description for Asset 23", new Guid("e3ae9810-d5d6-4623-9fc7-0b1e96ca5f10"), "Intel Core i25", 2300m, new DateTime(2024, 3, 3, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(1459), "23 GB", "WWWW00023", "23 TB", null },
                    { new Guid("880f1059-f46d-4d66-baea-a8a75b787d24"), "Asset 64", "auth0|65a4fd318d9d565392c4972a", "100000000063", 0, 3, new DateTime(2024, 1, 22, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(2230), null, new Guid("1ac4c6a1-8e9d-4a3d-ac88-bab0f5a6a24b"), "Description for Asset 64", new Guid("6446f0c3-48cb-4574-850f-1bb231b493dd"), "Intel Core i66", 6400m, new DateTime(2024, 1, 22, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(2229), "64 GB", "LLLL00064", "64 TB", null },
                    { new Guid("89155141-a366-44db-b0a4-4376ec44dcfe"), "Asset 35", "auth0|65b7de875bf9ce48b47eedaa", "100000000034", 6, 4, new DateTime(2024, 2, 20, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(1702), null, new Guid("7b6ac48d-3a5b-4627-8492-e027489d8147"), "Description for Asset 35", new Guid("e3ae9810-d5d6-4623-9fc7-0b1e96ca5f10"), "Intel Core i37", 3500m, new DateTime(2024, 2, 20, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(1701), "35 GB", "IIII00035", "35 TB", null },
                    { new Guid("94c5d955-ff84-44ba-8297-4212f5a2eb57"), "Asset 30", "auth0|65a4f8d7364ff592a0792a42", "100000000029", 1, 4, new DateTime(2024, 2, 25, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(1565), null, new Guid("2f1abaf1-c572-4a35-8c6a-174a37e73b66"), "Description for Asset 30", new Guid("e8b19c5b-1acd-42f1-a90a-d3092c22054b"), "Intel Core i32", 3000m, new DateTime(2024, 2, 25, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(1564), "30 GB", "DDDD00030", "30 TB", null },
                    { new Guid("96013f50-c6e1-4e8d-a6e4-d8ac93bdbdb8"), "Asset 70", "auth0|65a4f8d7364ff592a0792a42", "100000000069", 6, 4, new DateTime(2024, 1, 16, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(2346), null, new Guid("1ac4c6a1-8e9d-4a3d-ac88-bab0f5a6a24b"), "Description for Asset 70", new Guid("6446f0c3-48cb-4574-850f-1bb231b493dd"), "Intel Core i72", 7000m, new DateTime(2024, 1, 16, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(2345), "70 GB", "RRRR00070", "70 TB", null },
                    { new Guid("98781be4-7ee0-4934-b14f-51bfad3972e6"), "Asset 68", "auth0|65a4fd318d9d565392c4972a", "100000000067", 4, 2, new DateTime(2024, 1, 18, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(2318), null, new Guid("7b6ac48d-3a5b-4627-8492-e027489d8147"), "Description for Asset 68", new Guid("e3ae9810-d5d6-4623-9fc7-0b1e96ca5f10"), "Intel Core i70", 6800m, new DateTime(2024, 1, 18, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(2317), "68 GB", "PPPP00068", "68 TB", null },
                    { new Guid("9c4027f3-ed3b-49ca-8dd3-4332a7c29541"), "Asset 61", "auth0|65b7dee72e02f54da98cd265", "100000000060", 4, 0, new DateTime(2024, 1, 25, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(2185), new DateTime(2024, 1, 25, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(2186), new Guid("1ac4c6a1-8e9d-4a3d-ac88-bab0f5a6a24b"), "Description for Asset 61", new Guid("6446f0c3-48cb-4574-850f-1bb231b493dd"), "Intel Core i63", 6100m, new DateTime(2024, 1, 25, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(2184), "61 GB", "IIII00061", "61 TB", null },
                    { new Guid("9f00fd1f-21b1-47d1-ba85-c6f855d7fd17"), "Asset 48", "auth0|65a4fd318d9d565392c4972a", "100000000047", 5, 2, new DateTime(2024, 2, 7, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(1952), null, new Guid("2f1abaf1-c572-4a35-8c6a-174a37e73b66"), "Description for Asset 48", new Guid("e8b19c5b-1acd-42f1-a90a-d3092c22054b"), "Intel Core i50", 4800m, new DateTime(2024, 2, 7, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(1951), "48 GB", "VVVV00048", "48 TB", null },
                    { new Guid("a1952de2-fdf7-469f-bae6-092993cb4c01"), "Asset 43", "auth0|65b7de875bf9ce48b47eedaa", "100000000042", 0, 2, new DateTime(2024, 2, 12, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(1880), null, new Guid("1ac4c6a1-8e9d-4a3d-ac88-bab0f5a6a24b"), "Description for Asset 43", new Guid("6446f0c3-48cb-4574-850f-1bb231b493dd"), "Intel Core i45", 4300m, new DateTime(2024, 2, 12, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(1879), "43 GB", "QQQQ00043", "43 TB", null },
                    { new Guid("a6e966cd-eb16-403e-93ce-0a7f7e318a6b"), "Asset 25", "auth0|65b7dee72e02f54da98cd265", "100000000024", 3, 4, new DateTime(2024, 3, 1, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(1488), null, new Guid("1ac4c6a1-8e9d-4a3d-ac88-bab0f5a6a24b"), "Description for Asset 25", new Guid("6446f0c3-48cb-4574-850f-1bb231b493dd"), "Intel Core i27", 2500m, new DateTime(2024, 3, 1, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(1488), "25 GB", "YYYY00025", "25 TB", null },
                    { new Guid("a8ad6597-7b4a-46d9-a2ff-647b86e7da1c"), "Asset 12", "auth0|65a4fd318d9d565392c4972a", "100000000011", 4, 1, new DateTime(2024, 3, 14, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(1258), null, new Guid("2f1abaf1-c572-4a35-8c6a-174a37e73b66"), "Description for Asset 12", new Guid("e8b19c5b-1acd-42f1-a90a-d3092c22054b"), "Intel Core i14", 1200m, new DateTime(2024, 3, 14, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(1257), "12 GB", "LLLL00012", "12 TB", null },
                    { new Guid("aabac3ed-cd23-437e-9977-9f263cea7b12"), "Asset 39", "auth0|65b7de875bf9ce48b47eedaa", "100000000038", 3, 3, new DateTime(2024, 2, 16, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(1760), null, new Guid("2f1abaf1-c572-4a35-8c6a-174a37e73b66"), "Description for Asset 39", new Guid("e8b19c5b-1acd-42f1-a90a-d3092c22054b"), "Intel Core i41", 3900m, new DateTime(2024, 2, 16, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(1760), "39 GB", "MMMM00039", "39 TB", null },
                    { new Guid("b05c44eb-7568-4523-be49-08105fbb1106"), "Asset 57", "auth0|65b7dee72e02f54da98cd265", "100000000056", 0, 1, new DateTime(2024, 1, 29, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(2124), null, new Guid("2f1abaf1-c572-4a35-8c6a-174a37e73b66"), "Description for Asset 57", new Guid("e8b19c5b-1acd-42f1-a90a-d3092c22054b"), "Intel Core i59", 5700m, new DateTime(2024, 1, 29, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(2123), "57 GB", "EEEE00057", "57 TB", null },
                    { new Guid("b574cdb9-8ceb-4fd4-8e8f-2c1512aa907f"), "Asset 42", "auth0|65a4f8d7364ff592a0792a42", "100000000041", 6, 1, new DateTime(2024, 2, 13, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(1866), null, new Guid("2f1abaf1-c572-4a35-8c6a-174a37e73b66"), "Description for Asset 42", new Guid("e8b19c5b-1acd-42f1-a90a-d3092c22054b"), "Intel Core i44", 4200m, new DateTime(2024, 2, 13, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(1865), "42 GB", "PPPP00042", "42 TB", null },
                    { new Guid("be37261d-62bb-4d93-8982-4411941de97b"), "Asset 62", "auth0|65a4f8d7364ff592a0792a42", "100000000061", 5, 1, new DateTime(2024, 1, 24, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(2200), null, new Guid("7b6ac48d-3a5b-4627-8492-e027489d8147"), "Description for Asset 62", new Guid("e3ae9810-d5d6-4623-9fc7-0b1e96ca5f10"), "Intel Core i64", 6200m, new DateTime(2024, 1, 24, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(2200), "62 GB", "JJJJ00062", "62 TB", null },
                    { new Guid("c049086d-9699-4ee0-ab6b-f1a4802b03ee"), "Asset 16", "auth0|65a4fd318d9d565392c4972a", "100000000015", 1, 0, new DateTime(2024, 3, 10, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(1316), null, new Guid("1ac4c6a1-8e9d-4a3d-ac88-bab0f5a6a24b"), "Description for Asset 16", new Guid("6446f0c3-48cb-4574-850f-1bb231b493dd"), "Intel Core i18", 1600m, new DateTime(2024, 3, 10, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(1315), "16 GB", "PPPP00016", "16 TB", null },
                    { new Guid("c3bc7db1-01e3-45b3-a534-5411c807285e"), "Asset 52", "auth0|65a4fd318d9d565392c4972a", "100000000051", 2, 1, new DateTime(2024, 2, 3, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(2014), null, new Guid("1ac4c6a1-8e9d-4a3d-ac88-bab0f5a6a24b"), "Description for Asset 52", new Guid("6446f0c3-48cb-4574-850f-1bb231b493dd"), "Intel Core i54", 5200m, new DateTime(2024, 2, 3, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(2013), "52 GB", "ZZZZ00052", "52 TB", null },
                    { new Guid("c4d38b52-d1a2-4a0e-8de5-85eb2fcd6604"), "Asset 21", "auth0|65b7dee72e02f54da98cd265", "100000000020", 6, 0, new DateTime(2024, 3, 5, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(1430), new DateTime(2024, 3, 5, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(1431), new Guid("2f1abaf1-c572-4a35-8c6a-174a37e73b66"), "Description for Asset 21", new Guid("e8b19c5b-1acd-42f1-a90a-d3092c22054b"), "Intel Core i23", 2100m, new DateTime(2024, 3, 5, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(1429), "21 GB", "UUUU00021", "21 TB", null },
                    { new Guid("c7f7d3d3-2f4d-4e85-9e35-74e23e44d5f9"), "Asset 22", "auth0|65a4f8d7364ff592a0792a42", "100000000021", 0, 1, new DateTime(2024, 3, 4, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(1445), null, new Guid("1ac4c6a1-8e9d-4a3d-ac88-bab0f5a6a24b"), "Description for Asset 22", new Guid("6446f0c3-48cb-4574-850f-1bb231b493dd"), "Intel Core i24", 2200m, new DateTime(2024, 3, 4, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(1445), "22 GB", "VVVV00022", "22 TB", null },
                    { new Guid("ccbe957a-8557-47e4-9c99-ddccae845545"), "Asset 40", "auth0|65a4fd318d9d565392c4972a", "100000000039", 4, 4, new DateTime(2024, 2, 15, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(1775), null, new Guid("1ac4c6a1-8e9d-4a3d-ac88-bab0f5a6a24b"), "Description for Asset 40", new Guid("6446f0c3-48cb-4574-850f-1bb231b493dd"), "Intel Core i42", 4000m, new DateTime(2024, 2, 15, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(1775), "40 GB", "NNNN00040", "40 TB", null },
                    { new Guid("ccebfce7-bf7e-4f44-a049-f78059d28a18"), "Asset 29", "auth0|65b7dee72e02f54da98cd265", "100000000028", 0, 3, new DateTime(2024, 2, 26, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(1550), null, new Guid("7b6ac48d-3a5b-4627-8492-e027489d8147"), "Description for Asset 29", new Guid("e3ae9810-d5d6-4623-9fc7-0b1e96ca5f10"), "Intel Core i31", 2900m, new DateTime(2024, 2, 26, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(1550), "29 GB", "CCCC00029", "29 TB", null },
                    { new Guid("d09ff1a6-375a-4c6b-b790-bb322b576874"), "Asset 37", "auth0|65b7dee72e02f54da98cd265", "100000000036", 1, 1, new DateTime(2024, 2, 18, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(1731), null, new Guid("1ac4c6a1-8e9d-4a3d-ac88-bab0f5a6a24b"), "Description for Asset 37", new Guid("6446f0c3-48cb-4574-850f-1bb231b493dd"), "Intel Core i39", 3700m, new DateTime(2024, 2, 18, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(1731), "37 GB", "KKKK00037", "37 TB", null },
                    { new Guid("d7657a73-2859-4353-95a2-c720d5341882"), "Asset 65", "auth0|65b7dee72e02f54da98cd265", "100000000064", 1, 4, new DateTime(2024, 1, 21, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(2268), null, new Guid("7b6ac48d-3a5b-4627-8492-e027489d8147"), "Description for Asset 65", new Guid("e3ae9810-d5d6-4623-9fc7-0b1e96ca5f10"), "Intel Core i67", 6500m, new DateTime(2024, 1, 21, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(2267), "65 GB", "MMMM00065", "65 TB", null },
                    { new Guid("da962695-902b-40ef-a0ca-2ea3599659e8"), "Asset 59", "auth0|65b7de875bf9ce48b47eedaa", "100000000058", 2, 3, new DateTime(2024, 1, 27, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(2156), null, new Guid("7b6ac48d-3a5b-4627-8492-e027489d8147"), "Description for Asset 59", new Guid("e3ae9810-d5d6-4623-9fc7-0b1e96ca5f10"), "Intel Core i61", 5900m, new DateTime(2024, 1, 27, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(2155), "59 GB", "GGGG00059", "59 TB", null },
                    { new Guid("dcc3349d-654c-4415-8815-cedcbc349126"), "Asset 14", "auth0|65a4f8d7364ff592a0792a42", "100000000013", 6, 3, new DateTime(2024, 3, 12, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(1287), null, new Guid("7b6ac48d-3a5b-4627-8492-e027489d8147"), "Description for Asset 14", new Guid("e3ae9810-d5d6-4623-9fc7-0b1e96ca5f10"), "Intel Core i16", 1400m, new DateTime(2024, 3, 12, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(1286), "14 GB", "NNNN00014", "14 TB", null },
                    { new Guid("e6a5501a-de17-4657-a9d3-9aa5b74f862c"), "Asset 8", "auth0|65a4fd318d9d565392c4972a", "100000000007", 0, 2, new DateTime(2024, 3, 18, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(1188), null, new Guid("7b6ac48d-3a5b-4627-8492-e027489d8147"), "Description for Asset 8", new Guid("e3ae9810-d5d6-4623-9fc7-0b1e96ca5f10"), "Intel Core i10", 800m, new DateTime(2024, 3, 18, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(1187), "8 GB", "HHHH00008", "8 TB", null },
                    { new Guid("e7658228-f102-46ce-ad6d-eb770c11ddee"), "Asset 33", "auth0|65b7dee72e02f54da98cd265", "100000000032", 4, 2, new DateTime(2024, 2, 22, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(1668), null, new Guid("2f1abaf1-c572-4a35-8c6a-174a37e73b66"), "Description for Asset 33", new Guid("e8b19c5b-1acd-42f1-a90a-d3092c22054b"), "Intel Core i35", 3300m, new DateTime(2024, 2, 22, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(1667), "33 GB", "GGGG00033", "33 TB", null },
                    { new Guid("e954c356-7846-4438-95ad-efce405cbe87"), "Asset 3", "auth0|65b7de875bf9ce48b47eedaa", "100000000002", 2, 2, new DateTime(2024, 3, 23, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(943), null, new Guid("2f1abaf1-c572-4a35-8c6a-174a37e73b66"), "Description for Asset 3", new Guid("e8b19c5b-1acd-42f1-a90a-d3092c22054b"), "Intel Core i5", 300m, new DateTime(2024, 3, 23, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(942), "3 GB", "CCCC00003", "3 TB", null },
                    { new Guid("ec4337d3-7aa8-4396-831e-4eb510aa5bb1"), "Asset 49", "auth0|65b7dee72e02f54da98cd265", "100000000048", 6, 3, new DateTime(2024, 2, 6, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(1966), null, new Guid("1ac4c6a1-8e9d-4a3d-ac88-bab0f5a6a24b"), "Description for Asset 49", new Guid("6446f0c3-48cb-4574-850f-1bb231b493dd"), "Intel Core i51", 4900m, new DateTime(2024, 2, 6, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(1965), "49 GB", "WWWW00049", "49 TB", null },
                    { new Guid("eeb7f210-bf39-4d83-83f2-ffa564208f5a"), "Asset 1", "auth0|65b7dee72e02f54da98cd265", "100000000000", 0, 0, new DateTime(2024, 3, 25, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(882), new DateTime(2024, 3, 25, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(885), new Guid("1ac4c6a1-8e9d-4a3d-ac88-bab0f5a6a24b"), "Description for Asset 1", new Guid("6446f0c3-48cb-4574-850f-1bb231b493dd"), "Intel Core i3", 100m, new DateTime(2024, 3, 25, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(857), "1 GB", "AAAA00001", "1 TB", null },
                    { new Guid("eff36b81-3f39-4232-9410-85391584d000"), "Asset 2", "auth0|65a4f8d7364ff592a0792a42", "100000000001", 1, 1, new DateTime(2024, 3, 24, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(926), null, new Guid("7b6ac48d-3a5b-4627-8492-e027489d8147"), "Description for Asset 2", new Guid("e3ae9810-d5d6-4623-9fc7-0b1e96ca5f10"), "Intel Core i4", 200m, new DateTime(2024, 3, 24, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(925), "2 GB", "BBBB00002", "2 TB", null },
                    { new Guid("f0b38660-d5db-4f9d-9729-94358cb7bdb5"), "Asset 19", "auth0|65b7de875bf9ce48b47eedaa", "100000000018", 4, 3, new DateTime(2024, 3, 7, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(1400), null, new Guid("1ac4c6a1-8e9d-4a3d-ac88-bab0f5a6a24b"), "Description for Asset 19", new Guid("6446f0c3-48cb-4574-850f-1bb231b493dd"), "Intel Core i21", 1900m, new DateTime(2024, 3, 7, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(1400), "19 GB", "SSSS00019", "19 TB", null },
                    { new Guid("f7358570-ea64-4912-81b3-d3ef3a255b2e"), "Asset 41", "auth0|65b7dee72e02f54da98cd265", "100000000040", 5, 0, new DateTime(2024, 2, 14, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(1846), new DateTime(2024, 2, 14, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(1847), new Guid("7b6ac48d-3a5b-4627-8492-e027489d8147"), "Description for Asset 41", new Guid("e3ae9810-d5d6-4623-9fc7-0b1e96ca5f10"), "Intel Core i43", 4100m, new DateTime(2024, 2, 14, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(1846), "41 GB", "OOOO00041", "41 TB", null },
                    { new Guid("f79631e3-8401-451f-b49a-94a6b358807b"), "Asset 5", "auth0|65b7dee72e02f54da98cd265", "100000000004", 4, 4, new DateTime(2024, 3, 21, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(973), null, new Guid("7b6ac48d-3a5b-4627-8492-e027489d8147"), "Description for Asset 5", new Guid("e3ae9810-d5d6-4623-9fc7-0b1e96ca5f10"), "Intel Core i7", 500m, new DateTime(2024, 3, 21, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(972), "5 GB", "EEEE00005", "5 TB", null },
                    { new Guid("f8b91952-2bf0-4a59-9cd9-5e1f784eb79e"), "Asset 26", "auth0|65a4f8d7364ff592a0792a42", "100000000025", 4, 0, new DateTime(2024, 2, 29, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(1507), null, new Guid("7b6ac48d-3a5b-4627-8492-e027489d8147"), "Description for Asset 26", new Guid("e3ae9810-d5d6-4623-9fc7-0b1e96ca5f10"), "Intel Core i28", 2600m, new DateTime(2024, 2, 29, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(1506), "26 GB", "ZZZZ00026", "26 TB", null }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "TicketId", "AssetID", "AssignedUserID", "Category", "ClosedAt", "CompletedAt", "CreatedAt", "CreatedBy", "Description", "Priority", "Status", "Title" },
                values: new object[,]
                {
                    { new Guid("01062072-d694-4fb3-a358-c31dc50a5ae5"), new Guid("a6e966cd-eb16-403e-93ce-0a7f7e318a6b"), "auth0|65b7de875bf9ce48b47eedaa", 2, new DateTime(2023, 12, 24, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2713), new DateTime(2023, 12, 23, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2712), new DateTime(2023, 12, 22, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2714), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 95", 1, 2, "Ticket 95" },
                    { new Guid("010badc9-56f1-4776-8397-84cd26a534e0"), new Guid("9f00fd1f-21b1-47d1-ba85-c6f855d7fd17"), "auth0|65a4fd318d9d565392c4972a", 3, null, null, new DateTime(2024, 2, 7, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1959), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 48", 2, 3, "Ticket 48" },
                    { new Guid("0380a602-a367-458e-9ca3-76d6d4c57721"), new Guid("13a41e4c-47b5-4393-8b01-110462a3d083"), "auth0|65a4fd318d9d565392c4972a", 3, null, null, new DateTime(2024, 2, 23, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1681), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 32", 1, 3, "Ticket 32" },
                    { new Guid("0410e3fb-2149-4b61-9f11-733a5064b478"), new Guid("0f50b1be-1daa-4064-9e83-c4ded856a098"), "auth0|65b7dee72e02f54da98cd265", 0, new DateTime(2024, 3, 19, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1347), new DateTime(2024, 3, 18, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1347), new DateTime(2024, 3, 17, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1348), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 9", 2, 0, "Ticket 9" },
                    { new Guid("056193b5-13d4-4a57-9617-a961586196bc"), new Guid("0f50b1be-1daa-4064-9e83-c4ded856a098"), "auth0|65b7de875bf9ce48b47eedaa", 2, new DateTime(2024, 1, 9, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2382), new DateTime(2024, 1, 8, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2381), new DateTime(2024, 1, 7, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2382), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 79", 0, 2, "Ticket 79" },
                    { new Guid("05fa75cc-3a79-4f29-9efb-2a6891a1dea5"), new Guid("57c29b52-3614-4f45-80da-9f9f0c0be1cc"), "auth0|65a4f8d7364ff592a0792a42", 1, null, null, new DateTime(2023, 9, 18, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4060), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 190", 0, 1, "Ticket 190" },
                    { new Guid("07722522-2edf-4dc0-8f1a-30aed6d0aa57"), new Guid("414b5098-3cf1-42e8-a3b0-c8648922eb21"), "auth0|65b7de875bf9ce48b47eedaa", 2, new DateTime(2024, 2, 2, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2077), new DateTime(2024, 2, 1, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2076), new DateTime(2024, 1, 31, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2078), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 55", 0, 2, "Ticket 55" },
                    { new Guid("08bf07e3-2971-4c11-aeaf-0c0f434b99ba"), new Guid("da962695-902b-40ef-a0ca-2ea3599659e8"), "auth0|65b7dee72e02f54da98cd265", 0, new DateTime(2023, 11, 20, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3159), new DateTime(2023, 11, 19, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3158), new DateTime(2023, 11, 18, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3159), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 129", 2, 0, "Ticket 129" },
                    { new Guid("095b8eef-8362-4365-bbc5-8e609289325d"), new Guid("7e0d6368-b609-43da-ad5f-1be2ebaa2301"), "auth0|65a4fd318d9d565392c4972a", 3, null, null, new DateTime(2023, 8, 19, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4451), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 220", 0, 3, "Ticket 220" },
                    { new Guid("0b48a14c-0cbe-470d-ab3e-974dd1ca2c42"), new Guid("1f43dce8-8941-4536-bcae-59b78ad071f8"), "auth0|65b7dee72e02f54da98cd265", 0, new DateTime(2024, 1, 3, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2453), new DateTime(2024, 1, 2, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2452), new DateTime(2024, 1, 1, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2453), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 85", 0, 0, "Ticket 85" },
                    { new Guid("0b7518e2-2b1e-46a0-bd1a-94fc47cfd890"), new Guid("d09ff1a6-375a-4c6b-b790-bb322b576874"), "auth0|65b7dee72e02f54da98cd265", 0, new DateTime(2024, 2, 20, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1831), new DateTime(2024, 2, 19, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1830), new DateTime(2024, 2, 18, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1832), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 37", 0, 0, "Ticket 37" },
                    { new Guid("0c4c1a7d-8c6d-4f46-91c7-9ba06384fed2"), new Guid("eeb7f210-bf39-4d83-83f2-ffa564208f5a"), "auth0|65b7dee72e02f54da98cd265", 0, new DateTime(2023, 11, 8, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3332), new DateTime(2023, 11, 7, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3331), new DateTime(2023, 11, 6, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3333), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 141", 2, 0, "Ticket 141" },
                    { new Guid("0c87c915-db69-4953-b9d8-c05c3a558ebe"), new Guid("5cea12db-210f-424f-9310-a9594619b930"), "auth0|65b7dee72e02f54da98cd265", 0, new DateTime(2024, 1, 19, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2264), new DateTime(2024, 1, 18, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2263), new DateTime(2024, 1, 17, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2264), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 69", 2, 0, "Ticket 69" },
                    { new Guid("0cc5d87b-526b-4f80-9faa-cafd69fda329"), new Guid("eeb7f210-bf39-4d83-83f2-ffa564208f5a"), "auth0|65b7de875bf9ce48b47eedaa", 2, new DateTime(2024, 1, 17, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2287), new DateTime(2024, 1, 16, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2286), new DateTime(2024, 1, 15, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2288), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 71", 1, 2, "Ticket 71" },
                    { new Guid("10a10bf6-9665-4eed-8626-2904fb8336f9"), new Guid("6b414c7d-3fed-4932-a291-c7af0a50d852"), "auth0|65b7de875bf9ce48b47eedaa", 2, new DateTime(2023, 10, 9, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3768), new DateTime(2023, 10, 8, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3767), new DateTime(2023, 10, 7, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3769), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 171", 2, 2, "Ticket 171" },
                    { new Guid("1339934c-68e4-4907-80ef-1e9b4a4e018a"), new Guid("e6a5501a-de17-4657-a9d3-9aa5b74f862c"), "auth0|65a4f8d7364ff592a0792a42", 1, null, null, new DateTime(2024, 1, 8, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2371), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 78", 2, 1, "Ticket 78" },
                    { new Guid("1359ac47-dacc-48ea-922b-862ce7739b99"), new Guid("63f070ef-1274-4658-b44a-96cc2c6ea907"), "auth0|65a4fd318d9d565392c4972a", 3, null, null, new DateTime(2024, 3, 6, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1485), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 20", 1, 3, "Ticket 20" },
                    { new Guid("13e8a347-ff2d-454a-b392-9344fc108252"), new Guid("ec4337d3-7aa8-4396-831e-4eb510aa5bb1"), "auth0|65b7dee72e02f54da98cd265", 0, new DateTime(2023, 9, 21, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3980), new DateTime(2023, 9, 20, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3979), new DateTime(2023, 9, 19, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3981), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 189", 2, 0, "Ticket 189" },
                    { new Guid("1470f41c-ce35-48f2-9f32-6b10e1bc3a8a"), new Guid("0ddf2d45-9f40-4fcd-80a2-5286ec667ad1"), "auth0|65a4f8d7364ff592a0792a42", 1, null, null, new DateTime(2024, 2, 9, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1936), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 46", 0, 1, "Ticket 46" },
                    { new Guid("14e47953-7a3e-4e1c-90f9-30b814cb0e76"), new Guid("b574cdb9-8ceb-4fd4-8e8f-2c1512aa907f"), "auth0|65a4fd318d9d565392c4972a", 3, null, null, new DateTime(2023, 12, 5, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2956), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 112", 0, 3, "Ticket 112" },
                    { new Guid("15939548-079d-4c48-beda-a9975d9ffd30"), new Guid("c049086d-9699-4ee0-ab6b-f1a4802b03ee"), "auth0|65a4f8d7364ff592a0792a42", 1, null, null, new DateTime(2023, 12, 31, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2464), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 86", 1, 1, "Ticket 86" },
                    { new Guid("165b4299-56db-46dd-8e84-18e76989cf0c"), new Guid("210513be-95f9-46ce-a1e8-3b5ea08231c7"), "auth0|65b7dee72e02f54da98cd265", 0, new DateTime(2023, 11, 28, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3065), new DateTime(2023, 11, 27, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3064), new DateTime(2023, 11, 26, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3066), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 121", 0, 0, "Ticket 121" },
                    { new Guid("17120b1e-7c18-4efa-8efc-89bc1d6bb31f"), new Guid("a8ad6597-7b4a-46d9-a2ff-647b86e7da1c"), "auth0|65a4f8d7364ff592a0792a42", 1, null, null, new DateTime(2023, 8, 17, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4474), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 222", 2, 1, "Ticket 222" },
                    { new Guid("1a58161e-102c-4aaf-99da-4c55f2387617"), new Guid("f0b38660-d5db-4f9d-9729-94358cb7bdb5"), "auth0|65b7dee72e02f54da98cd265", 0, new DateTime(2023, 8, 12, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4557), new DateTime(2023, 8, 11, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4556), new DateTime(2023, 8, 10, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4558), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 229", 0, 0, "Ticket 229" },
                    { new Guid("1b9e374a-1d9d-46d9-8fd8-2eab37cbada4"), new Guid("e6a5501a-de17-4657-a9d3-9aa5b74f862c"), "auth0|65a4f8d7364ff592a0792a42", 1, null, null, new DateTime(2023, 8, 21, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4429), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 218", 1, 1, "Ticket 218" },
                    { new Guid("1ddbfe3b-b177-487c-a0bf-b72c4a20e46e"), new Guid("b05c44eb-7568-4523-be49-08105fbb1106"), "auth0|65b7dee72e02f54da98cd265", 0, new DateTime(2024, 1, 31, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2103), new DateTime(2024, 1, 30, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2102), new DateTime(2024, 1, 29, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2104), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 57", 2, 0, "Ticket 57" },
                    { new Guid("1e062402-56e7-4f9f-b011-bb6a69e59de3"), new Guid("85ce4a6a-a305-426a-9e29-f817f44c98a8"), "auth0|65b7de875bf9ce48b47eedaa", 2, new DateTime(2024, 1, 21, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2221), new DateTime(2024, 1, 20, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2221), new DateTime(2024, 1, 19, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2222), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 67", 0, 2, "Ticket 67" },
                    { new Guid("1f265abc-785a-45af-a96e-dba02191739d"), new Guid("6b414c7d-3fed-4932-a291-c7af0a50d852"), "auth0|65b7dee72e02f54da98cd265", 0, new DateTime(2023, 7, 31, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4735), new DateTime(2023, 7, 30, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4735), new DateTime(2023, 7, 29, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4736), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 241", 0, 0, "Ticket 241" },
                    { new Guid("1fc35ac2-d093-4539-ad91-199f512c8084"), new Guid("22dbcf5e-49f3-451d-8f68-a70d36d5eafc"), "auth0|65a4fd318d9d565392c4972a", 3, null, null, new DateTime(2023, 9, 12, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4133), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 196", 0, 3, "Ticket 196" },
                    { new Guid("20a31543-3ddd-4b9b-bf57-a02bccfc369b"), new Guid("7e6932ef-fe3a-4e22-bf03-be4c9fb40b68"), "auth0|65b7dee72e02f54da98cd265", 0, new DateTime(2024, 3, 11, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1448), new DateTime(2024, 3, 10, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1448), new DateTime(2024, 3, 9, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1449), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 17", 1, 0, "Ticket 17" },
                    { new Guid("20c1103c-da01-4016-87cb-2e3ba2a917c3"), new Guid("210513be-95f9-46ce-a1e8-3b5ea08231c7"), "auth0|65b7de875bf9ce48b47eedaa", 2, new DateTime(2024, 2, 6, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2032), new DateTime(2024, 2, 5, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2031), new DateTime(2024, 2, 4, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2032), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 51", 2, 2, "Ticket 51" },
                    { new Guid("223e3ab1-b5d5-41af-8908-4bc8d8c13152"), new Guid("8503793e-1bda-496e-a1da-3cf84041704b"), "auth0|65b7dee72e02f54da98cd265", 0, new DateTime(2023, 8, 20, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4462), new DateTime(2023, 8, 19, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4462), new DateTime(2023, 8, 18, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4463), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 221", 1, 0, "Ticket 221" },
                    { new Guid("2251ff76-27a3-4958-a4f5-8076ba5739ab"), new Guid("aabac3ed-cd23-437e-9977-9f263cea7b12"), "auth0|65b7dee72e02f54da98cd265", 0, new DateTime(2023, 12, 10, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2879), new DateTime(2023, 12, 9, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2878), new DateTime(2023, 12, 8, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2879), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 109", 0, 0, "Ticket 109" },
                    { new Guid("233977bb-1f5e-4b18-9090-2c143b8d779c"), new Guid("0026da90-a1a9-41fa-933e-576ad76ffbf7"), "auth0|65a4f8d7364ff592a0792a42", 1, null, null, new DateTime(2024, 3, 20, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1256), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 6", 2, 1, "Ticket 6" },
                    { new Guid("266638c3-59c0-44f3-b84a-d940fe052215"), new Guid("1106ab56-1576-4138-8521-a0ca8d9492e2"), "auth0|65a4fd318d9d565392c4972a", 3, null, null, new DateTime(2024, 2, 19, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1820), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 36", 2, 3, "Ticket 36" },
                    { new Guid("26d95773-a838-4f65-a57a-864725829065"), new Guid("f7358570-ea64-4912-81b3-d3ef3a255b2e"), "auth0|65b7dee72e02f54da98cd265", 0, new DateTime(2023, 9, 29, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3886), new DateTime(2023, 9, 28, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3885), new DateTime(2023, 9, 27, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3886), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 181", 0, 0, "Ticket 181" },
                    { new Guid("270db948-f94a-46fd-a4e3-a3d6da2e4294"), new Guid("1ef348d3-6cef-40c0-8d21-e1b3ac8ba85d"), "auth0|65b7dee72e02f54da98cd265", 0, new DateTime(2023, 8, 4, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4686), new DateTime(2023, 8, 3, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4685), new DateTime(2023, 8, 2, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4687), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 237", 2, 0, "Ticket 237" },
                    { new Guid("286401e2-af4f-4454-8338-493d8fe16ca7"), new Guid("f8b91952-2bf0-4a59-9cd9-5e1f784eb79e"), "auth0|65a4f8d7364ff592a0792a42", 1, null, null, new DateTime(2024, 2, 29, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1558), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 26", 1, 1, "Ticket 26" },
                    { new Guid("28692115-99f4-4fa9-88b1-4f0cab5945ad"), new Guid("7e0d6368-b609-43da-ad5f-1be2ebaa2301"), "auth0|65a4f8d7364ff592a0792a42", 1, null, null, new DateTime(2023, 10, 28, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3470), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 150", 2, 1, "Ticket 150" },
                    { new Guid("289d243a-c724-4e51-9c6d-b32e8106f57f"), new Guid("a1952de2-fdf7-469f-bae6-092993cb4c01"), "auth0|65b7de875bf9ce48b47eedaa", 2, new DateTime(2023, 9, 27, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3908), new DateTime(2023, 9, 26, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3908), new DateTime(2023, 9, 25, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3909), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 183", 2, 2, "Ticket 183" },
                    { new Guid("29420a83-3c12-4511-a2db-94242415bab7"), new Guid("e7658228-f102-46ce-ad6d-eb770c11ddee"), "auth0|65b7de875bf9ce48b47eedaa", 2, new DateTime(2023, 7, 29, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4758), new DateTime(2023, 7, 28, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4758), new DateTime(2023, 7, 27, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4759), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 243", 2, 2, "Ticket 243" },
                    { new Guid("2985914b-5fcf-4ba8-8760-8f96dfa39477"), new Guid("880f1059-f46d-4d66-baea-a8a75b787d24"), "auth0|65a4f8d7364ff592a0792a42", 1, null, null, new DateTime(2023, 11, 13, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3249), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 134", 1, 1, "Ticket 134" },
                    { new Guid("29968f1c-5520-4793-84ee-0427a38afcfd"), new Guid("e7658228-f102-46ce-ad6d-eb770c11ddee"), "auth0|65b7dee72e02f54da98cd265", 0, new DateTime(2023, 10, 7, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3791), new DateTime(2023, 10, 6, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3790), new DateTime(2023, 10, 5, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3791), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 173", 1, 0, "Ticket 173" },
                    { new Guid("2a4a51ff-3ee4-4c8e-b6c3-d576c5ca3a06"), new Guid("ccbe957a-8557-47e4-9c99-ddccae845545"), "auth0|65a4fd318d9d565392c4972a", 3, null, null, new DateTime(2023, 9, 28, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3874), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 180", 2, 3, "Ticket 180" },
                    { new Guid("2c175028-f577-4e0d-a229-3adcb8c6fc74"), new Guid("ccebfce7-bf7e-4f44-a049-f78059d28a18"), "auth0|65b7de875bf9ce48b47eedaa", 2, new DateTime(2023, 12, 20, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2762), new DateTime(2023, 12, 19, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2761), new DateTime(2023, 12, 18, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2763), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 99", 2, 2, "Ticket 99" },
                    { new Guid("2d74b7cc-a6fe-42c9-9efe-77fbd1669c69"), new Guid("86af32ca-f862-4f98-a7c2-e7ba19619301"), "auth0|65b7de875bf9ce48b47eedaa", 2, new DateTime(2023, 10, 17, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3625), new DateTime(2023, 10, 16, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3624), new DateTime(2023, 10, 15, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3625), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 163", 0, 2, "Ticket 163" },
                    { new Guid("2fdd6676-1c63-4c1f-a06b-5104167f0f9d"), new Guid("7e6932ef-fe3a-4e22-bf03-be4c9fb40b68"), "auth0|65b7dee72e02f54da98cd265", 0, new DateTime(2023, 10, 23, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3553), new DateTime(2023, 10, 22, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3552), new DateTime(2023, 10, 21, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3554), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 157", 0, 0, "Ticket 157" },
                    { new Guid("3066cdd0-aea9-49f2-b813-7623b44b38dd"), new Guid("c7f7d3d3-2f4d-4e85-9e35-74e23e44d5f9"), "auth0|65a4f8d7364ff592a0792a42", 1, null, null, new DateTime(2024, 3, 4, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1508), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 22", 0, 1, "Ticket 22" },
                    { new Guid("3160404f-bdec-4bcb-9277-8ee201c4e019"), new Guid("341f9b78-ce17-42e9-9091-dbefeba89d3b"), "auth0|65a4fd318d9d565392c4972a", 3, null, null, new DateTime(2023, 7, 22, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4815), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 248", 1, 3, "Ticket 248" },
                    { new Guid("3169734c-dcc5-4bee-ad9f-c36853a5f720"), new Guid("5cea12db-210f-424f-9310-a9594619b930"), "auth0|65b7de875bf9ce48b47eedaa", 2, new DateTime(2023, 11, 10, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3309), new DateTime(2023, 11, 9, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3309), new DateTime(2023, 11, 8, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3310), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 139", 0, 2, "Ticket 139" },
                    { new Guid("31744b06-f4cc-4b0c-9ae7-7f2642cf9e8f"), new Guid("7e6932ef-fe3a-4e22-bf03-be4c9fb40b68"), "auth0|65b7de875bf9ce48b47eedaa", 2, new DateTime(2024, 1, 1, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2563), new DateTime(2023, 12, 31, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2561), new DateTime(2023, 12, 30, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2564), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 87", 2, 2, "Ticket 87" },
                    { new Guid("32ebebb9-ee0e-4bc1-b3e1-c104d15502de"), new Guid("c7f7d3d3-2f4d-4e85-9e35-74e23e44d5f9"), "auth0|65a4fd318d9d565392c4972a", 3, null, null, new DateTime(2023, 8, 7, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4626), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 232", 0, 3, "Ticket 232" },
                    { new Guid("33f9c75a-622f-4d03-99bd-2561dcbd341d"), new Guid("da962695-902b-40ef-a0ca-2ea3599659e8"), "auth0|65b7de875bf9ce48b47eedaa", 2, new DateTime(2024, 1, 29, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2125), new DateTime(2024, 1, 28, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2125), new DateTime(2024, 1, 27, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2126), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 59", 1, 2, "Ticket 59" },
                    { new Guid("34640419-493f-4cb2-8128-c15815dabf23"), new Guid("aabac3ed-cd23-437e-9977-9f263cea7b12"), "auth0|65b7dee72e02f54da98cd265", 0, new DateTime(2023, 7, 23, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4831), new DateTime(2023, 7, 22, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4830), new DateTime(2023, 7, 21, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4831), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 249", 2, 0, "Ticket 249" },
                    { new Guid("34b06616-399f-4697-b50d-9bd108b83b75"), new Guid("c4d38b52-d1a2-4a0e-8de5-85eb2fcd6604"), "auth0|65b7de875bf9ce48b47eedaa", 2, new DateTime(2023, 8, 10, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4579), new DateTime(2023, 8, 9, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4579), new DateTime(2023, 8, 8, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4580), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 231", 2, 2, "Ticket 231" },
                    { new Guid("3656afa1-5654-4352-ae04-26ea75b77ae9"), new Guid("22dbcf5e-49f3-451d-8f68-a70d36d5eafc"), "auth0|65a4f8d7364ff592a0792a42", 1, null, null, new DateTime(2023, 11, 21, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3121), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 126", 2, 1, "Ticket 126" },
                    { new Guid("377f6878-4aa2-4631-b5d2-9c82b1fb87d8"), new Guid("1ef348d3-6cef-40c0-8d21-e1b3ac8ba85d"), "auth0|65b7de875bf9ce48b47eedaa", 2, new DateTime(2023, 10, 13, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3670), new DateTime(2023, 10, 12, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3669), new DateTime(2023, 10, 11, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3671), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 167", 1, 2, "Ticket 167" },
                    { new Guid("3804d5f1-0761-4a09-8f6e-5e4ef843760e"), new Guid("e954c356-7846-4438-95ad-efce405cbe87"), "auth0|65b7dee72e02f54da98cd265", 0, new DateTime(2024, 1, 15, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2314), new DateTime(2024, 1, 14, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2313), new DateTime(2024, 1, 13, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2315), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 73", 0, 0, "Ticket 73" },
                    { new Guid("3884de71-b81e-401e-8423-65a4bd41d5c5"), new Guid("0f5e4c81-1dee-4681-9e74-62f77ae22cb4"), "auth0|65a4fd318d9d565392c4972a", 3, null, null, new DateTime(2023, 11, 3, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3366), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 144", 2, 3, "Ticket 144" },
                    { new Guid("3c7aa09c-bd9e-436f-b667-5598da924e3a"), new Guid("d7657a73-2859-4353-95a2-c720d5341882"), "auth0|65b7de875bf9ce48b47eedaa", 2, new DateTime(2023, 11, 14, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3260), new DateTime(2023, 11, 13, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3259), new DateTime(2023, 11, 12, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3261), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 135", 2, 2, "Ticket 135" },
                    { new Guid("3d1bad6e-413c-4c24-97bc-893c8cf1e844"), new Guid("c3bc7db1-01e3-45b3-a534-5411c807285e"), "auth0|65a4f8d7364ff592a0792a42", 1, null, null, new DateTime(2023, 11, 25, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3076), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 122", 1, 1, "Ticket 122" },
                    { new Guid("3dd5afe7-e0c2-47f3-b466-9dc1d02a693b"), new Guid("341f9b78-ce17-42e9-9091-dbefeba89d3b"), "auth0|65a4fd318d9d565392c4972a", 3, null, null, new DateTime(2023, 12, 9, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2867), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 108", 2, 3, "Ticket 108" },
                    { new Guid("3e158613-6587-4ec0-863b-61c04d367417"), new Guid("a6e966cd-eb16-403e-93ce-0a7f7e318a6b"), "auth0|65b7dee72e02f54da98cd265", 0, new DateTime(2024, 3, 3, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1547), new DateTime(2024, 3, 2, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1546), new DateTime(2024, 3, 1, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1548), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 25", 0, 0, "Ticket 25" },
                    { new Guid("3fdaf745-6e12-4e75-ad08-eee413ae2004"), new Guid("8503793e-1bda-496e-a1da-3cf84041704b"), "auth0|65b7de875bf9ce48b47eedaa", 2, new DateTime(2024, 3, 17, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1376), new DateTime(2024, 3, 16, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1375), new DateTime(2024, 3, 15, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1377), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 11", 1, 2, "Ticket 11" },
                    { new Guid("41e846ad-7eff-46db-9581-9fea72d7f16c"), new Guid("94c5d955-ff84-44ba-8297-4212f5a2eb57"), "auth0|65a4fd318d9d565392c4972a", 3, null, null, new DateTime(2023, 12, 17, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2774), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 100", 0, 3, "Ticket 100" },
                    { new Guid("44239f37-2e44-4c40-980c-6384d26c5e22"), new Guid("d7657a73-2859-4353-95a2-c720d5341882"), "auth0|65b7dee72e02f54da98cd265", 0, new DateTime(2024, 1, 23, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2196), new DateTime(2024, 1, 22, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2196), new DateTime(2024, 1, 21, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2197), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 65", 1, 0, "Ticket 65" },
                    { new Guid("4483f71d-552d-4e5c-aaee-7766e558c8cb"), new Guid("85ce4a6a-a305-426a-9e29-f817f44c98a8"), "auth0|65b7dee72e02f54da98cd265", 0, new DateTime(2023, 11, 12, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3286), new DateTime(2023, 11, 11, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3285), new DateTime(2023, 11, 10, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3287), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 137", 1, 0, "Ticket 137" },
                    { new Guid("459bf62f-5332-4ece-b85d-8854ee75f4ce"), new Guid("7ec48e58-03e0-42ef-b69d-3ca5d36a540d"), "auth0|65a4fd318d9d565392c4972a", 3, null, null, new DateTime(2024, 2, 27, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1582), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 28", 0, 3, "Ticket 28" },
                    { new Guid("462e5370-6955-4eb3-ba9d-7f193689e8d2"), new Guid("96013f50-c6e1-4e8d-a6e4-d8ac93bdbdb8"), "auth0|65a4f8d7364ff592a0792a42", 1, null, null, new DateTime(2024, 1, 16, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2276), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 70", 0, 1, "Ticket 70" },
                    { new Guid("46f89848-7e7b-406d-bda3-a4ab432b4fc8"), new Guid("aabac3ed-cd23-437e-9977-9f263cea7b12"), "auth0|65b7de875bf9ce48b47eedaa", 2, new DateTime(2023, 10, 1, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3863), new DateTime(2023, 9, 30, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3862), new DateTime(2023, 9, 29, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3863), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 179", 1, 2, "Ticket 179" },
                    { new Guid("47b9563e-847e-48a2-8f2f-4f2ec3ea982a"), new Guid("66fa74a2-72e3-4847-ad07-51c4f5daeb40"), "auth0|65b7dee72e02f54da98cd265", 0, new DateTime(2023, 9, 25, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3934), new DateTime(2023, 9, 24, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3934), new DateTime(2023, 9, 23, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3935), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 185", 1, 0, "Ticket 185" },
                    { new Guid("47fbb3a1-7afd-4693-8d99-ccb24c4171b8"), new Guid("aabac3ed-cd23-437e-9977-9f263cea7b12"), "auth0|65b7de875bf9ce48b47eedaa", 2, new DateTime(2024, 2, 18, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1854), new DateTime(2024, 2, 17, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1853), new DateTime(2024, 2, 16, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1854), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 39", 2, 2, "Ticket 39" },
                    { new Guid("49c718d2-c024-45d8-8324-1b4e97477618"), new Guid("210513be-95f9-46ce-a1e8-3b5ea08231c7"), "auth0|65b7de875bf9ce48b47eedaa", 2, new DateTime(2023, 9, 19, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4073), new DateTime(2023, 9, 18, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4073), new DateTime(2023, 9, 17, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4074), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 191", 1, 2, "Ticket 191" },
                    { new Guid("4b2bcd12-8709-41a6-8f7c-342ba8f2d915"), new Guid("4cafe1b0-6478-4509-9433-80cc2a331b22"), "auth0|65b7de875bf9ce48b47eedaa", 2, new DateTime(2024, 3, 21, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1267), new DateTime(2024, 3, 20, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1266), new DateTime(2024, 3, 19, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1268), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 7", 0, 2, "Ticket 7" },
                    { new Guid("4b45c309-a620-4c3f-af8e-db9eab3f151b"), new Guid("89155141-a366-44db-b0a4-4376ec44dcfe"), "auth0|65b7de875bf9ce48b47eedaa", 2, new DateTime(2023, 10, 5, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3813), new DateTime(2023, 10, 4, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3812), new DateTime(2023, 10, 3, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3814), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 175", 0, 2, "Ticket 175" },
                    { new Guid("4ca06e71-6b94-4531-b742-58ed7aeaba7b"), new Guid("e6a5501a-de17-4657-a9d3-9aa5b74f862c"), "auth0|65a4fd318d9d565392c4972a", 3, null, null, new DateTime(2024, 3, 18, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1278), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 8", 1, 3, "Ticket 8" },
                    { new Guid("4d22e85e-7289-43a8-9297-c485313df60e"), new Guid("880f1059-f46d-4d66-baea-a8a75b787d24"), "auth0|65a4fd318d9d565392c4972a", 3, null, null, new DateTime(2024, 1, 22, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2182), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 64", 0, 3, "Ticket 64" },
                    { new Guid("4d45e5d6-0659-4346-9fa1-d49ca9f7793e"), new Guid("1ef348d3-6cef-40c0-8d21-e1b3ac8ba85d"), "auth0|65b7dee72e02f54da98cd265", 0, new DateTime(2023, 12, 22, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2739), new DateTime(2023, 12, 21, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2739), new DateTime(2023, 12, 20, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2740), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 97", 0, 0, "Ticket 97" },
                    { new Guid("4dcd23ea-702b-4db0-a1eb-6efd9988741a"), new Guid("7e0d6368-b609-43da-ad5f-1be2ebaa2301"), "auth0|65a4f8d7364ff592a0792a42", 1, null, null, new DateTime(2024, 3, 16, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1363), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 10", 0, 1, "Ticket 10" },
                    { new Guid("4e719bb8-865f-4be3-9ae6-b6bb2a9cb837"), new Guid("4cafe1b0-6478-4509-9433-80cc2a331b22"), "auth0|65b7de875bf9ce48b47eedaa", 2, new DateTime(2023, 11, 2, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3404), new DateTime(2023, 11, 1, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3403), new DateTime(2023, 10, 31, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3405), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 147", 2, 2, "Ticket 147" },
                    { new Guid("5034c8c5-ebd4-4398-88d2-8b17effb92da"), new Guid("4610a824-5bae-4dce-ad57-22e6d63ecd30"), "auth0|65a4fd318d9d565392c4972a", 3, null, null, new DateTime(2023, 12, 13, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2819), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 104", 1, 3, "Ticket 104" },
                    { new Guid("50f59443-44e4-4e78-926d-86d890567a04"), new Guid("89155141-a366-44db-b0a4-4376ec44dcfe"), "auth0|65b7dee72e02f54da98cd265", 0, new DateTime(2023, 7, 27, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4781), new DateTime(2023, 7, 26, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4780), new DateTime(2023, 7, 25, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4782), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 245", 1, 0, "Ticket 245" },
                    { new Guid("51e2b372-525c-49f8-b7f1-4235113e72a5"), new Guid("57c29b52-3614-4f45-80da-9f9f0c0be1cc"), "auth0|65a4fd318d9d565392c4972a", 3, null, null, new DateTime(2023, 11, 27, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3050), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 120", 2, 3, "Ticket 120" },
                    { new Guid("51f600a5-fa34-45f8-9a8b-3a8e2a37af8c"), new Guid("b574cdb9-8ceb-4fd4-8e8f-2c1512aa907f"), "auth0|65a4f8d7364ff592a0792a42", 1, null, null, new DateTime(2024, 2, 13, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1892), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 42", 2, 1, "Ticket 42" },
                    { new Guid("531c786c-05bb-4d9e-aab8-85b78468a5f8"), new Guid("4f7996f8-66bb-49c9-875e-2cddf0c6dd31"), "auth0|65a4fd318d9d565392c4972a", 3, null, null, new DateTime(2024, 1, 26, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2137), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 60", 2, 3, "Ticket 60" },
                    { new Guid("57aabde2-c84e-4354-bca2-9839a0fdaef6"), new Guid("f79631e3-8401-451f-b49a-94a6b358807b"), "auth0|65b7de875bf9ce48b47eedaa", 2, new DateTime(2023, 8, 26, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4391), new DateTime(2023, 8, 25, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4390), new DateTime(2023, 8, 24, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4392), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 215", 1, 2, "Ticket 215" },
                    { new Guid("59a9bb0e-310a-45ba-a411-0bbe6b2c247e"), new Guid("96013f50-c6e1-4e8d-a6e4-d8ac93bdbdb8"), "auth0|65a4f8d7364ff592a0792a42", 1, null, null, new DateTime(2023, 8, 29, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4300), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 210", 2, 1, "Ticket 210" },
                    { new Guid("5ac7463d-6035-449d-a1bd-17968b6f6578"), new Guid("110f2ffa-2825-4b68-b584-707b9c7cc472"), "auth0|65b7dee72e02f54da98cd265", 0, new DateTime(2023, 12, 2, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3016), new DateTime(2023, 12, 1, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3016), new DateTime(2023, 11, 30, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3017), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 117", 2, 0, "Ticket 117" },
                    { new Guid("5aca1633-6402-4f70-8b1f-891d13171929"), new Guid("4cafe1b0-6478-4509-9433-80cc2a331b22"), "auth0|65b7dee72e02f54da98cd265", 0, new DateTime(2023, 8, 24, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4417), new DateTime(2023, 8, 23, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4416), new DateTime(2023, 8, 22, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4418), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 217", 0, 0, "Ticket 217" },
                    { new Guid("5b549dd6-38e8-40a0-a6b1-7c5c875b422c"), new Guid("f7358570-ea64-4912-81b3-d3ef3a255b2e"), "auth0|65b7de875bf9ce48b47eedaa", 2, new DateTime(2023, 12, 8, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2901), new DateTime(2023, 12, 7, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2900), new DateTime(2023, 12, 6, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2902), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 111", 2, 2, "Ticket 111" },
                    { new Guid("5c6bc45a-92ab-430a-b6e5-f88a411e96cf"), new Guid("696346f6-5cf4-4bcf-997b-f7541af90e31"), "auth0|65b7dee72e02f54da98cd265", 0, new DateTime(2024, 3, 15, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1399), new DateTime(2024, 3, 14, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1398), new DateTime(2024, 3, 13, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1400), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 13", 0, 0, "Ticket 13" },
                    { new Guid("5d7473cf-f4a9-42a5-bc23-a0b61fa1a8a1"), new Guid("22dbcf5e-49f3-451d-8f68-a70d36d5eafc"), "auth0|65a4fd318d9d565392c4972a", 3, null, null, new DateTime(2024, 1, 30, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2088), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 56", 1, 3, "Ticket 56" },
                    { new Guid("5dceea5a-3f31-416d-929c-d1c7ac1e6a5d"), new Guid("1ef348d3-6cef-40c0-8d21-e1b3ac8ba85d"), "auth0|65b7de875bf9ce48b47eedaa", 2, new DateTime(2024, 3, 1, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1570), new DateTime(2024, 2, 29, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1569), new DateTime(2024, 2, 28, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1571), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 27", 2, 2, "Ticket 27" },
                    { new Guid("5e3678ab-b775-4322-a740-7c811b2d4fd9"), new Guid("4f7996f8-66bb-49c9-875e-2cddf0c6dd31"), "auth0|65a4fd318d9d565392c4972a", 3, null, null, new DateTime(2023, 9, 8, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4178), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 200", 1, 3, "Ticket 200" },
                    { new Guid("5f979d07-6678-4f86-88f3-630151ac71a7"), new Guid("7ec48e58-03e0-42ef-b69d-3ca5d36a540d"), "auth0|65a4fd318d9d565392c4972a", 3, null, null, new DateTime(2023, 10, 10, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3681), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 168", 2, 3, "Ticket 168" },
                    { new Guid("60d73449-1dc5-4c33-9324-472e4cdfd012"), new Guid("13a41e4c-47b5-4393-8b01-110462a3d083"), "auth0|65a4f8d7364ff592a0792a42", 1, null, null, new DateTime(2023, 7, 28, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4747), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 242", 1, 1, "Ticket 242" },
                    { new Guid("610f2566-4657-4bfa-8f12-287b1d15ff03"), new Guid("c7f7d3d3-2f4d-4e85-9e35-74e23e44d5f9"), "auth0|65a4fd318d9d565392c4972a", 3, null, null, new DateTime(2023, 12, 25, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2679), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 92", 1, 3, "Ticket 92" },
                    { new Guid("615f5bbf-1878-44ad-93cb-2be8db379a5e"), new Guid("b574cdb9-8ceb-4fd4-8e8f-2c1512aa907f"), "auth0|65a4f8d7364ff592a0792a42", 1, null, null, new DateTime(2023, 9, 26, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3897), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 182", 1, 1, "Ticket 182" },
                    { new Guid("61a885d0-b82a-4508-8c10-3ea62d38ddf0"), new Guid("57c29b52-3614-4f45-80da-9f9f0c0be1cc"), "auth0|65a4f8d7364ff592a0792a42", 1, null, null, new DateTime(2024, 2, 5, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2018), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 50", 1, 1, "Ticket 50" },
                    { new Guid("61ba2ae9-c657-4971-bd12-b3acf6036a7a"), new Guid("c7f7d3d3-2f4d-4e85-9e35-74e23e44d5f9"), "auth0|65a4f8d7364ff592a0792a42", 1, null, null, new DateTime(2023, 10, 16, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3614), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 162", 2, 1, "Ticket 162" },
                    { new Guid("62a6fb7b-2283-45af-a2e1-eb08c9613cfe"), new Guid("c4d38b52-d1a2-4a0e-8de5-85eb2fcd6604"), "auth0|65b7de875bf9ce48b47eedaa", 2, new DateTime(2023, 12, 28, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2667), new DateTime(2023, 12, 27, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2666), new DateTime(2023, 12, 26, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2668), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 91", 0, 2, "Ticket 91" },
                    { new Guid("66e98559-3fb3-4fa0-a365-d608c6e389cd"), new Guid("94c5d955-ff84-44ba-8297-4212f5a2eb57"), "auth0|65a4fd318d9d565392c4972a", 3, null, null, new DateTime(2023, 7, 30, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4721), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 240", 2, 3, "Ticket 240" },
                    { new Guid("67b253b6-8171-4609-8922-5e4d908b408c"), new Guid("be37261d-62bb-4d93-8982-4411941de97b"), "auth0|65a4f8d7364ff592a0792a42", 1, null, null, new DateTime(2024, 1, 24, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2159), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 62", 1, 1, "Ticket 62" },
                    { new Guid("67b79265-2460-4e07-bdaf-334f59954975"), new Guid("f79631e3-8401-451f-b49a-94a6b358807b"), "auth0|65b7dee72e02f54da98cd265", 0, new DateTime(2023, 11, 4, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3381), new DateTime(2023, 11, 3, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3380), new DateTime(2023, 11, 2, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3382), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 145", 0, 0, "Ticket 145" },
                    { new Guid("67b8ae96-bf11-4603-baa1-11779f28f150"), new Guid("5da46ea0-bac0-4152-b19d-5aec098d62ae"), "auth0|65a4fd318d9d565392c4972a", 3, null, null, new DateTime(2023, 11, 11, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3271), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 136", 0, 3, "Ticket 136" },
                    { new Guid("67ed7636-a5c7-4557-9a59-95f30415b131"), new Guid("85ce4a6a-a305-426a-9e29-f817f44c98a8"), "auth0|65b7de875bf9ce48b47eedaa", 2, new DateTime(2023, 9, 3, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4262), new DateTime(2023, 9, 2, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4261), new DateTime(2023, 9, 1, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4263), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 207", 2, 2, "Ticket 207" },
                    { new Guid("6961ec45-2073-4b8d-af4c-d2e83bf284b4"), new Guid("a8ad6597-7b4a-46d9-a2ff-647b86e7da1c"), "auth0|65a4fd318d9d565392c4972a", 3, null, null, new DateTime(2023, 10, 26, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3493), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 152", 1, 3, "Ticket 152" },
                    { new Guid("6965a657-6327-42ad-ad10-55483f72243c"), new Guid("054b5698-5d00-4f55-9132-ce0f5ea666bd"), "auth0|65a4f8d7364ff592a0792a42", 1, null, null, new DateTime(2023, 9, 10, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4155), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 198", 2, 1, "Ticket 198" },
                    { new Guid("69ebbb8d-2bb3-4153-8d1f-ef91f8f3b122"), new Guid("1f43dce8-8941-4536-bcae-59b78ad071f8"), "auth0|65b7dee72e02f54da98cd265", 0, new DateTime(2023, 8, 16, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4511), new DateTime(2023, 8, 15, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4511), new DateTime(2023, 8, 14, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4512), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 225", 2, 0, "Ticket 225" },
                    { new Guid("6b4c8cdc-4483-4abd-9247-7581c25a9ef5"), new Guid("7ec48e58-03e0-42ef-b69d-3ca5d36a540d"), "auth0|65a4f8d7364ff592a0792a42", 1, null, null, new DateTime(2023, 8, 1, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4697), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 238", 0, 1, "Ticket 238" },
                    { new Guid("6b6018b9-7537-47dc-aff7-6461128947ad"), new Guid("dcc3349d-654c-4415-8815-cedcbc349126"), "auth0|65a4fd318d9d565392c4972a", 3, null, null, new DateTime(2024, 1, 2, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2442), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 84", 2, 3, "Ticket 84" },
                    { new Guid("6b96fb16-933a-43ff-9732-336382b75a11"), new Guid("5da46ea0-bac0-4152-b19d-5aec098d62ae"), "auth0|65a4f8d7364ff592a0792a42", 1, null, null, new DateTime(2023, 9, 2, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4250), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 206", 1, 1, "Ticket 206" },
                    { new Guid("6e176bd5-4a5b-45f1-b687-e5c6a909ae7b"), new Guid("86af32ca-f862-4f98-a7c2-e7ba19619301"), "auth0|65b7dee72e02f54da98cd265", 0, new DateTime(2023, 8, 8, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4641), new DateTime(2023, 8, 7, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4640), new DateTime(2023, 8, 6, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4641), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 233", 1, 0, "Ticket 233" },
                    { new Guid("6e50821f-d312-4e9d-8fac-8e6160f46bd8"), new Guid("ec4337d3-7aa8-4396-831e-4eb510aa5bb1"), "auth0|65b7de875bf9ce48b47eedaa", 2, new DateTime(2023, 11, 30, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3039), new DateTime(2023, 11, 29, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3038), new DateTime(2023, 11, 28, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3040), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 119", 1, 2, "Ticket 119" },
                    { new Guid("6e56fbdb-cafa-4190-be96-14a446d23274"), new Guid("0f5e4c81-1dee-4681-9e74-62f77ae22cb4"), "auth0|65a4f8d7364ff592a0792a42", 1, null, null, new DateTime(2023, 8, 25, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4380), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 214", 0, 1, "Ticket 214" },
                    { new Guid("6f26d38e-e20e-4842-8678-5b5d2be21ae5"), new Guid("0f5e4c81-1dee-4681-9e74-62f77ae22cb4"), "auth0|65a4fd318d9d565392c4972a", 3, null, null, new DateTime(2024, 3, 22, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1232), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 4", 0, 3, "Ticket 4" },
                    { new Guid("6f3a392f-f680-47f5-a406-c91843eda101"), new Guid("66fa74a2-72e3-4847-ad07-51c4f5daeb40"), "auth0|65b7de875bf9ce48b47eedaa", 2, new DateTime(2023, 12, 4, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2994), new DateTime(2023, 12, 3, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2993), new DateTime(2023, 12, 2, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2994), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 115", 0, 2, "Ticket 115" },
                    { new Guid("75493af2-d6c0-4f49-9e42-9a31c8e30abb"), new Guid("94c5d955-ff84-44ba-8297-4212f5a2eb57"), "auth0|65a4f8d7364ff592a0792a42", 1, null, null, new DateTime(2024, 2, 25, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1658), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 30", 2, 1, "Ticket 30" },
                    { new Guid("75e73bcb-4f92-4178-a70e-7b445f7c7354"), new Guid("414b5098-3cf1-42e8-a3b0-c8648922eb21"), "auth0|65b7de875bf9ce48b47eedaa", 2, new DateTime(2023, 9, 15, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4122), new DateTime(2023, 9, 14, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4121), new DateTime(2023, 9, 13, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4123), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 195", 2, 2, "Ticket 195" },
                    { new Guid("7669b9d6-aa75-4974-90b1-ca94dce55675"), new Guid("a6e966cd-eb16-403e-93ce-0a7f7e318a6b"), "auth0|65b7dee72e02f54da98cd265", 0, new DateTime(2023, 10, 15, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3648), new DateTime(2023, 10, 14, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3647), new DateTime(2023, 10, 13, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3648), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 165", 2, 0, "Ticket 165" },
                    { new Guid("78623f86-840c-4e99-a247-33529c36c32a"), new Guid("054b5698-5d00-4f55-9132-ce0f5ea666bd"), "auth0|65a4fd318d9d565392c4972a", 3, null, null, new DateTime(2023, 11, 19, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3144), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 128", 1, 3, "Ticket 128" },
                    { new Guid("795b27c5-5678-4122-a12f-8a27d049905e"), new Guid("c3bc7db1-01e3-45b3-a534-5411c807285e"), "auth0|65a4fd318d9d565392c4972a", 3, null, null, new DateTime(2024, 2, 3, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2043), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 52", 0, 3, "Ticket 52" },
                    { new Guid("7a26122d-8cc9-4a2d-9b8e-ade4874e2759"), new Guid("0ddf2d45-9f40-4fcd-80a2-5286ec667ad1"), "auth0|65a4f8d7364ff592a0792a42", 1, null, null, new DateTime(2023, 9, 22, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3946), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 186", 2, 1, "Ticket 186" },
                    { new Guid("7af2d76e-e278-4962-affe-e7dc4af1a8d4"), new Guid("66fa74a2-72e3-4847-ad07-51c4f5daeb40"), "auth0|65b7dee72e02f54da98cd265", 0, new DateTime(2024, 2, 12, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1925), new DateTime(2024, 2, 11, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1925), new DateTime(2024, 2, 10, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1926), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 45", 2, 0, "Ticket 45" },
                    { new Guid("7c1e713c-bc3f-47fb-ae31-3cfaaf6c1604"), new Guid("b05c44eb-7568-4523-be49-08105fbb1106"), "auth0|65b7de875bf9ce48b47eedaa", 2, new DateTime(2023, 11, 22, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3132), new DateTime(2023, 11, 21, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3132), new DateTime(2023, 11, 20, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3133), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 127", 0, 2, "Ticket 127" },
                    { new Guid("7d52d70b-3b45-4c0d-8be4-84b863c8204a"), new Guid("86af32ca-f862-4f98-a7c2-e7ba19619301"), "auth0|65b7de875bf9ce48b47eedaa", 2, new DateTime(2024, 3, 5, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1520), new DateTime(2024, 3, 4, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1520), new DateTime(2024, 3, 3, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1521), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 23", 1, 2, "Ticket 23" },
                    { new Guid("7e406b1e-94fa-4937-b7cd-dc985b7ef06f"), new Guid("f79631e3-8401-451f-b49a-94a6b358807b"), "auth0|65b7de875bf9ce48b47eedaa", 2, new DateTime(2024, 1, 13, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2337), new DateTime(2024, 1, 12, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2336), new DateTime(2024, 1, 11, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2338), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 75", 2, 2, "Ticket 75" },
                    { new Guid("7e5a63f2-b6fc-4726-894a-e3986231a257"), new Guid("4cafe1b0-6478-4509-9433-80cc2a331b22"), "auth0|65b7dee72e02f54da98cd265", 0, new DateTime(2024, 1, 11, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2359), new DateTime(2024, 1, 10, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2358), new DateTime(2024, 1, 9, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2360), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 77", 1, 0, "Ticket 77" },
                    { new Guid("7f86d3a4-9f87-4922-8784-2b2c2bc671e2"), new Guid("63f070ef-1274-4658-b44a-96cc2c6ea907"), "auth0|65a4f8d7364ff592a0792a42", 1, null, null, new DateTime(2023, 8, 9, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4569), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 230", 1, 1, "Ticket 230" },
                    { new Guid("803dc2a8-e109-4e0d-9036-7b2b678487f8"), new Guid("8503793e-1bda-496e-a1da-3cf84041704b"), "auth0|65b7dee72e02f54da98cd265", 0, new DateTime(2024, 1, 7, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2408), new DateTime(2024, 1, 6, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2407), new DateTime(2024, 1, 5, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2409), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 81", 2, 0, "Ticket 81" },
                    { new Guid("805e4522-22d4-4ba9-9606-237cbcbf3406"), new Guid("9f00fd1f-21b1-47d1-ba85-c6f855d7fd17"), "auth0|65a4fd318d9d565392c4972a", 3, null, null, new DateTime(2023, 9, 20, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3969), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 188", 1, 3, "Ticket 188" },
                    { new Guid("80fc2108-1d7c-4680-95ce-29e79a96ca72"), new Guid("414b5098-3cf1-42e8-a3b0-c8648922eb21"), "auth0|65b7dee72e02f54da98cd265", 0, new DateTime(2023, 11, 24, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3110), new DateTime(2023, 11, 23, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3109), new DateTime(2023, 11, 22, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3110), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 125", 1, 0, "Ticket 125" },
                    { new Guid("81b6b5d2-c30e-453f-aaf9-e0cc38204566"), new Guid("d09ff1a6-375a-4c6b-b790-bb322b576874"), "auth0|65b7dee72e02f54da98cd265", 0, new DateTime(2023, 10, 3, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3840), new DateTime(2023, 10, 2, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3839), new DateTime(2023, 10, 1, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3840), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 177", 2, 0, "Ticket 177" },
                    { new Guid("840b538c-c56c-4183-b3fb-08409a50be9a"), new Guid("5a9cd035-c05b-484a-b4da-ee400ac432b2"), "auth0|65a4f8d7364ff592a0792a42", 1, null, null, new DateTime(2023, 8, 5, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4652), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 234", 2, 1, "Ticket 234" },
                    { new Guid("845d90d6-c092-473c-ad6e-63d94eff1c48"), new Guid("86af32ca-f862-4f98-a7c2-e7ba19619301"), "auth0|65b7dee72e02f54da98cd265", 0, new DateTime(2023, 12, 26, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2690), new DateTime(2023, 12, 25, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2689), new DateTime(2023, 12, 24, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2691), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 93", 2, 0, "Ticket 93" },
                    { new Guid("85251fd7-3ceb-4efe-b114-7c71bb07eb36"), new Guid("1106ab56-1576-4138-8521-a0ca8d9492e2"), "auth0|65a4fd318d9d565392c4972a", 3, null, null, new DateTime(2023, 10, 2, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3825), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 176", 1, 3, "Ticket 176" },
                    { new Guid("86db06c7-dcbc-4f89-b534-d4f1745d0f3f"), new Guid("ccebfce7-bf7e-4f44-a049-f78059d28a18"), "auth0|65b7de875bf9ce48b47eedaa", 2, new DateTime(2023, 8, 2, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4709), new DateTime(2023, 8, 1, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4709), new DateTime(2023, 7, 31, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4710), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 239", 1, 2, "Ticket 239" },
                    { new Guid("86fca3f8-e870-43ea-aad8-d922b050e153"), new Guid("0026da90-a1a9-41fa-933e-576ad76ffbf7"), "auth0|65a4fd318d9d565392c4972a", 3, null, null, new DateTime(2023, 8, 23, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4402), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 216", 2, 3, "Ticket 216" },
                    { new Guid("8c351a71-8a1c-484d-9e33-a6a62a44752d"), new Guid("be37261d-62bb-4d93-8982-4411941de97b"), "auth0|65a4f8d7364ff592a0792a42", 1, null, null, new DateTime(2023, 9, 6, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4204), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 202", 0, 1, "Ticket 202" },
                    { new Guid("8c3ede28-552b-4993-abde-28385c660343"), new Guid("9c4027f3-ed3b-49ca-8dd3-4332a7c29541"), "auth0|65b7de875bf9ce48b47eedaa", 2, new DateTime(2023, 11, 18, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3215), new DateTime(2023, 11, 17, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3214), new DateTime(2023, 11, 16, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3216), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 131", 1, 2, "Ticket 131" },
                    { new Guid("8df4742a-0e4f-4dc3-aefd-5adc78007b52"), new Guid("a8ad6597-7b4a-46d9-a2ff-647b86e7da1c"), "auth0|65a4fd318d9d565392c4972a", 3, null, null, new DateTime(2024, 3, 14, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1388), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 12", 2, 3, "Ticket 12" },
                    { new Guid("8ee262c2-68ff-424f-91b9-4b8c6a057ca4"), new Guid("1f43dce8-8941-4536-bcae-59b78ad071f8"), "auth0|65b7de875bf9ce48b47eedaa", 2, new DateTime(2024, 3, 13, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1422), new DateTime(2024, 3, 12, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1421), new DateTime(2024, 3, 11, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1423), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 15", 2, 2, "Ticket 15" },
                    { new Guid("8f573d27-b73d-4b9a-91bb-673b7c9e1433"), new Guid("ccbe957a-8557-47e4-9c99-ddccae845545"), "auth0|65a4f8d7364ff592a0792a42", 1, null, null, new DateTime(2023, 12, 7, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2890), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 110", 1, 1, "Ticket 110" },
                    { new Guid("9011b20c-a29b-46a9-a3e7-5ac7cd562f60"), new Guid("eeb7f210-bf39-4d83-83f2-ffa564208f5a"), "auth0|65b7de875bf9ce48b47eedaa", 2, new DateTime(2023, 8, 30, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4345), new DateTime(2023, 8, 29, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4345), new DateTime(2023, 8, 28, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4346), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 211", 0, 2, "Ticket 211" },
                    { new Guid("902a98b9-0be3-4617-bf5c-1e5143243ec5"), new Guid("d09ff1a6-375a-4c6b-b790-bb322b576874"), "auth0|65b7de875bf9ce48b47eedaa", 2, new DateTime(2023, 7, 25, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4804), new DateTime(2023, 7, 24, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4803), new DateTime(2023, 7, 23, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4805), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 247", 0, 2, "Ticket 247" },
                    { new Guid("91678406-1145-4ca6-9702-5440e71ad128"), new Guid("98781be4-7ee0-4934-b14f-51bfad3972e6"), "auth0|65a4f8d7364ff592a0792a42", 1, null, null, new DateTime(2023, 11, 9, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3298), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 138", 2, 1, "Ticket 138" },
                    { new Guid("94b16cca-111a-4ac9-ba96-ec872eaec438"), new Guid("96013f50-c6e1-4e8d-a6e4-d8ac93bdbdb8"), "auth0|65a4fd318d9d565392c4972a", 3, null, null, new DateTime(2023, 11, 7, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3321), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 140", 1, 3, "Ticket 140" },
                    { new Guid("94ff9add-b609-4c3d-8ee3-efaa15153aa0"), new Guid("89155141-a366-44db-b0a4-4376ec44dcfe"), "auth0|65b7de875bf9ce48b47eedaa", 2, new DateTime(2024, 2, 22, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1808), new DateTime(2024, 2, 21, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1808), new DateTime(2024, 2, 20, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1809), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 35", 1, 2, "Ticket 35" },
                    { new Guid("9525bd78-b7c5-42fd-997e-92107f6cefb2"), new Guid("eff36b81-3f39-4232-9410-85391584d000"), "auth0|65a4fd318d9d565392c4972a", 3, null, null, new DateTime(2023, 8, 27, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4358), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 212", 1, 3, "Ticket 212" },
                    { new Guid("9556361a-39a8-4ced-96e2-72c939a81a51"), new Guid("f8b91952-2bf0-4a59-9cd9-5e1f784eb79e"), "auth0|65a4f8d7364ff592a0792a42", 1, null, null, new DateTime(2023, 10, 12, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3659), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 166", 0, 1, "Ticket 166" },
                    { new Guid("956ba6f2-0104-4542-8117-e48ef6016545"), new Guid("054b5698-5d00-4f55-9132-ce0f5ea666bd"), "auth0|65a4f8d7364ff592a0792a42", 1, null, null, new DateTime(2024, 1, 28, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2114), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 58", 0, 1, "Ticket 58" },
                    { new Guid("96f99ebe-6bc0-4040-9611-7e891e07087c"), new Guid("110f2ffa-2825-4b68-b584-707b9c7cc472"), "auth0|65b7de875bf9ce48b47eedaa", 2, new DateTime(2024, 2, 10, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1948), new DateTime(2024, 2, 9, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1947), new DateTime(2024, 2, 8, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1948), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 47", 1, 2, "Ticket 47" },
                    { new Guid("9a555742-79ca-4eed-8f3d-36fae5d395e6"), new Guid("9c4027f3-ed3b-49ca-8dd3-4332a7c29541"), "auth0|65b7dee72e02f54da98cd265", 0, new DateTime(2023, 9, 9, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4193), new DateTime(2023, 9, 8, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4192), new DateTime(2023, 9, 7, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4194), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 201", 2, 0, "Ticket 201" },
                    { new Guid("9a6664df-652f-45ad-8816-6712880d72c1"), new Guid("6b414c7d-3fed-4932-a291-c7af0a50d852"), "auth0|65b7dee72e02f54da98cd265", 0, new DateTime(2023, 12, 18, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2785), new DateTime(2023, 12, 17, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2784), new DateTime(2023, 12, 16, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2786), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 101", 1, 0, "Ticket 101" },
                    { new Guid("9aa2c16c-1cab-4156-b4f7-57e9427a47b1"), new Guid("1106ab56-1576-4138-8521-a0ca8d9492e2"), "auth0|65a4f8d7364ff592a0792a42", 1, null, null, new DateTime(2023, 7, 24, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4792), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 246", 2, 1, "Ticket 246" },
                    { new Guid("9b03af0b-6c86-473f-9cce-625e03672a54"), new Guid("dcc3349d-654c-4415-8815-cedcbc349126"), "auth0|65a4fd318d9d565392c4972a", 3, null, null, new DateTime(2023, 8, 15, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4497), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 224", 1, 3, "Ticket 224" },
                    { new Guid("9b21707f-4886-45b8-befa-fe54300d4015"), new Guid("ccbe957a-8557-47e4-9c99-ddccae845545"), "auth0|65a4f8d7364ff592a0792a42", 1, null, null, new DateTime(2023, 7, 20, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4842), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 250", 0, 1, "Ticket 250" },
                    { new Guid("9b3994d3-69cd-4e9b-b3bf-42afa656e10c"), new Guid("01610c7a-9e93-41c4-88bf-65ff2ed11f50"), "auth0|65a4fd318d9d565392c4972a", 3, null, null, new DateTime(2023, 12, 29, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2578), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 88", 0, 3, "Ticket 88" },
                    { new Guid("9d48c4b0-9d73-48d5-81ff-830653393421"), new Guid("53b1cab2-6315-4281-800d-1338b8df64d8"), "auth0|65b7de875bf9ce48b47eedaa", 2, new DateTime(2024, 1, 25, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2170), new DateTime(2024, 1, 24, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2169), new DateTime(2024, 1, 23, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2171), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 63", 2, 2, "Ticket 63" },
                    { new Guid("9dc434a9-7a19-4184-9dcf-0f0da9d7ded9"), new Guid("da962695-902b-40ef-a0ca-2ea3599659e8"), "auth0|65b7de875bf9ce48b47eedaa", 2, new DateTime(2023, 9, 11, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4167), new DateTime(2023, 9, 10, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4166), new DateTime(2023, 9, 9, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4167), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 199", 0, 2, "Ticket 199" },
                    { new Guid("9e88d5e5-91d8-4473-896e-bcceb2e123a3"), new Guid("1f43dce8-8941-4536-bcae-59b78ad071f8"), "auth0|65b7de875bf9ce48b47eedaa", 2, new DateTime(2023, 10, 25, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3531), new DateTime(2023, 10, 24, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3530), new DateTime(2023, 10, 23, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3531), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 155", 1, 2, "Ticket 155" },
                    { new Guid("9ea2faeb-a34d-47f1-bc45-a70aaaa0e58f"), new Guid("0ddf2d45-9f40-4fcd-80a2-5286ec667ad1"), "auth0|65a4fd318d9d565392c4972a", 3, null, null, new DateTime(2023, 12, 1, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3005), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 116", 1, 3, "Ticket 116" },
                    { new Guid("9f2b47b0-2d35-43dd-a845-698c2e48f48d"), new Guid("d7657a73-2859-4353-95a2-c720d5341882"), "auth0|65b7dee72e02f54da98cd265", 0, new DateTime(2023, 9, 5, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4239), new DateTime(2023, 9, 4, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4238), new DateTime(2023, 9, 3, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4240), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 205", 0, 0, "Ticket 205" },
                    { new Guid("9f368f4a-ebe0-4141-8ca7-f2faf54f4129"), new Guid("696346f6-5cf4-4bcf-997b-f7541af90e31"), "auth0|65b7de875bf9ce48b47eedaa", 2, new DateTime(2024, 1, 5, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2431), new DateTime(2024, 1, 4, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2430), new DateTime(2024, 1, 3, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2431), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 83", 1, 2, "Ticket 83" },
                    { new Guid("9f7f2ade-ab29-4a58-8bf9-b70da2e908ee"), new Guid("e7658228-f102-46ce-ad6d-eb770c11ddee"), "auth0|65b7de875bf9ce48b47eedaa", 2, new DateTime(2023, 12, 16, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2807), new DateTime(2023, 12, 15, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2807), new DateTime(2023, 12, 14, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2808), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 103", 0, 2, "Ticket 103" },
                    { new Guid("9fdaecaa-8e68-4b9a-b9d7-27270a14b12d"), new Guid("94c5d955-ff84-44ba-8297-4212f5a2eb57"), "auth0|65a4f8d7364ff592a0792a42", 1, null, null, new DateTime(2023, 10, 8, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3757), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 170", 1, 1, "Ticket 170" },
                    { new Guid("a066a7c2-e868-43fb-a03a-debd6e85783c"), new Guid("64b45b41-2ae7-4798-93cd-b226d2340502"), "auth0|65a4f8d7364ff592a0792a42", 1, null, null, new DateTime(2024, 2, 1, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2066), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 54", 2, 1, "Ticket 54" },
                    { new Guid("a0afdaa2-3aef-46dc-9a3a-64f09dffad53"), new Guid("5a9cd035-c05b-484a-b4da-ee400ac432b2"), "auth0|65a4fd318d9d565392c4972a", 3, null, null, new DateTime(2023, 10, 14, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3636), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 164", 1, 3, "Ticket 164" },
                    { new Guid("a0ff5cea-2464-4ee7-a803-b13822735c00"), new Guid("c3bc7db1-01e3-45b3-a534-5411c807285e"), "auth0|65a4fd318d9d565392c4972a", 3, null, null, new DateTime(2023, 9, 16, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4085), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 192", 2, 3, "Ticket 192" },
                    { new Guid("a1027730-d304-4e47-b403-bc27fe789569"), new Guid("72e10416-635b-4d83-a77b-d572193637da"), "auth0|65a4f8d7364ff592a0792a42", 1, null, null, new DateTime(2023, 12, 3, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2982), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 114", 2, 1, "Ticket 114" },
                    { new Guid("a18efb45-73d3-4021-87b6-fb8a70cea103"), new Guid("696346f6-5cf4-4bcf-997b-f7541af90e31"), "auth0|65b7dee72e02f54da98cd265", 0, new DateTime(2023, 10, 27, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3508), new DateTime(2023, 10, 26, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3507), new DateTime(2023, 10, 25, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3508), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 153", 2, 0, "Ticket 153" },
                    { new Guid("a27f4362-26a5-4306-a680-464ff62e417b"), new Guid("98781be4-7ee0-4934-b14f-51bfad3972e6"), "auth0|65a4fd318d9d565392c4972a", 3, null, null, new DateTime(2023, 8, 31, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4274), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 208", 0, 3, "Ticket 208" },
                    { new Guid("a37ad342-98ed-4411-92f6-63b779f35ddf"), new Guid("eeb7f210-bf39-4d83-83f2-ffa564208f5a"), "auth0|65b7dee72e02f54da98cd265", 0, new DateTime(2024, 3, 27, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1189), new DateTime(2024, 3, 26, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1185), new DateTime(2024, 3, 25, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1191), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 1", 0, 0, "Ticket 1" },
                    { new Guid("a4afa5cc-9f51-498b-8881-9e1b5852b734"), new Guid("0f50b1be-1daa-4064-9e83-c4ded856a098"), "auth0|65b7dee72e02f54da98cd265", 0, new DateTime(2023, 10, 31, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3459), new DateTime(2023, 10, 30, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3458), new DateTime(2023, 10, 29, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3460), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 149", 1, 0, "Ticket 149" },
                    { new Guid("a53f8fb3-e58b-49de-90b7-af25823e3a19"), new Guid("76b28a73-a636-49f8-8b00-e9beb754a1d0"), "auth0|65b7dee72e02f54da98cd265", 0, new DateTime(2023, 9, 17, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4099), new DateTime(2023, 9, 16, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4098), new DateTime(2023, 9, 15, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4100), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 193", 0, 0, "Ticket 193" },
                    { new Guid("a5c02e0f-70be-433a-8cc2-cbd0b5013a82"), new Guid("5a9cd035-c05b-484a-b4da-ee400ac432b2"), "auth0|65a4fd318d9d565392c4972a", 3, null, null, new DateTime(2024, 3, 2, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1532), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 24", 2, 3, "Ticket 24" },
                    { new Guid("a5d26f57-ac56-4c32-b67d-112bac90b694"), new Guid("7e6932ef-fe3a-4e22-bf03-be4c9fb40b68"), "auth0|65b7de875bf9ce48b47eedaa", 2, new DateTime(2023, 8, 14, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4534), new DateTime(2023, 8, 13, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4534), new DateTime(2023, 8, 12, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4535), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 227", 1, 2, "Ticket 227" },
                    { new Guid("a61bb99a-e08b-4136-90cf-4daea6eb7e26"), new Guid("f8b91952-2bf0-4a59-9cd9-5e1f784eb79e"), "auth0|65a4fd318d9d565392c4972a", 3, null, null, new DateTime(2023, 12, 21, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2724), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 96", 2, 3, "Ticket 96" },
                    { new Guid("a65e02b8-6839-49d7-a0b0-0d929301f3e1"), new Guid("01610c7a-9e93-41c4-88bf-65ff2ed11f50"), "auth0|65a4fd318d9d565392c4972a", 3, null, null, new DateTime(2023, 8, 11, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4546), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 228", 2, 3, "Ticket 228" },
                    { new Guid("a6e11c8d-6123-4ffa-8eee-c19d6da581ec"), new Guid("5cea12db-210f-424f-9310-a9594619b930"), "auth0|65b7dee72e02f54da98cd265", 0, new DateTime(2023, 9, 1, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4289), new DateTime(2023, 8, 31, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4288), new DateTime(2023, 8, 30, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4290), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 209", 1, 0, "Ticket 209" },
                    { new Guid("ab24842a-b440-4942-a676-b0777c3da0e0"), new Guid("63f070ef-1274-4658-b44a-96cc2c6ea907"), "auth0|65a4fd318d9d565392c4972a", 3, null, null, new DateTime(2023, 10, 18, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3587), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 160", 0, 3, "Ticket 160" },
                    { new Guid("ab4870a9-e948-4d89-ad1e-608a651c9c54"), new Guid("53b1cab2-6315-4281-800d-1338b8df64d8"), "auth0|65b7dee72e02f54da98cd265", 0, new DateTime(2023, 11, 16, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3237), new DateTime(2023, 11, 15, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3236), new DateTime(2023, 11, 14, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3238), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 133", 0, 0, "Ticket 133" },
                    { new Guid("ab4f3d51-9842-44ce-9eb5-a9130d9a4252"), new Guid("880f1059-f46d-4d66-baea-a8a75b787d24"), "auth0|65a4fd318d9d565392c4972a", 3, null, null, new DateTime(2023, 9, 4, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4227), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 204", 2, 3, "Ticket 204" },
                    { new Guid("ab83995a-d844-4ec2-a5a9-207a31b4dcbd"), new Guid("f79631e3-8401-451f-b49a-94a6b358807b"), "auth0|65b7dee72e02f54da98cd265", 0, new DateTime(2024, 3, 23, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1243), new DateTime(2024, 3, 22, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1242), new DateTime(2024, 3, 21, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1244), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 5", 1, 0, "Ticket 5" },
                    { new Guid("adba5620-7a35-48ad-a232-35343e6ddc41"), new Guid("ccebfce7-bf7e-4f44-a049-f78059d28a18"), "auth0|65b7dee72e02f54da98cd265", 0, new DateTime(2024, 2, 28, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1594), new DateTime(2024, 2, 27, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1593), new DateTime(2024, 2, 26, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1594), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 29", 1, 0, "Ticket 29" },
                    { new Guid("ae782864-3ef0-4221-ad23-c78f98440ea1"), new Guid("01610c7a-9e93-41c4-88bf-65ff2ed11f50"), "auth0|65a4f8d7364ff592a0792a42", 1, null, null, new DateTime(2024, 3, 8, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1461), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 18", 2, 1, "Ticket 18" },
                    { new Guid("aeba0d96-aada-4cd6-92b7-14aed9ed871c"), new Guid("13a41e4c-47b5-4393-8b01-110462a3d083"), "auth0|65a4f8d7364ff592a0792a42", 1, null, null, new DateTime(2023, 12, 15, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2796), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 102", 2, 1, "Ticket 102" },
                    { new Guid("b060c73e-3b74-42f7-b8a9-b7981c45d053"), new Guid("c049086d-9699-4ee0-ab6b-f1a4802b03ee"), "auth0|65a4f8d7364ff592a0792a42", 1, null, null, new DateTime(2023, 8, 13, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4523), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 226", 0, 1, "Ticket 226" },
                    { new Guid("b1bc83ce-57f4-429c-92c2-1e6b38c93ec2"), new Guid("a8ad6597-7b4a-46d9-a2ff-647b86e7da1c"), "auth0|65a4f8d7364ff592a0792a42", 1, null, null, new DateTime(2024, 1, 4, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2419), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 82", 0, 1, "Ticket 82" },
                    { new Guid("b3f765a4-eeae-4520-ae1e-02e61a58c36c"), new Guid("e6a5501a-de17-4657-a9d3-9aa5b74f862c"), "auth0|65a4fd318d9d565392c4972a", 3, null, null, new DateTime(2023, 10, 30, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3447), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 148", 0, 3, "Ticket 148" },
                    { new Guid("b470f86e-baab-4452-8ee8-c167a94ad50f"), new Guid("53b1cab2-6315-4281-800d-1338b8df64d8"), "auth0|65b7de875bf9ce48b47eedaa", 2, new DateTime(2023, 9, 7, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4216), new DateTime(2023, 9, 6, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4215), new DateTime(2023, 9, 5, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4217), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 203", 1, 2, "Ticket 203" },
                    { new Guid("b5689f62-2b2f-47d8-a228-758036d61014"), new Guid("eff36b81-3f39-4232-9410-85391584d000"), "auth0|65a4f8d7364ff592a0792a42", 1, null, null, new DateTime(2023, 11, 5, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3343), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 142", 0, 1, "Ticket 142" },
                    { new Guid("b5993e07-5409-49cb-ab73-1f8385f4cfa6"), new Guid("c049086d-9699-4ee0-ab6b-f1a4802b03ee"), "auth0|65a4fd318d9d565392c4972a", 3, null, null, new DateTime(2024, 3, 10, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1433), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 16", 0, 3, "Ticket 16" },
                    { new Guid("b64edbd1-84f5-4204-91b2-61d53d0ea8e2"), new Guid("64b45b41-2ae7-4798-93cd-b226d2340502"), "auth0|65a4fd318d9d565392c4972a", 3, null, null, new DateTime(2023, 11, 23, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3098), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 124", 0, 3, "Ticket 124" },
                    { new Guid("b83d9e45-42ef-493a-b3a6-5f5e8a9d2dd5"), new Guid("0026da90-a1a9-41fa-933e-576ad76ffbf7"), "auth0|65a4fd318d9d565392c4972a", 3, null, null, new DateTime(2024, 1, 10, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2348), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 76", 0, 3, "Ticket 76" },
                    { new Guid("b96be621-d5ec-4c10-8bf6-de60de9f5baf"), new Guid("e954c356-7846-4438-95ad-efce405cbe87"), "auth0|65b7de875bf9ce48b47eedaa", 2, new DateTime(2024, 3, 25, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1220), new DateTime(2024, 3, 24, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1219), new DateTime(2024, 3, 23, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1221), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 3", 2, 2, "Ticket 3" },
                    { new Guid("ba6fb47f-779a-4c6d-a8c4-cdf3a9031122"), new Guid("89155141-a366-44db-b0a4-4376ec44dcfe"), "auth0|65b7dee72e02f54da98cd265", 0, new DateTime(2023, 12, 14, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2833), new DateTime(2023, 12, 13, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2832), new DateTime(2023, 12, 12, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2834), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 105", 2, 0, "Ticket 105" },
                    { new Guid("bb217052-496a-4360-8bd8-95b8bb251814"), new Guid("eff36b81-3f39-4232-9410-85391584d000"), "auth0|65a4fd318d9d565392c4972a", 3, null, null, new DateTime(2024, 1, 14, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2299), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 72", 2, 3, "Ticket 72" },
                    { new Guid("bb2eee7c-e6f0-466d-9a4e-c3b33fa622fa"), new Guid("5a9cd035-c05b-484a-b4da-ee400ac432b2"), "auth0|65a4f8d7364ff592a0792a42", 1, null, null, new DateTime(2023, 12, 23, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2701), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 94", 0, 1, "Ticket 94" },
                    { new Guid("bb8d4e32-8752-44b5-9d81-378301ea41a3"), new Guid("1106ab56-1576-4138-8521-a0ca8d9492e2"), "auth0|65a4f8d7364ff592a0792a42", 1, null, null, new DateTime(2023, 12, 11, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2845), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 106", 0, 1, "Ticket 106" },
                    { new Guid("bc3941e7-6de0-4bc5-a212-036b1a856eda"), new Guid("72e10416-635b-4d83-a77b-d572193637da"), "auth0|65a4fd318d9d565392c4972a", 3, null, null, new DateTime(2023, 9, 24, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3920), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 184", 0, 3, "Ticket 184" },
                    { new Guid("bcf5d9eb-e164-42f9-bafe-4562e25f9d3a"), new Guid("ccbe957a-8557-47e4-9c99-ddccae845545"), "auth0|65a4fd318d9d565392c4972a", 3, null, null, new DateTime(2024, 2, 15, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1865), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 40", 0, 3, "Ticket 40" },
                    { new Guid("beb3a522-54ee-4c53-80a5-1e4868ca8f2b"), new Guid("8503793e-1bda-496e-a1da-3cf84041704b"), "auth0|65b7de875bf9ce48b47eedaa", 2, new DateTime(2023, 10, 29, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3481), new DateTime(2023, 10, 28, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3481), new DateTime(2023, 10, 27, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3482), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 151", 0, 2, "Ticket 151" },
                    { new Guid("bf3c2f8d-b9b2-4ff7-9297-ec3e95a5d194"), new Guid("a1952de2-fdf7-469f-bae6-092993cb4c01"), "auth0|65b7dee72e02f54da98cd265", 0, new DateTime(2023, 12, 6, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2971), new DateTime(2023, 12, 5, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2970), new DateTime(2023, 12, 4, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2972), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 113", 1, 0, "Ticket 113" },
                    { new Guid("c215b42d-c311-4cb3-9ef8-55d14fee20aa"), new Guid("f7358570-ea64-4912-81b3-d3ef3a255b2e"), "auth0|65b7dee72e02f54da98cd265", 0, new DateTime(2024, 2, 16, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1880), new DateTime(2024, 2, 15, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1879), new DateTime(2024, 2, 14, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1881), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 41", 1, 0, "Ticket 41" },
                    { new Guid("c32435d8-fc84-4b04-80b4-b4beea7de94c"), new Guid("e7658228-f102-46ce-ad6d-eb770c11ddee"), "auth0|65b7dee72e02f54da98cd265", 0, new DateTime(2024, 2, 24, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1696), new DateTime(2024, 2, 23, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1695), new DateTime(2024, 2, 22, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1697), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 33", 2, 0, "Ticket 33" },
                    { new Guid("c33a6f6e-8fff-488c-a53e-2323bdb8d20c"), new Guid("b05c44eb-7568-4523-be49-08105fbb1106"), "auth0|65b7dee72e02f54da98cd265", 0, new DateTime(2023, 9, 13, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4144), new DateTime(2023, 9, 12, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4143), new DateTime(2023, 9, 11, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4145), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 197", 1, 0, "Ticket 197" },
                    { new Guid("c53e32b5-f856-4e4e-8473-39b851a782ce"), new Guid("be37261d-62bb-4d93-8982-4411941de97b"), "auth0|65a4fd318d9d565392c4972a", 3, null, null, new DateTime(2023, 11, 15, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3226), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 132", 2, 3, "Ticket 132" },
                    { new Guid("cacb880c-54d0-4bf0-8186-2b82479f71ea"), new Guid("696346f6-5cf4-4bcf-997b-f7541af90e31"), "auth0|65b7de875bf9ce48b47eedaa", 2, new DateTime(2023, 8, 18, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4485), new DateTime(2023, 8, 17, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4484), new DateTime(2023, 8, 16, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4486), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 223", 0, 2, "Ticket 223" },
                    { new Guid("cbd9b112-3d23-4009-acc4-f157c6f80e01"), new Guid("01610c7a-9e93-41c4-88bf-65ff2ed11f50"), "auth0|65a4f8d7364ff592a0792a42", 1, null, null, new DateTime(2023, 10, 20, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3564), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 158", 1, 1, "Ticket 158" },
                    { new Guid("cce91bca-38f2-4f74-be64-cf5eab50e48c"), new Guid("9f00fd1f-21b1-47d1-ba85-c6f855d7fd17"), "auth0|65a4f8d7364ff592a0792a42", 1, null, null, new DateTime(2023, 11, 29, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3028), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 118", 0, 1, "Ticket 118" },
                    { new Guid("cd1fbfe1-b09e-4496-a9f2-8664a276d716"), new Guid("98781be4-7ee0-4934-b14f-51bfad3972e6"), "auth0|65a4fd318d9d565392c4972a", 3, null, null, new DateTime(2024, 1, 18, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2232), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 68", 1, 3, "Ticket 68" },
                    { new Guid("cd27303a-cbb5-4e24-8327-59059e1dc9ee"), new Guid("f0b38660-d5db-4f9d-9729-94358cb7bdb5"), "auth0|65b7de875bf9ce48b47eedaa", 2, new DateTime(2023, 10, 21, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3576), new DateTime(2023, 10, 20, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3575), new DateTime(2023, 10, 19, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3577), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 159", 2, 2, "Ticket 159" },
                    { new Guid("cd51358f-e52d-4b83-bfa3-bc9abc7cdd18"), new Guid("341f9b78-ce17-42e9-9091-dbefeba89d3b"), "auth0|65a4f8d7364ff592a0792a42", 1, null, null, new DateTime(2024, 2, 17, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1842), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 38", 1, 1, "Ticket 38" },
                    { new Guid("d06373a6-9369-4e27-80c7-43fc2091ef13"), new Guid("341f9b78-ce17-42e9-9091-dbefeba89d3b"), "auth0|65a4f8d7364ff592a0792a42", 1, null, null, new DateTime(2023, 9, 30, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3852), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 178", 0, 1, "Ticket 178" },
                    { new Guid("d1b657a9-9924-4d3d-9c46-c99eb6a29f69"), new Guid("eff36b81-3f39-4232-9410-85391584d000"), "auth0|65a4f8d7364ff592a0792a42", 1, null, null, new DateTime(2024, 3, 24, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1208), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 2", 1, 1, "Ticket 2" },
                    { new Guid("d3ac7618-d326-411e-946a-9e65bbdf0111"), new Guid("110f2ffa-2825-4b68-b584-707b9c7cc472"), "auth0|65b7de875bf9ce48b47eedaa", 2, new DateTime(2023, 9, 23, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3957), new DateTime(2023, 9, 22, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3956), new DateTime(2023, 9, 21, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3958), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 187", 0, 2, "Ticket 187" },
                    { new Guid("d441a565-9c71-4e5e-8707-a32eafa5e4d8"), new Guid("0f5e4c81-1dee-4681-9e74-62f77ae22cb4"), "auth0|65a4f8d7364ff592a0792a42", 1, null, null, new DateTime(2024, 1, 12, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2326), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 74", 1, 1, "Ticket 74" },
                    { new Guid("d476196b-79dc-4cf9-b5d8-8e0e047c0cb6"), new Guid("c049086d-9699-4ee0-ab6b-f1a4802b03ee"), "auth0|65a4fd318d9d565392c4972a", 3, null, null, new DateTime(2023, 10, 22, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3542), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 156", 2, 3, "Ticket 156" },
                    { new Guid("d4d3f721-b19e-4b8d-b252-a790ab9add77"), new Guid("4610a824-5bae-4dce-ad57-22e6d63ecd30"), "auth0|65a4f8d7364ff592a0792a42", 1, null, null, new DateTime(2024, 2, 21, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1795), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 34", 0, 1, "Ticket 34" },
                    { new Guid("d56732f2-03c2-4369-9755-ba26cb906397"), new Guid("dcc3349d-654c-4415-8815-cedcbc349126"), "auth0|65a4f8d7364ff592a0792a42", 1, null, null, new DateTime(2024, 3, 12, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1411), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 14", 1, 1, "Ticket 14" },
                    { new Guid("d84cd009-917b-4352-8695-935dce692d35"), new Guid("7e0d6368-b609-43da-ad5f-1be2ebaa2301"), "auth0|65a4fd318d9d565392c4972a", 3, null, null, new DateTime(2024, 1, 6, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2393), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 80", 1, 3, "Ticket 80" },
                    { new Guid("d91d6a4c-d8cb-45e0-ab98-858c98f35711"), new Guid("a1952de2-fdf7-469f-bae6-092993cb4c01"), "auth0|65b7de875bf9ce48b47eedaa", 2, new DateTime(2024, 2, 14, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1903), new DateTime(2024, 2, 13, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1902), new DateTime(2024, 2, 12, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1904), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 43", 0, 2, "Ticket 43" },
                    { new Guid("da02f503-5622-4467-a079-cee059d59758"), new Guid("6b414c7d-3fed-4932-a291-c7af0a50d852"), "auth0|65b7de875bf9ce48b47eedaa", 2, new DateTime(2024, 2, 26, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1670), new DateTime(2024, 2, 25, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1669), new DateTime(2024, 2, 24, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1670), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 31", 0, 2, "Ticket 31" },
                    { new Guid("da8eeb85-e519-47e6-aa59-afe5c13ddc7e"), new Guid("e954c356-7846-4438-95ad-efce405cbe87"), "auth0|65b7de875bf9ce48b47eedaa", 2, new DateTime(2023, 11, 6, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3355), new DateTime(2023, 11, 5, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3354), new DateTime(2023, 11, 4, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3356), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 143", 1, 2, "Ticket 143" },
                    { new Guid("dcc66d08-5297-44d1-9efc-799c92ddcda7"), new Guid("4f7996f8-66bb-49c9-875e-2cddf0c6dd31"), "auth0|65a4f8d7364ff592a0792a42", 1, null, null, new DateTime(2023, 11, 17, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3203), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 130", 0, 1, "Ticket 130" },
                    { new Guid("dce99faa-6821-43a5-b70d-c1947bb97284"), new Guid("ec4337d3-7aa8-4396-831e-4eb510aa5bb1"), "auth0|65b7dee72e02f54da98cd265", 0, new DateTime(2024, 2, 8, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1974), new DateTime(2024, 2, 7, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1973), new DateTime(2024, 2, 6, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1975), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 49", 0, 0, "Ticket 49" },
                    { new Guid("dd192957-71ba-446c-9fd1-04ff27a0d8f6"), new Guid("0f50b1be-1daa-4064-9e83-c4ded856a098"), "auth0|65b7de875bf9ce48b47eedaa", 2, new DateTime(2023, 8, 22, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4440), new DateTime(2023, 8, 21, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4439), new DateTime(2023, 8, 20, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4441), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 219", 2, 2, "Ticket 219" },
                    { new Guid("df569a0b-5ef8-49b4-9538-cadc8b75e73e"), new Guid("4610a824-5bae-4dce-ad57-22e6d63ecd30"), "auth0|65a4f8d7364ff592a0792a42", 1, null, null, new DateTime(2023, 10, 4, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3802), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 174", 2, 1, "Ticket 174" },
                    { new Guid("dfff82f4-535e-4224-92eb-277bb7763b28"), new Guid("7ec48e58-03e0-42ef-b69d-3ca5d36a540d"), "auth0|65a4f8d7364ff592a0792a42", 1, null, null, new DateTime(2023, 12, 19, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2750), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 98", 1, 1, "Ticket 98" },
                    { new Guid("e2d9c5fb-8814-494f-8dd1-41ad987ab09f"), new Guid("c4d38b52-d1a2-4a0e-8de5-85eb2fcd6604"), "auth0|65b7dee72e02f54da98cd265", 0, new DateTime(2023, 10, 19, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3602), new DateTime(2023, 10, 18, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3601), new DateTime(2023, 10, 17, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3603), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 161", 1, 0, "Ticket 161" },
                    { new Guid("e6a29602-1049-49ba-99a8-2015f619fa69"), new Guid("76b28a73-a636-49f8-8b00-e9beb754a1d0"), "auth0|65b7de875bf9ce48b47eedaa", 2, new DateTime(2023, 11, 26, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3087), new DateTime(2023, 11, 25, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3086), new DateTime(2023, 11, 24, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3088), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 123", 2, 2, "Ticket 123" },
                    { new Guid("e7125198-6e85-40b1-b7d4-385aed51be0f"), new Guid("f0b38660-d5db-4f9d-9729-94358cb7bdb5"), "auth0|65b7de875bf9ce48b47eedaa", 2, new DateTime(2024, 3, 9, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1473), new DateTime(2024, 3, 8, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1472), new DateTime(2024, 3, 7, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1474), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 19", 0, 2, "Ticket 19" },
                    { new Guid("e7d7a943-200d-43ac-9aba-1fd51932ebd2"), new Guid("4610a824-5bae-4dce-ad57-22e6d63ecd30"), "auth0|65a4fd318d9d565392c4972a", 3, null, null, new DateTime(2023, 7, 26, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4770), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 244", 0, 3, "Ticket 244" },
                    { new Guid("e8104eae-45d0-451f-8a30-326b7b57056b"), new Guid("a6e966cd-eb16-403e-93ce-0a7f7e318a6b"), "auth0|65b7de875bf9ce48b47eedaa", 2, new DateTime(2023, 8, 6, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4663), new DateTime(2023, 8, 5, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4663), new DateTime(2023, 8, 4, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4664), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 235", 0, 2, "Ticket 235" },
                    { new Guid("e8196afe-f0ff-49c6-a2bb-00a91844e338"), new Guid("76b28a73-a636-49f8-8b00-e9beb754a1d0"), "auth0|65b7dee72e02f54da98cd265", 0, new DateTime(2024, 2, 4, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2055), new DateTime(2024, 2, 3, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2054), new DateTime(2024, 2, 2, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2055), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 53", 1, 0, "Ticket 53" },
                    { new Guid("e94bb023-76fc-4fd7-9141-0378d94eef01"), new Guid("ccebfce7-bf7e-4f44-a049-f78059d28a18"), "auth0|65b7dee72e02f54da98cd265", 0, new DateTime(2023, 10, 11, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3743), new DateTime(2023, 10, 10, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3742), new DateTime(2023, 10, 9, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3744), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 169", 0, 0, "Ticket 169" },
                    { new Guid("e97eaca4-7e1a-4dfc-9227-c150f4fef315"), new Guid("e954c356-7846-4438-95ad-efce405cbe87"), "auth0|65b7dee72e02f54da98cd265", 0, new DateTime(2023, 8, 28, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4369), new DateTime(2023, 8, 27, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4368), new DateTime(2023, 8, 26, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4369), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 213", 2, 0, "Ticket 213" },
                    { new Guid("e9c90bf9-b7c0-4a2b-8cd9-898b57978d55"), new Guid("72e10416-635b-4d83-a77b-d572193637da"), "auth0|65a4fd318d9d565392c4972a", 3, null, null, new DateTime(2024, 2, 11, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1914), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 44", 1, 3, "Ticket 44" },
                    { new Guid("ec6e65d3-d0b5-4713-8b8f-3273540a9e38"), new Guid("9c4027f3-ed3b-49ca-8dd3-4332a7c29541"), "auth0|65b7dee72e02f54da98cd265", 0, new DateTime(2024, 1, 27, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2148), new DateTime(2024, 1, 26, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2147), new DateTime(2024, 1, 25, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2149), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 61", 0, 0, "Ticket 61" },
                    { new Guid("ede6eba2-a58f-4ffc-90cc-023fcc8dfead"), new Guid("63f070ef-1274-4658-b44a-96cc2c6ea907"), "auth0|65a4f8d7364ff592a0792a42", 1, null, null, new DateTime(2023, 12, 27, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2604), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 90", 2, 1, "Ticket 90" },
                    { new Guid("f082d15d-e079-4f6c-b1a7-8612b774c8dc"), new Guid("d09ff1a6-375a-4c6b-b790-bb322b576874"), "auth0|65b7de875bf9ce48b47eedaa", 2, new DateTime(2023, 12, 12, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2856), new DateTime(2023, 12, 11, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2855), new DateTime(2023, 12, 10, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2857), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 107", 1, 2, "Ticket 107" },
                    { new Guid("f129fac4-84d5-4f0c-8cbd-c5eec54c764e"), new Guid("f0b38660-d5db-4f9d-9729-94358cb7bdb5"), "auth0|65b7dee72e02f54da98cd265", 0, new DateTime(2023, 12, 30, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2593), new DateTime(2023, 12, 29, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2592), new DateTime(2023, 12, 28, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2594), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 89", 1, 0, "Ticket 89" },
                    { new Guid("f2b2f031-c942-4284-9017-8aee8e2f6f3e"), new Guid("c4d38b52-d1a2-4a0e-8de5-85eb2fcd6604"), "auth0|65b7dee72e02f54da98cd265", 0, new DateTime(2024, 3, 7, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1497), new DateTime(2024, 3, 6, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1496), new DateTime(2024, 3, 5, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(1498), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 21", 2, 0, "Ticket 21" },
                    { new Guid("f3c0f785-d823-4714-881e-0a785bdab819"), new Guid("5da46ea0-bac0-4152-b19d-5aec098d62ae"), "auth0|65a4f8d7364ff592a0792a42", 1, null, null, new DateTime(2024, 1, 20, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(2210), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 66", 2, 1, "Ticket 66" },
                    { new Guid("f59f3cce-dffe-4656-8030-9a8f42b913b8"), new Guid("64b45b41-2ae7-4798-93cd-b226d2340502"), "auth0|65a4f8d7364ff592a0792a42", 1, null, null, new DateTime(2023, 9, 14, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4111), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 194", 1, 1, "Ticket 194" },
                    { new Guid("f900b06d-ba99-44ff-b871-23865ab69e0e"), new Guid("13a41e4c-47b5-4393-8b01-110462a3d083"), "auth0|65a4fd318d9d565392c4972a", 3, null, null, new DateTime(2023, 10, 6, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3779), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 172", 0, 3, "Ticket 172" },
                    { new Guid("f919b446-3888-411e-a9b7-47e3f3b880ff"), new Guid("0026da90-a1a9-41fa-933e-576ad76ffbf7"), "auth0|65a4f8d7364ff592a0792a42", 1, null, null, new DateTime(2023, 11, 1, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3392), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 146", 1, 1, "Ticket 146" },
                    { new Guid("f92bc732-2791-4001-9b17-2ee86c4e78a2"), new Guid("dcc3349d-654c-4415-8815-cedcbc349126"), "auth0|65a4f8d7364ff592a0792a42", 1, null, null, new DateTime(2023, 10, 24, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(3519), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 154", 0, 1, "Ticket 154" },
                    { new Guid("fc3c5529-89f3-4dee-b28c-81c494851d29"), new Guid("f8b91952-2bf0-4a59-9cd9-5e1f784eb79e"), "auth0|65a4fd318d9d565392c4972a", 3, null, null, new DateTime(2023, 8, 3, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(4675), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 236", 1, 3, "Ticket 236" }
                });

            migrationBuilder.InsertData(
                table: "WorkItems",
                columns: new[] { "WorkItemId", "AssetId", "Category", "CreatedAt", "CreatorUserID", "Description", "Priority", "Status", "Title" },
                values: new object[,]
                {
                    { new Guid("00d3f797-487f-444b-9041-1210e0fc15d2"), new Guid("86af32ca-f862-4f98-a7c2-e7ba19619301"), 0, new DateTime(2023, 12, 24, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(4930), null, "Description for WorkItem 93", 2, 2, "WorkItem 93" },
                    { new Guid("00f0209a-d833-4d93-b38f-10abeab4eaa9"), new Guid("c7f7d3d3-2f4d-4e85-9e35-74e23e44d5f9"), 3, new DateTime(2023, 8, 7, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(8205), null, "Description for WorkItem 232", 0, 0, "WorkItem 232" },
                    { new Guid("01627bb0-fb0c-4d48-bd4f-d941f0d32da0"), new Guid("4610a824-5bae-4dce-ad57-22e6d63ecd30"), 3, new DateTime(2023, 7, 26, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(8371), null, "Description for WorkItem 244", 0, 0, "WorkItem 244" },
                    { new Guid("01c6fa59-e7b6-4af9-9ad9-3676c83686db"), new Guid("53b1cab2-6315-4281-800d-1338b8df64d8"), 0, new DateTime(2023, 11, 14, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(5508), null, "Description for WorkItem 133", 0, 0, "WorkItem 133" },
                    { new Guid("02bd5b1f-f8b1-46cd-875d-eaa46a642015"), new Guid("7e0d6368-b609-43da-ad5f-1be2ebaa2301"), 3, new DateTime(2024, 1, 6, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(4727), null, "Description for WorkItem 80", 1, 1, "WorkItem 80" },
                    { new Guid("02c3ea8a-81f2-4ea7-b9f0-f6376ff3792a"), new Guid("ccebfce7-bf7e-4f44-a049-f78059d28a18"), 2, new DateTime(2023, 3, 13, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(149), null, "Description for WorkItem 379", 0, 0, "WorkItem 379" },
                    { new Guid("032d682f-f96b-47f0-bcb9-ee655f7f4ac5"), new Guid("0ddf2d45-9f40-4fcd-80a2-5286ec667ad1"), 3, new DateTime(2023, 2, 24, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(363), null, "Description for WorkItem 396", 2, 2, "WorkItem 396" },
                    { new Guid("040eeb7f-b9f7-4722-8077-549ac1c18467"), new Guid("b574cdb9-8ceb-4fd4-8e8f-2c1512aa907f"), 1, new DateTime(2023, 5, 9, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(9391), null, "Description for WorkItem 322", 0, 0, "WorkItem 322" },
                    { new Guid("04861dab-18ec-451a-a197-6a44e39681be"), new Guid("a6e966cd-eb16-403e-93ce-0a7f7e318a6b"), 2, new DateTime(2023, 3, 17, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(104), null, "Description for WorkItem 375", 2, 2, "WorkItem 375" },
                    { new Guid("05437580-ad4f-4e7c-b74a-7189306b9a7a"), new Guid("5da46ea0-bac0-4152-b19d-5aec098d62ae"), 1, new DateTime(2023, 9, 2, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(7568), null, "Description for WorkItem 206", 1, 1, "WorkItem 206" },
                    { new Guid("06cac986-5bb8-44b2-a1cb-0d5d72c13562"), new Guid("63f070ef-1274-4658-b44a-96cc2c6ea907"), 3, new DateTime(2024, 3, 6, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(3886), null, "Description for WorkItem 20", 1, 1, "WorkItem 20" },
                    { new Guid("08afada9-33b6-48d0-9a05-f82ab13f8899"), new Guid("76b28a73-a636-49f8-8b00-e9beb754a1d0"), 2, new DateTime(2023, 11, 24, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(5333), null, "Description for WorkItem 123", 2, 2, "WorkItem 123" },
                    { new Guid("094b6527-76e6-4ed1-b4bf-f8b26c05fe03"), new Guid("eff36b81-3f39-4232-9410-85391584d000"), 1, new DateTime(2023, 6, 18, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(8893), null, "Description for WorkItem 282", 2, 2, "WorkItem 282" },
                    { new Guid("0a317d55-3833-43b7-8d44-fc641133ac4b"), new Guid("01610c7a-9e93-41c4-88bf-65ff2ed11f50"), 3, new DateTime(2023, 12, 29, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(4873), null, "Description for WorkItem 88", 0, 0, "WorkItem 88" },
                    { new Guid("0b01103a-2e6d-411b-bf5d-f6df0df154e9"), new Guid("ccbe957a-8557-47e4-9c99-ddccae845545"), 1, new DateTime(2023, 7, 20, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(8435), null, "Description for WorkItem 250", 0, 0, "WorkItem 250" },
                    { new Guid("0b1ef6e1-4b1b-4949-bc86-8550d961bbcd"), new Guid("5da46ea0-bac0-4152-b19d-5aec098d62ae"), 3, new DateTime(2023, 6, 24, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(8827), null, "Description for WorkItem 276", 2, 2, "WorkItem 276" },
                    { new Guid("0cc90355-6276-446f-8b00-37d65c6f4b76"), new Guid("6b414c7d-3fed-4932-a291-c7af0a50d852"), 2, new DateTime(2024, 2, 24, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(4005), null, "Description for WorkItem 31", 0, 0, "WorkItem 31" },
                    { new Guid("0d170f0e-ebb5-4d9a-8efc-0f06fd4c83c0"), new Guid("89155141-a366-44db-b0a4-4376ec44dcfe"), 2, new DateTime(2023, 10, 3, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(6080), null, "Description for WorkItem 175", 0, 0, "WorkItem 175" },
                    { new Guid("0d4e6735-296c-4f82-9f20-c4242556491e"), new Guid("72e10416-635b-4d83-a77b-d572193637da"), 3, new DateTime(2023, 5, 7, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(9413), null, "Description for WorkItem 324", 2, 2, "WorkItem 324" },
                    { new Guid("0e1b0e89-0728-4354-b57c-875dd37d86ba"), new Guid("ec4337d3-7aa8-4396-831e-4eb510aa5bb1"), 2, new DateTime(2023, 11, 28, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(5290), null, "Description for WorkItem 119", 1, 1, "WorkItem 119" },
                    { new Guid("0e201e31-d861-4467-8248-b706d398ae11"), new Guid("e954c356-7846-4438-95ad-efce405cbe87"), 0, new DateTime(2023, 8, 26, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(7695), null, "Description for WorkItem 213", 2, 2, "WorkItem 213" },
                    { new Guid("0e3558b8-f843-4f11-81c5-1ebbb95b5130"), new Guid("341f9b78-ce17-42e9-9091-dbefeba89d3b"), 1, new DateTime(2023, 5, 13, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(9325), null, "Description for WorkItem 318", 2, 2, "WorkItem 318" },
                    { new Guid("0fe7a987-4d22-48bd-85a7-3626a736e5a5"), new Guid("e7658228-f102-46ce-ad6d-eb770c11ddee"), 0, new DateTime(2023, 5, 18, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(9275), null, "Description for WorkItem 313", 0, 0, "WorkItem 313" },
                    { new Guid("10d90368-480c-489e-a763-3e4c67f279b7"), new Guid("ccbe957a-8557-47e4-9c99-ddccae845545"), 3, new DateTime(2024, 2, 15, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(4245), null, "Description for WorkItem 40", 0, 0, "WorkItem 40" },
                    { new Guid("115be787-b165-40c1-9721-49193cf034a2"), new Guid("054b5698-5d00-4f55-9132-ce0f5ea666bd"), 1, new DateTime(2023, 4, 23, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(9563), null, "Description for WorkItem 338", 1, 1, "WorkItem 338" },
                    { new Guid("11805bb5-4b1a-4dbc-8e58-de1a036d64a7"), new Guid("8503793e-1bda-496e-a1da-3cf84041704b"), 2, new DateTime(2023, 6, 9, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(8988), null, "Description for WorkItem 291", 2, 2, "WorkItem 291" },
                    { new Guid("129fc241-25f7-4ca5-ac2e-e795ae80f323"), new Guid("414b5098-3cf1-42e8-a3b0-c8648922eb21"), 0, new DateTime(2023, 7, 5, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(8670), null, "Description for WorkItem 265", 0, 0, "WorkItem 265" },
                    { new Guid("132bdb3f-03a0-464a-a48d-c09cf533cc39"), new Guid("4f7996f8-66bb-49c9-875e-2cddf0c6dd31"), 1, new DateTime(2023, 6, 30, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(8722), null, "Description for WorkItem 270", 2, 2, "WorkItem 270" },
                    { new Guid("133ea975-fbd2-478c-b01d-d8d5aa45780c"), new Guid("76b28a73-a636-49f8-8b00-e9beb754a1d0"), 2, new DateTime(2023, 7, 7, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(8646), null, "Description for WorkItem 263", 1, 1, "WorkItem 263" },
                    { new Guid("14e15b4c-45ec-462f-9b83-33c7f4e11fc9"), new Guid("c049086d-9699-4ee0-ab6b-f1a4802b03ee"), 1, new DateTime(2023, 8, 13, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(7998), null, "Description for WorkItem 226", 0, 0, "WorkItem 226" },
                    { new Guid("14ebfe36-eae9-4492-b7fa-99b00d29846f"), new Guid("4610a824-5bae-4dce-ad57-22e6d63ecd30"), 3, new DateTime(2023, 12, 13, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(5051), null, "Description for WorkItem 104", 1, 1, "WorkItem 104" },
                    { new Guid("15095c69-75d5-4bc6-9676-bec57e4bf109"), new Guid("4f7996f8-66bb-49c9-875e-2cddf0c6dd31"), 3, new DateTime(2024, 1, 26, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(4470), null, "Description for WorkItem 60", 2, 2, "WorkItem 60" },
                    { new Guid("15a4972d-4743-4574-adf4-a14a33dd92d2"), new Guid("64b45b41-2ae7-4798-93cd-b226d2340502"), 1, new DateTime(2024, 2, 1, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(4402), null, "Description for WorkItem 54", 2, 2, "WorkItem 54" },
                    { new Guid("15e94fab-3705-4d50-aefb-3748aad78030"), new Guid("57c29b52-3614-4f45-80da-9f9f0c0be1cc"), 3, new DateTime(2023, 11, 27, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(5300), null, "Description for WorkItem 120", 2, 2, "WorkItem 120" },
                    { new Guid("16aa8659-dee7-43b4-8be3-a5632da8d2f0"), new Guid("f79631e3-8401-451f-b49a-94a6b358807b"), 2, new DateTime(2023, 4, 6, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(9809), null, "Description for WorkItem 355", 0, 0, "WorkItem 355" },
                    { new Guid("171eb872-4d7c-4b18-8cc5-a83e1b3f1a5f"), new Guid("880f1059-f46d-4d66-baea-a8a75b787d24"), 1, new DateTime(2023, 6, 26, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(8806), null, "Description for WorkItem 274", 0, 0, "WorkItem 274" },
                    { new Guid("17ce4bb5-ef23-4abe-bf41-131073e4a4c2"), new Guid("341f9b78-ce17-42e9-9091-dbefeba89d3b"), 1, new DateTime(2024, 2, 17, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(4223), null, "Description for WorkItem 38", 1, 1, "WorkItem 38" },
                    { new Guid("19272182-d1b4-430e-bfb1-bcc0a31d4914"), new Guid("1106ab56-1576-4138-8521-a0ca8d9492e2"), 1, new DateTime(2023, 12, 11, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(5141), null, "Description for WorkItem 106", 0, 0, "WorkItem 106" },
                    { new Guid("19e3abd5-a7ff-46b6-a60a-ca936633b78c"), new Guid("01610c7a-9e93-41c4-88bf-65ff2ed11f50"), 3, new DateTime(2023, 8, 11, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(8019), null, "Description for WorkItem 228", 2, 2, "WorkItem 228" },
                    { new Guid("19e6e205-725f-49b7-9cf4-24ae58491659"), new Guid("f79631e3-8401-451f-b49a-94a6b358807b"), 0, new DateTime(2023, 11, 2, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(5639), null, "Description for WorkItem 145", 0, 0, "WorkItem 145" },
                    { new Guid("1a9fe94f-4fee-4c56-8330-6029eb751c2d"), new Guid("13a41e4c-47b5-4393-8b01-110462a3d083"), 3, new DateTime(2023, 10, 6, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(6048), null, "Description for WorkItem 172", 0, 0, "WorkItem 172" },
                    { new Guid("1d2833e9-d0eb-4494-a929-6811b218d5e5"), new Guid("b574cdb9-8ceb-4fd4-8e8f-2c1512aa907f"), 3, new DateTime(2023, 2, 28, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(317), null, "Description for WorkItem 392", 1, 1, "WorkItem 392" },
                    { new Guid("1d4e30a7-a328-4b48-bf6e-79c608e4180e"), new Guid("f0b38660-d5db-4f9d-9729-94358cb7bdb5"), 0, new DateTime(2023, 3, 23, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(43), null, "Description for WorkItem 369", 2, 2, "WorkItem 369" },
                    { new Guid("1d5ae3c4-b26b-453e-8198-d4eaea235ff1"), new Guid("0026da90-a1a9-41fa-933e-576ad76ffbf7"), 3, new DateTime(2023, 8, 23, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(7883), null, "Description for WorkItem 216", 2, 2, "WorkItem 216" },
                    { new Guid("1d61bc19-edae-4bff-92cd-a961a29e3cc8"), new Guid("c3bc7db1-01e3-45b3-a534-5411c807285e"), 3, new DateTime(2024, 2, 3, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(4381), null, "Description for WorkItem 52", 0, 0, "WorkItem 52" },
                    { new Guid("1d66cb0c-e67a-4427-bf41-4360bc2faffc"), new Guid("f8b91952-2bf0-4a59-9cd9-5e1f784eb79e"), 3, new DateTime(2023, 3, 16, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(114), null, "Description for WorkItem 376", 0, 0, "WorkItem 376" },
                    { new Guid("204b3331-b216-4bee-a2b1-d325fdc210a5"), new Guid("880f1059-f46d-4d66-baea-a8a75b787d24"), 3, new DateTime(2023, 9, 4, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(7536), null, "Description for WorkItem 204", 2, 2, "WorkItem 204" },
                    { new Guid("204ca503-4b2e-4bfe-b252-2d632d0f33d5"), new Guid("7e0d6368-b609-43da-ad5f-1be2ebaa2301"), 1, new DateTime(2023, 10, 28, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(5716), null, "Description for WorkItem 150", 2, 2, "WorkItem 150" },
                    { new Guid("2137c9be-d886-49d1-b362-fefa50367fed"), new Guid("d09ff1a6-375a-4c6b-b790-bb322b576874"), 2, new DateTime(2023, 7, 23, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(8402), null, "Description for WorkItem 247", 0, 0, "WorkItem 247" },
                    { new Guid("213f96a0-9f88-4c18-a887-db8afbe17815"), new Guid("054b5698-5d00-4f55-9132-ce0f5ea666bd"), 1, new DateTime(2024, 1, 28, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(4445), null, "Description for WorkItem 58", 0, 0, "WorkItem 58" },
                    { new Guid("21403384-4288-43b9-bf81-b5ea65c6b765"), new Guid("7ec48e58-03e0-42ef-b69d-3ca5d36a540d"), 3, new DateTime(2023, 5, 23, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(9220), null, "Description for WorkItem 308", 1, 1, "WorkItem 308" },
                    { new Guid("2165b937-6b8f-48d6-993e-3eba72fab8b0"), new Guid("1ef348d3-6cef-40c0-8d21-e1b3ac8ba85d"), 0, new DateTime(2023, 3, 15, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(128), null, "Description for WorkItem 377", 1, 1, "WorkItem 377" },
                    { new Guid("2167c7bb-0ca2-410f-871b-7e3117b31f61"), new Guid("4f7996f8-66bb-49c9-875e-2cddf0c6dd31"), 3, new DateTime(2023, 4, 21, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(9583), null, "Description for WorkItem 340", 0, 0, "WorkItem 340" },
                    { new Guid("217e54a3-dd25-44ac-aa50-f82cf03382a2"), new Guid("da962695-902b-40ef-a0ca-2ea3599659e8"), 0, new DateTime(2023, 7, 1, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(8712), null, "Description for WorkItem 269", 1, 1, "WorkItem 269" },
                    { new Guid("21a39b3d-3e72-4a8f-85e7-6a8a44626e89"), new Guid("85ce4a6a-a305-426a-9e29-f817f44c98a8"), 2, new DateTime(2023, 4, 14, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(9723), null, "Description for WorkItem 347", 1, 1, "WorkItem 347" },
                    { new Guid("23d60029-3873-47a9-a8a7-6a27d4f29fd6"), new Guid("0026da90-a1a9-41fa-933e-576ad76ffbf7"), 1, new DateTime(2024, 3, 20, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(3656), null, "Description for WorkItem 6", 2, 2, "WorkItem 6" },
                    { new Guid("24552a47-2fa9-45a2-bc42-d5c57d2c1cf4"), new Guid("e6a5501a-de17-4657-a9d3-9aa5b74f862c"), 3, new DateTime(2024, 3, 18, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(3677), null, "Description for WorkItem 8", 1, 1, "WorkItem 8" },
                    { new Guid("24f05191-575d-40db-bc3e-cba8e6baf5e4"), new Guid("9c4027f3-ed3b-49ca-8dd3-4332a7c29541"), 0, new DateTime(2024, 1, 25, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(4514), null, "Description for WorkItem 61", 0, 0, "WorkItem 61" },
                    { new Guid("254bfb26-28af-4f29-ae38-70d5968f7f2d"), new Guid("e954c356-7846-4438-95ad-efce405cbe87"), 2, new DateTime(2023, 6, 17, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(8903), null, "Description for WorkItem 283", 0, 0, "WorkItem 283" },
                    { new Guid("25941323-bccf-45ed-b637-b8a3831ddd3f"), new Guid("110f2ffa-2825-4b68-b584-707b9c7cc472"), 2, new DateTime(2023, 5, 4, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(9443), null, "Description for WorkItem 327", 2, 2, "WorkItem 327" },
                    { new Guid("2625abf2-c8d2-4783-b550-13662f3fa5a9"), new Guid("696346f6-5cf4-4bcf-997b-f7541af90e31"), 2, new DateTime(2023, 3, 29, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(9893), null, "Description for WorkItem 363", 2, 2, "WorkItem 363" },
                    { new Guid("263e677a-6cd5-4015-ae0c-f1fee6d39f5c"), new Guid("dcc3349d-654c-4415-8815-cedcbc349126"), 1, new DateTime(2023, 10, 24, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(5759), null, "Description for WorkItem 154", 0, 0, "WorkItem 154" },
                    { new Guid("26521789-56f0-4ca1-8c58-c86303911eae"), new Guid("5cea12db-210f-424f-9310-a9594619b930"), 0, new DateTime(2023, 8, 30, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(7624), null, "Description for WorkItem 209", 1, 1, "WorkItem 209" },
                    { new Guid("287bb16c-d01e-4826-a6ad-c8ce4b993af3"), new Guid("ccbe957a-8557-47e4-9c99-ddccae845545"), 3, new DateTime(2023, 9, 28, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(6139), null, "Description for WorkItem 180", 2, 2, "WorkItem 180" },
                    { new Guid("28e4bae6-0774-4f32-a2a0-b92a5ebe5a40"), new Guid("76b28a73-a636-49f8-8b00-e9beb754a1d0"), 0, new DateTime(2023, 9, 15, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(7168), null, "Description for WorkItem 193", 0, 0, "WorkItem 193" },
                    { new Guid("29a6e27e-0564-45a4-aae0-69265dd42e97"), new Guid("da962695-902b-40ef-a0ca-2ea3599659e8"), 2, new DateTime(2023, 9, 9, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(7435), null, "Description for WorkItem 199", 0, 0, "WorkItem 199" },
                    { new Guid("2af0db2f-e6a0-4b8e-baf2-671414084b80"), new Guid("9f00fd1f-21b1-47d1-ba85-c6f855d7fd17"), 3, new DateTime(2023, 5, 3, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(9453), null, "Description for WorkItem 328", 0, 0, "WorkItem 328" },
                    { new Guid("2b6a3ad1-97be-4375-91f3-29526ec324ec"), new Guid("ec4337d3-7aa8-4396-831e-4eb510aa5bb1"), 0, new DateTime(2024, 2, 6, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(4346), null, "Description for WorkItem 49", 0, 0, "WorkItem 49" },
                    { new Guid("2b93fb9a-809a-4e92-b4a6-c2778c9a62f2"), new Guid("c7f7d3d3-2f4d-4e85-9e35-74e23e44d5f9"), 1, new DateTime(2023, 5, 29, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(9156), null, "Description for WorkItem 302", 1, 1, "WorkItem 302" },
                    { new Guid("2c866d29-6e33-41ed-8074-84a1d3f69497"), new Guid("414b5098-3cf1-42e8-a3b0-c8648922eb21"), 2, new DateTime(2023, 9, 13, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(7367), null, "Description for WorkItem 195", 2, 2, "WorkItem 195" },
                    { new Guid("2d5c9c5e-cf55-4af3-ad0b-1cf48f3429eb"), new Guid("9c4027f3-ed3b-49ca-8dd3-4332a7c29541"), 2, new DateTime(2023, 11, 16, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(5483), null, "Description for WorkItem 131", 1, 1, "WorkItem 131" },
                    { new Guid("2e8b3ec1-7a96-4724-88fa-5348f7ce7db2"), new Guid("a1952de2-fdf7-469f-bae6-092993cb4c01"), 2, new DateTime(2024, 2, 12, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(4278), null, "Description for WorkItem 43", 0, 0, "WorkItem 43" },
                    { new Guid("2ed24635-9afe-45de-b0ca-7501dfd5e37f"), new Guid("696346f6-5cf4-4bcf-997b-f7541af90e31"), 0, new DateTime(2023, 6, 7, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(9008), null, "Description for WorkItem 293", 1, 1, "WorkItem 293" },
                    { new Guid("2f1dc87d-0f45-4aef-886c-16cd9cd7ce23"), new Guid("4cafe1b0-6478-4509-9433-80cc2a331b22"), 0, new DateTime(2023, 8, 22, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(7899), null, "Description for WorkItem 217", 0, 0, "WorkItem 217" },
                    { new Guid("2f5bcb1c-01f3-43a2-9784-8cb09816951b"), new Guid("4f7996f8-66bb-49c9-875e-2cddf0c6dd31"), 1, new DateTime(2023, 11, 17, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(5473), null, "Description for WorkItem 130", 0, 0, "WorkItem 130" },
                    { new Guid("2f7aa4ff-c108-4010-874e-104c950a4853"), new Guid("c4d38b52-d1a2-4a0e-8de5-85eb2fcd6604"), 0, new DateTime(2024, 3, 5, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(3897), null, "Description for WorkItem 21", 2, 2, "WorkItem 21" },
                    { new Guid("30c57747-36f3-46c6-8bd3-cff1ceb53e52"), new Guid("aabac3ed-cd23-437e-9977-9f263cea7b12"), 2, new DateTime(2024, 2, 16, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(4235), null, "Description for WorkItem 39", 2, 2, "WorkItem 39" },
                    { new Guid("3160f3fd-f65c-46f1-a0f4-9d43dbc6e495"), new Guid("6b414c7d-3fed-4932-a291-c7af0a50d852"), 0, new DateTime(2023, 7, 29, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(8341), null, "Description for WorkItem 241", 0, 0, "WorkItem 241" },
                    { new Guid("326ed06a-3197-43c4-a473-5827c4bf53ee"), new Guid("96013f50-c6e1-4e8d-a6e4-d8ac93bdbdb8"), 1, new DateTime(2024, 1, 16, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(4617), null, "Description for WorkItem 70", 0, 0, "WorkItem 70" },
                    { new Guid("33c1491c-222f-4b6a-891c-9d57bbf20346"), new Guid("ec4337d3-7aa8-4396-831e-4eb510aa5bb1"), 2, new DateTime(2023, 7, 11, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(8603), null, "Description for WorkItem 259", 0, 0, "WorkItem 259" },
                    { new Guid("3642051c-0d5b-4641-ad7d-46ef698095af"), new Guid("4cafe1b0-6478-4509-9433-80cc2a331b22"), 0, new DateTime(2023, 4, 4, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(9829), null, "Description for WorkItem 357", 2, 2, "WorkItem 357" },
                    { new Guid("36ae04b3-e53c-483c-b423-6cda7d2606ec"), new Guid("341f9b78-ce17-42e9-9091-dbefeba89d3b"), 3, new DateTime(2023, 12, 9, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(5166), null, "Description for WorkItem 108", 2, 2, "WorkItem 108" },
                    { new Guid("374a4363-96f7-40fd-a5c1-9a1ce1cd28c6"), new Guid("414b5098-3cf1-42e8-a3b0-c8648922eb21"), 2, new DateTime(2024, 1, 31, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(4413), null, "Description for WorkItem 55", 0, 0, "WorkItem 55" },
                    { new Guid("3797dcb5-63db-4a46-85b7-7ac47219aa55"), new Guid("72e10416-635b-4d83-a77b-d572193637da"), 1, new DateTime(2023, 12, 3, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(5232), null, "Description for WorkItem 114", 2, 2, "WorkItem 114" },
                    { new Guid("382f52b7-f232-4bfd-bd79-cc3fceebebc8"), new Guid("c4d38b52-d1a2-4a0e-8de5-85eb2fcd6604"), 2, new DateTime(2023, 3, 21, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(63), null, "Description for WorkItem 371", 1, 1, "WorkItem 371" },
                    { new Guid("39d53cd8-804f-4683-b319-c455ef22612d"), new Guid("7e0d6368-b609-43da-ad5f-1be2ebaa2301"), 3, new DateTime(2023, 4, 1, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(9860), null, "Description for WorkItem 360", 2, 2, "WorkItem 360" },
                    { new Guid("39da3c83-28b4-4c0f-bd7e-bd4463930dea"), new Guid("f0b38660-d5db-4f9d-9729-94358cb7bdb5"), 2, new DateTime(2023, 6, 1, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(9125), null, "Description for WorkItem 299", 1, 1, "WorkItem 299" },
                    { new Guid("3b352eb3-c97c-4cfb-b93e-74b1cce58e8a"), new Guid("53b1cab2-6315-4281-800d-1338b8df64d8"), 2, new DateTime(2023, 9, 5, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(7520), null, "Description for WorkItem 203", 1, 1, "WorkItem 203" },
                    { new Guid("3b59189f-d9ca-42f5-a5d0-ab39d9c48b60"), new Guid("66fa74a2-72e3-4847-ad07-51c4f5daeb40"), 0, new DateTime(2024, 2, 10, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(4303), null, "Description for WorkItem 45", 2, 2, "WorkItem 45" },
                    { new Guid("3ee07753-3aa1-429d-9b39-5a4b4bba4af4"), new Guid("94c5d955-ff84-44ba-8297-4212f5a2eb57"), 1, new DateTime(2023, 5, 21, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(9240), null, "Description for WorkItem 310", 0, 0, "WorkItem 310" },
                    { new Guid("4046e81f-bf84-4772-8680-605462c0497e"), new Guid("0ddf2d45-9f40-4fcd-80a2-5286ec667ad1"), 3, new DateTime(2023, 12, 1, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(5257), null, "Description for WorkItem 116", 1, 1, "WorkItem 116" },
                    { new Guid("40c51924-eda0-4a58-abb8-02e69bc771c5"), new Guid("4cafe1b0-6478-4509-9433-80cc2a331b22"), 0, new DateTime(2024, 1, 9, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(4695), null, "Description for WorkItem 77", 1, 1, "WorkItem 77" },
                    { new Guid("41820602-cb92-479c-98fd-0060d63056bc"), new Guid("eff36b81-3f39-4232-9410-85391584d000"), 3, new DateTime(2024, 1, 14, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(4639), null, "Description for WorkItem 72", 2, 2, "WorkItem 72" },
                    { new Guid("420faffe-2a18-442d-9911-21a55feb8b59"), new Guid("22dbcf5e-49f3-451d-8f68-a70d36d5eafc"), 1, new DateTime(2023, 7, 4, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(8681), null, "Description for WorkItem 266", 1, 1, "WorkItem 266" },
                    { new Guid("42660fb0-9834-4d5c-adfd-5a587eaf0a94"), new Guid("dcc3349d-654c-4415-8815-cedcbc349126"), 3, new DateTime(2024, 1, 2, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(4831), null, "Description for WorkItem 84", 2, 2, "WorkItem 84" },
                    { new Guid("455a406b-89e6-4a4e-a85b-f393a0b79ad1"), new Guid("d09ff1a6-375a-4c6b-b790-bb322b576874"), 0, new DateTime(2023, 5, 14, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(9315), null, "Description for WorkItem 317", 1, 1, "WorkItem 317" },
                    { new Guid("466ff3f8-c4b8-4b18-b1dd-d8cb357c10de"), new Guid("f0b38660-d5db-4f9d-9729-94358cb7bdb5"), 2, new DateTime(2024, 3, 7, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(3871), null, "Description for WorkItem 19", 0, 0, "WorkItem 19" },
                    { new Guid("46aee1ad-47a1-4d59-84f3-7a92a4589145"), new Guid("e954c356-7846-4438-95ad-efce405cbe87"), 2, new DateTime(2023, 11, 4, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(5618), null, "Description for WorkItem 143", 1, 1, "WorkItem 143" },
                    { new Guid("46c61365-68a5-47ac-bb07-6443dc7ddbcf"), new Guid("c3bc7db1-01e3-45b3-a534-5411c807285e"), 1, new DateTime(2023, 11, 25, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(5322), null, "Description for WorkItem 122", 1, 1, "WorkItem 122" },
                    { new Guid("4854e116-409e-41e6-9b45-3f1e900a9fa1"), new Guid("414b5098-3cf1-42e8-a3b0-c8648922eb21"), 2, new DateTime(2023, 4, 26, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(9529), null, "Description for WorkItem 335", 1, 1, "WorkItem 335" },
                    { new Guid("48e4b65e-2b6b-4fbd-869d-cd67ead33f6c"), new Guid("5a9cd035-c05b-484a-b4da-ee400ac432b2"), 3, new DateTime(2024, 3, 2, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(3928), null, "Description for WorkItem 24", 2, 2, "WorkItem 24" },
                    { new Guid("4922b816-5b46-4ff9-adbe-5ed43f138359"), new Guid("c4d38b52-d1a2-4a0e-8de5-85eb2fcd6604"), 0, new DateTime(2023, 5, 30, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(9146), null, "Description for WorkItem 301", 0, 0, "WorkItem 301" },
                    { new Guid("4a21f3d7-cc98-432c-881c-a4508bf1922f"), new Guid("9f00fd1f-21b1-47d1-ba85-c6f855d7fd17"), 1, new DateTime(2023, 2, 22, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(384), null, "Description for WorkItem 398", 1, 1, "WorkItem 398" },
                    { new Guid("4a5b7674-cf9c-4473-9f34-fcde4201481a"), new Guid("054b5698-5d00-4f55-9132-ce0f5ea666bd"), 3, new DateTime(2023, 11, 19, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(5449), null, "Description for WorkItem 128", 1, 1, "WorkItem 128" },
                    { new Guid("4a68c7bd-516a-4f26-908e-62c399ca0ed8"), new Guid("110f2ffa-2825-4b68-b584-707b9c7cc472"), 2, new DateTime(2024, 2, 8, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(4324), null, "Description for WorkItem 47", 1, 1, "WorkItem 47" },
                    { new Guid("4a6fdd45-baab-4918-b765-97b05238a81c"), new Guid("e6a5501a-de17-4657-a9d3-9aa5b74f862c"), 1, new DateTime(2023, 8, 21, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(7910), null, "Description for WorkItem 218", 1, 1, "WorkItem 218" },
                    { new Guid("4a90d714-eaa5-4b95-9ff7-68828c86f898"), new Guid("7ec48e58-03e0-42ef-b69d-3ca5d36a540d"), 3, new DateTime(2023, 10, 10, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(6000), null, "Description for WorkItem 168", 2, 2, "WorkItem 168" },
                    { new Guid("4aa65f1e-9a3d-46c7-bedd-509d1d888e13"), new Guid("f0b38660-d5db-4f9d-9729-94358cb7bdb5"), 2, new DateTime(2023, 10, 19, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(5815), null, "Description for WorkItem 159", 2, 2, "WorkItem 159" },
                    { new Guid("4bc54566-e939-4a6c-90dc-8be5dc3f06b2"), new Guid("ccbe957a-8557-47e4-9c99-ddccae845545"), 1, new DateTime(2023, 12, 7, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(5187), null, "Description for WorkItem 110", 1, 1, "WorkItem 110" },
                    { new Guid("4bda9a05-fb58-4654-9315-fa82c3689266"), new Guid("eff36b81-3f39-4232-9410-85391584d000"), 3, new DateTime(2023, 8, 27, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(7677), null, "Description for WorkItem 212", 1, 1, "WorkItem 212" },
                    { new Guid("4bef2c3f-dbf1-4c26-8aae-a4b34f06ca98"), new Guid("9c4027f3-ed3b-49ca-8dd3-4332a7c29541"), 0, new DateTime(2023, 4, 20, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(9593), null, "Description for WorkItem 341", 1, 1, "WorkItem 341" },
                    { new Guid("4c05ae83-d59f-4d2b-adcb-ac29929f0076"), new Guid("66fa74a2-72e3-4847-ad07-51c4f5daeb40"), 2, new DateTime(2023, 12, 2, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(5242), null, "Description for WorkItem 115", 0, 0, "WorkItem 115" },
                    { new Guid("4d104940-69f4-41d1-8bfb-2f66fc926020"), new Guid("e954c356-7846-4438-95ad-efce405cbe87"), 0, new DateTime(2024, 1, 13, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(4649), null, "Description for WorkItem 73", 0, 0, "WorkItem 73" },
                    { new Guid("4db2b496-17ed-4c81-a667-0703caeb7fed"), new Guid("a6e966cd-eb16-403e-93ce-0a7f7e318a6b"), 0, new DateTime(2024, 3, 1, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(3939), null, "Description for WorkItem 25", 0, 0, "WorkItem 25" },
                    { new Guid("4e5e4090-978a-41a0-b23b-0899a9ae5e92"), new Guid("e954c356-7846-4438-95ad-efce405cbe87"), 2, new DateTime(2024, 3, 23, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(3616), null, "Description for WorkItem 3", 2, 2, "WorkItem 3" },
                    { new Guid("4eb1eb57-96f0-4ca5-84b9-03e928d4182f"), new Guid("57c29b52-3614-4f45-80da-9f9f0c0be1cc"), 1, new DateTime(2023, 9, 18, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(6249), null, "Description for WorkItem 190", 0, 0, "WorkItem 190" },
                    { new Guid("50379e54-5ee9-4deb-a3a5-aa22e8e9e6f7"), new Guid("7ec48e58-03e0-42ef-b69d-3ca5d36a540d"), 3, new DateTime(2024, 2, 27, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(3974), null, "Description for WorkItem 28", 0, 0, "WorkItem 28" },
                    { new Guid("50414d51-1129-433c-84c9-279f62c118f8"), new Guid("b574cdb9-8ceb-4fd4-8e8f-2c1512aa907f"), 3, new DateTime(2023, 7, 18, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(8456), null, "Description for WorkItem 252", 2, 2, "WorkItem 252" },
                    { new Guid("52130062-30fa-4023-8ad9-e9a489cdba99"), new Guid("6b414c7d-3fed-4932-a291-c7af0a50d852"), 0, new DateTime(2023, 3, 11, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(169), null, "Description for WorkItem 381", 2, 2, "WorkItem 381" },
                    { new Guid("52f87938-dcaa-44d2-87dd-e4c7bd7db26d"), new Guid("8503793e-1bda-496e-a1da-3cf84041704b"), 0, new DateTime(2023, 8, 18, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(7942), null, "Description for WorkItem 221", 1, 1, "WorkItem 221" },
                    { new Guid("5324f419-fe74-4310-a631-2b4b93f18703"), new Guid("8503793e-1bda-496e-a1da-3cf84041704b"), 0, new DateTime(2024, 1, 5, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(4737), null, "Description for WorkItem 81", 2, 2, "WorkItem 81" },
                    { new Guid("53c44ed0-d2ab-4c98-8c38-fb07e4efa3ca"), new Guid("01610c7a-9e93-41c4-88bf-65ff2ed11f50"), 3, new DateTime(2023, 3, 24, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(29), null, "Description for WorkItem 368", 1, 1, "WorkItem 368" },
                    { new Guid("53f67828-1a9a-435b-9e24-b47e35e28c2e"), new Guid("63f070ef-1274-4658-b44a-96cc2c6ea907"), 3, new DateTime(2023, 10, 18, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(5826), null, "Description for WorkItem 160", 0, 0, "WorkItem 160" },
                    { new Guid("551af909-e819-422d-a005-82c326a958e6"), new Guid("a6e966cd-eb16-403e-93ce-0a7f7e318a6b"), 0, new DateTime(2023, 5, 26, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(9190), null, "Description for WorkItem 305", 1, 1, "WorkItem 305" },
                    { new Guid("557fc48e-268c-44cf-8cdc-95a7839b4b0f"), new Guid("94c5d955-ff84-44ba-8297-4212f5a2eb57"), 1, new DateTime(2023, 10, 8, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(6023), null, "Description for WorkItem 170", 1, 1, "WorkItem 170" },
                    { new Guid("55e7c182-7375-46fb-b650-e7736cac8e30"), new Guid("c049086d-9699-4ee0-ab6b-f1a4802b03ee"), 3, new DateTime(2024, 3, 10, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(3769), null, "Description for WorkItem 16", 0, 0, "WorkItem 16" },
                    { new Guid("56ae5d50-378e-4e7d-ad56-525c5efcce01"), new Guid("c4d38b52-d1a2-4a0e-8de5-85eb2fcd6604"), 2, new DateTime(2023, 8, 8, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(8194), null, "Description for WorkItem 231", 2, 2, "WorkItem 231" },
                    { new Guid("58439e70-4734-47c4-bd22-d16c50a6dcb7"), new Guid("98781be4-7ee0-4934-b14f-51bfad3972e6"), 3, new DateTime(2023, 4, 13, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(9734), null, "Description for WorkItem 348", 2, 2, "WorkItem 348" },
                    { new Guid("59180aa1-962d-49bb-9267-a5b99eabb1b7"), new Guid("f79631e3-8401-451f-b49a-94a6b358807b"), 0, new DateTime(2024, 3, 21, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(3644), null, "Description for WorkItem 5", 1, 1, "WorkItem 5" },
                    { new Guid("59704b60-c3ce-4dd4-9daf-3745f44f6476"), new Guid("5a9cd035-c05b-484a-b4da-ee400ac432b2"), 1, new DateTime(2023, 12, 23, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(4940), null, "Description for WorkItem 94", 0, 0, "WorkItem 94" },
                    { new Guid("59952d9b-a229-4397-a682-e0280235e82b"), new Guid("57c29b52-3614-4f45-80da-9f9f0c0be1cc"), 3, new DateTime(2023, 2, 20, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(404), null, "Description for WorkItem 400", 0, 0, "WorkItem 400" },
                    { new Guid("59c83525-bafd-4f4c-b4cc-15c51ff67d3e"), new Guid("e6a5501a-de17-4657-a9d3-9aa5b74f862c"), 3, new DateTime(2023, 6, 12, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(8954), null, "Description for WorkItem 288", 2, 2, "WorkItem 288" },
                    { new Guid("5b71aa24-5e0b-4e53-ad47-0c4ac0421317"), new Guid("f79631e3-8401-451f-b49a-94a6b358807b"), 0, new DateTime(2023, 6, 15, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(8924), null, "Description for WorkItem 285", 2, 2, "WorkItem 285" },
                    { new Guid("5b8a06bc-37e3-498d-8477-49cb310ead6b"), new Guid("1106ab56-1576-4138-8521-a0ca8d9492e2"), 3, new DateTime(2024, 2, 19, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(4062), null, "Description for WorkItem 36", 2, 2, "WorkItem 36" },
                    { new Guid("5bf3b911-b93b-43b5-ba46-925a5879f0ed"), new Guid("1f43dce8-8941-4536-bcae-59b78ad071f8"), 2, new DateTime(2024, 3, 11, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(3759), null, "Description for WorkItem 15", 2, 2, "WorkItem 15" },
                    { new Guid("5c812b11-620a-47b5-8165-9b5aa08c33f0"), new Guid("4610a824-5bae-4dce-ad57-22e6d63ecd30"), 1, new DateTime(2024, 2, 21, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(4038), null, "Description for WorkItem 34", 0, 0, "WorkItem 34" },
                    { new Guid("5d954b78-a64c-437f-ba06-a7f64001ac9d"), new Guid("210513be-95f9-46ce-a1e8-3b5ea08231c7"), 0, new DateTime(2023, 7, 9, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(8624), null, "Description for WorkItem 261", 2, 2, "WorkItem 261" },
                    { new Guid("5dd23f86-8139-4a27-82c1-98f9c937d1a5"), new Guid("a1952de2-fdf7-469f-bae6-092993cb4c01"), 2, new DateTime(2023, 9, 25, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(6171), null, "Description for WorkItem 183", 2, 2, "WorkItem 183" },
                    { new Guid("5e670749-39bd-4da8-9f94-f3aa1138b63e"), new Guid("e7658228-f102-46ce-ad6d-eb770c11ddee"), 2, new DateTime(2023, 3, 9, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(189), null, "Description for WorkItem 383", 1, 1, "WorkItem 383" },
                    { new Guid("5ed8a57a-35ab-4ff6-bdfe-313693a9be17"), new Guid("c3bc7db1-01e3-45b3-a534-5411c807285e"), 1, new DateTime(2023, 7, 8, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(8635), null, "Description for WorkItem 262", 0, 0, "WorkItem 262" },
                    { new Guid("602f6241-3aad-4d05-b9f9-ec3af081bd24"), new Guid("d09ff1a6-375a-4c6b-b790-bb322b576874"), 2, new DateTime(2023, 3, 5, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(234), null, "Description for WorkItem 387", 2, 2, "WorkItem 387" },
                    { new Guid("60f3861b-6a52-412d-ac30-83bd8c9d73ed"), new Guid("880f1059-f46d-4d66-baea-a8a75b787d24"), 3, new DateTime(2024, 1, 22, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(4547), null, "Description for WorkItem 64", 0, 0, "WorkItem 64" },
                    { new Guid("6101a963-a902-4dc7-b176-7df3c29a2477"), new Guid("96013f50-c6e1-4e8d-a6e4-d8ac93bdbdb8"), 3, new DateTime(2023, 6, 20, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(8868), null, "Description for WorkItem 280", 0, 0, "WorkItem 280" },
                    { new Guid("6353a98b-53b6-45c2-94af-161ecb46e934"), new Guid("0f5e4c81-1dee-4681-9e74-62f77ae22cb4"), 3, new DateTime(2023, 11, 3, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(5628), null, "Description for WorkItem 144", 2, 2, "WorkItem 144" },
                    { new Guid("638a76a5-5ae9-4d94-a343-2202e12518b7"), new Guid("64b45b41-2ae7-4798-93cd-b226d2340502"), 1, new DateTime(2023, 4, 27, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(9519), null, "Description for WorkItem 334", 0, 0, "WorkItem 334" },
                    { new Guid("646c3a34-f90e-4b57-9116-e8568df2fc3a"), new Guid("f7358570-ea64-4912-81b3-d3ef3a255b2e"), 2, new DateTime(2023, 3, 1, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(307), null, "Description for WorkItem 391", 0, 0, "WorkItem 391" },
                    { new Guid("64848d6b-4656-4cbf-abb0-142d8e661b43"), new Guid("ec4337d3-7aa8-4396-831e-4eb510aa5bb1"), 0, new DateTime(2023, 5, 2, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(9467), null, "Description for WorkItem 329", 1, 1, "WorkItem 329" },
                    { new Guid("650b70ac-1b47-4ac5-815e-4f9fc896323a"), new Guid("eeb7f210-bf39-4d83-83f2-ffa564208f5a"), 0, new DateTime(2023, 6, 19, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(8882), null, "Description for WorkItem 281", 1, 1, "WorkItem 281" },
                    { new Guid("65284b4d-0d14-4d8c-ba38-d1107b40a49e"), new Guid("696346f6-5cf4-4bcf-997b-f7541af90e31"), 0, new DateTime(2024, 3, 13, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(3737), null, "Description for WorkItem 13", 0, 0, "WorkItem 13" },
                    { new Guid("655a8248-8ad0-4c5f-b228-270bec5320e8"), new Guid("89155141-a366-44db-b0a4-4376ec44dcfe"), 2, new DateTime(2023, 5, 16, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(9295), null, "Description for WorkItem 315", 2, 2, "WorkItem 315" },
                    { new Guid("65883828-b6c7-43bd-a007-045b33d17064"), new Guid("98781be4-7ee0-4934-b14f-51bfad3972e6"), 1, new DateTime(2023, 11, 9, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(5562), null, "Description for WorkItem 138", 2, 2, "WorkItem 138" },
                    { new Guid("66056107-a6d3-4fee-815a-169ce35bc4fe"), new Guid("d7657a73-2859-4353-95a2-c720d5341882"), 0, new DateTime(2024, 1, 21, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(4557), null, "Description for WorkItem 65", 1, 1, "WorkItem 65" },
                    { new Guid("668a11b1-9b68-41e3-a0ab-cab59f505058"), new Guid("0ddf2d45-9f40-4fcd-80a2-5286ec667ad1"), 3, new DateTime(2023, 7, 14, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(8496), null, "Description for WorkItem 256", 0, 0, "WorkItem 256" },
                    { new Guid("66b49ea4-3977-4a23-95c9-dca22eda9c6b"), new Guid("63f070ef-1274-4658-b44a-96cc2c6ea907"), 1, new DateTime(2023, 8, 9, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(8184), null, "Description for WorkItem 230", 1, 1, "WorkItem 230" },
                    { new Guid("66ca19b0-ad2d-4868-ae37-bcade4eae1ca"), new Guid("86af32ca-f862-4f98-a7c2-e7ba19619301"), 2, new DateTime(2024, 3, 3, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(3917), null, "Description for WorkItem 23", 1, 1, "WorkItem 23" },
                    { new Guid("66d5aa1d-c7b4-4f1e-b515-71a92d1df6ec"), new Guid("9f00fd1f-21b1-47d1-ba85-c6f855d7fd17"), 3, new DateTime(2023, 9, 20, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(6227), null, "Description for WorkItem 188", 1, 1, "WorkItem 188" },
                    { new Guid("682f77cb-a1a4-4e2c-acb7-416101c063c9"), new Guid("5da46ea0-bac0-4152-b19d-5aec098d62ae"), 1, new DateTime(2024, 1, 20, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(4571), null, "Description for WorkItem 66", 2, 2, "WorkItem 66" },
                    { new Guid("684a5dc4-6672-4eef-9477-2013e052245d"), new Guid("c7f7d3d3-2f4d-4e85-9e35-74e23e44d5f9"), 1, new DateTime(2024, 3, 4, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(3907), null, "Description for WorkItem 22", 0, 0, "WorkItem 22" },
                    { new Guid("69dfc5cb-9c17-44ba-8606-f87a3951531a"), new Guid("7e6932ef-fe3a-4e22-bf03-be4c9fb40b68"), 0, new DateTime(2023, 10, 21, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(5794), null, "Description for WorkItem 157", 0, 0, "WorkItem 157" },
                    { new Guid("6a02e38b-f9c3-4ad1-8f73-dc0d3a3972c0"), new Guid("341f9b78-ce17-42e9-9091-dbefeba89d3b"), 3, new DateTime(2023, 7, 22, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(8412), null, "Description for WorkItem 248", 1, 1, "WorkItem 248" },
                    { new Guid("6abf8547-eb19-4fb9-950d-e5e94e6cb550"), new Guid("c049086d-9699-4ee0-ab6b-f1a4802b03ee"), 3, new DateTime(2023, 6, 4, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(9090), null, "Description for WorkItem 296", 1, 1, "WorkItem 296" },
                    { new Guid("6b6afd06-00c8-475f-b14d-e1cd4b9f81d6"), new Guid("696346f6-5cf4-4bcf-997b-f7541af90e31"), 2, new DateTime(2023, 8, 16, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(7963), null, "Description for WorkItem 223", 0, 0, "WorkItem 223" },
                    { new Guid("6bcba68e-e7a3-4114-8051-22e0c271621d"), new Guid("53b1cab2-6315-4281-800d-1338b8df64d8"), 2, new DateTime(2023, 4, 18, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(9678), null, "Description for WorkItem 343", 0, 0, "WorkItem 343" },
                    { new Guid("6d962367-51b6-45bf-ba21-30e8a5cf8692"), new Guid("85ce4a6a-a305-426a-9e29-f817f44c98a8"), 0, new DateTime(2023, 6, 23, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(8837), null, "Description for WorkItem 277", 0, 0, "WorkItem 277" },
                    { new Guid("6ea15a66-9396-442e-b35d-37aa3de94681"), new Guid("5da46ea0-bac0-4152-b19d-5aec098d62ae"), 1, new DateTime(2023, 4, 15, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(9713), null, "Description for WorkItem 346", 0, 0, "WorkItem 346" },
                    { new Guid("6ecf9489-6c4b-4868-a9ed-06fcd0ca48dc"), new Guid("f8b91952-2bf0-4a59-9cd9-5e1f784eb79e"), 1, new DateTime(2023, 10, 12, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(5893), null, "Description for WorkItem 166", 0, 0, "WorkItem 166" },
                    { new Guid("70f540f9-f8b3-49e6-b898-53758f1492ae"), new Guid("85ce4a6a-a305-426a-9e29-f817f44c98a8"), 0, new DateTime(2023, 11, 10, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(5551), null, "Description for WorkItem 137", 1, 1, "WorkItem 137" },
                    { new Guid("7183fbd6-810f-4013-90d7-5da10e0d153a"), new Guid("b05c44eb-7568-4523-be49-08105fbb1106"), 2, new DateTime(2023, 7, 3, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(8691), null, "Description for WorkItem 267", 2, 2, "WorkItem 267" },
                    { new Guid("71e36063-955e-41cf-8e22-a238060cbd28"), new Guid("6b414c7d-3fed-4932-a291-c7af0a50d852"), 0, new DateTime(2023, 12, 16, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(5020), null, "Description for WorkItem 101", 1, 1, "WorkItem 101" },
                    { new Guid("7252ee64-357c-4366-90eb-087a8ccf9c15"), new Guid("eeb7f210-bf39-4d83-83f2-ffa564208f5a"), 0, new DateTime(2024, 3, 25, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(3585), null, "Description for WorkItem 1", 0, 0, "WorkItem 1" },
                    { new Guid("73c8e4ea-287f-4613-a961-c9ed76811f49"), new Guid("76b28a73-a636-49f8-8b00-e9beb754a1d0"), 0, new DateTime(2024, 2, 2, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(4392), null, "Description for WorkItem 53", 1, 1, "WorkItem 53" },
                    { new Guid("73f16975-879f-491f-9546-5522ba6902b5"), new Guid("4cafe1b0-6478-4509-9433-80cc2a331b22"), 2, new DateTime(2023, 10, 31, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(5681), null, "Description for WorkItem 147", 2, 2, "WorkItem 147" },
                    { new Guid("742aef1e-cb7d-421d-a1c1-68cc16416b96"), new Guid("72e10416-635b-4d83-a77b-d572193637da"), 3, new DateTime(2024, 2, 11, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(4292), null, "Description for WorkItem 44", 1, 1, "WorkItem 44" },
                    { new Guid("74ecfb7c-9bdb-4456-baed-1fb0be8ddd24"), new Guid("be37261d-62bb-4d93-8982-4411941de97b"), 3, new DateTime(2023, 6, 28, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(8743), null, "Description for WorkItem 272", 1, 1, "WorkItem 272" },
                    { new Guid("76a15127-af37-414c-a6e4-907603bd7013"), new Guid("c3bc7db1-01e3-45b3-a534-5411c807285e"), 3, new DateTime(2023, 4, 29, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(9498), null, "Description for WorkItem 332", 1, 1, "WorkItem 332" },
                    { new Guid("789b46f5-c57a-4eb5-8311-fbe031b29386"), new Guid("880f1059-f46d-4d66-baea-a8a75b787d24"), 3, new DateTime(2023, 4, 17, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(9688), null, "Description for WorkItem 344", 1, 1, "WorkItem 344" },
                    { new Guid("78e75ebf-f5c1-492c-9c4a-b7a3602c901d"), new Guid("b05c44eb-7568-4523-be49-08105fbb1106"), 0, new DateTime(2023, 9, 11, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(7401), null, "Description for WorkItem 197", 1, 1, "WorkItem 197" },
                    { new Guid("793e8528-b09b-4528-a302-33d7b703693b"), new Guid("89155141-a366-44db-b0a4-4376ec44dcfe"), 2, new DateTime(2024, 2, 20, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(4048), null, "Description for WorkItem 35", 1, 1, "WorkItem 35" },
                    { new Guid("79cc4674-6717-4a7a-a1d6-f50c5e8eb337"), new Guid("e7658228-f102-46ce-ad6d-eb770c11ddee"), 0, new DateTime(2023, 10, 5, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(6059), null, "Description for WorkItem 173", 1, 1, "WorkItem 173" },
                    { new Guid("79fa34da-acc0-4791-9df3-f0a140dc3ed4"), new Guid("210513be-95f9-46ce-a1e8-3b5ea08231c7"), 2, new DateTime(2023, 9, 17, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(6260), null, "Description for WorkItem 191", 1, 1, "WorkItem 191" },
                    { new Guid("7b6a5668-a693-4645-9142-81752b652e19"), new Guid("dcc3349d-654c-4415-8815-cedcbc349126"), 1, new DateTime(2024, 3, 12, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(3748), null, "Description for WorkItem 14", 1, 1, "WorkItem 14" },
                    { new Guid("7bd74f48-1c56-43ba-90dd-cc84f07df2f0"), new Guid("f8b91952-2bf0-4a59-9cd9-5e1f784eb79e"), 3, new DateTime(2023, 12, 21, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(4962), null, "Description for WorkItem 96", 2, 2, "WorkItem 96" },
                    { new Guid("7c8f8971-3c1e-41a9-adb8-ccb3d87b2b5f"), new Guid("f79631e3-8401-451f-b49a-94a6b358807b"), 2, new DateTime(2023, 8, 24, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(7870), null, "Description for WorkItem 215", 1, 1, "WorkItem 215" },
                    { new Guid("7cc4dd2a-4f0a-43fd-b398-07bce336a280"), new Guid("f8b91952-2bf0-4a59-9cd9-5e1f784eb79e"), 1, new DateTime(2024, 2, 29, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(3949), null, "Description for WorkItem 26", 1, 1, "WorkItem 26" },
                    { new Guid("7e975ab2-1425-4178-a6ab-16ee86a7c028"), new Guid("c049086d-9699-4ee0-ab6b-f1a4802b03ee"), 1, new DateTime(2023, 12, 31, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(4851), null, "Description for WorkItem 86", 1, 1, "WorkItem 86" },
                    { new Guid("7f970e77-5721-48cd-8efd-8db7c34ac5a6"), new Guid("e7658228-f102-46ce-ad6d-eb770c11ddee"), 2, new DateTime(2023, 7, 27, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(8362), null, "Description for WorkItem 243", 2, 2, "WorkItem 243" },
                    { new Guid("83ae1e83-a411-41d3-96e5-a8fc69553f80"), new Guid("94c5d955-ff84-44ba-8297-4212f5a2eb57"), 3, new DateTime(2023, 3, 12, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(159), null, "Description for WorkItem 380", 1, 1, "WorkItem 380" },
                    { new Guid("845306a2-2574-4dcf-8285-f6bc4a30637c"), new Guid("e6a5501a-de17-4657-a9d3-9aa5b74f862c"), 1, new DateTime(2024, 1, 8, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(4705), null, "Description for WorkItem 78", 2, 2, "WorkItem 78" },
                    { new Guid("8508786c-9ddf-4d79-a518-b8507c13579a"), new Guid("0f50b1be-1daa-4064-9e83-c4ded856a098"), 0, new DateTime(2023, 6, 11, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(8968), null, "Description for WorkItem 289", 0, 0, "WorkItem 289" },
                    { new Guid("850a4cc2-d357-438a-b7ee-00a96cec32d3"), new Guid("4610a824-5bae-4dce-ad57-22e6d63ecd30"), 3, new DateTime(2023, 3, 8, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(200), null, "Description for WorkItem 384", 2, 2, "WorkItem 384" },
                    { new Guid("8527fe28-abfa-4fe0-b421-75afbeb649eb"), new Guid("110f2ffa-2825-4b68-b584-707b9c7cc472"), 0, new DateTime(2023, 7, 13, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(8510), null, "Description for WorkItem 257", 1, 1, "WorkItem 257" },
                    { new Guid("87da8335-7282-4d2a-ac4f-1e42da6e4275"), new Guid("89155141-a366-44db-b0a4-4376ec44dcfe"), 0, new DateTime(2023, 3, 7, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(214), null, "Description for WorkItem 385", 0, 0, "WorkItem 385" },
                    { new Guid("882b6dfe-239e-4471-8e49-096c3bb5702d"), new Guid("1f43dce8-8941-4536-bcae-59b78ad071f8"), 0, new DateTime(2024, 1, 1, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(4841), null, "Description for WorkItem 85", 0, 0, "WorkItem 85" },
                    { new Guid("8a3345f7-c6d7-45e3-925b-01272257fd48"), new Guid("1ef348d3-6cef-40c0-8d21-e1b3ac8ba85d"), 2, new DateTime(2023, 5, 24, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(9210), null, "Description for WorkItem 307", 0, 0, "WorkItem 307" },
                    { new Guid("8a9ce083-fa41-4ac0-a09f-a5fbc16bf4c6"), new Guid("5a9cd035-c05b-484a-b4da-ee400ac432b2"), 1, new DateTime(2023, 3, 18, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(94), null, "Description for WorkItem 374", 1, 1, "WorkItem 374" },
                    { new Guid("8ac8e5a4-9917-403d-8ac3-bc0b0f4e97f7"), new Guid("7e6932ef-fe3a-4e22-bf03-be4c9fb40b68"), 2, new DateTime(2023, 8, 12, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(8008), null, "Description for WorkItem 227", 1, 1, "WorkItem 227" },
                    { new Guid("8ae445df-d051-49db-aaa2-5bcd9df85993"), new Guid("054b5698-5d00-4f55-9132-ce0f5ea666bd"), 1, new DateTime(2023, 9, 10, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(7418), null, "Description for WorkItem 198", 2, 2, "WorkItem 198" },
                    { new Guid("8bce3f75-1ca8-4c90-a9ee-49c72004a652"), new Guid("b574cdb9-8ceb-4fd4-8e8f-2c1512aa907f"), 3, new DateTime(2023, 12, 5, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(5210), null, "Description for WorkItem 112", 0, 0, "WorkItem 112" },
                    { new Guid("8cfa717f-ecf7-478b-b52b-bf91e755eb00"), new Guid("110f2ffa-2825-4b68-b584-707b9c7cc472"), 0, new DateTime(2023, 2, 23, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(374), null, "Description for WorkItem 397", 0, 0, "WorkItem 397" },
                    { new Guid("8f33148c-015c-4c03-ac45-81e6a417c062"), new Guid("341f9b78-ce17-42e9-9091-dbefeba89d3b"), 1, new DateTime(2023, 9, 30, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(6115), null, "Description for WorkItem 178", 0, 0, "WorkItem 178" },
                    { new Guid("8fbbf1fb-c7c4-4ba1-8479-5df55672c66c"), new Guid("96013f50-c6e1-4e8d-a6e4-d8ac93bdbdb8"), 3, new DateTime(2023, 11, 7, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(5586), null, "Description for WorkItem 140", 1, 1, "WorkItem 140" },
                    { new Guid("9073288c-2369-4377-8ef4-7e94f92e92e5"), new Guid("1ef348d3-6cef-40c0-8d21-e1b3ac8ba85d"), 0, new DateTime(2023, 8, 2, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(8259), null, "Description for WorkItem 237", 2, 2, "WorkItem 237" },
                    { new Guid("90adae65-cb66-4e3b-8b98-c8a12d0e792d"), new Guid("4cafe1b0-6478-4509-9433-80cc2a331b22"), 2, new DateTime(2023, 6, 13, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(8944), null, "Description for WorkItem 287", 1, 1, "WorkItem 287" },
                    { new Guid("914b5c7f-ce1c-4894-8489-5f2fa0eccb78"), new Guid("0ddf2d45-9f40-4fcd-80a2-5286ec667ad1"), 1, new DateTime(2023, 9, 22, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(6202), null, "Description for WorkItem 186", 2, 2, "WorkItem 186" },
                    { new Guid("9172fef5-6c38-41e2-966a-3a08e3fc12c5"), new Guid("1106ab56-1576-4138-8521-a0ca8d9492e2"), 3, new DateTime(2023, 10, 2, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(6093), null, "Description for WorkItem 176", 1, 1, "WorkItem 176" },
                    { new Guid("91eb4162-466c-44b7-89c0-6591ec6dfb57"), new Guid("da962695-902b-40ef-a0ca-2ea3599659e8"), 2, new DateTime(2023, 4, 22, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(9573), null, "Description for WorkItem 339", 2, 2, "WorkItem 339" },
                    { new Guid("91eed712-a8ef-4686-8e95-e2ab4a6c7224"), new Guid("01610c7a-9e93-41c4-88bf-65ff2ed11f50"), 1, new DateTime(2023, 10, 20, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(5805), null, "Description for WorkItem 158", 1, 1, "WorkItem 158" },
                    { new Guid("922bef24-dca5-4871-a559-533573455624"), new Guid("64b45b41-2ae7-4798-93cd-b226d2340502"), 1, new DateTime(2023, 9, 14, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(7347), null, "Description for WorkItem 194", 1, 1, "WorkItem 194" },
                    { new Guid("92349d1d-ce43-40cd-b041-145097bbf7ab"), new Guid("86af32ca-f862-4f98-a7c2-e7ba19619301"), 2, new DateTime(2023, 5, 28, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(9166), null, "Description for WorkItem 303", 2, 2, "WorkItem 303" },
                    { new Guid("9249d3b2-c77f-4b2a-993c-c8bef607f1ed"), new Guid("aabac3ed-cd23-437e-9977-9f263cea7b12"), 0, new DateTime(2023, 3, 3, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(287), null, "Description for WorkItem 389", 1, 1, "WorkItem 389" },
                    { new Guid("940b7d46-cef2-408c-9121-a0d53f6e1d0a"), new Guid("110f2ffa-2825-4b68-b584-707b9c7cc472"), 0, new DateTime(2023, 11, 30, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(5268), null, "Description for WorkItem 117", 2, 2, "WorkItem 117" },
                    { new Guid("94a2d742-2d6c-4811-8ef6-83117cb60cb4"), new Guid("57c29b52-3614-4f45-80da-9f9f0c0be1cc"), 1, new DateTime(2024, 2, 5, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(4356), null, "Description for WorkItem 50", 1, 1, "WorkItem 50" },
                    { new Guid("94a833b3-144c-40b0-8d30-172b0fe4a95d"), new Guid("9c4027f3-ed3b-49ca-8dd3-4332a7c29541"), 0, new DateTime(2023, 9, 7, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(7487), null, "Description for WorkItem 201", 2, 2, "WorkItem 201" },
                    { new Guid("95674928-b6f5-4d51-9522-8ee931a6dce1"), new Guid("64b45b41-2ae7-4798-93cd-b226d2340502"), 3, new DateTime(2023, 7, 6, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(8657), null, "Description for WorkItem 264", 2, 2, "WorkItem 264" },
                    { new Guid("9622d40a-1c5d-4ab2-b94a-c835e64077e6"), new Guid("a1952de2-fdf7-469f-bae6-092993cb4c01"), 0, new DateTime(2023, 7, 17, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(8466), null, "Description for WorkItem 253", 0, 0, "WorkItem 253" },
                    { new Guid("9657bf12-bed1-4d16-88b5-5433786bd2f9"), new Guid("c4d38b52-d1a2-4a0e-8de5-85eb2fcd6604"), 0, new DateTime(2023, 10, 17, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(5836), null, "Description for WorkItem 161", 1, 1, "WorkItem 161" },
                    { new Guid("97420779-7e8f-445a-9f58-edb0b2a80f6b"), new Guid("63f070ef-1274-4658-b44a-96cc2c6ea907"), 3, new DateTime(2023, 5, 31, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(9135), null, "Description for WorkItem 300", 2, 2, "WorkItem 300" },
                    { new Guid("97c1fd8d-1579-4355-af44-4768527b31d5"), new Guid("ec4337d3-7aa8-4396-831e-4eb510aa5bb1"), 2, new DateTime(2023, 2, 21, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(394), null, "Description for WorkItem 399", 2, 2, "WorkItem 399" },
                    { new Guid("9867c48b-3342-425d-9e2e-a9a88e5c9f18"), new Guid("8503793e-1bda-496e-a1da-3cf84041704b"), 2, new DateTime(2024, 3, 15, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(3713), null, "Description for WorkItem 11", 1, 1, "WorkItem 11" },
                    { new Guid("9a1d31fd-3df7-4778-88c6-6236d78ddb00"), new Guid("5a9cd035-c05b-484a-b4da-ee400ac432b2"), 1, new DateTime(2023, 8, 5, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(8229), null, "Description for WorkItem 234", 2, 2, "WorkItem 234" },
                    { new Guid("9a394445-7ad2-4e51-a628-a95b9d183d46"), new Guid("13a41e4c-47b5-4393-8b01-110462a3d083"), 1, new DateTime(2023, 3, 10, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(179), null, "Description for WorkItem 382", 0, 0, "WorkItem 382" },
                    { new Guid("9a6c24cb-f458-48eb-b6df-7605bb3cee72"), new Guid("5cea12db-210f-424f-9310-a9594619b930"), 0, new DateTime(2023, 4, 12, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(9744), null, "Description for WorkItem 349", 0, 0, "WorkItem 349" },
                    { new Guid("9c18ef0d-8170-493e-9cb4-504d833eb0bc"), new Guid("9f00fd1f-21b1-47d1-ba85-c6f855d7fd17"), 1, new DateTime(2023, 11, 29, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(5279), null, "Description for WorkItem 118", 0, 0, "WorkItem 118" },
                    { new Guid("9c8752e0-4b1c-4682-aefd-a4a0a865e3c7"), new Guid("7e6932ef-fe3a-4e22-bf03-be4c9fb40b68"), 2, new DateTime(2023, 3, 25, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(19), null, "Description for WorkItem 367", 0, 0, "WorkItem 367" },
                    { new Guid("9c9fe38b-b7e9-463b-b2fd-ab49294ee33a"), new Guid("be37261d-62bb-4d93-8982-4411941de97b"), 1, new DateTime(2023, 9, 6, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(7503), null, "Description for WorkItem 202", 0, 0, "WorkItem 202" },
                    { new Guid("9ca3baa5-d96d-43f8-a037-005352d3f122"), new Guid("d7657a73-2859-4353-95a2-c720d5341882"), 2, new DateTime(2023, 6, 25, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(8817), null, "Description for WorkItem 275", 1, 1, "WorkItem 275" },
                    { new Guid("9ca61495-f31a-412c-a6b9-fdde731dc0ef"), new Guid("7e6932ef-fe3a-4e22-bf03-be4c9fb40b68"), 2, new DateTime(2023, 12, 30, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(4862), null, "Description for WorkItem 87", 2, 2, "WorkItem 87" },
                    { new Guid("9caff0e2-3755-4048-947b-7de89bdfd2ab"), new Guid("f8b91952-2bf0-4a59-9cd9-5e1f784eb79e"), 1, new DateTime(2023, 5, 25, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(9200), null, "Description for WorkItem 306", 2, 2, "WorkItem 306" },
                    { new Guid("9d7b4b84-5cb3-4309-9dea-c394bc06331a"), new Guid("c7f7d3d3-2f4d-4e85-9e35-74e23e44d5f9"), 3, new DateTime(2023, 12, 25, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(4918), null, "Description for WorkItem 92", 1, 1, "WorkItem 92" },
                    { new Guid("9e6650b0-3485-4d47-9f25-45c102915959"), new Guid("22dbcf5e-49f3-451d-8f68-a70d36d5eafc"), 3, new DateTime(2024, 1, 30, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(4423), null, "Description for WorkItem 56", 1, 1, "WorkItem 56" },
                    { new Guid("9e6e3747-d72d-4151-817f-33bd99839fc9"), new Guid("ccbe957a-8557-47e4-9c99-ddccae845545"), 1, new DateTime(2023, 3, 2, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(297), null, "Description for WorkItem 390", 2, 2, "WorkItem 390" },
                    { new Guid("9f7ec937-484d-4411-9a07-a55ecaac755d"), new Guid("f0b38660-d5db-4f9d-9729-94358cb7bdb5"), 0, new DateTime(2023, 12, 28, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(4883), null, "Description for WorkItem 89", 1, 1, "WorkItem 89" },
                    { new Guid("a02e73f1-aed8-4934-a479-809fb8e7ec99"), new Guid("f0b38660-d5db-4f9d-9729-94358cb7bdb5"), 0, new DateTime(2023, 8, 10, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(8173), null, "Description for WorkItem 229", 0, 0, "WorkItem 229" },
                    { new Guid("a033d165-c1ed-47a3-9530-1df4c935a9c0"), new Guid("ccebfce7-bf7e-4f44-a049-f78059d28a18"), 2, new DateTime(2023, 12, 18, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(4994), null, "Description for WorkItem 99", 2, 2, "WorkItem 99" },
                    { new Guid("a04f2a70-49bb-4524-ab6b-d54f6def781e"), new Guid("dcc3349d-654c-4415-8815-cedcbc349126"), 3, new DateTime(2023, 8, 15, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(7973), null, "Description for WorkItem 224", 1, 1, "WorkItem 224" },
                    { new Guid("a0b34505-c808-4b06-aa44-d72e6fbbf0dc"), new Guid("a8ad6597-7b4a-46d9-a2ff-647b86e7da1c"), 1, new DateTime(2024, 1, 4, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(4806), null, "Description for WorkItem 82", 0, 0, "WorkItem 82" },
                    { new Guid("a10053c6-bf13-4f1f-b791-a1a674e58c62"), new Guid("1106ab56-1576-4138-8521-a0ca8d9492e2"), 1, new DateTime(2023, 7, 24, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(8391), null, "Description for WorkItem 246", 2, 2, "WorkItem 246" },
                    { new Guid("a1414c30-2437-4c82-9be3-05ba4ee61ada"), new Guid("0f50b1be-1daa-4064-9e83-c4ded856a098"), 2, new DateTime(2024, 1, 7, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(4716), null, "Description for WorkItem 79", 0, 0, "WorkItem 79" },
                    { new Guid("a3052a2b-3db1-480e-837d-cdce23fc0769"), new Guid("72e10416-635b-4d83-a77b-d572193637da"), 3, new DateTime(2023, 9, 24, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(6182), null, "Description for WorkItem 184", 0, 0, "WorkItem 184" },
                    { new Guid("a35376b9-9c71-4077-9a7a-07bddde7e74f"), new Guid("a8ad6597-7b4a-46d9-a2ff-647b86e7da1c"), 3, new DateTime(2023, 6, 8, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(8998), null, "Description for WorkItem 292", 0, 0, "WorkItem 292" },
                    { new Guid("a3698c1a-3236-4a17-9cf6-64c3aa9fab66"), new Guid("d7657a73-2859-4353-95a2-c720d5341882"), 0, new DateTime(2023, 4, 16, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(9702), null, "Description for WorkItem 345", 2, 2, "WorkItem 345" },
                    { new Guid("a3ab439e-56de-43f2-bd8a-9e76e7f28918"), new Guid("dcc3349d-654c-4415-8815-cedcbc349126"), 1, new DateTime(2023, 6, 6, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(9019), null, "Description for WorkItem 294", 2, 2, "WorkItem 294" },
                    { new Guid("a3da7d7c-57df-404a-a999-0504ac4f193e"), new Guid("1ef348d3-6cef-40c0-8d21-e1b3ac8ba85d"), 2, new DateTime(2024, 2, 28, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(3959), null, "Description for WorkItem 27", 2, 2, "WorkItem 27" },
                    { new Guid("a3e640b0-2dd6-4d0e-baf8-e4ae5542cdaf"), new Guid("63f070ef-1274-4658-b44a-96cc2c6ea907"), 1, new DateTime(2023, 3, 22, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(53), null, "Description for WorkItem 370", 0, 0, "WorkItem 370" },
                    { new Guid("a42ac51a-d930-4e3b-bb6c-50708b5b0353"), new Guid("a8ad6597-7b4a-46d9-a2ff-647b86e7da1c"), 3, new DateTime(2023, 10, 26, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(5737), null, "Description for WorkItem 152", 1, 1, "WorkItem 152" },
                    { new Guid("a446917e-16d5-4912-87bc-6d9dde99e5ec"), new Guid("53b1cab2-6315-4281-800d-1338b8df64d8"), 0, new DateTime(2023, 6, 27, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(8795), null, "Description for WorkItem 273", 2, 2, "WorkItem 273" },
                    { new Guid("a4ad23d5-5776-445b-964b-2849bcd464bf"), new Guid("1f43dce8-8941-4536-bcae-59b78ad071f8"), 0, new DateTime(2023, 8, 14, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(7987), null, "Description for WorkItem 225", 2, 2, "WorkItem 225" },
                    { new Guid("a5197a21-b5e4-4d46-b2ea-9f9991dd83c2"), new Guid("66fa74a2-72e3-4847-ad07-51c4f5daeb40"), 0, new DateTime(2023, 5, 6, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(9423), null, "Description for WorkItem 325", 0, 0, "WorkItem 325" },
                    { new Guid("a62556b5-550f-4e5d-8087-c11bae13c3d0"), new Guid("eff36b81-3f39-4232-9410-85391584d000"), 1, new DateTime(2023, 11, 5, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(5607), null, "Description for WorkItem 142", 0, 0, "WorkItem 142" },
                    { new Guid("a81c123b-3562-4402-a261-45de173f253d"), new Guid("9f00fd1f-21b1-47d1-ba85-c6f855d7fd17"), 3, new DateTime(2024, 2, 7, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(4335), null, "Description for WorkItem 48", 2, 2, "WorkItem 48" },
                    { new Guid("a99efa15-307a-435d-bc42-2a41667a21bc"), new Guid("5a9cd035-c05b-484a-b4da-ee400ac432b2"), 3, new DateTime(2023, 5, 27, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(9176), null, "Description for WorkItem 304", 0, 0, "WorkItem 304" },
                    { new Guid("a9f1f957-9c4b-428d-93b1-a2a1a47433f3"), new Guid("ec4337d3-7aa8-4396-831e-4eb510aa5bb1"), 0, new DateTime(2023, 9, 19, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(6238), null, "Description for WorkItem 189", 2, 2, "WorkItem 189" },
                    { new Guid("aa8be53e-71eb-42b2-bc24-034ca01465c4"), new Guid("a6e966cd-eb16-403e-93ce-0a7f7e318a6b"), 2, new DateTime(2023, 8, 4, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(8239), null, "Description for WorkItem 235", 0, 0, "WorkItem 235" },
                    { new Guid("ab5c2881-abc1-450e-a16e-d44a3bd74763"), new Guid("7e0d6368-b609-43da-ad5f-1be2ebaa2301"), 1, new DateTime(2023, 6, 10, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(8978), null, "Description for WorkItem 290", 1, 1, "WorkItem 290" },
                    { new Guid("abb37c71-935b-48a5-815d-9807ae79ff71"), new Guid("a8ad6597-7b4a-46d9-a2ff-647b86e7da1c"), 1, new DateTime(2023, 8, 17, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(7952), null, "Description for WorkItem 222", 2, 2, "WorkItem 222" },
                    { new Guid("abbd7e7e-06f8-419b-aff8-1e8bd3ede37f"), new Guid("a8ad6597-7b4a-46d9-a2ff-647b86e7da1c"), 1, new DateTime(2023, 3, 30, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(9883), null, "Description for WorkItem 362", 1, 1, "WorkItem 362" },
                    { new Guid("ac26ad18-9742-47ef-a28c-62dfa0321e2b"), new Guid("aabac3ed-cd23-437e-9977-9f263cea7b12"), 0, new DateTime(2023, 7, 21, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(8425), null, "Description for WorkItem 249", 2, 2, "WorkItem 249" },
                    { new Guid("ac5ee180-d2ec-471d-8fcd-4c09c8d9131f"), new Guid("9f00fd1f-21b1-47d1-ba85-c6f855d7fd17"), 1, new DateTime(2023, 7, 12, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(8592), null, "Description for WorkItem 258", 2, 2, "WorkItem 258" },
                    { new Guid("aca7a37e-176f-4e49-b3e6-7199ef3d5bd4"), new Guid("be37261d-62bb-4d93-8982-4411941de97b"), 1, new DateTime(2024, 1, 24, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(4526), null, "Description for WorkItem 62", 1, 1, "WorkItem 62" },
                    { new Guid("accef828-7b62-4913-8d8a-ae1ada8f01a2"), new Guid("aabac3ed-cd23-437e-9977-9f263cea7b12"), 2, new DateTime(2023, 9, 29, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(6125), null, "Description for WorkItem 179", 1, 1, "WorkItem 179" },
                    { new Guid("ad4ee2ca-1f91-4c77-92b3-7a67f535f4ec"), new Guid("054b5698-5d00-4f55-9132-ce0f5ea666bd"), 3, new DateTime(2023, 7, 2, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(8702), null, "Description for WorkItem 268", 0, 0, "WorkItem 268" },
                    { new Guid("ad5f2487-3a2a-4a00-b0f1-dbde55a5f89b"), new Guid("76b28a73-a636-49f8-8b00-e9beb754a1d0"), 0, new DateTime(2023, 4, 28, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(9509), null, "Description for WorkItem 333", 2, 2, "WorkItem 333" },
                    { new Guid("ad6b3bd6-df9f-45e9-a6b1-1290ba4362aa"), new Guid("0f50b1be-1daa-4064-9e83-c4ded856a098"), 2, new DateTime(2023, 4, 2, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(9849), null, "Description for WorkItem 359", 1, 1, "WorkItem 359" },
                    { new Guid("adda4e80-a2a1-469e-bf78-7b966294269c"), new Guid("e6a5501a-de17-4657-a9d3-9aa5b74f862c"), 1, new DateTime(2023, 4, 3, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(9839), null, "Description for WorkItem 358", 0, 0, "WorkItem 358" },
                    { new Guid("ae5551bf-270d-4a5a-8edb-2038958f7fe5"), new Guid("85ce4a6a-a305-426a-9e29-f817f44c98a8"), 2, new DateTime(2024, 1, 19, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(4582), null, "Description for WorkItem 67", 0, 0, "WorkItem 67" },
                    { new Guid("ae55904a-3e05-48cd-8a21-35a1956aa358"), new Guid("eeb7f210-bf39-4d83-83f2-ffa564208f5a"), 2, new DateTime(2023, 4, 10, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(9764), null, "Description for WorkItem 351", 2, 2, "WorkItem 351" },
                    { new Guid("ae7bf25b-3d3b-4c87-83f7-0c4d91fa7f92"), new Guid("be37261d-62bb-4d93-8982-4411941de97b"), 3, new DateTime(2023, 11, 15, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(5497), null, "Description for WorkItem 132", 2, 2, "WorkItem 132" },
                    { new Guid("ae99705b-8c9f-48bc-a0ab-50e6b1a3d27a"), new Guid("a6e966cd-eb16-403e-93ce-0a7f7e318a6b"), 2, new DateTime(2023, 12, 22, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(4951), null, "Description for WorkItem 95", 1, 1, "WorkItem 95" },
                    { new Guid("aefa3132-b00b-4ab1-a8b1-639301fd72eb"), new Guid("1ef348d3-6cef-40c0-8d21-e1b3ac8ba85d"), 0, new DateTime(2023, 12, 20, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(4972), null, "Description for WorkItem 97", 0, 0, "WorkItem 97" },
                    { new Guid("af586967-6f87-41eb-99f1-8302ca408c15"), new Guid("696346f6-5cf4-4bcf-997b-f7541af90e31"), 0, new DateTime(2023, 10, 25, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(5748), null, "Description for WorkItem 153", 2, 2, "WorkItem 153" },
                    { new Guid("af6e858e-1b8f-47e4-a485-7627dc129156"), new Guid("d09ff1a6-375a-4c6b-b790-bb322b576874"), 0, new DateTime(2024, 2, 18, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(4073), null, "Description for WorkItem 37", 0, 0, "WorkItem 37" },
                    { new Guid("afb6c161-6ae6-4f58-ba65-b079e82199e5"), new Guid("eeb7f210-bf39-4d83-83f2-ffa564208f5a"), 2, new DateTime(2023, 8, 28, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(7658), null, "Description for WorkItem 211", 0, 0, "WorkItem 211" },
                    { new Guid("b06af581-89a7-44d2-80c9-79ed701b4b2c"), new Guid("b05c44eb-7568-4523-be49-08105fbb1106"), 2, new DateTime(2023, 11, 20, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(5379), null, "Description for WorkItem 127", 0, 0, "WorkItem 127" },
                    { new Guid("b1aa64ac-4e52-4db6-a80e-173e555d1043"), new Guid("7ec48e58-03e0-42ef-b69d-3ca5d36a540d"), 1, new DateTime(2023, 8, 1, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(8307), null, "Description for WorkItem 238", 0, 0, "WorkItem 238" },
                    { new Guid("b2a18310-ade4-4b1d-945c-155da64014b7"), new Guid("c3bc7db1-01e3-45b3-a534-5411c807285e"), 3, new DateTime(2023, 9, 16, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(6337), null, "Description for WorkItem 192", 2, 2, "WorkItem 192" },
                    { new Guid("b4884118-cddc-44b3-beda-cdefa2e4fd4b"), new Guid("96013f50-c6e1-4e8d-a6e4-d8ac93bdbdb8"), 1, new DateTime(2023, 4, 11, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(9754), null, "Description for WorkItem 350", 1, 1, "WorkItem 350" },
                    { new Guid("b4db8499-4648-4b2e-bfa4-b8a81fe0e781"), new Guid("b05c44eb-7568-4523-be49-08105fbb1106"), 0, new DateTime(2023, 4, 24, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(9553), null, "Description for WorkItem 337", 0, 0, "WorkItem 337" },
                    { new Guid("b60e54ab-69c4-477c-b65c-cd928c80e550"), new Guid("8503793e-1bda-496e-a1da-3cf84041704b"), 0, new DateTime(2023, 3, 31, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(9873), null, "Description for WorkItem 361", 0, 0, "WorkItem 361" },
                    { new Guid("b6f57b25-1578-4ded-96ce-14387e29e74c"), new Guid("0f50b1be-1daa-4064-9e83-c4ded856a098"), 2, new DateTime(2023, 8, 20, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(7920), null, "Description for WorkItem 219", 2, 2, "WorkItem 219" },
                    { new Guid("b6fe8e48-a00e-47da-9e90-46071c658fcb"), new Guid("414b5098-3cf1-42e8-a3b0-c8648922eb21"), 0, new DateTime(2023, 11, 22, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(5357), null, "Description for WorkItem 125", 1, 1, "WorkItem 125" },
                    { new Guid("b79e25af-177c-46fa-a2ca-666d87f77063"), new Guid("0f5e4c81-1dee-4681-9e74-62f77ae22cb4"), 3, new DateTime(2024, 3, 22, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(3633), null, "Description for WorkItem 4", 0, 0, "WorkItem 4" },
                    { new Guid("b7f05c45-c207-4d59-be45-3e64c6dd5c38"), new Guid("a6e966cd-eb16-403e-93ce-0a7f7e318a6b"), 0, new DateTime(2023, 10, 13, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(5883), null, "Description for WorkItem 165", 2, 2, "WorkItem 165" },
                    { new Guid("b80d131c-2b50-4a94-a2c7-c53f646b72c2"), new Guid("c4d38b52-d1a2-4a0e-8de5-85eb2fcd6604"), 2, new DateTime(2023, 12, 26, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(4904), null, "Description for WorkItem 91", 0, 0, "WorkItem 91" },
                    { new Guid("b906af38-faec-48da-bfdf-de0e7a1b7088"), new Guid("a1952de2-fdf7-469f-bae6-092993cb4c01"), 0, new DateTime(2023, 2, 27, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(333), null, "Description for WorkItem 393", 2, 2, "WorkItem 393" },
                    { new Guid("b97b9f4f-e88d-4c54-80f8-57bd9d3374ac"), new Guid("86af32ca-f862-4f98-a7c2-e7ba19619301"), 0, new DateTime(2023, 3, 19, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(84), null, "Description for WorkItem 373", 0, 0, "WorkItem 373" },
                    { new Guid("b9ad8d0e-98bd-469c-91a2-87841736cc78"), new Guid("f7358570-ea64-4912-81b3-d3ef3a255b2e"), 0, new DateTime(2023, 5, 10, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(9381), null, "Description for WorkItem 321", 2, 2, "WorkItem 321" },
                    { new Guid("ba610105-8359-4b58-b5ce-2340c136ec86"), new Guid("1106ab56-1576-4138-8521-a0ca8d9492e2"), 1, new DateTime(2023, 3, 6, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(224), null, "Description for WorkItem 386", 1, 1, "WorkItem 386" },
                    { new Guid("baa00186-12ad-4038-8927-b54f91aef241"), new Guid("d09ff1a6-375a-4c6b-b790-bb322b576874"), 0, new DateTime(2023, 10, 1, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(6104), null, "Description for WorkItem 177", 2, 2, "WorkItem 177" },
                    { new Guid("baa8833f-979b-45a0-a42e-2dc5f3e2dfaa"), new Guid("13a41e4c-47b5-4393-8b01-110462a3d083"), 1, new DateTime(2023, 7, 28, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(8352), null, "Description for WorkItem 242", 1, 1, "WorkItem 242" },
                    { new Guid("bb1af4d3-f999-4919-81c6-49a2572dae83"), new Guid("f7358570-ea64-4912-81b3-d3ef3a255b2e"), 2, new DateTime(2023, 12, 6, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(5198), null, "Description for WorkItem 111", 2, 2, "WorkItem 111" },
                    { new Guid("bc7ac292-bc8e-43c1-a6f2-c896a508123f"), new Guid("1f43dce8-8941-4536-bcae-59b78ad071f8"), 0, new DateTime(2023, 3, 27, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(9998), null, "Description for WorkItem 365", 1, 1, "WorkItem 365" },
                    { new Guid("bca42a2a-134a-43aa-b962-a4c6a0e0ab72"), new Guid("f79631e3-8401-451f-b49a-94a6b358807b"), 2, new DateTime(2024, 1, 11, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(4670), null, "Description for WorkItem 75", 2, 2, "WorkItem 75" },
                    { new Guid("bcdbdd2f-f47e-448f-834e-ef753e12b5e8"), new Guid("98781be4-7ee0-4934-b14f-51bfad3972e6"), 3, new DateTime(2024, 1, 18, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(4596), null, "Description for WorkItem 68", 1, 1, "WorkItem 68" },
                    { new Guid("bf7df3cd-b41b-41e8-bb35-e4e8ab21d0f3"), new Guid("0ddf2d45-9f40-4fcd-80a2-5286ec667ad1"), 1, new DateTime(2023, 5, 5, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(9433), null, "Description for WorkItem 326", 1, 1, "WorkItem 326" },
                    { new Guid("bfbac8ca-e368-4e9e-ad5c-a9fadaaae0e7"), new Guid("f8b91952-2bf0-4a59-9cd9-5e1f784eb79e"), 3, new DateTime(2023, 8, 3, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(8249), null, "Description for WorkItem 236", 1, 1, "WorkItem 236" },
                    { new Guid("bfbf2716-a985-4a78-a1de-55236d144294"), new Guid("98781be4-7ee0-4934-b14f-51bfad3972e6"), 3, new DateTime(2023, 8, 31, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(7601), null, "Description for WorkItem 208", 0, 0, "WorkItem 208" },
                    { new Guid("bff03978-f350-4da2-aa64-15df86088d26"), new Guid("d7657a73-2859-4353-95a2-c720d5341882"), 2, new DateTime(2023, 11, 12, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(5530), null, "Description for WorkItem 135", 2, 2, "WorkItem 135" },
                    { new Guid("c154e8ba-fba8-451d-9afc-ced65082d698"), new Guid("ccebfce7-bf7e-4f44-a049-f78059d28a18"), 0, new DateTime(2023, 5, 22, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(9230), null, "Description for WorkItem 309", 2, 2, "WorkItem 309" },
                    { new Guid("c179dc77-fa1f-46c2-bd06-0a41ac097931"), new Guid("210513be-95f9-46ce-a1e8-3b5ea08231c7"), 2, new DateTime(2023, 4, 30, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(9488), null, "Description for WorkItem 331", 0, 0, "WorkItem 331" },
                    { new Guid("c391d426-6ba0-4c76-862b-358c71888568"), new Guid("7e0d6368-b609-43da-ad5f-1be2ebaa2301"), 3, new DateTime(2023, 8, 19, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(7931), null, "Description for WorkItem 220", 0, 0, "WorkItem 220" },
                    { new Guid("c39e3687-ed70-408e-8ef8-7a8af4a7dbe3"), new Guid("ccebfce7-bf7e-4f44-a049-f78059d28a18"), 2, new DateTime(2023, 7, 31, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(8317), null, "Description for WorkItem 239", 1, 1, "WorkItem 239" },
                    { new Guid("c4013598-736b-47fa-8524-f7fb6696f166"), new Guid("c049086d-9699-4ee0-ab6b-f1a4802b03ee"), 1, new DateTime(2023, 3, 26, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(9), null, "Description for WorkItem 366", 2, 2, "WorkItem 366" },
                    { new Guid("c413a9b6-4264-4b6d-9da1-5b6fbce109d2"), new Guid("f7358570-ea64-4912-81b3-d3ef3a255b2e"), 0, new DateTime(2024, 2, 14, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(4256), null, "Description for WorkItem 41", 1, 1, "WorkItem 41" },
                    { new Guid("c46679ce-0fd2-47cd-be48-be9cd70cc46b"), new Guid("57c29b52-3614-4f45-80da-9f9f0c0be1cc"), 1, new DateTime(2023, 5, 1, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(9478), null, "Description for WorkItem 330", 2, 2, "WorkItem 330" },
                    { new Guid("c52fa45c-e347-487a-8486-f94419dce773"), new Guid("880f1059-f46d-4d66-baea-a8a75b787d24"), 1, new DateTime(2023, 11, 13, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(5519), null, "Description for WorkItem 134", 1, 1, "WorkItem 134" },
                    { new Guid("c536badb-13aa-4b92-87fa-74d6556ba9dc"), new Guid("89155141-a366-44db-b0a4-4376ec44dcfe"), 0, new DateTime(2023, 12, 12, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(5130), null, "Description for WorkItem 105", 2, 2, "WorkItem 105" },
                    { new Guid("c54d9583-282b-402b-9e03-f69466fa12f0"), new Guid("ccebfce7-bf7e-4f44-a049-f78059d28a18"), 0, new DateTime(2024, 2, 26, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(3984), null, "Description for WorkItem 29", 1, 1, "WorkItem 29" },
                    { new Guid("c65dbaf0-1a44-47ae-8207-37753da5c480"), new Guid("0f50b1be-1daa-4064-9e83-c4ded856a098"), 0, new DateTime(2024, 3, 17, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(3687), null, "Description for WorkItem 9", 2, 2, "WorkItem 9" },
                    { new Guid("c756c285-c66e-4423-8615-8e31d960ebf5"), new Guid("f7358570-ea64-4912-81b3-d3ef3a255b2e"), 0, new DateTime(2023, 9, 27, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(6150), null, "Description for WorkItem 181", 0, 0, "WorkItem 181" },
                    { new Guid("c779c77e-cb27-479d-88b1-2b7e79ddb0cf"), new Guid("0026da90-a1a9-41fa-933e-576ad76ffbf7"), 1, new DateTime(2023, 11, 1, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(5670), null, "Description for WorkItem 146", 1, 1, "WorkItem 146" },
                    { new Guid("c89ea72a-33bb-4dcb-9767-dcf5170e00fd"), new Guid("c7f7d3d3-2f4d-4e85-9e35-74e23e44d5f9"), 3, new DateTime(2023, 3, 20, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(74), null, "Description for WorkItem 372", 2, 2, "WorkItem 372" },
                    { new Guid("c8a77899-7f04-4562-869a-d1b84415dbd1"), new Guid("da962695-902b-40ef-a0ca-2ea3599659e8"), 2, new DateTime(2024, 1, 27, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(4455), null, "Description for WorkItem 59", 1, 1, "WorkItem 59" },
                    { new Guid("ca0a6144-9642-46a2-a866-7bb678042117"), new Guid("4610a824-5bae-4dce-ad57-22e6d63ecd30"), 1, new DateTime(2023, 5, 17, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(9285), null, "Description for WorkItem 314", 1, 1, "WorkItem 314" },
                    { new Guid("ca5db0d9-d7f5-4ec3-860e-54d2a785a0b0"), new Guid("9c4027f3-ed3b-49ca-8dd3-4332a7c29541"), 2, new DateTime(2023, 6, 29, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(8732), null, "Description for WorkItem 271", 0, 0, "WorkItem 271" },
                    { new Guid("ca871290-001e-45a8-9560-ed66147c6b0e"), new Guid("eeb7f210-bf39-4d83-83f2-ffa564208f5a"), 0, new DateTime(2023, 11, 6, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(5596), null, "Description for WorkItem 141", 2, 2, "WorkItem 141" },
                    { new Guid("cb753fe5-d0f3-4860-93ed-c91bfb284651"), new Guid("0026da90-a1a9-41fa-933e-576ad76ffbf7"), 3, new DateTime(2023, 4, 5, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(9819), null, "Description for WorkItem 356", 1, 1, "WorkItem 356" },
                    { new Guid("cbb7e254-fc5c-4cb4-9227-2c221aa0e992"), new Guid("210513be-95f9-46ce-a1e8-3b5ea08231c7"), 2, new DateTime(2024, 2, 4, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(4367), null, "Description for WorkItem 51", 2, 2, "WorkItem 51" },
                    { new Guid("cc0aef5a-c969-426a-8bdf-bfa66e04f3cf"), new Guid("aabac3ed-cd23-437e-9977-9f263cea7b12"), 0, new DateTime(2023, 12, 8, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(5177), null, "Description for WorkItem 109", 0, 0, "WorkItem 109" },
                    { new Guid("cc3cddfe-cdc0-488e-9493-8cbda8710928"), new Guid("ccbe957a-8557-47e4-9c99-ddccae845545"), 3, new DateTime(2023, 5, 11, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(9368), null, "Description for WorkItem 320", 1, 1, "WorkItem 320" },
                    { new Guid("cc5b5ce3-03fd-4187-b34b-b830ec91bbf6"), new Guid("0ddf2d45-9f40-4fcd-80a2-5286ec667ad1"), 1, new DateTime(2024, 2, 9, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(4314), null, "Description for WorkItem 46", 0, 0, "WorkItem 46" },
                    { new Guid("cdb06d01-d837-4e3e-a2b4-5d14b990865b"), new Guid("7e6932ef-fe3a-4e22-bf03-be4c9fb40b68"), 0, new DateTime(2024, 3, 9, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(3848), null, "Description for WorkItem 17", 1, 1, "WorkItem 17" },
                    { new Guid("d15f9601-6e72-4579-a5a7-388c5269b69b"), new Guid("0f5e4c81-1dee-4681-9e74-62f77ae22cb4"), 1, new DateTime(2024, 1, 12, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(4659), null, "Description for WorkItem 74", 1, 1, "WorkItem 74" },
                    { new Guid("d1d87064-de17-4762-9e14-35d7724956a2"), new Guid("1f43dce8-8941-4536-bcae-59b78ad071f8"), 2, new DateTime(2023, 6, 5, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(9029), null, "Description for WorkItem 295", 0, 0, "WorkItem 295" },
                    { new Guid("d20bc345-8ffe-43b7-95b9-cea2eba0d15b"), new Guid("0026da90-a1a9-41fa-933e-576ad76ffbf7"), 3, new DateTime(2024, 1, 10, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(4684), null, "Description for WorkItem 76", 0, 0, "WorkItem 76" },
                    { new Guid("d2e8efaa-cc7f-49e0-a642-6726bcf5a352"), new Guid("be37261d-62bb-4d93-8982-4411941de97b"), 1, new DateTime(2023, 4, 19, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(9667), null, "Description for WorkItem 342", 2, 2, "WorkItem 342" },
                    { new Guid("d3ace035-4c2e-46c3-b6be-2f1e540d69b8"), new Guid("b05c44eb-7568-4523-be49-08105fbb1106"), 0, new DateTime(2024, 1, 29, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(4434), null, "Description for WorkItem 57", 2, 2, "WorkItem 57" },
                    { new Guid("d3e54fee-2ba4-4dc1-88ee-c2524a4ffc28"), new Guid("e7658228-f102-46ce-ad6d-eb770c11ddee"), 0, new DateTime(2024, 2, 22, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(4026), null, "Description for WorkItem 33", 2, 2, "WorkItem 33" },
                    { new Guid("d4c27902-f639-4b93-8ec6-43e94c263a7a"), new Guid("696346f6-5cf4-4bcf-997b-f7541af90e31"), 2, new DateTime(2024, 1, 3, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(4816), null, "Description for WorkItem 83", 1, 1, "WorkItem 83" },
                    { new Guid("d4c4f3d8-1f65-4a27-9ce8-9885c748ab88"), new Guid("e954c356-7846-4438-95ad-efce405cbe87"), 0, new DateTime(2023, 4, 8, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(9788), null, "Description for WorkItem 353", 1, 1, "WorkItem 353" },
                    { new Guid("d4de2b67-7adb-43ca-bf59-ace6f5f485e4"), new Guid("5da46ea0-bac0-4152-b19d-5aec098d62ae"), 3, new DateTime(2023, 11, 11, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(5540), null, "Description for WorkItem 136", 0, 0, "WorkItem 136" },
                    { new Guid("d661553c-d142-4228-8955-87cac8a52060"), new Guid("7e6932ef-fe3a-4e22-bf03-be4c9fb40b68"), 0, new DateTime(2023, 6, 3, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(9104), null, "Description for WorkItem 297", 2, 2, "WorkItem 297" },
                    { new Guid("d6a82c10-5961-4e14-9aeb-8eb0ee87cc98"), new Guid("eff36b81-3f39-4232-9410-85391584d000"), 3, new DateTime(2023, 4, 9, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(9775), null, "Description for WorkItem 352", 0, 0, "WorkItem 352" },
                    { new Guid("d6e12ec8-0256-41d6-88a9-bd532b9aae6b"), new Guid("96013f50-c6e1-4e8d-a6e4-d8ac93bdbdb8"), 1, new DateTime(2023, 8, 29, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(7641), null, "Description for WorkItem 210", 2, 2, "WorkItem 210" },
                    { new Guid("d7cc6a13-0c06-49d7-8e4b-5aa230b6a930"), new Guid("ccebfce7-bf7e-4f44-a049-f78059d28a18"), 0, new DateTime(2023, 10, 9, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(6013), null, "Description for WorkItem 169", 0, 0, "WorkItem 169" },
                    { new Guid("d8a58d0f-812e-452a-91c6-8a4edc7a1385"), new Guid("f7358570-ea64-4912-81b3-d3ef3a255b2e"), 2, new DateTime(2023, 7, 19, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(8445), null, "Description for WorkItem 251", 1, 1, "WorkItem 251" },
                    { new Guid("da9cfb72-9bda-47f7-8230-ccb2f70a0727"), new Guid("8503793e-1bda-496e-a1da-3cf84041704b"), 2, new DateTime(2023, 10, 27, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(5727), null, "Description for WorkItem 151", 0, 0, "WorkItem 151" },
                    { new Guid("db259174-b020-42c0-9c2e-2f9468c4a17d"), new Guid("b574cdb9-8ceb-4fd4-8e8f-2c1512aa907f"), 1, new DateTime(2024, 2, 13, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(4267), null, "Description for WorkItem 42", 2, 2, "WorkItem 42" },
                    { new Guid("dc566a03-5900-4fcb-a13e-a6312127cb69"), new Guid("01610c7a-9e93-41c4-88bf-65ff2ed11f50"), 1, new DateTime(2024, 3, 8, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(3861), null, "Description for WorkItem 18", 2, 2, "WorkItem 18" },
                    { new Guid("dc91976a-9e89-49c5-b29e-c432a243d704"), new Guid("86af32ca-f862-4f98-a7c2-e7ba19619301"), 0, new DateTime(2023, 8, 6, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(8218), null, "Description for WorkItem 233", 1, 1, "WorkItem 233" },
                    { new Guid("dd26b3c5-ad02-4fa8-9827-ed88b1f9df89"), new Guid("b574cdb9-8ceb-4fd4-8e8f-2c1512aa907f"), 1, new DateTime(2023, 9, 26, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(6160), null, "Description for WorkItem 182", 1, 1, "WorkItem 182" },
                    { new Guid("ddbdfd73-5c26-4812-9912-1d96e4e36618"), new Guid("89155141-a366-44db-b0a4-4376ec44dcfe"), 0, new DateTime(2023, 7, 25, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(8381), null, "Description for WorkItem 245", 1, 1, "WorkItem 245" },
                    { new Guid("ddca61a4-3ca0-42a9-b5ce-cd2e5f7ab7e6"), new Guid("dcc3349d-654c-4415-8815-cedcbc349126"), 3, new DateTime(2023, 3, 28, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(9903), null, "Description for WorkItem 364", 0, 0, "WorkItem 364" },
                    { new Guid("de09ab64-5c5d-4405-ae2f-7f730b883665"), new Guid("6b414c7d-3fed-4932-a291-c7af0a50d852"), 2, new DateTime(2023, 5, 20, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(9250), null, "Description for WorkItem 311", 1, 1, "WorkItem 311" },
                    { new Guid("de2c9f9f-48a8-4038-a88a-144af34681b2"), new Guid("4610a824-5bae-4dce-ad57-22e6d63ecd30"), 1, new DateTime(2023, 10, 4, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(6070), null, "Description for WorkItem 174", 2, 2, "WorkItem 174" },
                    { new Guid("de57876e-3447-4c50-9134-1c1dde517995"), new Guid("13a41e4c-47b5-4393-8b01-110462a3d083"), 3, new DateTime(2023, 5, 19, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(9261), null, "Description for WorkItem 312", 2, 2, "WorkItem 312" },
                    { new Guid("df277c5e-cb5b-476f-842a-009bec0a119b"), new Guid("c7f7d3d3-2f4d-4e85-9e35-74e23e44d5f9"), 1, new DateTime(2023, 10, 16, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(5847), null, "Description for WorkItem 162", 2, 2, "WorkItem 162" },
                    { new Guid("e0ab3824-fd63-4479-ab0b-5681aba8f452"), new Guid("e7658228-f102-46ce-ad6d-eb770c11ddee"), 2, new DateTime(2023, 12, 14, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(5041), null, "Description for WorkItem 103", 0, 0, "WorkItem 103" },
                    { new Guid("e14e962a-85a6-4b5e-9db6-a0926fc79e00"), new Guid("1f43dce8-8941-4536-bcae-59b78ad071f8"), 2, new DateTime(2023, 10, 23, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(5769), null, "Description for WorkItem 155", 1, 1, "WorkItem 155" },
                    { new Guid("e1527cf6-34d5-47cb-bf4b-87e1ca884e7d"), new Guid("66fa74a2-72e3-4847-ad07-51c4f5daeb40"), 0, new DateTime(2023, 9, 23, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(6192), null, "Description for WorkItem 185", 1, 1, "WorkItem 185" },
                    { new Guid("e28e0f29-1e2c-4d39-b71c-2d1c4ce2be56"), new Guid("01610c7a-9e93-41c4-88bf-65ff2ed11f50"), 1, new DateTime(2023, 6, 2, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(9115), null, "Description for WorkItem 298", 0, 0, "WorkItem 298" },
                    { new Guid("e32fc053-4d34-4296-914b-36d44fa596be"), new Guid("94c5d955-ff84-44ba-8297-4212f5a2eb57"), 3, new DateTime(2023, 7, 30, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(8328), null, "Description for WorkItem 240", 2, 2, "WorkItem 240" },
                    { new Guid("e38415e4-cfde-4011-aa8f-5381974a83cf"), new Guid("a8ad6597-7b4a-46d9-a2ff-647b86e7da1c"), 3, new DateTime(2024, 3, 14, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(3727), null, "Description for WorkItem 12", 2, 2, "WorkItem 12" },
                    { new Guid("e47b219a-4588-4057-85c7-4ba19dc3ce5a"), new Guid("da962695-902b-40ef-a0ca-2ea3599659e8"), 0, new DateTime(2023, 11, 18, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(5460), null, "Description for WorkItem 129", 2, 2, "WorkItem 129" },
                    { new Guid("e4c329f3-5175-4099-a34d-4a1d2871ed33"), new Guid("0f5e4c81-1dee-4681-9e74-62f77ae22cb4"), 3, new DateTime(2023, 6, 16, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(8913), null, "Description for WorkItem 284", 1, 1, "WorkItem 284" },
                    { new Guid("e57123ac-a2b3-44d5-8385-1e5069cc7f50"), new Guid("eff36b81-3f39-4232-9410-85391584d000"), 1, new DateTime(2024, 3, 24, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(3604), null, "Description for WorkItem 2", 1, 1, "WorkItem 2" },
                    { new Guid("e58b6976-e98c-4956-ab78-c4e4cf08946a"), new Guid("110f2ffa-2825-4b68-b584-707b9c7cc472"), 2, new DateTime(2023, 9, 21, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(6213), null, "Description for WorkItem 187", 0, 0, "WorkItem 187" },
                    { new Guid("e5904584-d1c7-41cc-af38-8e1e845256fe"), new Guid("5cea12db-210f-424f-9310-a9594619b930"), 2, new DateTime(2023, 6, 21, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(8858), null, "Description for WorkItem 279", 2, 2, "WorkItem 279" },
                    { new Guid("e5a1c1b3-3478-4d81-9d2e-10e3e528ef29"), new Guid("a1952de2-fdf7-469f-bae6-092993cb4c01"), 0, new DateTime(2023, 12, 4, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(5221), null, "Description for WorkItem 113", 1, 1, "WorkItem 113" },
                    { new Guid("e6071508-d20a-490f-acc4-a14269a21716"), new Guid("6b414c7d-3fed-4932-a291-c7af0a50d852"), 2, new DateTime(2023, 10, 7, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(6034), null, "Description for WorkItem 171", 2, 2, "WorkItem 171" },
                    { new Guid("e650090a-2dae-4edc-8cdf-cfe256121294"), new Guid("64b45b41-2ae7-4798-93cd-b226d2340502"), 3, new DateTime(2023, 11, 23, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(5347), null, "Description for WorkItem 124", 0, 0, "WorkItem 124" },
                    { new Guid("e6b9b1b6-1855-4a83-848e-d14e550b1f93"), new Guid("4cafe1b0-6478-4509-9433-80cc2a331b22"), 2, new DateTime(2024, 3, 19, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(3667), null, "Description for WorkItem 7", 0, 0, "WorkItem 7" },
                    { new Guid("e748a373-c1b5-4d21-8e6b-7049aa8eb259"), new Guid("aabac3ed-cd23-437e-9977-9f263cea7b12"), 2, new DateTime(2023, 5, 12, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(9335), null, "Description for WorkItem 319", 0, 0, "WorkItem 319" },
                    { new Guid("e77ba4f3-d08f-40d0-bf98-fcf84d561ff3"), new Guid("0f50b1be-1daa-4064-9e83-c4ded856a098"), 0, new DateTime(2023, 10, 29, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(5706), null, "Description for WorkItem 149", 1, 1, "WorkItem 149" },
                    { new Guid("e7ebe01d-fb37-49b7-b098-b584d475246e"), new Guid("1ef348d3-6cef-40c0-8d21-e1b3ac8ba85d"), 2, new DateTime(2023, 10, 11, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(5904), null, "Description for WorkItem 167", 1, 1, "WorkItem 167" },
                    { new Guid("e81b1c37-3510-4eb5-bfc7-3ad7cd1c28b7"), new Guid("94c5d955-ff84-44ba-8297-4212f5a2eb57"), 3, new DateTime(2023, 12, 17, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(5010), null, "Description for WorkItem 100", 0, 0, "WorkItem 100" },
                    { new Guid("e8845a1d-e3f5-4e7f-a675-7c5709ed8e81"), new Guid("0026da90-a1a9-41fa-933e-576ad76ffbf7"), 1, new DateTime(2023, 6, 14, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(8934), null, "Description for WorkItem 286", 0, 0, "WorkItem 286" },
                    { new Guid("e92930ee-33e7-49d0-adb5-f93bd795b734"), new Guid("c049086d-9699-4ee0-ab6b-f1a4802b03ee"), 3, new DateTime(2023, 10, 22, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(5784), null, "Description for WorkItem 156", 2, 2, "WorkItem 156" },
                    { new Guid("e9552333-8539-4c48-bb77-4905939221b1"), new Guid("a1952de2-fdf7-469f-bae6-092993cb4c01"), 2, new DateTime(2023, 5, 8, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(9402), null, "Description for WorkItem 323", 1, 1, "WorkItem 323" },
                    { new Guid("ea57a2fc-c56d-47f2-bd9d-3f65c43e8232"), new Guid("5cea12db-210f-424f-9310-a9594619b930"), 0, new DateTime(2024, 1, 17, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(4607), null, "Description for WorkItem 69", 2, 2, "WorkItem 69" },
                    { new Guid("ea73e260-8962-4639-b24b-57667508af89"), new Guid("d09ff1a6-375a-4c6b-b790-bb322b576874"), 2, new DateTime(2023, 12, 10, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(5152), null, "Description for WorkItem 107", 1, 1, "WorkItem 107" },
                    { new Guid("ec553e94-4b48-42ae-a6ed-3a7c004b0aab"), new Guid("53b1cab2-6315-4281-800d-1338b8df64d8"), 2, new DateTime(2024, 1, 23, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(4536), null, "Description for WorkItem 63", 2, 2, "WorkItem 63" },
                    { new Guid("ed8746f3-4aa0-4281-b9fa-ea5de5bfa6ee"), new Guid("7ec48e58-03e0-42ef-b69d-3ca5d36a540d"), 1, new DateTime(2023, 3, 14, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(138), null, "Description for WorkItem 378", 2, 2, "WorkItem 378" },
                    { new Guid("edb69ed8-16f1-4444-baf6-2c8a4411bb1b"), new Guid("0f5e4c81-1dee-4681-9e74-62f77ae22cb4"), 1, new DateTime(2023, 4, 7, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(9798), null, "Description for WorkItem 354", 2, 2, "WorkItem 354" },
                    { new Guid("eeca9296-e09a-48ba-a443-a1569eedac6d"), new Guid("98781be4-7ee0-4934-b14f-51bfad3972e6"), 1, new DateTime(2023, 6, 22, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(8847), null, "Description for WorkItem 278", 1, 1, "WorkItem 278" },
                    { new Guid("eeeb47bc-ad22-40aa-9f3b-9f74de028c98"), new Guid("7ec48e58-03e0-42ef-b69d-3ca5d36a540d"), 1, new DateTime(2023, 12, 19, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(4983), null, "Description for WorkItem 98", 1, 1, "WorkItem 98" },
                    { new Guid("ef2b23cb-4308-4983-90a8-562b2799cdb4"), new Guid("1106ab56-1576-4138-8521-a0ca8d9492e2"), 3, new DateTime(2023, 5, 15, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(9305), null, "Description for WorkItem 316", 0, 0, "WorkItem 316" },
                    { new Guid("f11cf894-910e-4ca6-a7f8-a9059acc1383"), new Guid("22dbcf5e-49f3-451d-8f68-a70d36d5eafc"), 3, new DateTime(2023, 9, 12, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(7384), null, "Description for WorkItem 196", 0, 0, "WorkItem 196" },
                    { new Guid("f27b948f-7f66-4a37-9060-1be89d67600b"), new Guid("e6a5501a-de17-4657-a9d3-9aa5b74f862c"), 3, new DateTime(2023, 10, 30, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(5695), null, "Description for WorkItem 148", 0, 0, "WorkItem 148" },
                    { new Guid("f3f11176-31eb-4b80-9393-7782e90b0cfc"), new Guid("5a9cd035-c05b-484a-b4da-ee400ac432b2"), 3, new DateTime(2023, 10, 14, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(5872), null, "Description for WorkItem 164", 1, 1, "WorkItem 164" },
                    { new Guid("f4bb9caa-df9c-45db-ad0b-63b8e743f8bf"), new Guid("86af32ca-f862-4f98-a7c2-e7ba19619301"), 2, new DateTime(2023, 10, 15, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(5857), null, "Description for WorkItem 163", 0, 0, "WorkItem 163" },
                    { new Guid("f4c0a4af-1470-4aed-877b-1478509f74cf"), new Guid("13a41e4c-47b5-4393-8b01-110462a3d083"), 3, new DateTime(2024, 2, 23, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(4016), null, "Description for WorkItem 32", 1, 1, "WorkItem 32" },
                    { new Guid("f5867e26-56be-4caf-a97d-7ff0eb2543e2"), new Guid("210513be-95f9-46ce-a1e8-3b5ea08231c7"), 0, new DateTime(2023, 11, 26, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(5312), null, "Description for WorkItem 121", 0, 0, "WorkItem 121" },
                    { new Guid("f5ef70b4-1153-4aa1-bb27-c92a9f5c00c1"), new Guid("7e0d6368-b609-43da-ad5f-1be2ebaa2301"), 1, new DateTime(2024, 3, 16, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(3702), null, "Description for WorkItem 10", 0, 0, "WorkItem 10" },
                    { new Guid("f61069fc-7849-4516-9567-d2de1d4ecac5"), new Guid("d7657a73-2859-4353-95a2-c720d5341882"), 0, new DateTime(2023, 9, 3, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(7552), null, "Description for WorkItem 205", 0, 0, "WorkItem 205" },
                    { new Guid("f687e5cb-2663-4bfb-a8b3-4b9f8e3147ab"), new Guid("0f5e4c81-1dee-4681-9e74-62f77ae22cb4"), 1, new DateTime(2023, 8, 25, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(7713), null, "Description for WorkItem 214", 0, 0, "WorkItem 214" },
                    { new Guid("f6b99950-398e-42ee-b26f-28a31ee1b783"), new Guid("13a41e4c-47b5-4393-8b01-110462a3d083"), 1, new DateTime(2023, 12, 15, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(5030), null, "Description for WorkItem 102", 2, 2, "WorkItem 102" },
                    { new Guid("f79b5aeb-91bb-4dfb-8e89-693547096097"), new Guid("85ce4a6a-a305-426a-9e29-f817f44c98a8"), 2, new DateTime(2023, 9, 1, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(7585), null, "Description for WorkItem 207", 2, 2, "WorkItem 207" },
                    { new Guid("f7d64512-0c8d-4927-a902-0bb2b6c709b3"), new Guid("94c5d955-ff84-44ba-8297-4212f5a2eb57"), 1, new DateTime(2024, 2, 25, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(3995), null, "Description for WorkItem 30", 2, 2, "WorkItem 30" },
                    { new Guid("f80145cd-5bf8-46ad-b941-515411751670"), new Guid("66fa74a2-72e3-4847-ad07-51c4f5daeb40"), 2, new DateTime(2023, 7, 15, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(8486), null, "Description for WorkItem 255", 2, 2, "WorkItem 255" },
                    { new Guid("f82596ef-f8a6-4ed4-b0d7-eaa56473f0d2"), new Guid("72e10416-635b-4d83-a77b-d572193637da"), 1, new DateTime(2023, 7, 16, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(8476), null, "Description for WorkItem 254", 1, 1, "WorkItem 254" },
                    { new Guid("f8329a9a-a3e9-44e4-976e-67a710483734"), new Guid("341f9b78-ce17-42e9-9091-dbefeba89d3b"), 3, new DateTime(2023, 3, 4, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(245), null, "Description for WorkItem 388", 0, 0, "WorkItem 388" },
                    { new Guid("f8687235-753f-4a04-a6d2-d006ee43588f"), new Guid("5cea12db-210f-424f-9310-a9594619b930"), 2, new DateTime(2023, 11, 8, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(5572), null, "Description for WorkItem 139", 0, 0, "WorkItem 139" },
                    { new Guid("f8d98cf4-de8a-472e-85ef-51a62f01ab97"), new Guid("22dbcf5e-49f3-451d-8f68-a70d36d5eafc"), 3, new DateTime(2023, 4, 25, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(9539), null, "Description for WorkItem 336", 2, 2, "WorkItem 336" },
                    { new Guid("fa315f12-bcd6-458e-ae9b-e0463e45288a"), new Guid("4f7996f8-66bb-49c9-875e-2cddf0c6dd31"), 3, new DateTime(2023, 9, 8, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(7453), null, "Description for WorkItem 200", 1, 1, "WorkItem 200" },
                    { new Guid("fa81ae1e-071f-4b4c-9c17-3604048f2aa7"), new Guid("66fa74a2-72e3-4847-ad07-51c4f5daeb40"), 2, new DateTime(2023, 2, 25, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(353), null, "Description for WorkItem 395", 1, 1, "WorkItem 395" },
                    { new Guid("fac1b107-eaa6-4a47-9292-66b5f7874958"), new Guid("eeb7f210-bf39-4d83-83f2-ffa564208f5a"), 2, new DateTime(2024, 1, 15, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(4628), null, "Description for WorkItem 71", 1, 1, "WorkItem 71" },
                    { new Guid("fbcbac2c-8370-4e92-8b40-f54ff323a8c6"), new Guid("57c29b52-3614-4f45-80da-9f9f0c0be1cc"), 3, new DateTime(2023, 7, 10, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(8613), null, "Description for WorkItem 260", 1, 1, "WorkItem 260" },
                    { new Guid("fee813ca-f06b-4dc7-a563-775d3c4b01a9"), new Guid("22dbcf5e-49f3-451d-8f68-a70d36d5eafc"), 1, new DateTime(2023, 11, 21, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(5368), null, "Description for WorkItem 126", 2, 2, "WorkItem 126" },
                    { new Guid("ff79193a-f0b9-4967-9638-717946a66f36"), new Guid("63f070ef-1274-4658-b44a-96cc2c6ea907"), 1, new DateTime(2023, 12, 27, 19, 20, 16, 165, DateTimeKind.Local).AddTicks(4893), null, "Description for WorkItem 90", 2, 2, "WorkItem 90" },
                    { new Guid("ff9491b7-9bf4-437e-840c-4123c9a4ac13"), new Guid("72e10416-635b-4d83-a77b-d572193637da"), 1, new DateTime(2023, 2, 26, 19, 20, 16, 166, DateTimeKind.Local).AddTicks(343), null, "Description for WorkItem 394", 0, 0, "WorkItem 394" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("01062072-d694-4fb3-a358-c31dc50a5ae5"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("010badc9-56f1-4776-8397-84cd26a534e0"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("0380a602-a367-458e-9ca3-76d6d4c57721"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("0410e3fb-2149-4b61-9f11-733a5064b478"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("056193b5-13d4-4a57-9617-a961586196bc"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("05fa75cc-3a79-4f29-9efb-2a6891a1dea5"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("07722522-2edf-4dc0-8f1a-30aed6d0aa57"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("08bf07e3-2971-4c11-aeaf-0c0f434b99ba"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("095b8eef-8362-4365-bbc5-8e609289325d"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("0b48a14c-0cbe-470d-ab3e-974dd1ca2c42"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("0b7518e2-2b1e-46a0-bd1a-94fc47cfd890"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("0c4c1a7d-8c6d-4f46-91c7-9ba06384fed2"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("0c87c915-db69-4953-b9d8-c05c3a558ebe"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("0cc5d87b-526b-4f80-9faa-cafd69fda329"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("10a10bf6-9665-4eed-8626-2904fb8336f9"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("1339934c-68e4-4907-80ef-1e9b4a4e018a"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("1359ac47-dacc-48ea-922b-862ce7739b99"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("13e8a347-ff2d-454a-b392-9344fc108252"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("1470f41c-ce35-48f2-9f32-6b10e1bc3a8a"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("14e47953-7a3e-4e1c-90f9-30b814cb0e76"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("15939548-079d-4c48-beda-a9975d9ffd30"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("165b4299-56db-46dd-8e84-18e76989cf0c"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("17120b1e-7c18-4efa-8efc-89bc1d6bb31f"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("1a58161e-102c-4aaf-99da-4c55f2387617"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("1b9e374a-1d9d-46d9-8fd8-2eab37cbada4"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("1ddbfe3b-b177-487c-a0bf-b72c4a20e46e"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("1e062402-56e7-4f9f-b011-bb6a69e59de3"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("1f265abc-785a-45af-a96e-dba02191739d"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("1fc35ac2-d093-4539-ad91-199f512c8084"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("20a31543-3ddd-4b9b-bf57-a02bccfc369b"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("20c1103c-da01-4016-87cb-2e3ba2a917c3"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("223e3ab1-b5d5-41af-8908-4bc8d8c13152"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("2251ff76-27a3-4958-a4f5-8076ba5739ab"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("233977bb-1f5e-4b18-9090-2c143b8d779c"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("266638c3-59c0-44f3-b84a-d940fe052215"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("26d95773-a838-4f65-a57a-864725829065"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("270db948-f94a-46fd-a4e3-a3d6da2e4294"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("286401e2-af4f-4454-8338-493d8fe16ca7"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("28692115-99f4-4fa9-88b1-4f0cab5945ad"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("289d243a-c724-4e51-9c6d-b32e8106f57f"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("29420a83-3c12-4511-a2db-94242415bab7"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("2985914b-5fcf-4ba8-8760-8f96dfa39477"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("29968f1c-5520-4793-84ee-0427a38afcfd"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("2a4a51ff-3ee4-4c8e-b6c3-d576c5ca3a06"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("2c175028-f577-4e0d-a229-3adcb8c6fc74"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("2d74b7cc-a6fe-42c9-9efe-77fbd1669c69"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("2fdd6676-1c63-4c1f-a06b-5104167f0f9d"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("3066cdd0-aea9-49f2-b813-7623b44b38dd"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("3160404f-bdec-4bcb-9277-8ee201c4e019"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("3169734c-dcc5-4bee-ad9f-c36853a5f720"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("31744b06-f4cc-4b0c-9ae7-7f2642cf9e8f"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("32ebebb9-ee0e-4bc1-b3e1-c104d15502de"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("33f9c75a-622f-4d03-99bd-2561dcbd341d"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("34640419-493f-4cb2-8128-c15815dabf23"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("34b06616-399f-4697-b50d-9bd108b83b75"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("3656afa1-5654-4352-ae04-26ea75b77ae9"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("377f6878-4aa2-4631-b5d2-9c82b1fb87d8"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("3804d5f1-0761-4a09-8f6e-5e4ef843760e"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("3884de71-b81e-401e-8423-65a4bd41d5c5"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("3c7aa09c-bd9e-436f-b667-5598da924e3a"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("3d1bad6e-413c-4c24-97bc-893c8cf1e844"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("3dd5afe7-e0c2-47f3-b466-9dc1d02a693b"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("3e158613-6587-4ec0-863b-61c04d367417"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("3fdaf745-6e12-4e75-ad08-eee413ae2004"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("41e846ad-7eff-46db-9581-9fea72d7f16c"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("44239f37-2e44-4c40-980c-6384d26c5e22"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("4483f71d-552d-4e5c-aaee-7766e558c8cb"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("459bf62f-5332-4ece-b85d-8854ee75f4ce"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("462e5370-6955-4eb3-ba9d-7f193689e8d2"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("46f89848-7e7b-406d-bda3-a4ab432b4fc8"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("47b9563e-847e-48a2-8f2f-4f2ec3ea982a"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("47fbb3a1-7afd-4693-8d99-ccb24c4171b8"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("49c718d2-c024-45d8-8324-1b4e97477618"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("4b2bcd12-8709-41a6-8f7c-342ba8f2d915"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("4b45c309-a620-4c3f-af8e-db9eab3f151b"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("4ca06e71-6b94-4531-b742-58ed7aeaba7b"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("4d22e85e-7289-43a8-9297-c485313df60e"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("4d45e5d6-0659-4346-9fa1-d49ca9f7793e"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("4dcd23ea-702b-4db0-a1eb-6efd9988741a"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("4e719bb8-865f-4be3-9ae6-b6bb2a9cb837"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("5034c8c5-ebd4-4398-88d2-8b17effb92da"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("50f59443-44e4-4e78-926d-86d890567a04"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("51e2b372-525c-49f8-b7f1-4235113e72a5"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("51f600a5-fa34-45f8-9a8b-3a8e2a37af8c"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("531c786c-05bb-4d9e-aab8-85b78468a5f8"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("57aabde2-c84e-4354-bca2-9839a0fdaef6"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("59a9bb0e-310a-45ba-a411-0bbe6b2c247e"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("5ac7463d-6035-449d-a1bd-17968b6f6578"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("5aca1633-6402-4f70-8b1f-891d13171929"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("5b549dd6-38e8-40a0-a6b1-7c5c875b422c"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("5c6bc45a-92ab-430a-b6e5-f88a411e96cf"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("5d7473cf-f4a9-42a5-bc23-a0b61fa1a8a1"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("5dceea5a-3f31-416d-929c-d1c7ac1e6a5d"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("5e3678ab-b775-4322-a740-7c811b2d4fd9"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("5f979d07-6678-4f86-88f3-630151ac71a7"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("60d73449-1dc5-4c33-9324-472e4cdfd012"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("610f2566-4657-4bfa-8f12-287b1d15ff03"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("615f5bbf-1878-44ad-93cb-2be8db379a5e"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("61a885d0-b82a-4508-8c10-3ea62d38ddf0"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("61ba2ae9-c657-4971-bd12-b3acf6036a7a"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("62a6fb7b-2283-45af-a2e1-eb08c9613cfe"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("66e98559-3fb3-4fa0-a365-d608c6e389cd"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("67b253b6-8171-4609-8922-5e4d908b408c"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("67b79265-2460-4e07-bdaf-334f59954975"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("67b8ae96-bf11-4603-baa1-11779f28f150"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("67ed7636-a5c7-4557-9a59-95f30415b131"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("6961ec45-2073-4b8d-af4c-d2e83bf284b4"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("6965a657-6327-42ad-ad10-55483f72243c"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("69ebbb8d-2bb3-4153-8d1f-ef91f8f3b122"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("6b4c8cdc-4483-4abd-9247-7581c25a9ef5"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("6b6018b9-7537-47dc-aff7-6461128947ad"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("6b96fb16-933a-43ff-9732-336382b75a11"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("6e176bd5-4a5b-45f1-b687-e5c6a909ae7b"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("6e50821f-d312-4e9d-8fac-8e6160f46bd8"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("6e56fbdb-cafa-4190-be96-14a446d23274"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("6f26d38e-e20e-4842-8678-5b5d2be21ae5"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("6f3a392f-f680-47f5-a406-c91843eda101"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("75493af2-d6c0-4f49-9e42-9a31c8e30abb"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("75e73bcb-4f92-4178-a70e-7b445f7c7354"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("7669b9d6-aa75-4974-90b1-ca94dce55675"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("78623f86-840c-4e99-a247-33529c36c32a"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("795b27c5-5678-4122-a12f-8a27d049905e"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("7a26122d-8cc9-4a2d-9b8e-ade4874e2759"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("7af2d76e-e278-4962-affe-e7dc4af1a8d4"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("7c1e713c-bc3f-47fb-ae31-3cfaaf6c1604"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("7d52d70b-3b45-4c0d-8be4-84b863c8204a"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("7e406b1e-94fa-4937-b7cd-dc985b7ef06f"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("7e5a63f2-b6fc-4726-894a-e3986231a257"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("7f86d3a4-9f87-4922-8784-2b2c2bc671e2"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("803dc2a8-e109-4e0d-9036-7b2b678487f8"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("805e4522-22d4-4ba9-9606-237cbcbf3406"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("80fc2108-1d7c-4680-95ce-29e79a96ca72"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("81b6b5d2-c30e-453f-aaf9-e0cc38204566"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("840b538c-c56c-4183-b3fb-08409a50be9a"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("845d90d6-c092-473c-ad6e-63d94eff1c48"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("85251fd7-3ceb-4efe-b114-7c71bb07eb36"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("86db06c7-dcbc-4f89-b534-d4f1745d0f3f"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("86fca3f8-e870-43ea-aad8-d922b050e153"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("8c351a71-8a1c-484d-9e33-a6a62a44752d"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("8c3ede28-552b-4993-abde-28385c660343"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("8df4742a-0e4f-4dc3-aefd-5adc78007b52"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("8ee262c2-68ff-424f-91b9-4b8c6a057ca4"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("8f573d27-b73d-4b9a-91bb-673b7c9e1433"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("9011b20c-a29b-46a9-a3e7-5ac7cd562f60"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("902a98b9-0be3-4617-bf5c-1e5143243ec5"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("91678406-1145-4ca6-9702-5440e71ad128"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("94b16cca-111a-4ac9-ba96-ec872eaec438"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("94ff9add-b609-4c3d-8ee3-efaa15153aa0"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("9525bd78-b7c5-42fd-997e-92107f6cefb2"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("9556361a-39a8-4ced-96e2-72c939a81a51"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("956ba6f2-0104-4542-8117-e48ef6016545"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("96f99ebe-6bc0-4040-9611-7e891e07087c"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("9a555742-79ca-4eed-8f3d-36fae5d395e6"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("9a6664df-652f-45ad-8816-6712880d72c1"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("9aa2c16c-1cab-4156-b4f7-57e9427a47b1"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("9b03af0b-6c86-473f-9cce-625e03672a54"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("9b21707f-4886-45b8-befa-fe54300d4015"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("9b3994d3-69cd-4e9b-b3bf-42afa656e10c"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("9d48c4b0-9d73-48d5-81ff-830653393421"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("9dc434a9-7a19-4184-9dcf-0f0da9d7ded9"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("9e88d5e5-91d8-4473-896e-bcceb2e123a3"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("9ea2faeb-a34d-47f1-bc45-a70aaaa0e58f"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("9f2b47b0-2d35-43dd-a845-698c2e48f48d"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("9f368f4a-ebe0-4141-8ca7-f2faf54f4129"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("9f7f2ade-ab29-4a58-8bf9-b70da2e908ee"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("9fdaecaa-8e68-4b9a-b9d7-27270a14b12d"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("a066a7c2-e868-43fb-a03a-debd6e85783c"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("a0afdaa2-3aef-46dc-9a3a-64f09dffad53"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("a0ff5cea-2464-4ee7-a803-b13822735c00"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("a1027730-d304-4e47-b403-bc27fe789569"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("a18efb45-73d3-4021-87b6-fb8a70cea103"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("a27f4362-26a5-4306-a680-464ff62e417b"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("a37ad342-98ed-4411-92f6-63b779f35ddf"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("a4afa5cc-9f51-498b-8881-9e1b5852b734"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("a53f8fb3-e58b-49de-90b7-af25823e3a19"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("a5c02e0f-70be-433a-8cc2-cbd0b5013a82"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("a5d26f57-ac56-4c32-b67d-112bac90b694"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("a61bb99a-e08b-4136-90cf-4daea6eb7e26"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("a65e02b8-6839-49d7-a0b0-0d929301f3e1"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("a6e11c8d-6123-4ffa-8eee-c19d6da581ec"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("ab24842a-b440-4942-a676-b0777c3da0e0"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("ab4870a9-e948-4d89-ad1e-608a651c9c54"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("ab4f3d51-9842-44ce-9eb5-a9130d9a4252"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("ab83995a-d844-4ec2-a5a9-207a31b4dcbd"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("adba5620-7a35-48ad-a232-35343e6ddc41"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("ae782864-3ef0-4221-ad23-c78f98440ea1"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("aeba0d96-aada-4cd6-92b7-14aed9ed871c"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("b060c73e-3b74-42f7-b8a9-b7981c45d053"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("b1bc83ce-57f4-429c-92c2-1e6b38c93ec2"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("b3f765a4-eeae-4520-ae1e-02e61a58c36c"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("b470f86e-baab-4452-8ee8-c167a94ad50f"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("b5689f62-2b2f-47d8-a228-758036d61014"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("b5993e07-5409-49cb-ab73-1f8385f4cfa6"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("b64edbd1-84f5-4204-91b2-61d53d0ea8e2"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("b83d9e45-42ef-493a-b3a6-5f5e8a9d2dd5"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("b96be621-d5ec-4c10-8bf6-de60de9f5baf"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("ba6fb47f-779a-4c6d-a8c4-cdf3a9031122"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("bb217052-496a-4360-8bd8-95b8bb251814"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("bb2eee7c-e6f0-466d-9a4e-c3b33fa622fa"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("bb8d4e32-8752-44b5-9d81-378301ea41a3"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("bc3941e7-6de0-4bc5-a212-036b1a856eda"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("bcf5d9eb-e164-42f9-bafe-4562e25f9d3a"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("beb3a522-54ee-4c53-80a5-1e4868ca8f2b"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("bf3c2f8d-b9b2-4ff7-9297-ec3e95a5d194"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("c215b42d-c311-4cb3-9ef8-55d14fee20aa"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("c32435d8-fc84-4b04-80b4-b4beea7de94c"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("c33a6f6e-8fff-488c-a53e-2323bdb8d20c"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("c53e32b5-f856-4e4e-8473-39b851a782ce"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("cacb880c-54d0-4bf0-8186-2b82479f71ea"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("cbd9b112-3d23-4009-acc4-f157c6f80e01"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("cce91bca-38f2-4f74-be64-cf5eab50e48c"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("cd1fbfe1-b09e-4496-a9f2-8664a276d716"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("cd27303a-cbb5-4e24-8327-59059e1dc9ee"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("cd51358f-e52d-4b83-bfa3-bc9abc7cdd18"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("d06373a6-9369-4e27-80c7-43fc2091ef13"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("d1b657a9-9924-4d3d-9c46-c99eb6a29f69"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("d3ac7618-d326-411e-946a-9e65bbdf0111"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("d441a565-9c71-4e5e-8707-a32eafa5e4d8"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("d476196b-79dc-4cf9-b5d8-8e0e047c0cb6"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("d4d3f721-b19e-4b8d-b252-a790ab9add77"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("d56732f2-03c2-4369-9755-ba26cb906397"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("d84cd009-917b-4352-8695-935dce692d35"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("d91d6a4c-d8cb-45e0-ab98-858c98f35711"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("da02f503-5622-4467-a079-cee059d59758"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("da8eeb85-e519-47e6-aa59-afe5c13ddc7e"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("dcc66d08-5297-44d1-9efc-799c92ddcda7"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("dce99faa-6821-43a5-b70d-c1947bb97284"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("dd192957-71ba-446c-9fd1-04ff27a0d8f6"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("df569a0b-5ef8-49b4-9538-cadc8b75e73e"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("dfff82f4-535e-4224-92eb-277bb7763b28"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("e2d9c5fb-8814-494f-8dd1-41ad987ab09f"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("e6a29602-1049-49ba-99a8-2015f619fa69"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("e7125198-6e85-40b1-b7d4-385aed51be0f"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("e7d7a943-200d-43ac-9aba-1fd51932ebd2"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("e8104eae-45d0-451f-8a30-326b7b57056b"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("e8196afe-f0ff-49c6-a2bb-00a91844e338"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("e94bb023-76fc-4fd7-9141-0378d94eef01"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("e97eaca4-7e1a-4dfc-9227-c150f4fef315"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("e9c90bf9-b7c0-4a2b-8cd9-898b57978d55"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("ec6e65d3-d0b5-4713-8b8f-3273540a9e38"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("ede6eba2-a58f-4ffc-90cc-023fcc8dfead"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("f082d15d-e079-4f6c-b1a7-8612b774c8dc"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("f129fac4-84d5-4f0c-8cbd-c5eec54c764e"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("f2b2f031-c942-4284-9017-8aee8e2f6f3e"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("f3c0f785-d823-4714-881e-0a785bdab819"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("f59f3cce-dffe-4656-8030-9a8f42b913b8"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("f900b06d-ba99-44ff-b871-23865ab69e0e"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("f919b446-3888-411e-a9b7-47e3f3b880ff"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("f92bc732-2791-4001-9b17-2ee86c4e78a2"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("fc3c5529-89f3-4dee-b28c-81c494851d29"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("00d3f797-487f-444b-9041-1210e0fc15d2"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("00f0209a-d833-4d93-b38f-10abeab4eaa9"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("01627bb0-fb0c-4d48-bd4f-d941f0d32da0"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("01c6fa59-e7b6-4af9-9ad9-3676c83686db"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("02bd5b1f-f8b1-46cd-875d-eaa46a642015"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("02c3ea8a-81f2-4ea7-b9f0-f6376ff3792a"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("032d682f-f96b-47f0-bcb9-ee655f7f4ac5"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("040eeb7f-b9f7-4722-8077-549ac1c18467"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("04861dab-18ec-451a-a197-6a44e39681be"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("05437580-ad4f-4e7c-b74a-7189306b9a7a"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("06cac986-5bb8-44b2-a1cb-0d5d72c13562"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("08afada9-33b6-48d0-9a05-f82ab13f8899"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("094b6527-76e6-4ed1-b4bf-f8b26c05fe03"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("0a317d55-3833-43b7-8d44-fc641133ac4b"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("0b01103a-2e6d-411b-bf5d-f6df0df154e9"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("0b1ef6e1-4b1b-4949-bc86-8550d961bbcd"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("0cc90355-6276-446f-8b00-37d65c6f4b76"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("0d170f0e-ebb5-4d9a-8efc-0f06fd4c83c0"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("0d4e6735-296c-4f82-9f20-c4242556491e"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("0e1b0e89-0728-4354-b57c-875dd37d86ba"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("0e201e31-d861-4467-8248-b706d398ae11"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("0e3558b8-f843-4f11-81c5-1ebbb95b5130"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("0fe7a987-4d22-48bd-85a7-3626a736e5a5"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("10d90368-480c-489e-a763-3e4c67f279b7"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("115be787-b165-40c1-9721-49193cf034a2"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("11805bb5-4b1a-4dbc-8e58-de1a036d64a7"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("129fc241-25f7-4ca5-ac2e-e795ae80f323"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("132bdb3f-03a0-464a-a48d-c09cf533cc39"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("133ea975-fbd2-478c-b01d-d8d5aa45780c"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("14e15b4c-45ec-462f-9b83-33c7f4e11fc9"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("14ebfe36-eae9-4492-b7fa-99b00d29846f"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("15095c69-75d5-4bc6-9676-bec57e4bf109"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("15a4972d-4743-4574-adf4-a14a33dd92d2"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("15e94fab-3705-4d50-aefb-3748aad78030"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("16aa8659-dee7-43b4-8be3-a5632da8d2f0"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("171eb872-4d7c-4b18-8cc5-a83e1b3f1a5f"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("17ce4bb5-ef23-4abe-bf41-131073e4a4c2"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("19272182-d1b4-430e-bfb1-bcc0a31d4914"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("19e3abd5-a7ff-46b6-a60a-ca936633b78c"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("19e6e205-725f-49b7-9cf4-24ae58491659"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("1a9fe94f-4fee-4c56-8330-6029eb751c2d"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("1d2833e9-d0eb-4494-a929-6811b218d5e5"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("1d4e30a7-a328-4b48-bf6e-79c608e4180e"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("1d5ae3c4-b26b-453e-8198-d4eaea235ff1"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("1d61bc19-edae-4bff-92cd-a961a29e3cc8"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("1d66cb0c-e67a-4427-bf41-4360bc2faffc"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("204b3331-b216-4bee-a2b1-d325fdc210a5"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("204ca503-4b2e-4bfe-b252-2d632d0f33d5"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("2137c9be-d886-49d1-b362-fefa50367fed"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("213f96a0-9f88-4c18-a887-db8afbe17815"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("21403384-4288-43b9-bf81-b5ea65c6b765"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("2165b937-6b8f-48d6-993e-3eba72fab8b0"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("2167c7bb-0ca2-410f-871b-7e3117b31f61"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("217e54a3-dd25-44ac-aa50-f82cf03382a2"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("21a39b3d-3e72-4a8f-85e7-6a8a44626e89"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("23d60029-3873-47a9-a8a7-6a27d4f29fd6"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("24552a47-2fa9-45a2-bc42-d5c57d2c1cf4"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("24f05191-575d-40db-bc3e-cba8e6baf5e4"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("254bfb26-28af-4f29-ae38-70d5968f7f2d"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("25941323-bccf-45ed-b637-b8a3831ddd3f"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("2625abf2-c8d2-4783-b550-13662f3fa5a9"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("263e677a-6cd5-4015-ae0c-f1fee6d39f5c"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("26521789-56f0-4ca1-8c58-c86303911eae"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("287bb16c-d01e-4826-a6ad-c8ce4b993af3"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("28e4bae6-0774-4f32-a2a0-b92a5ebe5a40"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("29a6e27e-0564-45a4-aae0-69265dd42e97"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("2af0db2f-e6a0-4b8e-baf2-671414084b80"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("2b6a3ad1-97be-4375-91f3-29526ec324ec"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("2b93fb9a-809a-4e92-b4a6-c2778c9a62f2"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("2c866d29-6e33-41ed-8074-84a1d3f69497"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("2d5c9c5e-cf55-4af3-ad0b-1cf48f3429eb"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("2e8b3ec1-7a96-4724-88fa-5348f7ce7db2"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("2ed24635-9afe-45de-b0ca-7501dfd5e37f"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("2f1dc87d-0f45-4aef-886c-16cd9cd7ce23"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("2f5bcb1c-01f3-43a2-9784-8cb09816951b"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("2f7aa4ff-c108-4010-874e-104c950a4853"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("30c57747-36f3-46c6-8bd3-cff1ceb53e52"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("3160f3fd-f65c-46f1-a0f4-9d43dbc6e495"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("326ed06a-3197-43c4-a473-5827c4bf53ee"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("33c1491c-222f-4b6a-891c-9d57bbf20346"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("3642051c-0d5b-4641-ad7d-46ef698095af"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("36ae04b3-e53c-483c-b423-6cda7d2606ec"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("374a4363-96f7-40fd-a5c1-9a1ce1cd28c6"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("3797dcb5-63db-4a46-85b7-7ac47219aa55"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("382f52b7-f232-4bfd-bd79-cc3fceebebc8"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("39d53cd8-804f-4683-b319-c455ef22612d"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("39da3c83-28b4-4c0f-bd7e-bd4463930dea"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("3b352eb3-c97c-4cfb-b93e-74b1cce58e8a"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("3b59189f-d9ca-42f5-a5d0-ab39d9c48b60"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("3ee07753-3aa1-429d-9b39-5a4b4bba4af4"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("4046e81f-bf84-4772-8680-605462c0497e"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("40c51924-eda0-4a58-abb8-02e69bc771c5"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("41820602-cb92-479c-98fd-0060d63056bc"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("420faffe-2a18-442d-9911-21a55feb8b59"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("42660fb0-9834-4d5c-adfd-5a587eaf0a94"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("455a406b-89e6-4a4e-a85b-f393a0b79ad1"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("466ff3f8-c4b8-4b18-b1dd-d8cb357c10de"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("46aee1ad-47a1-4d59-84f3-7a92a4589145"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("46c61365-68a5-47ac-bb07-6443dc7ddbcf"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("4854e116-409e-41e6-9b45-3f1e900a9fa1"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("48e4b65e-2b6b-4fbd-869d-cd67ead33f6c"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("4922b816-5b46-4ff9-adbe-5ed43f138359"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("4a21f3d7-cc98-432c-881c-a4508bf1922f"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("4a5b7674-cf9c-4473-9f34-fcde4201481a"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("4a68c7bd-516a-4f26-908e-62c399ca0ed8"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("4a6fdd45-baab-4918-b765-97b05238a81c"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("4a90d714-eaa5-4b95-9ff7-68828c86f898"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("4aa65f1e-9a3d-46c7-bedd-509d1d888e13"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("4bc54566-e939-4a6c-90dc-8be5dc3f06b2"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("4bda9a05-fb58-4654-9315-fa82c3689266"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("4bef2c3f-dbf1-4c26-8aae-a4b34f06ca98"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("4c05ae83-d59f-4d2b-adcb-ac29929f0076"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("4d104940-69f4-41d1-8bfb-2f66fc926020"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("4db2b496-17ed-4c81-a667-0703caeb7fed"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("4e5e4090-978a-41a0-b23b-0899a9ae5e92"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("4eb1eb57-96f0-4ca5-84b9-03e928d4182f"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("50379e54-5ee9-4deb-a3a5-aa22e8e9e6f7"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("50414d51-1129-433c-84c9-279f62c118f8"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("52130062-30fa-4023-8ad9-e9a489cdba99"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("52f87938-dcaa-44d2-87dd-e4c7bd7db26d"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("5324f419-fe74-4310-a631-2b4b93f18703"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("53c44ed0-d2ab-4c98-8c38-fb07e4efa3ca"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("53f67828-1a9a-435b-9e24-b47e35e28c2e"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("551af909-e819-422d-a005-82c326a958e6"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("557fc48e-268c-44cf-8cdc-95a7839b4b0f"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("55e7c182-7375-46fb-b650-e7736cac8e30"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("56ae5d50-378e-4e7d-ad56-525c5efcce01"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("58439e70-4734-47c4-bd22-d16c50a6dcb7"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("59180aa1-962d-49bb-9267-a5b99eabb1b7"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("59704b60-c3ce-4dd4-9daf-3745f44f6476"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("59952d9b-a229-4397-a682-e0280235e82b"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("59c83525-bafd-4f4c-b4cc-15c51ff67d3e"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("5b71aa24-5e0b-4e53-ad47-0c4ac0421317"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("5b8a06bc-37e3-498d-8477-49cb310ead6b"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("5bf3b911-b93b-43b5-ba46-925a5879f0ed"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("5c812b11-620a-47b5-8165-9b5aa08c33f0"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("5d954b78-a64c-437f-ba06-a7f64001ac9d"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("5dd23f86-8139-4a27-82c1-98f9c937d1a5"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("5e670749-39bd-4da8-9f94-f3aa1138b63e"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("5ed8a57a-35ab-4ff6-bdfe-313693a9be17"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("602f6241-3aad-4d05-b9f9-ec3af081bd24"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("60f3861b-6a52-412d-ac30-83bd8c9d73ed"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("6101a963-a902-4dc7-b176-7df3c29a2477"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("6353a98b-53b6-45c2-94af-161ecb46e934"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("638a76a5-5ae9-4d94-a343-2202e12518b7"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("646c3a34-f90e-4b57-9116-e8568df2fc3a"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("64848d6b-4656-4cbf-abb0-142d8e661b43"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("650b70ac-1b47-4ac5-815e-4f9fc896323a"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("65284b4d-0d14-4d8c-ba38-d1107b40a49e"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("655a8248-8ad0-4c5f-b228-270bec5320e8"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("65883828-b6c7-43bd-a007-045b33d17064"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("66056107-a6d3-4fee-815a-169ce35bc4fe"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("668a11b1-9b68-41e3-a0ab-cab59f505058"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("66b49ea4-3977-4a23-95c9-dca22eda9c6b"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("66ca19b0-ad2d-4868-ae37-bcade4eae1ca"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("66d5aa1d-c7b4-4f1e-b515-71a92d1df6ec"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("682f77cb-a1a4-4e2c-acb7-416101c063c9"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("684a5dc4-6672-4eef-9477-2013e052245d"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("69dfc5cb-9c17-44ba-8606-f87a3951531a"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("6a02e38b-f9c3-4ad1-8f73-dc0d3a3972c0"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("6abf8547-eb19-4fb9-950d-e5e94e6cb550"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("6b6afd06-00c8-475f-b14d-e1cd4b9f81d6"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("6bcba68e-e7a3-4114-8051-22e0c271621d"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("6d962367-51b6-45bf-ba21-30e8a5cf8692"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("6ea15a66-9396-442e-b35d-37aa3de94681"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("6ecf9489-6c4b-4868-a9ed-06fcd0ca48dc"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("70f540f9-f8b3-49e6-b898-53758f1492ae"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("7183fbd6-810f-4013-90d7-5da10e0d153a"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("71e36063-955e-41cf-8e22-a238060cbd28"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("7252ee64-357c-4366-90eb-087a8ccf9c15"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("73c8e4ea-287f-4613-a961-c9ed76811f49"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("73f16975-879f-491f-9546-5522ba6902b5"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("742aef1e-cb7d-421d-a1c1-68cc16416b96"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("74ecfb7c-9bdb-4456-baed-1fb0be8ddd24"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("76a15127-af37-414c-a6e4-907603bd7013"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("789b46f5-c57a-4eb5-8311-fbe031b29386"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("78e75ebf-f5c1-492c-9c4a-b7a3602c901d"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("793e8528-b09b-4528-a302-33d7b703693b"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("79cc4674-6717-4a7a-a1d6-f50c5e8eb337"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("79fa34da-acc0-4791-9df3-f0a140dc3ed4"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("7b6a5668-a693-4645-9142-81752b652e19"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("7bd74f48-1c56-43ba-90dd-cc84f07df2f0"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("7c8f8971-3c1e-41a9-adb8-ccb3d87b2b5f"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("7cc4dd2a-4f0a-43fd-b398-07bce336a280"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("7e975ab2-1425-4178-a6ab-16ee86a7c028"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("7f970e77-5721-48cd-8efd-8db7c34ac5a6"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("83ae1e83-a411-41d3-96e5-a8fc69553f80"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("845306a2-2574-4dcf-8285-f6bc4a30637c"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("8508786c-9ddf-4d79-a518-b8507c13579a"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("850a4cc2-d357-438a-b7ee-00a96cec32d3"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("8527fe28-abfa-4fe0-b421-75afbeb649eb"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("87da8335-7282-4d2a-ac4f-1e42da6e4275"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("882b6dfe-239e-4471-8e49-096c3bb5702d"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("8a3345f7-c6d7-45e3-925b-01272257fd48"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("8a9ce083-fa41-4ac0-a09f-a5fbc16bf4c6"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("8ac8e5a4-9917-403d-8ac3-bc0b0f4e97f7"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("8ae445df-d051-49db-aaa2-5bcd9df85993"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("8bce3f75-1ca8-4c90-a9ee-49c72004a652"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("8cfa717f-ecf7-478b-b52b-bf91e755eb00"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("8f33148c-015c-4c03-ac45-81e6a417c062"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("8fbbf1fb-c7c4-4ba1-8479-5df55672c66c"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("9073288c-2369-4377-8ef4-7e94f92e92e5"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("90adae65-cb66-4e3b-8b98-c8a12d0e792d"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("914b5c7f-ce1c-4894-8489-5f2fa0eccb78"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("9172fef5-6c38-41e2-966a-3a08e3fc12c5"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("91eb4162-466c-44b7-89c0-6591ec6dfb57"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("91eed712-a8ef-4686-8e95-e2ab4a6c7224"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("922bef24-dca5-4871-a559-533573455624"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("92349d1d-ce43-40cd-b041-145097bbf7ab"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("9249d3b2-c77f-4b2a-993c-c8bef607f1ed"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("940b7d46-cef2-408c-9121-a0d53f6e1d0a"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("94a2d742-2d6c-4811-8ef6-83117cb60cb4"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("94a833b3-144c-40b0-8d30-172b0fe4a95d"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("95674928-b6f5-4d51-9522-8ee931a6dce1"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("9622d40a-1c5d-4ab2-b94a-c835e64077e6"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("9657bf12-bed1-4d16-88b5-5433786bd2f9"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("97420779-7e8f-445a-9f58-edb0b2a80f6b"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("97c1fd8d-1579-4355-af44-4768527b31d5"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("9867c48b-3342-425d-9e2e-a9a88e5c9f18"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("9a1d31fd-3df7-4778-88c6-6236d78ddb00"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("9a394445-7ad2-4e51-a628-a95b9d183d46"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("9a6c24cb-f458-48eb-b6df-7605bb3cee72"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("9c18ef0d-8170-493e-9cb4-504d833eb0bc"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("9c8752e0-4b1c-4682-aefd-a4a0a865e3c7"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("9c9fe38b-b7e9-463b-b2fd-ab49294ee33a"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("9ca3baa5-d96d-43f8-a037-005352d3f122"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("9ca61495-f31a-412c-a6b9-fdde731dc0ef"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("9caff0e2-3755-4048-947b-7de89bdfd2ab"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("9d7b4b84-5cb3-4309-9dea-c394bc06331a"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("9e6650b0-3485-4d47-9f25-45c102915959"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("9e6e3747-d72d-4151-817f-33bd99839fc9"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("9f7ec937-484d-4411-9a07-a55ecaac755d"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("a02e73f1-aed8-4934-a479-809fb8e7ec99"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("a033d165-c1ed-47a3-9530-1df4c935a9c0"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("a04f2a70-49bb-4524-ab6b-d54f6def781e"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("a0b34505-c808-4b06-aa44-d72e6fbbf0dc"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("a10053c6-bf13-4f1f-b791-a1a674e58c62"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("a1414c30-2437-4c82-9be3-05ba4ee61ada"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("a3052a2b-3db1-480e-837d-cdce23fc0769"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("a35376b9-9c71-4077-9a7a-07bddde7e74f"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("a3698c1a-3236-4a17-9cf6-64c3aa9fab66"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("a3ab439e-56de-43f2-bd8a-9e76e7f28918"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("a3da7d7c-57df-404a-a999-0504ac4f193e"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("a3e640b0-2dd6-4d0e-baf8-e4ae5542cdaf"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("a42ac51a-d930-4e3b-bb6c-50708b5b0353"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("a446917e-16d5-4912-87bc-6d9dde99e5ec"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("a4ad23d5-5776-445b-964b-2849bcd464bf"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("a5197a21-b5e4-4d46-b2ea-9f9991dd83c2"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("a62556b5-550f-4e5d-8087-c11bae13c3d0"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("a81c123b-3562-4402-a261-45de173f253d"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("a99efa15-307a-435d-bc42-2a41667a21bc"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("a9f1f957-9c4b-428d-93b1-a2a1a47433f3"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("aa8be53e-71eb-42b2-bc24-034ca01465c4"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("ab5c2881-abc1-450e-a16e-d44a3bd74763"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("abb37c71-935b-48a5-815d-9807ae79ff71"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("abbd7e7e-06f8-419b-aff8-1e8bd3ede37f"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("ac26ad18-9742-47ef-a28c-62dfa0321e2b"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("ac5ee180-d2ec-471d-8fcd-4c09c8d9131f"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("aca7a37e-176f-4e49-b3e6-7199ef3d5bd4"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("accef828-7b62-4913-8d8a-ae1ada8f01a2"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("ad4ee2ca-1f91-4c77-92b3-7a67f535f4ec"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("ad5f2487-3a2a-4a00-b0f1-dbde55a5f89b"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("ad6b3bd6-df9f-45e9-a6b1-1290ba4362aa"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("adda4e80-a2a1-469e-bf78-7b966294269c"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("ae5551bf-270d-4a5a-8edb-2038958f7fe5"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("ae55904a-3e05-48cd-8a21-35a1956aa358"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("ae7bf25b-3d3b-4c87-83f7-0c4d91fa7f92"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("ae99705b-8c9f-48bc-a0ab-50e6b1a3d27a"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("aefa3132-b00b-4ab1-a8b1-639301fd72eb"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("af586967-6f87-41eb-99f1-8302ca408c15"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("af6e858e-1b8f-47e4-a485-7627dc129156"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("afb6c161-6ae6-4f58-ba65-b079e82199e5"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("b06af581-89a7-44d2-80c9-79ed701b4b2c"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("b1aa64ac-4e52-4db6-a80e-173e555d1043"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("b2a18310-ade4-4b1d-945c-155da64014b7"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("b4884118-cddc-44b3-beda-cdefa2e4fd4b"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("b4db8499-4648-4b2e-bfa4-b8a81fe0e781"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("b60e54ab-69c4-477c-b65c-cd928c80e550"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("b6f57b25-1578-4ded-96ce-14387e29e74c"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("b6fe8e48-a00e-47da-9e90-46071c658fcb"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("b79e25af-177c-46fa-a2ca-666d87f77063"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("b7f05c45-c207-4d59-be45-3e64c6dd5c38"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("b80d131c-2b50-4a94-a2c7-c53f646b72c2"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("b906af38-faec-48da-bfdf-de0e7a1b7088"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("b97b9f4f-e88d-4c54-80f8-57bd9d3374ac"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("b9ad8d0e-98bd-469c-91a2-87841736cc78"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("ba610105-8359-4b58-b5ce-2340c136ec86"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("baa00186-12ad-4038-8927-b54f91aef241"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("baa8833f-979b-45a0-a42e-2dc5f3e2dfaa"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("bb1af4d3-f999-4919-81c6-49a2572dae83"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("bc7ac292-bc8e-43c1-a6f2-c896a508123f"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("bca42a2a-134a-43aa-b962-a4c6a0e0ab72"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("bcdbdd2f-f47e-448f-834e-ef753e12b5e8"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("bf7df3cd-b41b-41e8-bb35-e4e8ab21d0f3"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("bfbac8ca-e368-4e9e-ad5c-a9fadaaae0e7"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("bfbf2716-a985-4a78-a1de-55236d144294"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("bff03978-f350-4da2-aa64-15df86088d26"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("c154e8ba-fba8-451d-9afc-ced65082d698"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("c179dc77-fa1f-46c2-bd06-0a41ac097931"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("c391d426-6ba0-4c76-862b-358c71888568"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("c39e3687-ed70-408e-8ef8-7a8af4a7dbe3"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("c4013598-736b-47fa-8524-f7fb6696f166"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("c413a9b6-4264-4b6d-9da1-5b6fbce109d2"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("c46679ce-0fd2-47cd-be48-be9cd70cc46b"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("c52fa45c-e347-487a-8486-f94419dce773"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("c536badb-13aa-4b92-87fa-74d6556ba9dc"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("c54d9583-282b-402b-9e03-f69466fa12f0"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("c65dbaf0-1a44-47ae-8207-37753da5c480"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("c756c285-c66e-4423-8615-8e31d960ebf5"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("c779c77e-cb27-479d-88b1-2b7e79ddb0cf"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("c89ea72a-33bb-4dcb-9767-dcf5170e00fd"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("c8a77899-7f04-4562-869a-d1b84415dbd1"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("ca0a6144-9642-46a2-a866-7bb678042117"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("ca5db0d9-d7f5-4ec3-860e-54d2a785a0b0"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("ca871290-001e-45a8-9560-ed66147c6b0e"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("cb753fe5-d0f3-4860-93ed-c91bfb284651"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("cbb7e254-fc5c-4cb4-9227-2c221aa0e992"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("cc0aef5a-c969-426a-8bdf-bfa66e04f3cf"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("cc3cddfe-cdc0-488e-9493-8cbda8710928"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("cc5b5ce3-03fd-4187-b34b-b830ec91bbf6"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("cdb06d01-d837-4e3e-a2b4-5d14b990865b"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("d15f9601-6e72-4579-a5a7-388c5269b69b"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("d1d87064-de17-4762-9e14-35d7724956a2"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("d20bc345-8ffe-43b7-95b9-cea2eba0d15b"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("d2e8efaa-cc7f-49e0-a642-6726bcf5a352"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("d3ace035-4c2e-46c3-b6be-2f1e540d69b8"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("d3e54fee-2ba4-4dc1-88ee-c2524a4ffc28"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("d4c27902-f639-4b93-8ec6-43e94c263a7a"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("d4c4f3d8-1f65-4a27-9ce8-9885c748ab88"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("d4de2b67-7adb-43ca-bf59-ace6f5f485e4"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("d661553c-d142-4228-8955-87cac8a52060"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("d6a82c10-5961-4e14-9aeb-8eb0ee87cc98"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("d6e12ec8-0256-41d6-88a9-bd532b9aae6b"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("d7cc6a13-0c06-49d7-8e4b-5aa230b6a930"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("d8a58d0f-812e-452a-91c6-8a4edc7a1385"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("da9cfb72-9bda-47f7-8230-ccb2f70a0727"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("db259174-b020-42c0-9c2e-2f9468c4a17d"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("dc566a03-5900-4fcb-a13e-a6312127cb69"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("dc91976a-9e89-49c5-b29e-c432a243d704"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("dd26b3c5-ad02-4fa8-9827-ed88b1f9df89"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("ddbdfd73-5c26-4812-9912-1d96e4e36618"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("ddca61a4-3ca0-42a9-b5ce-cd2e5f7ab7e6"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("de09ab64-5c5d-4405-ae2f-7f730b883665"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("de2c9f9f-48a8-4038-a88a-144af34681b2"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("de57876e-3447-4c50-9134-1c1dde517995"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("df277c5e-cb5b-476f-842a-009bec0a119b"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("e0ab3824-fd63-4479-ab0b-5681aba8f452"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("e14e962a-85a6-4b5e-9db6-a0926fc79e00"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("e1527cf6-34d5-47cb-bf4b-87e1ca884e7d"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("e28e0f29-1e2c-4d39-b71c-2d1c4ce2be56"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("e32fc053-4d34-4296-914b-36d44fa596be"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("e38415e4-cfde-4011-aa8f-5381974a83cf"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("e47b219a-4588-4057-85c7-4ba19dc3ce5a"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("e4c329f3-5175-4099-a34d-4a1d2871ed33"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("e57123ac-a2b3-44d5-8385-1e5069cc7f50"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("e58b6976-e98c-4956-ab78-c4e4cf08946a"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("e5904584-d1c7-41cc-af38-8e1e845256fe"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("e5a1c1b3-3478-4d81-9d2e-10e3e528ef29"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("e6071508-d20a-490f-acc4-a14269a21716"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("e650090a-2dae-4edc-8cdf-cfe256121294"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("e6b9b1b6-1855-4a83-848e-d14e550b1f93"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("e748a373-c1b5-4d21-8e6b-7049aa8eb259"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("e77ba4f3-d08f-40d0-bf98-fcf84d561ff3"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("e7ebe01d-fb37-49b7-b098-b584d475246e"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("e81b1c37-3510-4eb5-bfc7-3ad7cd1c28b7"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("e8845a1d-e3f5-4e7f-a675-7c5709ed8e81"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("e92930ee-33e7-49d0-adb5-f93bd795b734"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("e9552333-8539-4c48-bb77-4905939221b1"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("ea57a2fc-c56d-47f2-bd9d-3f65c43e8232"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("ea73e260-8962-4639-b24b-57667508af89"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("ec553e94-4b48-42ae-a6ed-3a7c004b0aab"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("ed8746f3-4aa0-4281-b9fa-ea5de5bfa6ee"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("edb69ed8-16f1-4444-baf6-2c8a4411bb1b"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("eeca9296-e09a-48ba-a443-a1569eedac6d"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("eeeb47bc-ad22-40aa-9f3b-9f74de028c98"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("ef2b23cb-4308-4983-90a8-562b2799cdb4"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("f11cf894-910e-4ca6-a7f8-a9059acc1383"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("f27b948f-7f66-4a37-9060-1be89d67600b"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("f3f11176-31eb-4b80-9393-7782e90b0cfc"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("f4bb9caa-df9c-45db-ad0b-63b8e743f8bf"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("f4c0a4af-1470-4aed-877b-1478509f74cf"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("f5867e26-56be-4caf-a97d-7ff0eb2543e2"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("f5ef70b4-1153-4aa1-bb27-c92a9f5c00c1"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("f61069fc-7849-4516-9567-d2de1d4ecac5"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("f687e5cb-2663-4bfb-a8b3-4b9f8e3147ab"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("f6b99950-398e-42ee-b26f-28a31ee1b783"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("f79b5aeb-91bb-4dfb-8e89-693547096097"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("f7d64512-0c8d-4927-a902-0bb2b6c709b3"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("f80145cd-5bf8-46ad-b941-515411751670"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("f82596ef-f8a6-4ed4-b0d7-eaa56473f0d2"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("f8329a9a-a3e9-44e4-976e-67a710483734"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("f8687235-753f-4a04-a6d2-d006ee43588f"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("f8d98cf4-de8a-472e-85ef-51a62f01ab97"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("fa315f12-bcd6-458e-ae9b-e0463e45288a"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("fa81ae1e-071f-4b4c-9c17-3604048f2aa7"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("fac1b107-eaa6-4a47-9292-66b5f7874958"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("fbcbac2c-8370-4e92-8b40-f54ff323a8c6"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("fee813ca-f06b-4dc7-a563-775d3c4b01a9"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("ff79193a-f0b9-4967-9638-717946a66f36"));

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "WorkItemId",
                keyValue: new Guid("ff9491b7-9bf4-437e-840c-4123c9a4ac13"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("0026da90-a1a9-41fa-933e-576ad76ffbf7"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("01610c7a-9e93-41c4-88bf-65ff2ed11f50"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("054b5698-5d00-4f55-9132-ce0f5ea666bd"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("0ddf2d45-9f40-4fcd-80a2-5286ec667ad1"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("0f50b1be-1daa-4064-9e83-c4ded856a098"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("0f5e4c81-1dee-4681-9e74-62f77ae22cb4"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("1106ab56-1576-4138-8521-a0ca8d9492e2"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("110f2ffa-2825-4b68-b584-707b9c7cc472"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("13a41e4c-47b5-4393-8b01-110462a3d083"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("1ef348d3-6cef-40c0-8d21-e1b3ac8ba85d"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("1f43dce8-8941-4536-bcae-59b78ad071f8"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("210513be-95f9-46ce-a1e8-3b5ea08231c7"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("22dbcf5e-49f3-451d-8f68-a70d36d5eafc"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("341f9b78-ce17-42e9-9091-dbefeba89d3b"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("414b5098-3cf1-42e8-a3b0-c8648922eb21"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("4610a824-5bae-4dce-ad57-22e6d63ecd30"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("4cafe1b0-6478-4509-9433-80cc2a331b22"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("4f7996f8-66bb-49c9-875e-2cddf0c6dd31"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("53b1cab2-6315-4281-800d-1338b8df64d8"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("57c29b52-3614-4f45-80da-9f9f0c0be1cc"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("5a9cd035-c05b-484a-b4da-ee400ac432b2"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("5cea12db-210f-424f-9310-a9594619b930"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("5da46ea0-bac0-4152-b19d-5aec098d62ae"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("63f070ef-1274-4658-b44a-96cc2c6ea907"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("64b45b41-2ae7-4798-93cd-b226d2340502"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("66fa74a2-72e3-4847-ad07-51c4f5daeb40"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("696346f6-5cf4-4bcf-997b-f7541af90e31"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("6b414c7d-3fed-4932-a291-c7af0a50d852"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("72e10416-635b-4d83-a77b-d572193637da"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("76b28a73-a636-49f8-8b00-e9beb754a1d0"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("7e0d6368-b609-43da-ad5f-1be2ebaa2301"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("7e6932ef-fe3a-4e22-bf03-be4c9fb40b68"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("7ec48e58-03e0-42ef-b69d-3ca5d36a540d"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("8503793e-1bda-496e-a1da-3cf84041704b"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("85ce4a6a-a305-426a-9e29-f817f44c98a8"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("86af32ca-f862-4f98-a7c2-e7ba19619301"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("880f1059-f46d-4d66-baea-a8a75b787d24"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("89155141-a366-44db-b0a4-4376ec44dcfe"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("94c5d955-ff84-44ba-8297-4212f5a2eb57"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("96013f50-c6e1-4e8d-a6e4-d8ac93bdbdb8"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("98781be4-7ee0-4934-b14f-51bfad3972e6"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("9c4027f3-ed3b-49ca-8dd3-4332a7c29541"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("9f00fd1f-21b1-47d1-ba85-c6f855d7fd17"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("a1952de2-fdf7-469f-bae6-092993cb4c01"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("a6e966cd-eb16-403e-93ce-0a7f7e318a6b"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("a8ad6597-7b4a-46d9-a2ff-647b86e7da1c"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("aabac3ed-cd23-437e-9977-9f263cea7b12"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("b05c44eb-7568-4523-be49-08105fbb1106"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("b574cdb9-8ceb-4fd4-8e8f-2c1512aa907f"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("be37261d-62bb-4d93-8982-4411941de97b"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("c049086d-9699-4ee0-ab6b-f1a4802b03ee"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("c3bc7db1-01e3-45b3-a534-5411c807285e"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("c4d38b52-d1a2-4a0e-8de5-85eb2fcd6604"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("c7f7d3d3-2f4d-4e85-9e35-74e23e44d5f9"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("ccbe957a-8557-47e4-9c99-ddccae845545"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("ccebfce7-bf7e-4f44-a049-f78059d28a18"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("d09ff1a6-375a-4c6b-b790-bb322b576874"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("d7657a73-2859-4353-95a2-c720d5341882"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("da962695-902b-40ef-a0ca-2ea3599659e8"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("dcc3349d-654c-4415-8815-cedcbc349126"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("e6a5501a-de17-4657-a9d3-9aa5b74f862c"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("e7658228-f102-46ce-ad6d-eb770c11ddee"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("e954c356-7846-4438-95ad-efce405cbe87"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("ec4337d3-7aa8-4396-831e-4eb510aa5bb1"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("eeb7f210-bf39-4d83-83f2-ffa564208f5a"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("eff36b81-3f39-4232-9410-85391584d000"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("f0b38660-d5db-4f9d-9729-94358cb7bdb5"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("f7358570-ea64-4912-81b3-d3ef3a255b2e"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("f79631e3-8401-451f-b49a-94a6b358807b"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: new Guid("f8b91952-2bf0-4a59-9cd9-5e1f784eb79e"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: new Guid("1ac4c6a1-8e9d-4a3d-ac88-bab0f5a6a24b"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: new Guid("2f1abaf1-c572-4a35-8c6a-174a37e73b66"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: new Guid("7b6ac48d-3a5b-4627-8492-e027489d8147"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: new Guid("6446f0c3-48cb-4574-850f-1bb231b493dd"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: new Guid("e3ae9810-d5d6-4623-9fc7-0b1e96ca5f10"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: new Guid("e8b19c5b-1acd-42f1-a90a-d3092c22054b"));

            migrationBuilder.AlterColumn<Guid>(
                name: "AssignedUserID",
                table: "Tickets",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentId", "DepartmentName" },
                values: new object[,]
                {
                    { new Guid("3d526281-eadc-4787-b905-b124b02448c9"), 1 },
                    { new Guid("488bc0e5-f891-4ceb-b029-5d6744d830c3"), 2 },
                    { new Guid("fcf5a7fd-caea-4fbc-b605-77441b9eca6f"), 0 }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "LocationID", "LocationName" },
                values: new object[,]
                {
                    { new Guid("19c8195d-37c1-4d89-9d39-07bf5842e69d"), 0 },
                    { new Guid("b582da51-20dd-4fde-aed6-d2f5b1c5b7ab"), 1 },
                    { new Guid("f7b8f18b-b6f4-48eb-93aa-afc0e38c435e"), 2 }
                });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "AssetId", "AssetName", "AssignedTo", "BarcodeNumber", "Category", "Condition", "CreatedAt", "DeletedAt", "DepartmentId", "Description", "LocationId", "Processor", "PurchaseCost", "PurchaseDate", "Ram", "SerialNumber", "Storage", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0186db38-7113-4142-a1e1-9dee806daeb2"), "Asset 23", "auth0|65b7de875bf9ce48b47eedaa", "100000000022", 1, 2, new DateTime(2024, 1, 12, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(1058), null, new Guid("3d526281-eadc-4787-b905-b124b02448c9"), "Description for Asset 23", new Guid("b582da51-20dd-4fde-aed6-d2f5b1c5b7ab"), "Intel Core i25", 2300m, new DateTime(2024, 1, 12, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(1056), "23 GB", "WWWW00023", "23 TB", null },
                    { new Guid("05f24951-e653-4a66-bf9c-a7fc974790af"), "Asset 28", "auth0|65a4fd318d9d565392c4972a", "100000000027", 6, 2, new DateTime(2024, 1, 7, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(1232), null, new Guid("fcf5a7fd-caea-4fbc-b605-77441b9eca6f"), "Description for Asset 28", new Guid("19c8195d-37c1-4d89-9d39-07bf5842e69d"), "Intel Core i30", 2800m, new DateTime(2024, 1, 7, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(1231), "28 GB", "BBBB00028", "28 TB", null },
                    { new Guid("071c3cc5-02b0-432f-8f41-ba673225e1c8"), "Asset 54", "auth0|65a4f8d7364ff592a0792a42", "100000000053", 4, 3, new DateTime(2023, 12, 12, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(2296), null, new Guid("488bc0e5-f891-4ceb-b029-5d6744d830c3"), "Description for Asset 54", new Guid("f7b8f18b-b6f4-48eb-93aa-afc0e38c435e"), "Intel Core i56", 5400m, new DateTime(2023, 12, 12, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(2295), "54 GB", "BBBB00054", "54 TB", null },
                    { new Guid("0d968db3-960d-4fda-8ebb-adc1a3a50999"), "Asset 3", "auth0|65b7de875bf9ce48b47eedaa", "100000000002", 2, 2, new DateTime(2024, 2, 1, 15, 13, 12, 222, DateTimeKind.Local).AddTicks(9980), null, new Guid("488bc0e5-f891-4ceb-b029-5d6744d830c3"), "Description for Asset 3", new Guid("f7b8f18b-b6f4-48eb-93aa-afc0e38c435e"), "Intel Core i5", 300m, new DateTime(2024, 2, 1, 15, 13, 12, 222, DateTimeKind.Local).AddTicks(9979), "3 GB", "CCCC00003", "3 TB", null },
                    { new Guid("1ad928bb-4612-4cbd-b795-f4d9e05d0b73"), "Asset 14", "auth0|65a4f8d7364ff592a0792a42", "100000000013", 6, 3, new DateTime(2024, 1, 21, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(556), null, new Guid("3d526281-eadc-4787-b905-b124b02448c9"), "Description for Asset 14", new Guid("b582da51-20dd-4fde-aed6-d2f5b1c5b7ab"), "Intel Core i16", 1400m, new DateTime(2024, 1, 21, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(546), "14 GB", "NNNN00014", "14 TB", null },
                    { new Guid("1df30ac9-724a-4ace-a5bd-cbb579e7ca2c"), "Asset 31", "auth0|65b7de875bf9ce48b47eedaa", "100000000030", 2, 0, new DateTime(2024, 1, 4, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(1406), new DateTime(2024, 1, 4, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(1408), new Guid("fcf5a7fd-caea-4fbc-b605-77441b9eca6f"), "Description for Asset 31", new Guid("19c8195d-37c1-4d89-9d39-07bf5842e69d"), "Intel Core i33", 3100m, new DateTime(2024, 1, 4, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(1405), "31 GB", "EEEE00031", "31 TB", null },
                    { new Guid("2069b475-a494-48bb-8f1e-5077e9fc0c29"), "Asset 19", "auth0|65b7de875bf9ce48b47eedaa", "100000000018", 4, 3, new DateTime(2024, 1, 16, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(816), null, new Guid("fcf5a7fd-caea-4fbc-b605-77441b9eca6f"), "Description for Asset 19", new Guid("19c8195d-37c1-4d89-9d39-07bf5842e69d"), "Intel Core i21", 1900m, new DateTime(2024, 1, 16, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(815), "19 GB", "SSSS00019", "19 TB", null },
                    { new Guid("2448cee6-eacf-4b8c-b35f-47e61b43d7cf"), "Asset 41", "auth0|65b7dee72e02f54da98cd265", "100000000040", 5, 0, new DateTime(2023, 12, 25, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(1813), new DateTime(2023, 12, 25, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(1814), new Guid("3d526281-eadc-4787-b905-b124b02448c9"), "Description for Asset 41", new Guid("b582da51-20dd-4fde-aed6-d2f5b1c5b7ab"), "Intel Core i43", 4100m, new DateTime(2023, 12, 25, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(1811), "41 GB", "OOOO00041", "41 TB", null },
                    { new Guid("2918bf65-e859-411e-85cf-4dee00fe7f73"), "Asset 1", "auth0|65b7dee72e02f54da98cd265", "100000000000", 0, 0, new DateTime(2024, 2, 3, 15, 13, 12, 222, DateTimeKind.Local).AddTicks(9841), new DateTime(2024, 2, 3, 15, 13, 12, 222, DateTimeKind.Local).AddTicks(9845), new Guid("fcf5a7fd-caea-4fbc-b605-77441b9eca6f"), "Description for Asset 1", new Guid("19c8195d-37c1-4d89-9d39-07bf5842e69d"), "Intel Core i3", 100m, new DateTime(2024, 2, 3, 15, 13, 12, 222, DateTimeKind.Local).AddTicks(9813), "1 GB", "AAAA00001", "1 TB", null },
                    { new Guid("2c48c132-38e2-43d7-bf83-2e78dc062be2"), "Asset 67", "auth0|65b7de875bf9ce48b47eedaa", "100000000066", 3, 1, new DateTime(2023, 11, 29, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(2867), null, new Guid("fcf5a7fd-caea-4fbc-b605-77441b9eca6f"), "Description for Asset 67", new Guid("19c8195d-37c1-4d89-9d39-07bf5842e69d"), "Intel Core i69", 6700m, new DateTime(2023, 11, 29, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(2865), "67 GB", "OOOO00067", "67 TB", null },
                    { new Guid("2e7474a0-28d5-4c9e-b838-61db8782cc92"), "Asset 45", "auth0|65b7dee72e02f54da98cd265", "100000000044", 2, 4, new DateTime(2023, 12, 21, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(1946), null, new Guid("488bc0e5-f891-4ceb-b029-5d6744d830c3"), "Description for Asset 45", new Guid("f7b8f18b-b6f4-48eb-93aa-afc0e38c435e"), "Intel Core i47", 4500m, new DateTime(2023, 12, 21, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(1944), "45 GB", "SSSS00045", "45 TB", null },
                    { new Guid("3f747ed7-980b-4e92-acdf-ec1102d4a0af"), "Asset 64", "auth0|65a4fd318d9d565392c4972a", "100000000063", 0, 3, new DateTime(2023, 12, 2, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(2688), null, new Guid("fcf5a7fd-caea-4fbc-b605-77441b9eca6f"), "Description for Asset 64", new Guid("19c8195d-37c1-4d89-9d39-07bf5842e69d"), "Intel Core i66", 6400m, new DateTime(2023, 12, 2, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(2687), "64 GB", "LLLL00064", "64 TB", null },
                    { new Guid("4fb29223-242d-434d-9437-2927203619ea"), "Asset 40", "auth0|65a4fd318d9d565392c4972a", "100000000039", 4, 4, new DateTime(2023, 12, 26, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(1781), null, new Guid("fcf5a7fd-caea-4fbc-b605-77441b9eca6f"), "Description for Asset 40", new Guid("19c8195d-37c1-4d89-9d39-07bf5842e69d"), "Intel Core i42", 4000m, new DateTime(2023, 12, 26, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(1780), "40 GB", "NNNN00040", "40 TB", null },
                    { new Guid("6246fb7d-c2f9-425b-a185-98350aa9da3e"), "Asset 7", "auth0|65b7de875bf9ce48b47eedaa", "100000000006", 6, 1, new DateTime(2024, 1, 28, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(123), null, new Guid("fcf5a7fd-caea-4fbc-b605-77441b9eca6f"), "Description for Asset 7", new Guid("19c8195d-37c1-4d89-9d39-07bf5842e69d"), "Intel Core i9", 700m, new DateTime(2024, 1, 28, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(121), "7 GB", "GGGG00007", "7 TB", null },
                    { new Guid("63092697-3fcc-4e41-9969-c783a15e768f"), "Asset 39", "auth0|65b7de875bf9ce48b47eedaa", "100000000038", 3, 3, new DateTime(2023, 12, 27, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(1748), null, new Guid("488bc0e5-f891-4ceb-b029-5d6744d830c3"), "Description for Asset 39", new Guid("f7b8f18b-b6f4-48eb-93aa-afc0e38c435e"), "Intel Core i41", 3900m, new DateTime(2023, 12, 27, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(1747), "39 GB", "MMMM00039", "39 TB", null },
                    { new Guid("65aa9a7c-d370-42ae-bfd4-c73044970716"), "Asset 46", "auth0|65a4f8d7364ff592a0792a42", "100000000045", 3, 0, new DateTime(2023, 12, 20, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(2041), null, new Guid("fcf5a7fd-caea-4fbc-b605-77441b9eca6f"), "Description for Asset 46", new Guid("19c8195d-37c1-4d89-9d39-07bf5842e69d"), "Intel Core i48", 4600m, new DateTime(2023, 12, 20, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(2040), "46 GB", "TTTT00046", "46 TB", null },
                    { new Guid("6ccb1d85-1dbd-465d-a425-f22ec75c4b85"), "Asset 63", "auth0|65b7de875bf9ce48b47eedaa", "100000000062", 6, 2, new DateTime(2023, 12, 3, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(2657), null, new Guid("488bc0e5-f891-4ceb-b029-5d6744d830c3"), "Description for Asset 63", new Guid("f7b8f18b-b6f4-48eb-93aa-afc0e38c435e"), "Intel Core i65", 6300m, new DateTime(2023, 12, 3, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(2656), "63 GB", "KKKK00063", "63 TB", null },
                    { new Guid("6d8e062e-c71e-4b72-bcc6-a7066bc54f25"), "Asset 18", "auth0|65a4f8d7364ff592a0792a42", "100000000017", 3, 2, new DateTime(2024, 1, 17, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(784), null, new Guid("488bc0e5-f891-4ceb-b029-5d6744d830c3"), "Description for Asset 18", new Guid("f7b8f18b-b6f4-48eb-93aa-afc0e38c435e"), "Intel Core i20", 1800m, new DateTime(2024, 1, 17, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(783), "18 GB", "RRRR00018", "18 TB", null },
                    { new Guid("734b123e-c217-49d1-8478-561ba7973cab"), "Asset 32", "auth0|65a4fd318d9d565392c4972a", "100000000031", 3, 1, new DateTime(2024, 1, 3, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(1438), null, new Guid("3d526281-eadc-4787-b905-b124b02448c9"), "Description for Asset 32", new Guid("b582da51-20dd-4fde-aed6-d2f5b1c5b7ab"), "Intel Core i34", 3200m, new DateTime(2024, 1, 3, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(1437), "32 GB", "FFFF00032", "32 TB", null },
                    { new Guid("798f6fce-fb81-402f-b76e-33049b892820"), "Asset 25", "auth0|65b7dee72e02f54da98cd265", "100000000024", 3, 4, new DateTime(2024, 1, 10, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(1131), null, new Guid("fcf5a7fd-caea-4fbc-b605-77441b9eca6f"), "Description for Asset 25", new Guid("19c8195d-37c1-4d89-9d39-07bf5842e69d"), "Intel Core i27", 2500m, new DateTime(2024, 1, 10, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(1130), "25 GB", "YYYY00025", "25 TB", null },
                    { new Guid("81faf274-2a02-4780-82ef-53dbf6359121"), "Asset 57", "auth0|65b7dee72e02f54da98cd265", "100000000056", 0, 1, new DateTime(2023, 12, 9, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(2388), null, new Guid("488bc0e5-f891-4ceb-b029-5d6744d830c3"), "Description for Asset 57", new Guid("f7b8f18b-b6f4-48eb-93aa-afc0e38c435e"), "Intel Core i59", 5700m, new DateTime(2023, 12, 9, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(2387), "57 GB", "EEEE00057", "57 TB", null },
                    { new Guid("8276c361-4485-4daa-b78b-a41b042d9dde"), "Asset 65", "auth0|65b7dee72e02f54da98cd265", "100000000064", 1, 4, new DateTime(2023, 12, 1, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(2727), null, new Guid("3d526281-eadc-4787-b905-b124b02448c9"), "Description for Asset 65", new Guid("b582da51-20dd-4fde-aed6-d2f5b1c5b7ab"), "Intel Core i67", 6500m, new DateTime(2023, 12, 1, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(2726), "65 GB", "MMMM00065", "65 TB", null },
                    { new Guid("82d28eab-12af-4ad5-bc6f-ca265703df62"), "Asset 69", "auth0|65b7dee72e02f54da98cd265", "100000000068", 5, 3, new DateTime(2023, 11, 27, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(2928), null, new Guid("488bc0e5-f891-4ceb-b029-5d6744d830c3"), "Description for Asset 69", new Guid("f7b8f18b-b6f4-48eb-93aa-afc0e38c435e"), "Intel Core i71", 6900m, new DateTime(2023, 11, 27, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(2927), "69 GB", "QQQQ00069", "69 TB", null },
                    { new Guid("84376aa5-1faa-43c2-bdc9-2a5d90a4cabc"), "Asset 35", "auth0|65b7de875bf9ce48b47eedaa", "100000000034", 6, 4, new DateTime(2023, 12, 31, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(1621), null, new Guid("3d526281-eadc-4787-b905-b124b02448c9"), "Description for Asset 35", new Guid("b582da51-20dd-4fde-aed6-d2f5b1c5b7ab"), "Intel Core i37", 3500m, new DateTime(2023, 12, 31, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(1619), "35 GB", "IIII00035", "35 TB", null },
                    { new Guid("8567c826-3630-44ef-9744-6f70d74b335f"), "Asset 34", "auth0|65a4f8d7364ff592a0792a42", "100000000033", 5, 3, new DateTime(2024, 1, 1, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(1588), null, new Guid("fcf5a7fd-caea-4fbc-b605-77441b9eca6f"), "Description for Asset 34", new Guid("19c8195d-37c1-4d89-9d39-07bf5842e69d"), "Intel Core i36", 3400m, new DateTime(2024, 1, 1, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(1587), "34 GB", "HHHH00034", "34 TB", null },
                    { new Guid("87f80008-d28d-4881-986c-34fecb6c962a"), "Asset 33", "auth0|65b7dee72e02f54da98cd265", "100000000032", 4, 2, new DateTime(2024, 1, 2, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(1474), null, new Guid("488bc0e5-f891-4ceb-b029-5d6744d830c3"), "Description for Asset 33", new Guid("f7b8f18b-b6f4-48eb-93aa-afc0e38c435e"), "Intel Core i35", 3300m, new DateTime(2024, 1, 2, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(1473), "33 GB", "GGGG00033", "33 TB", null },
                    { new Guid("8ab8775a-fe1e-42bb-84a8-0664c8726d13"), "Asset 51", "auth0|65b7de875bf9ce48b47eedaa", "100000000050", 1, 0, new DateTime(2023, 12, 15, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(2202), new DateTime(2023, 12, 15, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(2204), new Guid("488bc0e5-f891-4ceb-b029-5d6744d830c3"), "Description for Asset 51", new Guid("f7b8f18b-b6f4-48eb-93aa-afc0e38c435e"), "Intel Core i53", 5100m, new DateTime(2023, 12, 15, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(2201), "51 GB", "YYYY00051", "51 TB", null },
                    { new Guid("8b6d3ded-2544-419e-ade6-a9fa14d48681"), "Asset 58", "auth0|65a4f8d7364ff592a0792a42", "100000000057", 1, 2, new DateTime(2023, 12, 8, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(2425), null, new Guid("fcf5a7fd-caea-4fbc-b605-77441b9eca6f"), "Description for Asset 58", new Guid("19c8195d-37c1-4d89-9d39-07bf5842e69d"), "Intel Core i60", 5800m, new DateTime(2023, 12, 8, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(2424), "58 GB", "FFFF00058", "58 TB", null },
                    { new Guid("94e65e9f-ade5-41ea-b16d-73b1823d0d7a"), "Asset 42", "auth0|65a4f8d7364ff592a0792a42", "100000000041", 6, 1, new DateTime(2023, 12, 24, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(1852), null, new Guid("488bc0e5-f891-4ceb-b029-5d6744d830c3"), "Description for Asset 42", new Guid("f7b8f18b-b6f4-48eb-93aa-afc0e38c435e"), "Intel Core i44", 4200m, new DateTime(2023, 12, 24, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(1851), "42 GB", "PPPP00042", "42 TB", null },
                    { new Guid("a1eaf5d0-9721-4d6b-976d-10a18744d0bf"), "Asset 16", "auth0|65a4fd318d9d565392c4972a", "100000000015", 1, 0, new DateTime(2024, 1, 19, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(708), null, new Guid("fcf5a7fd-caea-4fbc-b605-77441b9eca6f"), "Description for Asset 16", new Guid("19c8195d-37c1-4d89-9d39-07bf5842e69d"), "Intel Core i18", 1600m, new DateTime(2024, 1, 19, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(707), "16 GB", "PPPP00016", "16 TB", null },
                    { new Guid("a44ff748-7c83-4bc6-808a-4e35747cae73"), "Asset 53", "auth0|65b7dee72e02f54da98cd265", "100000000052", 3, 2, new DateTime(2023, 12, 13, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(2265), null, new Guid("3d526281-eadc-4787-b905-b124b02448c9"), "Description for Asset 53", new Guid("b582da51-20dd-4fde-aed6-d2f5b1c5b7ab"), "Intel Core i55", 5300m, new DateTime(2023, 12, 13, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(2264), "53 GB", "AAAA00053", "53 TB", null },
                    { new Guid("a50f16ea-c203-4219-bb6b-3b9c5a789348"), "Asset 44", "auth0|65a4fd318d9d565392c4972a", "100000000043", 1, 3, new DateTime(2023, 12, 22, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(1914), null, new Guid("3d526281-eadc-4787-b905-b124b02448c9"), "Description for Asset 44", new Guid("b582da51-20dd-4fde-aed6-d2f5b1c5b7ab"), "Intel Core i46", 4400m, new DateTime(2023, 12, 22, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(1913), "44 GB", "RRRR00044", "44 TB", null },
                    { new Guid("a5c99e92-69fc-4047-bcaf-f2ce22dfffbd"), "Asset 50", "auth0|65a4f8d7364ff592a0792a42", "100000000049", 0, 4, new DateTime(2023, 12, 16, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(2171), null, new Guid("3d526281-eadc-4787-b905-b124b02448c9"), "Description for Asset 50", new Guid("b582da51-20dd-4fde-aed6-d2f5b1c5b7ab"), "Intel Core i52", 5000m, new DateTime(2023, 12, 16, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(2169), "50 GB", "XXXX00050", "50 TB", null },
                    { new Guid("a911f2dc-8c99-42ea-a817-d1b909d08b9e"), "Asset 56", "auth0|65a4fd318d9d565392c4972a", "100000000055", 6, 0, new DateTime(2023, 12, 10, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(2358), null, new Guid("3d526281-eadc-4787-b905-b124b02448c9"), "Description for Asset 56", new Guid("b582da51-20dd-4fde-aed6-d2f5b1c5b7ab"), "Intel Core i58", 5600m, new DateTime(2023, 12, 10, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(2356), "56 GB", "DDDD00056", "56 TB", null },
                    { new Guid("ac8bf8bb-b749-4e5f-803e-8ad389810274"), "Asset 38", "auth0|65a4f8d7364ff592a0792a42", "100000000037", 2, 2, new DateTime(2023, 12, 28, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(1716), null, new Guid("3d526281-eadc-4787-b905-b124b02448c9"), "Description for Asset 38", new Guid("b582da51-20dd-4fde-aed6-d2f5b1c5b7ab"), "Intel Core i40", 3800m, new DateTime(2023, 12, 28, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(1715), "38 GB", "LLLL00038", "38 TB", null },
                    { new Guid("b2b37aff-c7d5-412a-9559-891792fe803d"), "Asset 48", "auth0|65a4fd318d9d565392c4972a", "100000000047", 5, 2, new DateTime(2023, 12, 18, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(2103), null, new Guid("488bc0e5-f891-4ceb-b029-5d6744d830c3"), "Description for Asset 48", new Guid("f7b8f18b-b6f4-48eb-93aa-afc0e38c435e"), "Intel Core i50", 4800m, new DateTime(2023, 12, 18, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(2102), "48 GB", "VVVV00048", "48 TB", null },
                    { new Guid("b2f07e84-6d04-42ab-8f9a-5c95ba4329c9"), "Asset 9", "auth0|65b7dee72e02f54da98cd265", "100000000008", 1, 3, new DateTime(2024, 1, 26, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(199), null, new Guid("488bc0e5-f891-4ceb-b029-5d6744d830c3"), "Description for Asset 9", new Guid("f7b8f18b-b6f4-48eb-93aa-afc0e38c435e"), "Intel Core i11", 900m, new DateTime(2024, 1, 26, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(197), "9 GB", "IIII00009", "9 TB", null },
                    { new Guid("b450cb81-decd-48e5-96c6-109074706ea9"), "Asset 13", "auth0|65b7dee72e02f54da98cd265", "100000000012", 5, 2, new DateTime(2024, 1, 22, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(515), null, new Guid("fcf5a7fd-caea-4fbc-b605-77441b9eca6f"), "Description for Asset 13", new Guid("19c8195d-37c1-4d89-9d39-07bf5842e69d"), "Intel Core i15", 1300m, new DateTime(2024, 1, 22, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(514), "13 GB", "MMMM00013", "13 TB", null },
                    { new Guid("b609c356-cb1a-4aff-b8ff-13fcd0368559"), "Asset 22", "auth0|65a4f8d7364ff592a0792a42", "100000000021", 0, 1, new DateTime(2024, 1, 13, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(913), null, new Guid("fcf5a7fd-caea-4fbc-b605-77441b9eca6f"), "Description for Asset 22", new Guid("19c8195d-37c1-4d89-9d39-07bf5842e69d"), "Intel Core i24", 2200m, new DateTime(2024, 1, 13, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(911), "22 GB", "VVVV00022", "22 TB", null },
                    { new Guid("b65a3653-e9ea-43b7-83a6-715eeb60b5bd"), "Asset 12", "auth0|65a4fd318d9d565392c4972a", "100000000011", 4, 1, new DateTime(2024, 1, 23, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(469), null, new Guid("488bc0e5-f891-4ceb-b029-5d6744d830c3"), "Description for Asset 12", new Guid("f7b8f18b-b6f4-48eb-93aa-afc0e38c435e"), "Intel Core i14", 1200m, new DateTime(2024, 1, 23, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(466), "12 GB", "LLLL00012", "12 TB", null },
                    { new Guid("b884b195-1fa6-434a-b3a0-af1ac1de7c60"), "Asset 59", "auth0|65b7de875bf9ce48b47eedaa", "100000000058", 2, 3, new DateTime(2023, 12, 7, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(2525), null, new Guid("3d526281-eadc-4787-b905-b124b02448c9"), "Description for Asset 59", new Guid("b582da51-20dd-4fde-aed6-d2f5b1c5b7ab"), "Intel Core i61", 5900m, new DateTime(2023, 12, 7, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(2523), "59 GB", "GGGG00059", "59 TB", null },
                    { new Guid("bbae71f3-a79a-4426-9918-bdb57bb58806"), "Asset 15", "auth0|65b7de875bf9ce48b47eedaa", "100000000014", 0, 4, new DateTime(2024, 1, 20, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(674), null, new Guid("488bc0e5-f891-4ceb-b029-5d6744d830c3"), "Description for Asset 15", new Guid("f7b8f18b-b6f4-48eb-93aa-afc0e38c435e"), "Intel Core i17", 1500m, new DateTime(2024, 1, 20, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(672), "15 GB", "OOOO00015", "15 TB", null },
                    { new Guid("bcdc779a-4026-43d3-83d9-aee099e3c6f5"), "Asset 49", "auth0|65b7dee72e02f54da98cd265", "100000000048", 6, 3, new DateTime(2023, 12, 17, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(2134), null, new Guid("fcf5a7fd-caea-4fbc-b605-77441b9eca6f"), "Description for Asset 49", new Guid("19c8195d-37c1-4d89-9d39-07bf5842e69d"), "Intel Core i51", 4900m, new DateTime(2023, 12, 17, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(2132), "49 GB", "WWWW00049", "49 TB", null },
                    { new Guid("be6f513b-8ff6-422e-902e-4adb53186100"), "Asset 5", "auth0|65b7dee72e02f54da98cd265", "100000000004", 4, 4, new DateTime(2024, 1, 30, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(49), null, new Guid("3d526281-eadc-4787-b905-b124b02448c9"), "Description for Asset 5", new Guid("b582da51-20dd-4fde-aed6-d2f5b1c5b7ab"), "Intel Core i7", 500m, new DateTime(2024, 1, 30, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(48), "5 GB", "EEEE00005", "5 TB", null },
                    { new Guid("c0fe8045-0fce-443f-aadb-845cf60f63e2"), "Asset 68", "auth0|65a4fd318d9d565392c4972a", "100000000067", 4, 2, new DateTime(2023, 11, 28, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(2898), null, new Guid("3d526281-eadc-4787-b905-b124b02448c9"), "Description for Asset 68", new Guid("b582da51-20dd-4fde-aed6-d2f5b1c5b7ab"), "Intel Core i70", 6800m, new DateTime(2023, 11, 28, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(2897), "68 GB", "PPPP00068", "68 TB", null },
                    { new Guid("c2700fff-b0f8-4e3f-9450-3a0e8b523083"), "Asset 43", "auth0|65b7de875bf9ce48b47eedaa", "100000000042", 0, 2, new DateTime(2023, 12, 23, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(1883), null, new Guid("fcf5a7fd-caea-4fbc-b605-77441b9eca6f"), "Description for Asset 43", new Guid("19c8195d-37c1-4d89-9d39-07bf5842e69d"), "Intel Core i45", 4300m, new DateTime(2023, 12, 23, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(1882), "43 GB", "QQQQ00043", "43 TB", null },
                    { new Guid("c27af898-42af-4eff-bf56-a4377b6e09a6"), "Asset 4", "auth0|65a4fd318d9d565392c4972a", "100000000003", 3, 3, new DateTime(2024, 1, 31, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(14), null, new Guid("fcf5a7fd-caea-4fbc-b605-77441b9eca6f"), "Description for Asset 4", new Guid("19c8195d-37c1-4d89-9d39-07bf5842e69d"), "Intel Core i6", 400m, new DateTime(2024, 1, 31, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(12), "4 GB", "DDDD00004", "4 TB", null },
                    { new Guid("c414843f-d8ec-4c9e-a0be-9d9d2443f8bb"), "Asset 21", "auth0|65b7dee72e02f54da98cd265", "100000000020", 6, 0, new DateTime(2024, 1, 14, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(879), new DateTime(2024, 1, 14, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(881), new Guid("488bc0e5-f891-4ceb-b029-5d6744d830c3"), "Description for Asset 21", new Guid("f7b8f18b-b6f4-48eb-93aa-afc0e38c435e"), "Intel Core i23", 2100m, new DateTime(2024, 1, 14, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(878), "21 GB", "UUUU00021", "21 TB", null },
                    { new Guid("c420b659-be54-4a28-b131-5344c7ac07f3"), "Asset 8", "auth0|65a4fd318d9d565392c4972a", "100000000007", 0, 2, new DateTime(2024, 1, 27, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(162), null, new Guid("3d526281-eadc-4787-b905-b124b02448c9"), "Description for Asset 8", new Guid("b582da51-20dd-4fde-aed6-d2f5b1c5b7ab"), "Intel Core i10", 800m, new DateTime(2024, 1, 27, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(161), "8 GB", "HHHH00008", "8 TB", null },
                    { new Guid("c681cf14-e1ff-4bfe-bacb-07eb14d4729d"), "Asset 20", "auth0|65a4fd318d9d565392c4972a", "100000000019", 5, 4, new DateTime(2024, 1, 15, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(848), null, new Guid("3d526281-eadc-4787-b905-b124b02448c9"), "Description for Asset 20", new Guid("b582da51-20dd-4fde-aed6-d2f5b1c5b7ab"), "Intel Core i22", 2000m, new DateTime(2024, 1, 15, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(846), "20 GB", "TTTT00020", "20 TB", null },
                    { new Guid("c706c8cd-d2c5-400a-8aa8-3b537e7cb9c6"), "Asset 60", "auth0|65a4fd318d9d565392c4972a", "100000000059", 3, 4, new DateTime(2023, 12, 6, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(2558), null, new Guid("488bc0e5-f891-4ceb-b029-5d6744d830c3"), "Description for Asset 60", new Guid("f7b8f18b-b6f4-48eb-93aa-afc0e38c435e"), "Intel Core i62", 6000m, new DateTime(2023, 12, 6, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(2556), "60 GB", "HHHH00060", "60 TB", null },
                    { new Guid("c7890c8e-8c49-481f-862d-0a7fdc855718"), "Asset 62", "auth0|65a4f8d7364ff592a0792a42", "100000000061", 5, 1, new DateTime(2023, 12, 4, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(2624), null, new Guid("3d526281-eadc-4787-b905-b124b02448c9"), "Description for Asset 62", new Guid("b582da51-20dd-4fde-aed6-d2f5b1c5b7ab"), "Intel Core i64", 6200m, new DateTime(2023, 12, 4, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(2622), "62 GB", "JJJJ00062", "62 TB", null },
                    { new Guid("c8ad0841-4379-47b7-b33e-dd6e0806faeb"), "Asset 10", "auth0|65a4f8d7364ff592a0792a42", "100000000009", 2, 4, new DateTime(2024, 1, 25, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(242), null, new Guid("fcf5a7fd-caea-4fbc-b605-77441b9eca6f"), "Description for Asset 10", new Guid("19c8195d-37c1-4d89-9d39-07bf5842e69d"), "Intel Core i12", 1000m, new DateTime(2024, 1, 25, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(240), "10 GB", "JJJJ00010", "10 TB", null },
                    { new Guid("cad7fa03-3cbb-46f0-ae04-daa69d04a856"), "Asset 70", "auth0|65a4f8d7364ff592a0792a42", "100000000069", 6, 4, new DateTime(2023, 11, 26, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(2960), null, new Guid("fcf5a7fd-caea-4fbc-b605-77441b9eca6f"), "Description for Asset 70", new Guid("19c8195d-37c1-4d89-9d39-07bf5842e69d"), "Intel Core i72", 7000m, new DateTime(2023, 11, 26, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(2959), "70 GB", "RRRR00070", "70 TB", null },
                    { new Guid("d044d52f-3014-43fb-9b7a-6e27125b6c47"), "Asset 47", "auth0|65b7de875bf9ce48b47eedaa", "100000000046", 4, 1, new DateTime(2023, 12, 19, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(2072), null, new Guid("3d526281-eadc-4787-b905-b124b02448c9"), "Description for Asset 47", new Guid("b582da51-20dd-4fde-aed6-d2f5b1c5b7ab"), "Intel Core i49", 4700m, new DateTime(2023, 12, 19, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(2071), "47 GB", "UUUU00047", "47 TB", null },
                    { new Guid("d17c1c16-81a0-419e-80b9-7d6c871843d6"), "Asset 2", "auth0|65a4f8d7364ff592a0792a42", "100000000001", 1, 1, new DateTime(2024, 2, 2, 15, 13, 12, 222, DateTimeKind.Local).AddTicks(9929), null, new Guid("3d526281-eadc-4787-b905-b124b02448c9"), "Description for Asset 2", new Guid("b582da51-20dd-4fde-aed6-d2f5b1c5b7ab"), "Intel Core i4", 200m, new DateTime(2024, 2, 2, 15, 13, 12, 222, DateTimeKind.Local).AddTicks(9928), "2 GB", "BBBB00002", "2 TB", null },
                    { new Guid("d8cd2124-fd7a-46ad-8feb-0df7b06c412e"), "Asset 6", "auth0|65a4f8d7364ff592a0792a42", "100000000005", 5, 0, new DateTime(2024, 1, 29, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(90), null, new Guid("488bc0e5-f891-4ceb-b029-5d6744d830c3"), "Description for Asset 6", new Guid("f7b8f18b-b6f4-48eb-93aa-afc0e38c435e"), "Intel Core i8", 600m, new DateTime(2024, 1, 29, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(88), "6 GB", "FFFF00006", "6 TB", null },
                    { new Guid("d8f28655-14fd-4a8c-8276-d4a4b7d8e952"), "Asset 11", "auth0|65b7de875bf9ce48b47eedaa", "100000000010", 3, 0, new DateTime(2024, 1, 24, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(275), new DateTime(2024, 1, 24, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(277), new Guid("3d526281-eadc-4787-b905-b124b02448c9"), "Description for Asset 11", new Guid("b582da51-20dd-4fde-aed6-d2f5b1c5b7ab"), "Intel Core i13", 1100m, new DateTime(2024, 1, 24, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(274), "11 GB", "KKKK00011", "11 TB", null },
                    { new Guid("d94f2c8e-c9b2-4bff-8c53-c86cc41b5a26"), "Asset 17", "auth0|65b7dee72e02f54da98cd265", "100000000016", 2, 1, new DateTime(2024, 1, 18, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(742), null, new Guid("3d526281-eadc-4787-b905-b124b02448c9"), "Description for Asset 17", new Guid("b582da51-20dd-4fde-aed6-d2f5b1c5b7ab"), "Intel Core i19", 1700m, new DateTime(2024, 1, 18, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(741), "17 GB", "QQQQ00017", "17 TB", null },
                    { new Guid("e0a864e1-5e4e-48db-8bdd-64cbbefa5046"), "Asset 30", "auth0|65a4f8d7364ff592a0792a42", "100000000029", 1, 4, new DateTime(2024, 1, 5, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(1374), null, new Guid("488bc0e5-f891-4ceb-b029-5d6744d830c3"), "Description for Asset 30", new Guid("f7b8f18b-b6f4-48eb-93aa-afc0e38c435e"), "Intel Core i32", 3000m, new DateTime(2024, 1, 5, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(1372), "30 GB", "DDDD00030", "30 TB", null },
                    { new Guid("e0c1a02a-4bc4-48cb-9556-a617e2c84023"), "Asset 29", "auth0|65b7dee72e02f54da98cd265", "100000000028", 0, 3, new DateTime(2024, 1, 6, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(1263), null, new Guid("3d526281-eadc-4787-b905-b124b02448c9"), "Description for Asset 29", new Guid("b582da51-20dd-4fde-aed6-d2f5b1c5b7ab"), "Intel Core i31", 2900m, new DateTime(2024, 1, 6, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(1262), "29 GB", "CCCC00029", "29 TB", null },
                    { new Guid("e1c16561-23d0-410f-88c4-f687d0c550e3"), "Asset 27", "auth0|65b7de875bf9ce48b47eedaa", "100000000026", 5, 1, new DateTime(2024, 1, 8, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(1200), null, new Guid("488bc0e5-f891-4ceb-b029-5d6744d830c3"), "Description for Asset 27", new Guid("f7b8f18b-b6f4-48eb-93aa-afc0e38c435e"), "Intel Core i29", 2700m, new DateTime(2024, 1, 8, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(1199), "27 GB", "AAAA00027", "27 TB", null },
                    { new Guid("e3a2cf71-676b-4685-9fee-de6a276c9e35"), "Asset 52", "auth0|65a4fd318d9d565392c4972a", "100000000051", 2, 1, new DateTime(2023, 12, 14, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(2234), null, new Guid("fcf5a7fd-caea-4fbc-b605-77441b9eca6f"), "Description for Asset 52", new Guid("19c8195d-37c1-4d89-9d39-07bf5842e69d"), "Intel Core i54", 5200m, new DateTime(2023, 12, 14, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(2233), "52 GB", "ZZZZ00052", "52 TB", null },
                    { new Guid("e688f1d2-81f7-4b8f-812c-06edd73834a0"), "Asset 55", "auth0|65b7de875bf9ce48b47eedaa", "100000000054", 5, 4, new DateTime(2023, 12, 11, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(2327), null, new Guid("fcf5a7fd-caea-4fbc-b605-77441b9eca6f"), "Description for Asset 55", new Guid("19c8195d-37c1-4d89-9d39-07bf5842e69d"), "Intel Core i57", 5500m, new DateTime(2023, 12, 11, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(2326), "55 GB", "CCCC00055", "55 TB", null },
                    { new Guid("e706872a-f6f2-4693-b445-2dd37bc26b0e"), "Asset 61", "auth0|65b7dee72e02f54da98cd265", "100000000060", 4, 0, new DateTime(2023, 12, 5, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(2590), new DateTime(2023, 12, 5, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(2592), new Guid("fcf5a7fd-caea-4fbc-b605-77441b9eca6f"), "Description for Asset 61", new Guid("19c8195d-37c1-4d89-9d39-07bf5842e69d"), "Intel Core i63", 6100m, new DateTime(2023, 12, 5, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(2589), "61 GB", "IIII00061", "61 TB", null },
                    { new Guid("e89c0901-ee96-4e2d-a2f4-f558336276e9"), "Asset 66", "auth0|65a4f8d7364ff592a0792a42", "100000000065", 2, 0, new DateTime(2023, 11, 30, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(2833), null, new Guid("488bc0e5-f891-4ceb-b029-5d6744d830c3"), "Description for Asset 66", new Guid("f7b8f18b-b6f4-48eb-93aa-afc0e38c435e"), "Intel Core i68", 6600m, new DateTime(2023, 11, 30, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(2832), "66 GB", "NNNN00066", "66 TB", null },
                    { new Guid("e8ddd435-2464-4c9d-a43f-388b1975f901"), "Asset 36", "auth0|65a4fd318d9d565392c4972a", "100000000035", 0, 0, new DateTime(2023, 12, 30, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(1652), null, new Guid("488bc0e5-f891-4ceb-b029-5d6744d830c3"), "Description for Asset 36", new Guid("f7b8f18b-b6f4-48eb-93aa-afc0e38c435e"), "Intel Core i38", 3600m, new DateTime(2023, 12, 30, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(1651), "36 GB", "JJJJ00036", "36 TB", null },
                    { new Guid("ec1afd48-270c-4eae-9b2f-1938e675a234"), "Asset 24", "auth0|65a4fd318d9d565392c4972a", "100000000023", 2, 3, new DateTime(2024, 1, 11, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(1100), null, new Guid("488bc0e5-f891-4ceb-b029-5d6744d830c3"), "Description for Asset 24", new Guid("f7b8f18b-b6f4-48eb-93aa-afc0e38c435e"), "Intel Core i26", 2400m, new DateTime(2024, 1, 11, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(1099), "24 GB", "XXXX00024", "24 TB", null },
                    { new Guid("fb548886-ac24-4da8-9730-6e47711de250"), "Asset 37", "auth0|65b7dee72e02f54da98cd265", "100000000036", 1, 1, new DateTime(2023, 12, 29, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(1684), null, new Guid("fcf5a7fd-caea-4fbc-b605-77441b9eca6f"), "Description for Asset 37", new Guid("19c8195d-37c1-4d89-9d39-07bf5842e69d"), "Intel Core i39", 3700m, new DateTime(2023, 12, 29, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(1682), "37 GB", "KKKK00037", "37 TB", null },
                    { new Guid("fe51f92f-b49f-4cfb-a98d-739e4f57503e"), "Asset 26", "auth0|65a4f8d7364ff592a0792a42", "100000000025", 4, 0, new DateTime(2024, 1, 9, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(1169), null, new Guid("3d526281-eadc-4787-b905-b124b02448c9"), "Description for Asset 26", new Guid("b582da51-20dd-4fde-aed6-d2f5b1c5b7ab"), "Intel Core i28", 2600m, new DateTime(2024, 1, 9, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(1168), "26 GB", "ZZZZ00026", "26 TB", null }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "TicketId", "AssetID", "AssignedUserID", "Category", "ClosedAt", "CompletedAt", "CreatedAt", "CreatedBy", "Description", "Priority", "Status", "Title" },
                values: new object[,]
                {
                    { new Guid("0210230f-9bf7-498c-b4da-85da7b5183c3"), new Guid("0d968db3-960d-4fda-8ebb-adc1a3a50999"), null, 0, new DateTime(2023, 11, 25, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(9893), new DateTime(2023, 11, 24, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(9891), new DateTime(2023, 11, 23, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(9894), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 73", 0, 0, "Ticket 73" },
                    { new Guid("02d926b5-390a-493e-8b1c-98df335bcd67"), new Guid("6246fb7d-c2f9-425b-a185-98350aa9da3e"), null, 2, new DateTime(2023, 9, 12, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(2526), new DateTime(2023, 9, 11, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(2524), new DateTime(2023, 9, 10, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(2527), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 147", 2, 2, "Ticket 147" },
                    { new Guid("036f790e-0142-4ed8-895b-b8c145ea18cd"), new Guid("b609c356-cb1a-4aff-b8ff-13fcd0368559"), null, 3, null, null, new DateTime(2023, 6, 17, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(5743), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 232", 0, 3, "Ticket 232" },
                    { new Guid("044daefe-1522-4483-8f75-4bd17007c84e"), new Guid("1df30ac9-724a-4ace-a5bd-cbb579e7ca2c"), null, 0, new DateTime(2023, 10, 28, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(1093), new DateTime(2023, 10, 27, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(1092), new DateTime(2023, 10, 26, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(1095), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 101", 1, 0, "Ticket 101" },
                    { new Guid("0458a3bb-7b65-40ff-ab79-75e472117404"), new Guid("e0a864e1-5e4e-48db-8bdd-64cbbefa5046"), null, 1, null, null, new DateTime(2024, 1, 5, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(8595), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 30", 2, 1, "Ticket 30" },
                    { new Guid("0518856f-64a8-40e2-87cd-27ef7e0e46dd"), new Guid("b2f07e84-6d04-42ab-8f9a-5c95ba4329c9"), null, 0, new DateTime(2023, 9, 10, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(2583), new DateTime(2023, 9, 9, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(2581), new DateTime(2023, 9, 8, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(2585), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 149", 1, 0, "Ticket 149" },
                    { new Guid("0531bbe8-9b17-4dc0-9397-646af45ad6c3"), new Guid("e0c1a02a-4bc4-48cb-9556-a617e2c84023"), null, 0, new DateTime(2023, 8, 21, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(3187), new DateTime(2023, 8, 20, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(3185), new DateTime(2023, 8, 19, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(3189), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 169", 0, 0, "Ticket 169" },
                    { new Guid("05660d29-9b1a-4d9e-8b09-82d6d974b2f1"), new Guid("b450cb81-decd-48e5-96c6-109074706ea9"), null, 0, new DateTime(2024, 1, 24, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(8055), new DateTime(2024, 1, 23, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(8054), new DateTime(2024, 1, 22, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(8057), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 13", 0, 0, "Ticket 13" },
                    { new Guid("05cf80ed-7192-4f04-80cf-d8df5350db44"), new Guid("ec1afd48-270c-4eae-9b2f-1938e675a234"), null, 1, null, null, new DateTime(2023, 6, 15, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(5814), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 234", 2, 1, "Ticket 234" },
                    { new Guid("066fe6e9-d45d-4b3e-b1f4-1862d43acf06"), new Guid("c0fe8045-0fce-443f-aadb-845cf60f63e2"), null, 3, null, null, new DateTime(2023, 7, 11, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(4716), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 208", 0, 3, "Ticket 208" },
                    { new Guid("08f4cf01-4c11-4de3-a502-916a6032c999"), new Guid("c420b659-be54-4a28-b131-5344c7ac07f3"), null, 3, null, null, new DateTime(2024, 1, 27, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(7915), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 8", 1, 3, "Ticket 8" },
                    { new Guid("09358b70-5d0b-4f3b-97d8-0ec0916739a6"), new Guid("8276c361-4485-4daa-b78b-a41b042d9dde"), null, 2, new DateTime(2023, 9, 24, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(2205), new DateTime(2023, 9, 23, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(2203), new DateTime(2023, 9, 22, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(2206), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 135", 2, 2, "Ticket 135" },
                    { new Guid("0c9bc8b3-6f24-420c-aafc-2b6b1345a23a"), new Guid("ac8bf8bb-b749-4e5f-803e-8ad389810274"), null, 3, null, null, new DateTime(2023, 10, 19, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(1285), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 108", 2, 3, "Ticket 108" },
                    { new Guid("0d444183-8503-4e8b-a8b0-78d6244bbd5b"), new Guid("b65a3653-e9ea-43b7-83a6-715eeb60b5bd"), null, 3, null, null, new DateTime(2024, 1, 23, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(8030), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 12", 2, 3, "Ticket 12" },
                    { new Guid("0e6f90ac-ec68-4575-96c4-c94eddd610c8"), new Guid("d8cd2124-fd7a-46ad-8feb-0df7b06c412e"), null, 1, null, null, new DateTime(2023, 9, 11, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(2500), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 146", 1, 1, "Ticket 146" },
                    { new Guid("0ea5007e-0d9d-4e5d-95b0-0d729ea1bf73"), new Guid("ec1afd48-270c-4eae-9b2f-1938e675a234"), null, 3, null, null, new DateTime(2023, 8, 24, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(3058), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 164", 1, 3, "Ticket 164" },
                    { new Guid("0eae5363-b78b-4722-980f-b5eb0eaf640b"), new Guid("87f80008-d28d-4881-986c-34fecb6c962a"), null, 2, new DateTime(2023, 6, 8, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(6176), new DateTime(2023, 6, 7, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(6173), new DateTime(2023, 6, 6, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(6179), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 243", 2, 2, "Ticket 243" },
                    { new Guid("0f11948e-f8b7-452e-ab4f-ab3564c2d4d3"), new Guid("c0fe8045-0fce-443f-aadb-845cf60f63e2"), null, 1, null, null, new DateTime(2023, 9, 19, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(2285), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 138", 2, 1, "Ticket 138" },
                    { new Guid("0fa76c5f-b097-4306-a539-df963a30ef3d"), new Guid("d94f2c8e-c9b2-4bff-8c53-c86cc41b5a26"), null, 0, new DateTime(2023, 9, 2, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(2869), new DateTime(2023, 9, 1, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(2867), new DateTime(2023, 8, 31, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(2870), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 157", 0, 0, "Ticket 157" },
                    { new Guid("11907ca2-6a26-42bc-be0b-b5d4de566eea"), new Guid("b884b195-1fa6-434a-b3a0-af1ac1de7c60"), null, 0, new DateTime(2023, 9, 30, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(1935), new DateTime(2023, 9, 29, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(1934), new DateTime(2023, 9, 28, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(1937), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 129", 2, 0, "Ticket 129" },
                    { new Guid("13f7f623-7690-4c34-90ec-4670e877f4e9"), new Guid("8567c826-3630-44ef-9744-6f70d74b335f"), null, 3, null, null, new DateTime(2023, 6, 5, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(6225), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 244", 0, 3, "Ticket 244" },
                    { new Guid("14a7612c-5461-4085-b06a-f94f5588a2c1"), new Guid("bcdc779a-4026-43d3-83d9-aee099e3c6f5"), null, 0, new DateTime(2023, 12, 19, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(9177), new DateTime(2023, 12, 18, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(9176), new DateTime(2023, 12, 17, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(9179), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 49", 0, 0, "Ticket 49" },
                    { new Guid("15918950-88bb-4555-bbbb-d85c1c185e7d"), new Guid("e89c0901-ee96-4e2d-a2f4-f558336276e9"), null, 1, null, null, new DateTime(2023, 11, 30, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(9704), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 66", 2, 1, "Ticket 66" },
                    { new Guid("1763df8e-6d46-4792-ae83-348e2ee5d77d"), new Guid("ac8bf8bb-b749-4e5f-803e-8ad389810274"), null, 1, null, null, new DateTime(2023, 12, 28, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(8878), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 38", 1, 1, "Ticket 38" },
                    { new Guid("18b4f9dd-8462-4e57-be67-862c322e1162"), new Guid("c414843f-d8ec-4c9e-a0be-9d9d2443f8bb"), null, 0, new DateTime(2024, 1, 16, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(8342), new DateTime(2024, 1, 15, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(8340), new DateTime(2024, 1, 14, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(8343), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 21", 2, 0, "Ticket 21" },
                    { new Guid("18e98cfa-750e-4c5e-a17d-73c85880c908"), new Guid("798f6fce-fb81-402f-b76e-33049b892820"), null, 0, new DateTime(2023, 8, 25, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(3084), new DateTime(2023, 8, 24, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(3082), new DateTime(2023, 8, 23, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(3085), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 165", 2, 0, "Ticket 165" },
                    { new Guid("198b53fc-29ec-4fcf-b28d-72ebd2abf210"), new Guid("fe51f92f-b49f-4cfb-a98d-739e4f57503e"), null, 3, null, null, new DateTime(2023, 10, 31, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(903), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 96", 2, 3, "Ticket 96" },
                    { new Guid("1a714042-1116-4b17-82f7-c6e2cde9edc2"), new Guid("e0c1a02a-4bc4-48cb-9556-a617e2c84023"), null, 2, new DateTime(2023, 6, 12, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(6011), new DateTime(2023, 6, 11, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(6009), new DateTime(2023, 6, 10, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(6014), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 239", 1, 2, "Ticket 239" },
                    { new Guid("1a8dc0da-b121-4773-873f-ff0e32adc9e0"), new Guid("0d968db3-960d-4fda-8ebb-adc1a3a50999"), null, 2, new DateTime(2024, 2, 3, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(7771), new DateTime(2024, 2, 2, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(7769), new DateTime(2024, 2, 1, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(7772), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 3", 2, 2, "Ticket 3" },
                    { new Guid("1b05536c-7916-439e-99dd-97fd6eb6fdf3"), new Guid("2918bf65-e859-411e-85cf-4dee00fe7f73"), null, 0, new DateTime(2024, 2, 5, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(7705), new DateTime(2024, 2, 4, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(7698), new DateTime(2024, 2, 3, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(7711), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 1", 0, 0, "Ticket 1" },
                    { new Guid("1b1dc502-0fa6-4929-922b-2c5d9364840e"), new Guid("1ad928bb-4612-4cbd-b795-f4d9e05d0b73"), null, 3, null, null, new DateTime(2023, 6, 25, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(5417), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 224", 1, 3, "Ticket 224" },
                    { new Guid("1b9c83a2-6cb3-4844-994c-5cbe3fe07e9e"), new Guid("94e65e9f-ade5-41ea-b16d-73b1823d0d7a"), null, 3, null, null, new DateTime(2023, 10, 15, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(1388), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 112", 0, 3, "Ticket 112" },
                    { new Guid("1ea72b8a-c0b5-447d-a945-6778e8f8b223"), new Guid("2069b475-a494-48bb-8f1e-5077e9fc0c29"), null, 0, new DateTime(2023, 6, 22, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(5614), new DateTime(2023, 6, 21, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(5612), new DateTime(2023, 6, 20, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(5618), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 229", 0, 0, "Ticket 229" },
                    { new Guid("1fde8785-8122-45b3-bfc6-7b67683d71ce"), new Guid("c7890c8e-8c49-481f-862d-0a7fdc855718"), null, 3, null, null, new DateTime(2023, 9, 25, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(2027), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 132", 2, 3, "Ticket 132" },
                    { new Guid("2006a614-c186-4862-85bf-6c67fae96d7f"), new Guid("87f80008-d28d-4881-986c-34fecb6c962a"), null, 0, new DateTime(2024, 1, 4, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(8674), new DateTime(2024, 1, 3, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(8672), new DateTime(2024, 1, 2, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(8675), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 33", 2, 0, "Ticket 33" },
                    { new Guid("223a7398-a2c0-4501-a8fb-98b942faed40"), new Guid("ec1afd48-270c-4eae-9b2f-1938e675a234"), null, 3, null, null, new DateTime(2024, 1, 11, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(8432), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 24", 2, 3, "Ticket 24" },
                    { new Guid("238fc481-91c6-43be-b894-95f00f67ea78"), new Guid("a1eaf5d0-9721-4d6b-976d-10a18744d0bf"), null, 1, null, null, new DateTime(2023, 11, 10, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(315), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 86", 1, 1, "Ticket 86" },
                    { new Guid("2670a2f5-64d3-498e-938e-d2e5d3c627b0"), new Guid("d044d52f-3014-43fb-9b7a-6e27125b6c47"), null, 2, new DateTime(2023, 8, 3, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(3932), new DateTime(2023, 8, 2, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(3930), new DateTime(2023, 8, 1, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(3935), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 187", 0, 2, "Ticket 187" },
                    { new Guid("26e4676e-c30a-443f-be5d-934f9b7fbb4f"), new Guid("a44ff748-7c83-4bc6-808a-4e35747cae73"), null, 2, new DateTime(2023, 10, 6, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(1772), new DateTime(2023, 10, 5, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(1771), new DateTime(2023, 10, 4, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(1774), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 123", 2, 2, "Ticket 123" },
                    { new Guid("26f3177c-c64a-4a0e-8d89-611227ec2d6e"), new Guid("2c48c132-38e2-43d7-bf83-2e78dc062be2"), null, 2, new DateTime(2023, 12, 1, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(9730), new DateTime(2023, 11, 30, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(9728), new DateTime(2023, 11, 29, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(9732), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 67", 0, 2, "Ticket 67" },
                    { new Guid("29569a59-5535-4457-a853-245748274a71"), new Guid("d17c1c16-81a0-419e-80b9-7d6c871843d6"), null, 1, null, null, new DateTime(2024, 2, 2, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(7743), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 2", 1, 1, "Ticket 2" },
                    { new Guid("2b4c3e47-0e8a-465b-99ed-9699a2456858"), new Guid("82d28eab-12af-4ad5-bc6f-ca265703df62"), null, 0, new DateTime(2023, 7, 12, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(4740), new DateTime(2023, 7, 11, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(4739), new DateTime(2023, 7, 10, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(4742), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 209", 1, 0, "Ticket 209" },
                    { new Guid("2c098b94-5f33-4141-bda9-f37cfb59d173"), new Guid("05f24951-e653-4a66-bf9c-a7fc974790af"), null, 1, null, null, new DateTime(2023, 6, 11, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(5974), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 238", 0, 1, "Ticket 238" },
                    { new Guid("2d5b2125-6771-48b1-a4c7-aedb6f444f4b"), new Guid("d8f28655-14fd-4a8c-8276-d4a4b7d8e952"), null, 0, new DateTime(2023, 11, 17, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(177), new DateTime(2023, 11, 16, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(175), new DateTime(2023, 11, 15, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(179), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 81", 2, 0, "Ticket 81" },
                    { new Guid("2d912b7a-71cc-4cae-ab32-07290d034fe3"), new Guid("6d8e062e-c71e-4b72-bcc6-a7066bc54f25"), null, 3, null, null, new DateTime(2023, 6, 21, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(5574), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 228", 2, 3, "Ticket 228" },
                    { new Guid("303ff197-8246-46ac-b1ad-2ba7d9916711"), new Guid("4fb29223-242d-434d-9437-2927203619ea"), null, 1, null, null, new DateTime(2023, 10, 17, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(1336), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 110", 1, 1, "Ticket 110" },
                    { new Guid("30e7c614-7bf9-4298-9cf4-2f39f5701dd9"), new Guid("a1eaf5d0-9721-4d6b-976d-10a18744d0bf"), null, 3, null, null, new DateTime(2023, 9, 1, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(2843), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 156", 2, 3, "Ticket 156" },
                    { new Guid("315d54cc-4acb-4aec-bd4c-65430e1f5bb6"), new Guid("0186db38-7113-4142-a1e1-9dee806daeb2"), null, 2, new DateTime(2023, 8, 27, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(3027), new DateTime(2023, 8, 26, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(3026), new DateTime(2023, 8, 25, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(3029), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 163", 0, 2, "Ticket 163" },
                    { new Guid("315dc7d7-78ba-438a-93fc-d2ddccac28e8"), new Guid("2918bf65-e859-411e-85cf-4dee00fe7f73"), null, 0, new DateTime(2023, 9, 18, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(2369), new DateTime(2023, 9, 17, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(2367), new DateTime(2023, 9, 16, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(2371), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 141", 2, 0, "Ticket 141" },
                    { new Guid("330927f9-77c8-45ef-a08c-b3fbd1ef461c"), new Guid("b2f07e84-6d04-42ab-8f9a-5c95ba4329c9"), null, 0, new DateTime(2024, 1, 28, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(7942), new DateTime(2024, 1, 27, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(7940), new DateTime(2024, 1, 26, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(7943), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 9", 2, 0, "Ticket 9" },
                    { new Guid("35154e40-6c54-463d-b821-c614b4fa9d33"), new Guid("a50f16ea-c203-4219-bb6b-3b9c5a789348"), null, 1, null, null, new DateTime(2023, 10, 13, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(1441), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 114", 2, 1, "Ticket 114" },
                    { new Guid("358ac71b-c813-4252-9445-03e2a4a20082"), new Guid("bbae71f3-a79a-4426-9918-bdb57bb58806"), null, 2, new DateTime(2024, 1, 22, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(8107), new DateTime(2024, 1, 21, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(8106), new DateTime(2024, 1, 20, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(8109), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 15", 2, 2, "Ticket 15" },
                    { new Guid("362f4259-106a-4ef6-8667-b06a9926d4ca"), new Guid("fe51f92f-b49f-4cfb-a98d-739e4f57503e"), null, 3, null, null, new DateTime(2023, 6, 13, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(5926), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 236", 1, 3, "Ticket 236" },
                    { new Guid("3936b4d9-0b50-4b25-8e38-1b895c479671"), new Guid("2069b475-a494-48bb-8f1e-5077e9fc0c29"), null, 2, new DateTime(2023, 8, 31, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(2921), new DateTime(2023, 8, 30, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(2919), new DateTime(2023, 8, 29, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(2923), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 159", 2, 2, "Ticket 159" },
                    { new Guid("398f60e8-cdf2-45a6-8e1f-c5629c5d024b"), new Guid("4fb29223-242d-434d-9437-2927203619ea"), null, 3, null, null, new DateTime(2023, 12, 26, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(8931), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 40", 0, 3, "Ticket 40" },
                    { new Guid("3b83a203-07ac-4329-b3e8-7adc4578bd7c"), new Guid("8567c826-3630-44ef-9744-6f70d74b335f"), null, 1, null, null, new DateTime(2024, 1, 1, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(8703), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 34", 0, 1, "Ticket 34" },
                    { new Guid("3b8e8107-236b-4d1a-993f-d7ec093b85f2"), new Guid("c0fe8045-0fce-443f-aadb-845cf60f63e2"), null, 3, null, null, new DateTime(2023, 11, 28, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(9762), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 68", 1, 3, "Ticket 68" },
                    { new Guid("3bdeec1d-c068-4b31-b682-970ba5da1241"), new Guid("81faf274-2a02-4780-82ef-53dbf6359121"), null, 0, new DateTime(2023, 12, 11, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(9391), new DateTime(2023, 12, 10, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(9389), new DateTime(2023, 12, 9, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(9393), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 57", 2, 0, "Ticket 57" },
                    { new Guid("3c611382-d8a6-4c70-b5b3-c27e8f7f8b21"), new Guid("071c3cc5-02b0-432f-8f41-ba673225e1c8"), null, 3, null, null, new DateTime(2023, 10, 3, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(1804), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 124", 0, 3, "Ticket 124" },
                    { new Guid("3cb7683b-c7be-45cd-9729-050e68ba4ccd"), new Guid("c681cf14-e1ff-4bfe-bacb-07eb14d4729d"), null, 3, null, null, new DateTime(2023, 8, 28, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(2949), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 160", 0, 3, "Ticket 160" },
                    { new Guid("3e9776f4-99d9-4ada-97c1-273f2d5d52fa"), new Guid("2e7474a0-28d5-4c9e-b838-61db8782cc92"), null, 0, new DateTime(2023, 12, 23, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(9071), new DateTime(2023, 12, 22, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(9069), new DateTime(2023, 12, 21, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(9072), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 45", 2, 0, "Ticket 45" },
                    { new Guid("3fc65a9e-531b-408e-9c41-42fe4febdc48"), new Guid("65aa9a7c-d370-42ae-bfd4-c73044970716"), null, 1, null, null, new DateTime(2023, 12, 20, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(9098), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 46", 0, 1, "Ticket 46" },
                    { new Guid("423d8190-ee85-4c2f-9278-15da79f49764"), new Guid("e0a864e1-5e4e-48db-8bdd-64cbbefa5046"), null, 1, null, null, new DateTime(2023, 8, 18, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(3214), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 170", 1, 1, "Ticket 170" },
                    { new Guid("43db3af1-1da5-4dda-9752-4845e781de69"), new Guid("b884b195-1fa6-434a-b3a0-af1ac1de7c60"), null, 2, new DateTime(2023, 12, 9, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(9508), new DateTime(2023, 12, 8, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(9506), new DateTime(2023, 12, 7, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(9509), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 59", 1, 2, "Ticket 59" },
                    { new Guid("4526dbfe-0f9b-4242-8bca-fcd4d43f446d"), new Guid("6ccb1d85-1dbd-465d-a425-f22ec75c4b85"), null, 2, new DateTime(2023, 12, 5, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(9620), new DateTime(2023, 12, 4, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(9618), new DateTime(2023, 12, 3, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(9622), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 63", 2, 2, "Ticket 63" },
                    { new Guid("454fbaec-0dda-4b7e-8349-e066ec2ac562"), new Guid("bbae71f3-a79a-4426-9918-bdb57bb58806"), null, 2, new DateTime(2023, 9, 4, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(2810), new DateTime(2023, 9, 3, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(2809), new DateTime(2023, 9, 2, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(2812), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 155", 1, 2, "Ticket 155" },
                    { new Guid("45906c36-edaa-4604-bf82-9405c8796758"), new Guid("b2b37aff-c7d5-412a-9559-891792fe803d"), null, 3, null, null, new DateTime(2023, 7, 31, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(3983), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 188", 1, 3, "Ticket 188" },
                    { new Guid("45be12c2-0134-4bb1-8f62-188e12d6007b"), new Guid("0186db38-7113-4142-a1e1-9dee806daeb2"), null, 0, new DateTime(2023, 6, 18, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(5783), new DateTime(2023, 6, 17, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(5777), new DateTime(2023, 6, 16, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(5785), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 233", 1, 0, "Ticket 233" },
                    { new Guid("46c710da-23d7-4bfa-8be1-c182b3b8c8c5"), new Guid("c8ad0841-4379-47b7-b33e-dd6e0806faeb"), null, 1, null, null, new DateTime(2023, 9, 7, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(2609), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 150", 2, 1, "Ticket 150" },
                    { new Guid("4752231c-b3c7-432f-824f-444649fc9071"), new Guid("e706872a-f6f2-4693-b445-2dd37bc26b0e"), null, 0, new DateTime(2023, 12, 7, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(9566), new DateTime(2023, 12, 6, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(9564), new DateTime(2023, 12, 5, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(9567), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 61", 0, 0, "Ticket 61" },
                    { new Guid("48503f0c-e86b-4433-a4ab-b56e9b3b2756"), new Guid("8ab8775a-fe1e-42bb-84a8-0664c8726d13"), null, 2, new DateTime(2023, 7, 30, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(4095), new DateTime(2023, 7, 29, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(4093), new DateTime(2023, 7, 28, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(4098), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 191", 1, 2, "Ticket 191" },
                    { new Guid("490ad268-c15f-4cac-85e0-9614deb9f1ce"), new Guid("e0a864e1-5e4e-48db-8bdd-64cbbefa5046"), null, 3, null, null, new DateTime(2023, 6, 9, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(6051), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 240", 2, 3, "Ticket 240" },
                    { new Guid("4a98dc3c-0dac-489e-a3fb-527e65989f06"), new Guid("b2f07e84-6d04-42ab-8f9a-5c95ba4329c9"), null, 2, new DateTime(2023, 11, 19, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(124), new DateTime(2023, 11, 18, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(123), new DateTime(2023, 11, 17, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(126), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 79", 0, 2, "Ticket 79" },
                    { new Guid("4b152663-0bcf-4d02-90a7-428ec7bd21dd"), new Guid("84376aa5-1faa-43c2-bdc9-2a5d90a4cabc"), null, 0, new DateTime(2023, 10, 24, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(1200), new DateTime(2023, 10, 23, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(1199), new DateTime(2023, 10, 22, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(1202), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 105", 2, 0, "Ticket 105" },
                    { new Guid("4b4eb5d9-ae89-4239-b24c-bb7bd21e45df"), new Guid("c414843f-d8ec-4c9e-a0be-9d9d2443f8bb"), null, 2, new DateTime(2023, 6, 20, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(5701), new DateTime(2023, 6, 19, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(5699), new DateTime(2023, 6, 18, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(5704), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 231", 2, 2, "Ticket 231" },
                    { new Guid("4b5f763b-9393-4fc9-8ad2-18adab9708f8"), new Guid("8b6d3ded-2544-419e-ade6-a9fa14d48681"), null, 1, null, null, new DateTime(2023, 12, 8, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(9482), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 58", 0, 1, "Ticket 58" },
                    { new Guid("4bcdc2ad-e28c-4644-9c5d-cb43d6658000"), new Guid("1df30ac9-724a-4ace-a5bd-cbb579e7ca2c"), null, 2, new DateTime(2024, 1, 6, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(8621), new DateTime(2024, 1, 5, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(8619), new DateTime(2024, 1, 4, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(8622), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 31", 0, 2, "Ticket 31" },
                    { new Guid("4c2de52a-aa9c-49c6-a7e8-90912cc5f326"), new Guid("05f24951-e653-4a66-bf9c-a7fc974790af"), null, 1, null, null, new DateTime(2023, 10, 29, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(1007), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 98", 1, 1, "Ticket 98" },
                    { new Guid("4d93f3a0-cc5b-473d-be13-53da718768af"), new Guid("e688f1d2-81f7-4b8f-812c-06edd73834a0"), null, 2, new DateTime(2023, 7, 26, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(4364), new DateTime(2023, 7, 25, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(4362), new DateTime(2023, 7, 24, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(4368), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 195", 2, 2, "Ticket 195" },
                    { new Guid("4db17a23-cdde-4de1-9393-932fb7b1e1a7"), new Guid("a1eaf5d0-9721-4d6b-976d-10a18744d0bf"), null, 3, null, null, new DateTime(2024, 1, 19, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(8134), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 16", 0, 3, "Ticket 16" },
                    { new Guid("4dbf5073-85a1-42db-be56-9d1e44de9724"), new Guid("3f747ed7-980b-4e92-acdf-ec1102d4a0af"), null, 1, null, null, new DateTime(2023, 9, 23, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(2177), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 134", 1, 1, "Ticket 134" },
                    { new Guid("4e95202e-1a84-42c6-af8c-29da929fc437"), new Guid("a911f2dc-8c99-42ea-a817-d1b909d08b9e"), null, 3, null, null, new DateTime(2023, 12, 10, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(9365), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 56", 1, 3, "Ticket 56" },
                    { new Guid("4f5df65a-f573-4da6-899a-0db914a12b12"), new Guid("d8f28655-14fd-4a8c-8276-d4a4b7d8e952"), null, 2, new DateTime(2024, 1, 26, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(7997), new DateTime(2024, 1, 25, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(7996), new DateTime(2024, 1, 24, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(7999), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 11", 1, 2, "Ticket 11" },
                    { new Guid("538e79f8-1fc2-4509-b0b5-d818a8bde32f"), new Guid("734b123e-c217-49d1-8478-561ba7973cab"), null, 3, null, null, new DateTime(2024, 1, 3, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(8647), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 32", 1, 3, "Ticket 32" },
                    { new Guid("54f469d2-b4ff-45c9-9a1c-d2428eaae452"), new Guid("cad7fa03-3cbb-46f0-ae04-daa69d04a856"), null, 3, null, null, new DateTime(2023, 9, 17, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(2344), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 140", 1, 3, "Ticket 140" },
                    { new Guid("568d2810-3283-42af-8b4c-98a654892551"), new Guid("2e7474a0-28d5-4c9e-b838-61db8782cc92"), null, 0, new DateTime(2023, 8, 5, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(3845), new DateTime(2023, 8, 4, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(3843), new DateTime(2023, 8, 3, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(3849), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 185", 1, 0, "Ticket 185" },
                    { new Guid("56dc156e-3042-4762-9799-fbf2d7421bd5"), new Guid("be6f513b-8ff6-422e-902e-4adb53186100"), null, 0, new DateTime(2024, 2, 1, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(7831), new DateTime(2024, 1, 31, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(7830), new DateTime(2024, 1, 30, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(7833), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 5", 1, 0, "Ticket 5" },
                    { new Guid("58a63b86-cb9f-4ac5-8d4d-51178642612c"), new Guid("b450cb81-decd-48e5-96c6-109074706ea9"), null, 2, new DateTime(2023, 6, 28, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(5383), new DateTime(2023, 6, 27, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(5381), new DateTime(2023, 6, 26, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(5385), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 223", 0, 2, "Ticket 223" },
                    { new Guid("5c52803f-0173-45f9-80ae-81f278490dda"), new Guid("d044d52f-3014-43fb-9b7a-6e27125b6c47"), null, 2, new DateTime(2023, 12, 21, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(9125), new DateTime(2023, 12, 20, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(9123), new DateTime(2023, 12, 19, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(9126), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 47", 1, 2, "Ticket 47" },
                    { new Guid("5c6b6564-85cd-4e3c-8818-9201a6ec0ba0"), new Guid("2918bf65-e859-411e-85cf-4dee00fe7f73"), null, 2, new DateTime(2023, 11, 27, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(9840), new DateTime(2023, 11, 26, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(9838), new DateTime(2023, 11, 25, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(9841), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 71", 1, 2, "Ticket 71" },
                    { new Guid("5d310819-76d5-46df-a152-195f59be6bea"), new Guid("1df30ac9-724a-4ace-a5bd-cbb579e7ca2c"), null, 0, new DateTime(2023, 6, 10, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(6092), new DateTime(2023, 6, 9, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(6090), new DateTime(2023, 6, 8, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(6096), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 241", 0, 0, "Ticket 241" },
                    { new Guid("5dd04f77-598e-45e0-8953-7326ab015c32"), new Guid("8276c361-4485-4daa-b78b-a41b042d9dde"), null, 0, new DateTime(2023, 12, 3, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(9673), new DateTime(2023, 12, 2, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(9671), new DateTime(2023, 12, 1, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(9675), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 65", 1, 0, "Ticket 65" },
                    { new Guid("5e0623aa-e39a-428d-8b9e-0718f688ba02"), new Guid("a44ff748-7c83-4bc6-808a-4e35747cae73"), null, 0, new DateTime(2023, 7, 28, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(4179), new DateTime(2023, 7, 27, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(4176), new DateTime(2023, 7, 26, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(4182), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 193", 0, 0, "Ticket 193" },
                    { new Guid("5e22619c-5d21-4554-9857-97300877870c"), new Guid("82d28eab-12af-4ad5-bc6f-ca265703df62"), null, 2, new DateTime(2023, 9, 20, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(2312), new DateTime(2023, 9, 19, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(2310), new DateTime(2023, 9, 18, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(2313), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 139", 0, 2, "Ticket 139" },
                    { new Guid("5edc3205-ae54-4189-b407-eaa3347b62b0"), new Guid("c7890c8e-8c49-481f-862d-0a7fdc855718"), null, 1, null, null, new DateTime(2023, 12, 4, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(9593), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 62", 1, 1, "Ticket 62" },
                    { new Guid("5fbbeffe-b57c-4d87-9cfd-4efd1bb1f9c1"), new Guid("e0a864e1-5e4e-48db-8bdd-64cbbefa5046"), null, 3, null, null, new DateTime(2023, 10, 27, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(1067), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 100", 0, 3, "Ticket 100" },
                    { new Guid("607cf0ca-25df-45b6-b0c1-4150dafb5ab9"), new Guid("63092697-3fcc-4e41-9969-c783a15e768f"), null, 0, new DateTime(2023, 10, 20, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(1310), new DateTime(2023, 10, 19, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(1309), new DateTime(2023, 10, 18, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(1312), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 109", 0, 0, "Ticket 109" },
                    { new Guid("61645fa6-1489-4f37-b17e-2d512ccc643c"), new Guid("bbae71f3-a79a-4426-9918-bdb57bb58806"), null, 0, new DateTime(2023, 11, 13, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(288), new DateTime(2023, 11, 12, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(287), new DateTime(2023, 11, 11, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(290), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 85", 0, 0, "Ticket 85" },
                    { new Guid("61f71815-0a23-4b58-8a69-aca55c5d86ae"), new Guid("2448cee6-eacf-4b8c-b35f-47e61b43d7cf"), null, 2, new DateTime(2023, 10, 18, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(1362), new DateTime(2023, 10, 17, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(1360), new DateTime(2023, 10, 16, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(1364), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 111", 2, 2, "Ticket 111" },
                    { new Guid("62ca4a77-d856-4f6a-b6a8-d7ad18de298d"), new Guid("c681cf14-e1ff-4bfe-bacb-07eb14d4729d"), null, 1, null, null, new DateTime(2023, 6, 19, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(5660), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 230", 1, 1, "Ticket 230" },
                    { new Guid("64e30aee-3e26-49b7-87b5-df12751bdc5e"), new Guid("e706872a-f6f2-4693-b445-2dd37bc26b0e"), null, 2, new DateTime(2023, 9, 28, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(1994), new DateTime(2023, 9, 27, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(1993), new DateTime(2023, 9, 26, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(1996), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 131", 1, 2, "Ticket 131" },
                    { new Guid("6513a94b-f4cc-451c-a895-92f2507c25ca"), new Guid("c27af898-42af-4eff-bf56-a4377b6e09a6"), null, 3, null, null, new DateTime(2023, 9, 13, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(2447), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 144", 2, 3, "Ticket 144" },
                    { new Guid("65196d3f-8896-4f4e-a682-d2f967e9a4d9"), new Guid("0186db38-7113-4142-a1e1-9dee806daeb2"), null, 2, new DateTime(2024, 1, 14, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(8406), new DateTime(2024, 1, 13, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(8393), new DateTime(2024, 1, 12, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(8408), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 23", 1, 2, "Ticket 23" },
                    { new Guid("68abc370-59d4-44f1-bef7-9810c0b8812d"), new Guid("65aa9a7c-d370-42ae-bfd4-c73044970716"), null, 3, null, null, new DateTime(2023, 10, 11, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(1497), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 116", 1, 3, "Ticket 116" },
                    { new Guid("6a7055c1-a001-4ff1-bf24-40601c5a6a2c"), new Guid("a911f2dc-8c99-42ea-a817-d1b909d08b9e"), null, 1, null, null, new DateTime(2023, 10, 1, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(1856), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 126", 2, 1, "Ticket 126" },
                    { new Guid("6af0d6f1-cb10-41aa-b478-d01ea8c5c7ae"), new Guid("d17c1c16-81a0-419e-80b9-7d6c871843d6"), null, 3, null, null, new DateTime(2023, 11, 24, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(9867), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 72", 2, 3, "Ticket 72" },
                    { new Guid("6ca90119-e9f5-4aab-b863-ba7cb616b9db"), new Guid("bcdc779a-4026-43d3-83d9-aee099e3c6f5"), null, 2, new DateTime(2023, 10, 10, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(1663), new DateTime(2023, 10, 9, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(1661), new DateTime(2023, 10, 8, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(1665), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 119", 1, 2, "Ticket 119" },
                    { new Guid("6cff3d7b-abda-4dfd-adc2-f7902d21d3ba"), new Guid("87f80008-d28d-4881-986c-34fecb6c962a"), null, 2, new DateTime(2023, 10, 26, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(1147), new DateTime(2023, 10, 25, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(1145), new DateTime(2023, 10, 24, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(1148), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 103", 0, 2, "Ticket 103" },
                    { new Guid("6d46e1b3-b57b-40c1-9dca-25d4243d9b40"), new Guid("2918bf65-e859-411e-85cf-4dee00fe7f73"), null, 2, new DateTime(2023, 7, 10, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(4788), new DateTime(2023, 7, 9, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(4787), new DateTime(2023, 7, 8, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(4790), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 211", 0, 2, "Ticket 211" },
                    { new Guid("6f26047b-ff36-4183-ba4f-d983f577d79f"), new Guid("1ad928bb-4612-4cbd-b795-f4d9e05d0b73"), null, 3, null, null, new DateTime(2023, 11, 12, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(263), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 84", 2, 3, "Ticket 84" },
                    { new Guid("6f47b94c-455a-4ed6-8e7d-b208a6e14999"), new Guid("e8ddd435-2464-4c9d-a43f-388b1975f901"), null, 3, null, null, new DateTime(2023, 12, 30, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(8762), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 36", 2, 3, "Ticket 36" },
                    { new Guid("6ffd4dfd-0be2-455d-b396-bf41a02dbef4"), new Guid("c2700fff-b0f8-4e3f-9450-3a0e8b523083"), null, 0, new DateTime(2023, 10, 16, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(1414), new DateTime(2023, 10, 15, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(1412), new DateTime(2023, 10, 14, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(1416), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 113", 1, 0, "Ticket 113" },
                    { new Guid("701fefae-aaea-4f51-a9d6-e9bb9fc7c4a0"), new Guid("c8ad0841-4379-47b7-b33e-dd6e0806faeb"), null, 3, null, null, new DateTime(2023, 6, 29, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(5270), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 220", 0, 3, "Ticket 220" },
                    { new Guid("7087fc18-9834-40ad-a914-82f0e8afd78a"), new Guid("6ccb1d85-1dbd-465d-a425-f22ec75c4b85"), null, 0, new DateTime(2023, 9, 26, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(2149), new DateTime(2023, 9, 25, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(2147), new DateTime(2023, 9, 24, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(2151), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 133", 0, 0, "Ticket 133" },
                    { new Guid("7168ed6c-05d2-4cb7-8a62-e99a18a874c6"), new Guid("2448cee6-eacf-4b8c-b35f-47e61b43d7cf"), null, 0, new DateTime(2023, 8, 9, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(3679), new DateTime(2023, 8, 8, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(3677), new DateTime(2023, 8, 7, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(3681), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 181", 0, 0, "Ticket 181" },
                    { new Guid("717519bb-40e8-4730-b165-37448153e32c"), new Guid("fb548886-ac24-4da8-9730-6e47711de250"), null, 2, new DateTime(2023, 10, 22, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(1253), new DateTime(2023, 10, 21, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(1251), new DateTime(2023, 10, 20, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(1254), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 107", 1, 2, "Ticket 107" },
                    { new Guid("71d843fa-8eaa-4aa1-b40c-97fe3553a81f"), new Guid("2c48c132-38e2-43d7-bf83-2e78dc062be2"), null, 0, new DateTime(2023, 9, 22, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(2257), new DateTime(2023, 9, 21, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(2256), new DateTime(2023, 9, 20, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(2259), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 137", 1, 0, "Ticket 137" },
                    { new Guid("723d6320-d3d6-4b2f-bd19-4e7606d91f50"), new Guid("b65a3653-e9ea-43b7-83a6-715eeb60b5bd"), null, 1, null, null, new DateTime(2023, 11, 14, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(205), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 82", 0, 1, "Ticket 82" },
                    { new Guid("7494b310-e933-438f-a526-88e148fd9c55"), new Guid("b2b37aff-c7d5-412a-9559-891792fe803d"), null, 3, null, null, new DateTime(2023, 12, 18, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(9152), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 48", 2, 3, "Ticket 48" },
                    { new Guid("74be00cf-f7c9-46da-acf2-3ce29e82df30"), new Guid("c27af898-42af-4eff-bf56-a4377b6e09a6"), null, 1, null, null, new DateTime(2023, 11, 22, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(9919), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 74", 1, 1, "Ticket 74" },
                    { new Guid("754e4228-0c6c-4172-b2a2-84b25671ab5c"), new Guid("e3a2cf71-676b-4685-9fee-de6a276c9e35"), null, 3, null, null, new DateTime(2023, 12, 14, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(9262), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 52", 0, 3, "Ticket 52" },
                    { new Guid("75512f49-0a50-4849-8562-76fe73a1b18d"), new Guid("94e65e9f-ade5-41ea-b16d-73b1823d0d7a"), null, 1, null, null, new DateTime(2023, 8, 6, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(3721), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 182", 1, 1, "Ticket 182" },
                    { new Guid("75d35157-5768-4487-be15-ad559de36891"), new Guid("84376aa5-1faa-43c2-bdc9-2a5d90a4cabc"), null, 2, new DateTime(2023, 8, 15, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(3511), new DateTime(2023, 8, 14, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(3509), new DateTime(2023, 8, 13, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(3512), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 175", 0, 2, "Ticket 175" },
                    { new Guid("75e3931a-1304-4876-ba48-02e3bf1068ff"), new Guid("81faf274-2a02-4780-82ef-53dbf6359121"), null, 0, new DateTime(2023, 7, 24, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(4439), new DateTime(2023, 7, 23, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(4437), new DateTime(2023, 7, 22, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(4440), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 197", 1, 0, "Ticket 197" },
                    { new Guid("764e9c8b-818c-4849-9478-a7eb0b46ed5f"), new Guid("ec1afd48-270c-4eae-9b2f-1938e675a234"), null, 1, null, null, new DateTime(2023, 11, 2, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(850), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 94", 0, 1, "Ticket 94" },
                    { new Guid("7706d538-5c26-4cd3-9da9-c101c266c451"), new Guid("e1c16561-23d0-410f-88c4-f687d0c550e3"), null, 2, new DateTime(2024, 1, 10, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(8511), new DateTime(2024, 1, 9, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(8509), new DateTime(2024, 1, 8, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(8512), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 27", 2, 2, "Ticket 27" },
                    { new Guid("77b72de2-94ed-4c76-86a4-43a9f0ed94d1"), new Guid("b884b195-1fa6-434a-b3a0-af1ac1de7c60"), null, 2, new DateTime(2023, 7, 22, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(4488), new DateTime(2023, 7, 21, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(4487), new DateTime(2023, 7, 20, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(4490), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 199", 0, 2, "Ticket 199" },
                    { new Guid("77d8da4e-95f9-4e46-9a7d-a74604de99c6"), new Guid("94e65e9f-ade5-41ea-b16d-73b1823d0d7a"), null, 1, null, null, new DateTime(2023, 12, 24, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(8986), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 42", 2, 1, "Ticket 42" },
                    { new Guid("784731d6-3a9a-4c94-8a9e-596dc0bea65f"), new Guid("071c3cc5-02b0-432f-8f41-ba673225e1c8"), null, 1, null, null, new DateTime(2023, 12, 12, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(9314), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 54", 2, 1, "Ticket 54" },
                    { new Guid("7e1b7ce5-88de-4ec2-a780-bda66c44365b"), new Guid("be6f513b-8ff6-422e-902e-4adb53186100"), null, 2, new DateTime(2023, 11, 23, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(9946), new DateTime(2023, 11, 22, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(9944), new DateTime(2023, 11, 21, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(9947), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 75", 2, 2, "Ticket 75" },
                    { new Guid("7f5ed0f1-d56a-442b-a2d6-a43da44fb113"), new Guid("c2700fff-b0f8-4e3f-9450-3a0e8b523083"), null, 2, new DateTime(2023, 12, 25, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(9011), new DateTime(2023, 12, 24, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(9010), new DateTime(2023, 12, 23, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(9013), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 43", 0, 2, "Ticket 43" },
                    { new Guid("80c6be63-b5dd-4c1b-a82b-0626c42609b0"), new Guid("bcdc779a-4026-43d3-83d9-aee099e3c6f5"), null, 0, new DateTime(2023, 8, 1, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(4022), new DateTime(2023, 7, 31, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(4019), new DateTime(2023, 7, 30, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(4025), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 189", 2, 0, "Ticket 189" },
                    { new Guid("823ab545-ffab-4d11-9ba7-ead97061fecf"), new Guid("0d968db3-960d-4fda-8ebb-adc1a3a50999"), null, 2, new DateTime(2023, 9, 16, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(2420), new DateTime(2023, 9, 15, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(2419), new DateTime(2023, 9, 14, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(2422), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 143", 1, 2, "Ticket 143" },
                    { new Guid("83e676b5-d7aa-42cd-a5d7-350fda7de208"), new Guid("d8f28655-14fd-4a8c-8276-d4a4b7d8e952"), null, 2, new DateTime(2023, 9, 8, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(2636), new DateTime(2023, 9, 7, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(2634), new DateTime(2023, 9, 6, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(2637), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 151", 0, 2, "Ticket 151" },
                    { new Guid("84871031-ab82-484f-8721-a04cbbeef123"), new Guid("1ad928bb-4612-4cbd-b795-f4d9e05d0b73"), null, 1, null, null, new DateTime(2023, 9, 3, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(2782), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 154", 0, 1, "Ticket 154" },
                    { new Guid("84b35de1-153b-4164-8d7e-a7d3e818ed12"), new Guid("fb548886-ac24-4da8-9730-6e47711de250"), null, 0, new DateTime(2023, 12, 31, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(8851), new DateTime(2023, 12, 30, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(8849), new DateTime(2023, 12, 29, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(8853), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 37", 0, 0, "Ticket 37" },
                    { new Guid("87e9bbe7-1804-42da-93c8-0e80ce4f0637"), new Guid("e89c0901-ee96-4e2d-a2f4-f558336276e9"), null, 1, null, null, new DateTime(2023, 7, 13, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(4668), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 206", 1, 1, "Ticket 206" },
                    { new Guid("88da8d56-19b8-4fe0-bbbc-e72a12c6bc98"), new Guid("798f6fce-fb81-402f-b76e-33049b892820"), null, 2, new DateTime(2023, 6, 16, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(5838), new DateTime(2023, 6, 15, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(5836), new DateTime(2023, 6, 14, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(5839), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 235", 0, 2, "Ticket 235" },
                    { new Guid("8906757c-d4a1-4f13-9f74-7dc6c539fdea"), new Guid("4fb29223-242d-434d-9437-2927203619ea"), null, 1, null, null, new DateTime(2023, 5, 30, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(6484), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 250", 0, 1, "Ticket 250" },
                    { new Guid("8b842875-dc9b-480f-bbb2-4061936922d1"), new Guid("d94f2c8e-c9b2-4bff-8c53-c86cc41b5a26"), null, 2, new DateTime(2023, 11, 11, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(342), new DateTime(2023, 11, 10, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(340), new DateTime(2023, 11, 9, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(343), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 87", 2, 2, "Ticket 87" },
                    { new Guid("8cd41583-a8e7-4686-9ae4-dc165892a862"), new Guid("b609c356-cb1a-4aff-b8ff-13fcd0368559"), null, 1, null, null, new DateTime(2024, 1, 13, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(8368), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 22", 0, 1, "Ticket 22" },
                    { new Guid("91e43a39-eedb-4f61-8ea4-3aec9b7dbcca"), new Guid("be6f513b-8ff6-422e-902e-4adb53186100"), null, 2, new DateTime(2023, 7, 6, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(5049), new DateTime(2023, 7, 5, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(5046), new DateTime(2023, 7, 4, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(5052), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 215", 1, 2, "Ticket 215" },
                    { new Guid("930097b2-2ad8-4149-a5e8-abf81dab0814"), new Guid("8ab8775a-fe1e-42bb-84a8-0664c8726d13"), null, 2, new DateTime(2023, 12, 17, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(9229), new DateTime(2023, 12, 16, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(9228), new DateTime(2023, 12, 15, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(9231), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 51", 2, 2, "Ticket 51" },
                    { new Guid("93c4d9c1-945e-4839-8d0c-a3eb17b28f9b"), new Guid("1df30ac9-724a-4ace-a5bd-cbb579e7ca2c"), null, 2, new DateTime(2023, 8, 19, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(3240), new DateTime(2023, 8, 18, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(3238), new DateTime(2023, 8, 17, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(3241), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 171", 2, 2, "Ticket 171" },
                    { new Guid("94ce7f7f-1716-41a6-9bb0-0f45f605f839"), new Guid("e706872a-f6f2-4693-b445-2dd37bc26b0e"), null, 0, new DateTime(2023, 7, 20, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(4537), new DateTime(2023, 7, 19, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(4535), new DateTime(2023, 7, 18, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(4538), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 201", 2, 0, "Ticket 201" },
                    { new Guid("953b1e14-1ac0-44c7-aa2a-35a20b40a5e9"), new Guid("e8ddd435-2464-4c9d-a43f-388b1975f901"), null, 1, null, null, new DateTime(2023, 6, 3, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(6311), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 246", 2, 1, "Ticket 246" },
                    { new Guid("9643fa35-0259-437a-b46b-4451e266a4c5"), new Guid("be6f513b-8ff6-422e-902e-4adb53186100"), null, 0, new DateTime(2023, 9, 14, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(2473), new DateTime(2023, 9, 13, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(2471), new DateTime(2023, 9, 12, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(2475), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 145", 0, 0, "Ticket 145" },
                    { new Guid("9763f4ea-c72f-48cc-9056-ad303101741d"), new Guid("84376aa5-1faa-43c2-bdc9-2a5d90a4cabc"), null, 2, new DateTime(2024, 1, 2, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(8729), new DateTime(2024, 1, 1, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(8727), new DateTime(2023, 12, 31, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(8730), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 35", 1, 2, "Ticket 35" },
                    { new Guid("97cc0d65-a16f-4046-92c0-b050dbdb56ce"), new Guid("05f24951-e653-4a66-bf9c-a7fc974790af"), null, 3, null, null, new DateTime(2023, 8, 20, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(3162), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 168", 2, 3, "Ticket 168" },
                    { new Guid("9b8280b1-ff60-4473-a228-6d39b2262363"), new Guid("3f747ed7-980b-4e92-acdf-ec1102d4a0af"), null, 3, null, null, new DateTime(2023, 12, 2, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(9648), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 64", 0, 3, "Ticket 64" },
                    { new Guid("9b8948c1-210e-4bff-b601-315d38c0d0ba"), new Guid("6246fb7d-c2f9-425b-a185-98350aa9da3e"), null, 0, new DateTime(2023, 11, 21, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(71), new DateTime(2023, 11, 20, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(69), new DateTime(2023, 11, 19, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(72), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 77", 1, 0, "Ticket 77" },
                    { new Guid("9c09830f-cbc5-45a6-bf8e-35d3d0e28dd9"), new Guid("a911f2dc-8c99-42ea-a817-d1b909d08b9e"), null, 3, null, null, new DateTime(2023, 7, 23, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(4415), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 196", 0, 3, "Ticket 196" },
                    { new Guid("9c361ab3-4d67-4463-a3bb-851d06623499"), new Guid("a5c99e92-69fc-4047-bcaf-f2ce22dfffbd"), null, 3, null, null, new DateTime(2023, 10, 7, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(1692), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 120", 2, 3, "Ticket 120" },
                    { new Guid("9c8fa75d-2115-4891-8e19-8ae7ad6be82f"), new Guid("734b123e-c217-49d1-8478-561ba7973cab"), null, 1, null, null, new DateTime(2023, 6, 7, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(6136), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 242", 1, 1, "Ticket 242" },
                    { new Guid("9da838ef-d19d-4ec5-b5b2-218d95c5b221"), new Guid("ac8bf8bb-b749-4e5f-803e-8ad389810274"), null, 1, null, null, new DateTime(2023, 8, 10, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(3591), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 178", 0, 1, "Ticket 178" },
                    { new Guid("9dc6f71b-df30-4539-8a5d-e55081914ce7"), new Guid("63092697-3fcc-4e41-9969-c783a15e768f"), null, 0, new DateTime(2023, 6, 2, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(6442), new DateTime(2023, 6, 1, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(6439), new DateTime(2023, 5, 31, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(6444), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 249", 2, 0, "Ticket 249" },
                    { new Guid("9e3b9cb1-1881-47c4-91ba-98d864ea44a1"), new Guid("ac8bf8bb-b749-4e5f-803e-8ad389810274"), null, 3, null, null, new DateTime(2023, 6, 1, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(6399), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 248", 1, 3, "Ticket 248" },
                    { new Guid("a04174ca-5f69-44f1-a7d0-af4aa2278d7c"), new Guid("cad7fa03-3cbb-46f0-ae04-daa69d04a856"), null, 1, null, null, new DateTime(2023, 11, 26, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(9814), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 70", 0, 1, "Ticket 70" },
                    { new Guid("a14367bc-1771-4911-b7ec-483f31f3d611"), new Guid("3f747ed7-980b-4e92-acdf-ec1102d4a0af"), null, 3, null, null, new DateTime(2023, 7, 15, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(4617), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 204", 2, 3, "Ticket 204" },
                    { new Guid("a16157c6-cbbb-4ad8-a4f1-b0b1bd076d8a"), new Guid("2e7474a0-28d5-4c9e-b838-61db8782cc92"), null, 2, new DateTime(2023, 10, 14, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(1466), new DateTime(2023, 10, 13, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(1465), new DateTime(2023, 10, 12, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(1468), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 115", 0, 2, "Ticket 115" },
                    { new Guid("a20de620-edc4-4cb7-b4d0-bc7b48f2e7b0"), new Guid("c420b659-be54-4a28-b131-5344c7ac07f3"), null, 3, null, null, new DateTime(2023, 9, 9, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(2557), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 148", 0, 3, "Ticket 148" },
                    { new Guid("a611ad99-ed62-4a52-9e35-a7e6c56d2411"), new Guid("071c3cc5-02b0-432f-8f41-ba673225e1c8"), null, 1, null, null, new DateTime(2023, 7, 25, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(4226), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 194", 1, 1, "Ticket 194" },
                    { new Guid("a6c743c7-dd5c-46d6-85e4-3cde7105bc3b"), new Guid("81faf274-2a02-4780-82ef-53dbf6359121"), null, 2, new DateTime(2023, 10, 2, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(1883), new DateTime(2023, 10, 1, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(1882), new DateTime(2023, 9, 30, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(1885), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 127", 0, 2, "Ticket 127" },
                    { new Guid("a723be10-b63e-4fc3-9c62-1dcb9a44a9e8"), new Guid("e1c16561-23d0-410f-88c4-f687d0c550e3"), null, 2, new DateTime(2023, 8, 23, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(3136), new DateTime(2023, 8, 22, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(3134), new DateTime(2023, 8, 21, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(3138), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 167", 1, 2, "Ticket 167" },
                    { new Guid("a7b86e32-69a2-4dea-8136-3b2c202a9fac"), new Guid("c8ad0841-4379-47b7-b33e-dd6e0806faeb"), null, 1, null, null, new DateTime(2024, 1, 25, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(7971), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 10", 0, 1, "Ticket 10" },
                    { new Guid("a8ee9e70-42b2-4b2b-9774-b779e78026f3"), new Guid("e8ddd435-2464-4c9d-a43f-388b1975f901"), null, 3, null, null, new DateTime(2023, 8, 12, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(3537), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 176", 1, 3, "Ticket 176" },
                    { new Guid("aa07ea74-81dd-440f-9256-424a4dd0d012"), new Guid("734b123e-c217-49d1-8478-561ba7973cab"), null, 3, null, null, new DateTime(2023, 8, 16, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(3272), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 172", 0, 3, "Ticket 172" },
                    { new Guid("aa49dc0a-138d-4adb-872a-0e74107d146d"), new Guid("c27af898-42af-4eff-bf56-a4377b6e09a6"), null, 1, null, null, new DateTime(2023, 7, 5, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(4913), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 214", 0, 1, "Ticket 214" },
                    { new Guid("af2498d2-58b4-46f5-8796-874203b282cf"), new Guid("e0c1a02a-4bc4-48cb-9556-a617e2c84023"), null, 2, new DateTime(2023, 10, 30, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(1033), new DateTime(2023, 10, 29, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(1031), new DateTime(2023, 10, 28, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(1034), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 99", 2, 2, "Ticket 99" },
                    { new Guid("b0767f96-a80b-471a-b424-586921dc4e14"), new Guid("c706c8cd-d2c5-400a-8aa8-3b537e7cb9c6"), null, 1, null, null, new DateTime(2023, 9, 27, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(1968), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 130", 0, 1, "Ticket 130" },
                    { new Guid("b0addd21-cc6c-4074-89f3-e9f0f3604377"), new Guid("4fb29223-242d-434d-9437-2927203619ea"), null, 3, null, null, new DateTime(2023, 8, 8, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(3650), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 180", 2, 3, "Ticket 180" },
                    { new Guid("b13c5b91-bbd0-43cd-95cd-ef3b88ec9931"), new Guid("d044d52f-3014-43fb-9b7a-6e27125b6c47"), null, 0, new DateTime(2023, 10, 12, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(1524), new DateTime(2023, 10, 11, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(1522), new DateTime(2023, 10, 10, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(1526), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 117", 2, 0, "Ticket 117" },
                    { new Guid("b13c93aa-51e6-441d-93eb-b556237441b9"), new Guid("6ccb1d85-1dbd-465d-a425-f22ec75c4b85"), null, 2, new DateTime(2023, 7, 18, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(4586), new DateTime(2023, 7, 17, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(4584), new DateTime(2023, 7, 16, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(4588), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 203", 1, 2, "Ticket 203" },
                    { new Guid("b1bc0231-2ce1-4a44-9a9c-f52833c882b6"), new Guid("b65a3653-e9ea-43b7-83a6-715eeb60b5bd"), null, 1, null, null, new DateTime(2023, 6, 27, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(5348), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 222", 2, 1, "Ticket 222" },
                    { new Guid("b20ae896-6bc8-4aaa-adb0-8631307364f8"), new Guid("e8ddd435-2464-4c9d-a43f-388b1975f901"), null, 1, null, null, new DateTime(2023, 10, 21, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(1226), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 106", 0, 1, "Ticket 106" },
                    { new Guid("b2c3fca5-a190-4d4c-a7a0-1226659e5552"), new Guid("8567c826-3630-44ef-9744-6f70d74b335f"), null, 1, null, null, new DateTime(2023, 8, 14, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(3476), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 174", 2, 1, "Ticket 174" },
                    { new Guid("b3309991-0577-42f6-a306-23ad29bc4691"), new Guid("d8f28655-14fd-4a8c-8276-d4a4b7d8e952"), null, 0, new DateTime(2023, 6, 30, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(5310), new DateTime(2023, 6, 29, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(5307), new DateTime(2023, 6, 28, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(5313), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 221", 1, 0, "Ticket 221" },
                    { new Guid("b487c611-fc61-4cad-861e-20c0b825c346"), new Guid("a5c99e92-69fc-4047-bcaf-f2ce22dfffbd"), null, 1, null, null, new DateTime(2023, 12, 16, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(9203), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 50", 1, 1, "Ticket 50" },
                    { new Guid("b4c391bc-09cc-4119-8213-32ce455acbed"), new Guid("8ab8775a-fe1e-42bb-84a8-0664c8726d13"), null, 0, new DateTime(2023, 10, 8, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(1718), new DateTime(2023, 10, 7, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(1717), new DateTime(2023, 10, 6, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(1720), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 121", 0, 0, "Ticket 121" },
                    { new Guid("b502a48b-0537-4089-b42f-90c38d78a7f8"), new Guid("fb548886-ac24-4da8-9730-6e47711de250"), null, 0, new DateTime(2023, 8, 13, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(3564), new DateTime(2023, 8, 12, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(3562), new DateTime(2023, 8, 11, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(3565), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 177", 2, 0, "Ticket 177" },
                    { new Guid("b528507e-a2a4-49de-a029-98e646aedb4c"), new Guid("6246fb7d-c2f9-425b-a185-98350aa9da3e"), null, 2, new DateTime(2024, 1, 30, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(7889), new DateTime(2024, 1, 29, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(7887), new DateTime(2024, 1, 28, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(7890), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 7", 0, 2, "Ticket 7" },
                    { new Guid("b5aa360f-ab6b-45ba-9bd8-bdcdad2f1a17"), new Guid("c420b659-be54-4a28-b131-5344c7ac07f3"), null, 1, null, null, new DateTime(2023, 11, 18, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(98), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 78", 2, 1, "Ticket 78" },
                    { new Guid("b6796ff1-71f9-4ea9-934a-bbbb55c5a7ba"), new Guid("2448cee6-eacf-4b8c-b35f-47e61b43d7cf"), null, 0, new DateTime(2023, 12, 27, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(8958), new DateTime(2023, 12, 26, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(8956), new DateTime(2023, 12, 25, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(8959), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 41", 1, 0, "Ticket 41" },
                    { new Guid("b690e652-fab2-4f37-825a-028cb7beee4b"), new Guid("1ad928bb-4612-4cbd-b795-f4d9e05d0b73"), null, 1, null, null, new DateTime(2024, 1, 21, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(8083), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 14", 1, 1, "Ticket 14" },
                    { new Guid("b7d6090f-774a-447f-8c22-704e28d53f3f"), new Guid("84376aa5-1faa-43c2-bdc9-2a5d90a4cabc"), null, 0, new DateTime(2023, 6, 6, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(6265), new DateTime(2023, 6, 5, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(6263), new DateTime(2023, 6, 4, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(6268), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 245", 1, 0, "Ticket 245" },
                    { new Guid("b976a391-fc4d-4384-ac7a-c1183547ca1b"), new Guid("6d8e062e-c71e-4b72-bcc6-a7066bc54f25"), null, 1, null, null, new DateTime(2024, 1, 17, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(8257), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 18", 2, 1, "Ticket 18" },
                    { new Guid("baacdaf2-2768-4c9e-a8ae-20ddf0b852e5"), new Guid("cad7fa03-3cbb-46f0-ae04-daa69d04a856"), null, 1, null, null, new DateTime(2023, 7, 9, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(4764), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 210", 2, 1, "Ticket 210" },
                    { new Guid("be11c36a-87e3-41e1-9938-9bb8f6a390d7"), new Guid("c681cf14-e1ff-4bfe-bacb-07eb14d4729d"), null, 3, null, null, new DateTime(2024, 1, 15, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(8316), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 20", 1, 3, "Ticket 20" },
                    { new Guid("c0d2aeb1-d08a-4cc9-859c-fd39dab96e65"), new Guid("e688f1d2-81f7-4b8f-812c-06edd73834a0"), null, 0, new DateTime(2023, 10, 4, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(1829), new DateTime(2023, 10, 3, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(1828), new DateTime(2023, 10, 2, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(1831), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 125", 1, 0, "Ticket 125" },
                    { new Guid("c1265de9-2c27-4663-89b2-510312b21e6c"), new Guid("c414843f-d8ec-4c9e-a0be-9d9d2443f8bb"), null, 0, new DateTime(2023, 8, 29, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(2975), new DateTime(2023, 8, 28, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(2974), new DateTime(2023, 8, 27, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(2977), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 161", 1, 0, "Ticket 161" },
                    { new Guid("c315a5b2-bff8-4804-ac20-7f563f5524e8"), new Guid("05f24951-e653-4a66-bf9c-a7fc974790af"), null, 3, null, null, new DateTime(2024, 1, 7, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(8544), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 28", 0, 3, "Ticket 28" },
                    { new Guid("c33c8a8a-7792-4ebc-83df-316bc034e033"), new Guid("a44ff748-7c83-4bc6-808a-4e35747cae73"), null, 0, new DateTime(2023, 12, 15, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(9288), new DateTime(2023, 12, 14, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(9287), new DateTime(2023, 12, 13, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(9290), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 53", 1, 0, "Ticket 53" },
                    { new Guid("c3b46176-b849-496f-a287-80020121d996"), new Guid("d17c1c16-81a0-419e-80b9-7d6c871843d6"), null, 3, null, null, new DateTime(2023, 7, 7, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(4831), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 212", 1, 3, "Ticket 212" },
                    { new Guid("c46a97ea-b559-4bda-af4c-1655a0606423"), new Guid("6d8e062e-c71e-4b72-bcc6-a7066bc54f25"), null, 3, null, null, new DateTime(2023, 11, 8, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(681), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 88", 0, 3, "Ticket 88" },
                    { new Guid("c67dca86-0809-4f80-b6e8-db39c10a4022"), new Guid("8276c361-4485-4daa-b78b-a41b042d9dde"), null, 0, new DateTime(2023, 7, 16, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(4642), new DateTime(2023, 7, 15, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(4640), new DateTime(2023, 7, 14, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(4643), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 205", 0, 0, "Ticket 205" },
                    { new Guid("c7c7296e-fb8f-4ecc-8e30-aa849f7031f3"), new Guid("b609c356-cb1a-4aff-b8ff-13fcd0368559"), null, 3, null, null, new DateTime(2023, 11, 4, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(798), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 92", 1, 3, "Ticket 92" },
                    { new Guid("c9a0290f-b7c5-48bd-b518-ee956391ccb2"), new Guid("6d8e062e-c71e-4b72-bcc6-a7066bc54f25"), null, 1, null, null, new DateTime(2023, 8, 30, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(2894), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 158", 1, 1, "Ticket 158" },
                    { new Guid("ca768ae5-2286-44f8-9fe2-27cb145a3696"), new Guid("c8ad0841-4379-47b7-b33e-dd6e0806faeb"), null, 3, null, null, new DateTime(2023, 11, 16, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(151), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 80", 1, 3, "Ticket 80" },
                    { new Guid("caf4537f-2f9b-4693-bb35-ea2347d26929"), new Guid("c706c8cd-d2c5-400a-8aa8-3b537e7cb9c6"), null, 3, null, null, new DateTime(2023, 7, 19, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(4513), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 200", 1, 3, "Ticket 200" },
                    { new Guid("cb1a8980-0909-42bd-99ee-0d3bf0c54022"), new Guid("c414843f-d8ec-4c9e-a0be-9d9d2443f8bb"), null, 2, new DateTime(2023, 11, 7, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(764), new DateTime(2023, 11, 6, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(762), new DateTime(2023, 11, 5, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(765), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 91", 0, 2, "Ticket 91" },
                    { new Guid("cbf32950-b3dc-4206-b6e7-44fcd8421fc9"), new Guid("8567c826-3630-44ef-9744-6f70d74b335f"), null, 3, null, null, new DateTime(2023, 10, 23, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(1174), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 104", 1, 3, "Ticket 104" },
                    { new Guid("ccf98062-3ca3-4582-8743-921531fdbae5"), new Guid("b450cb81-decd-48e5-96c6-109074706ea9"), null, 0, new DateTime(2023, 9, 6, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(2690), new DateTime(2023, 9, 5, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(2688), new DateTime(2023, 9, 4, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(2691), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 153", 2, 0, "Ticket 153" },
                    { new Guid("cec6d855-d016-4530-bff1-1936a89e1f19"), new Guid("e688f1d2-81f7-4b8f-812c-06edd73834a0"), null, 2, new DateTime(2023, 12, 13, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(9339), new DateTime(2023, 12, 12, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(9337), new DateTime(2023, 12, 11, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(9341), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 55", 0, 2, "Ticket 55" },
                    { new Guid("d040e385-cec1-43de-8509-e093554439d9"), new Guid("b2b37aff-c7d5-412a-9559-891792fe803d"), null, 1, null, null, new DateTime(2023, 10, 9, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(1637), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 118", 0, 1, "Ticket 118" },
                    { new Guid("d20eb112-a12b-467c-b9a5-8f2513c0d05e"), new Guid("d94f2c8e-c9b2-4bff-8c53-c86cc41b5a26"), null, 0, new DateTime(2024, 1, 20, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(8225), new DateTime(2024, 1, 19, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(8224), new DateTime(2024, 1, 18, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(8227), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 17", 1, 0, "Ticket 17" },
                    { new Guid("d3772c29-27b7-42ff-a37e-4d18697eeda7"), new Guid("0186db38-7113-4142-a1e1-9dee806daeb2"), null, 0, new DateTime(2023, 11, 5, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(823), new DateTime(2023, 11, 4, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(822), new DateTime(2023, 11, 3, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(825), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 93", 2, 0, "Ticket 93" },
                    { new Guid("d476a426-31af-4fa2-bff0-117ebba8eb89"), new Guid("e89c0901-ee96-4e2d-a2f4-f558336276e9"), null, 3, null, null, new DateTime(2023, 9, 21, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(2231), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 136", 0, 3, "Ticket 136" },
                    { new Guid("d4be3cd5-c1d5-4335-9e55-c692fed59338"), new Guid("d8cd2124-fd7a-46ad-8feb-0df7b06c412e"), null, 1, null, null, new DateTime(2024, 1, 29, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(7862), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 6", 2, 1, "Ticket 6" },
                    { new Guid("d538413f-84e7-425b-a75b-cb17ac86713c"), new Guid("c27af898-42af-4eff-bf56-a4377b6e09a6"), null, 3, null, null, new DateTime(2024, 1, 31, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(7805), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 4", 0, 3, "Ticket 4" },
                    { new Guid("d5431c23-d031-4179-8c1b-1d089e4cdd03"), new Guid("a1eaf5d0-9721-4d6b-976d-10a18744d0bf"), null, 1, null, null, new DateTime(2023, 6, 23, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(5488), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 226", 0, 1, "Ticket 226" },
                    { new Guid("d5f6351a-ac4d-43c8-8229-eca8fc419eba"), new Guid("734b123e-c217-49d1-8478-561ba7973cab"), null, 1, null, null, new DateTime(2023, 10, 25, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(1120), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 102", 2, 1, "Ticket 102" },
                    { new Guid("d78006f5-83da-4d71-8bac-7d2123bcbf44"), new Guid("8b6d3ded-2544-419e-ade6-a9fa14d48681"), null, 3, null, null, new DateTime(2023, 9, 29, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(1910), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 128", 1, 3, "Ticket 128" },
                    { new Guid("d832c188-0fe5-42e7-b2ff-80a1dbcd30af"), new Guid("65aa9a7c-d370-42ae-bfd4-c73044970716"), null, 1, null, null, new DateTime(2023, 8, 2, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(3891), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 186", 2, 1, "Ticket 186" },
                    { new Guid("d934f527-7858-4ba6-89e2-ff3ce48e859e"), new Guid("e0c1a02a-4bc4-48cb-9556-a617e2c84023"), null, 0, new DateTime(2024, 1, 8, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(8569), new DateTime(2024, 1, 7, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(8567), new DateTime(2024, 1, 6, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(8570), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 29", 1, 0, "Ticket 29" },
                    { new Guid("d94df552-de29-4946-a896-a4e3900d9468"), new Guid("798f6fce-fb81-402f-b76e-33049b892820"), null, 0, new DateTime(2024, 1, 12, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(8458), new DateTime(2024, 1, 11, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(8457), new DateTime(2024, 1, 10, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(8460), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 25", 0, 0, "Ticket 25" },
                    { new Guid("db706122-1927-4c03-8fad-f5e01eea87f8"), new Guid("798f6fce-fb81-402f-b76e-33049b892820"), null, 2, new DateTime(2023, 11, 3, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(876), new DateTime(2023, 11, 2, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(874), new DateTime(2023, 11, 1, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(877), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 95", 1, 2, "Ticket 95" },
                    { new Guid("dd030cdb-f609-4ff5-a873-321f05cb9d36"), new Guid("d17c1c16-81a0-419e-80b9-7d6c871843d6"), null, 1, null, null, new DateTime(2023, 9, 15, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(2396), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 142", 0, 1, "Ticket 142" },
                    { new Guid("dd8e63bf-5d81-4286-b38a-3604ef839d1b"), new Guid("e3a2cf71-676b-4685-9fee-de6a276c9e35"), null, 1, null, null, new DateTime(2023, 10, 5, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(1746), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 122", 1, 1, "Ticket 122" },
                    { new Guid("df01eaba-1281-443f-8601-d53560669ec0"), new Guid("e1c16561-23d0-410f-88c4-f687d0c550e3"), null, 0, new DateTime(2023, 6, 14, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(5950), new DateTime(2023, 6, 13, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(5948), new DateTime(2023, 6, 12, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(5952), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 237", 2, 0, "Ticket 237" },
                    { new Guid("df22c8a7-4e34-4c68-8ef7-a965c7c637fa"), new Guid("0d968db3-960d-4fda-8ebb-adc1a3a50999"), null, 0, new DateTime(2023, 7, 8, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(4871), new DateTime(2023, 7, 7, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(4869), new DateTime(2023, 7, 6, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(4874), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 213", 2, 0, "Ticket 213" },
                    { new Guid("df7480c2-1c99-4806-a698-ede532f51644"), new Guid("d8cd2124-fd7a-46ad-8feb-0df7b06c412e"), null, 3, null, null, new DateTime(2023, 11, 20, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(9978), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 76", 0, 3, "Ticket 76" },
                    { new Guid("e0519965-8390-4917-8538-2beac71a1a24"), new Guid("8b6d3ded-2544-419e-ade6-a9fa14d48681"), null, 1, null, null, new DateTime(2023, 7, 21, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(4464), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 198", 2, 1, "Ticket 198" },
                    { new Guid("e118ecbe-0a2d-4bd3-94a7-4f1d86ce4f10"), new Guid("a50f16ea-c203-4219-bb6b-3b9c5a789348"), null, 3, null, null, new DateTime(2023, 8, 4, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(3802), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 184", 0, 3, "Ticket 184" },
                    { new Guid("e1350227-1437-4379-8e6e-e4f9c92d0cbc"), new Guid("c706c8cd-d2c5-400a-8aa8-3b537e7cb9c6"), null, 3, null, null, new DateTime(2023, 12, 6, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(9540), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 60", 2, 3, "Ticket 60" },
                    { new Guid("e3307c29-8357-417f-b3a2-fceb5e2a4a72"), new Guid("63092697-3fcc-4e41-9969-c783a15e768f"), null, 2, new DateTime(2023, 12, 29, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(8905), new DateTime(2023, 12, 28, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(8903), new DateTime(2023, 12, 27, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(8906), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 39", 2, 2, "Ticket 39" },
                    { new Guid("e3bd2c87-7823-4c3e-b8cb-2f2cb56c8dea"), new Guid("c7890c8e-8c49-481f-862d-0a7fdc855718"), null, 1, null, null, new DateTime(2023, 7, 17, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(4562), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 202", 0, 1, "Ticket 202" },
                    { new Guid("e47ce070-1995-4d5d-a29a-8905cff46abc"), new Guid("b609c356-cb1a-4aff-b8ff-13fcd0368559"), null, 1, null, null, new DateTime(2023, 8, 26, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(3002), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 162", 2, 1, "Ticket 162" },
                    { new Guid("e5422985-b1c2-45a3-a083-4cdbb4a77b89"), new Guid("d94f2c8e-c9b2-4bff-8c53-c86cc41b5a26"), null, 2, new DateTime(2023, 6, 24, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(5526), new DateTime(2023, 6, 23, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(5523), new DateTime(2023, 6, 22, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(5528), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 227", 1, 2, "Ticket 227" },
                    { new Guid("e6eca911-8c25-4b59-997b-3dda18e501e6"), new Guid("fb548886-ac24-4da8-9730-6e47711de250"), null, 2, new DateTime(2023, 6, 4, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(6354), new DateTime(2023, 6, 3, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(6352), new DateTime(2023, 6, 2, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(6358), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 247", 0, 2, "Ticket 247" },
                    { new Guid("e83f57e5-5f7e-41ce-8fc0-95fb43f4ac5c"), new Guid("e1c16561-23d0-410f-88c4-f687d0c550e3"), null, 0, new DateTime(2023, 11, 1, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(929), new DateTime(2023, 10, 31, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(927), new DateTime(2023, 10, 30, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(931), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 97", 0, 0, "Ticket 97" },
                    { new Guid("e862befe-9df6-4a9f-b432-48eb26454679"), new Guid("c681cf14-e1ff-4bfe-bacb-07eb14d4729d"), null, 1, null, null, new DateTime(2023, 11, 6, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(738), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 90", 2, 1, "Ticket 90" },
                    { new Guid("eb0ec2ca-0382-49b9-8c9b-5f3bccdf87e6"), new Guid("c2700fff-b0f8-4e3f-9450-3a0e8b523083"), null, 2, new DateTime(2023, 8, 7, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(3762), new DateTime(2023, 8, 6, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(3760), new DateTime(2023, 8, 5, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(3765), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 183", 2, 2, "Ticket 183" },
                    { new Guid("ec83dd8f-4b22-4c7e-8a63-123b906c4ebd"), new Guid("fe51f92f-b49f-4cfb-a98d-739e4f57503e"), null, 1, null, null, new DateTime(2024, 1, 9, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(8484), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 26", 1, 1, "Ticket 26" },
                    { new Guid("ecc1fe9c-1df1-436c-8a92-187d201a5ee9"), new Guid("fe51f92f-b49f-4cfb-a98d-739e4f57503e"), null, 1, null, null, new DateTime(2023, 8, 22, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(3110), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 166", 0, 1, "Ticket 166" },
                    { new Guid("ecf1d828-721f-4d98-8287-c0c47209bbe4"), new Guid("e3a2cf71-676b-4685-9fee-de6a276c9e35"), null, 3, null, null, new DateTime(2023, 7, 27, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(4136), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 192", 2, 3, "Ticket 192" },
                    { new Guid("ed096333-fc8f-42ff-a120-b8b80d9cfe3a"), new Guid("82d28eab-12af-4ad5-bc6f-ca265703df62"), null, 0, new DateTime(2023, 11, 29, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(9788), new DateTime(2023, 11, 28, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(9787), new DateTime(2023, 11, 27, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(9790), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 69", 2, 0, "Ticket 69" },
                    { new Guid("ed4c2c84-ce87-4945-a8f8-6e293c025f33"), new Guid("a50f16ea-c203-4219-bb6b-3b9c5a789348"), null, 3, null, null, new DateTime(2023, 12, 22, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(9044), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 44", 1, 3, "Ticket 44" },
                    { new Guid("edd772df-29fa-45ed-8111-3d32d6566292"), new Guid("2069b475-a494-48bb-8f1e-5077e9fc0c29"), null, 0, new DateTime(2023, 11, 9, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(711), new DateTime(2023, 11, 8, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(710), new DateTime(2023, 11, 7, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(713), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 89", 1, 0, "Ticket 89" },
                    { new Guid("ee524f40-9fa4-41ef-84a6-c365cb2be4cd"), new Guid("87f80008-d28d-4881-986c-34fecb6c962a"), null, 0, new DateTime(2023, 8, 17, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(3298), new DateTime(2023, 8, 16, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(3296), new DateTime(2023, 8, 15, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(3299), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 173", 1, 0, "Ticket 173" },
                    { new Guid("f18e0d1b-cb7a-4e58-812c-f6ce644e52e9"), new Guid("b450cb81-decd-48e5-96c6-109074706ea9"), null, 2, new DateTime(2023, 11, 15, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(231), new DateTime(2023, 11, 14, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(230), new DateTime(2023, 11, 13, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(233), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 83", 1, 2, "Ticket 83" },
                    { new Guid("f1d83101-29c8-44fd-8bcf-a8d93a349e9c"), new Guid("6246fb7d-c2f9-425b-a185-98350aa9da3e"), null, 0, new DateTime(2023, 7, 4, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(5131), new DateTime(2023, 7, 3, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(5128), new DateTime(2023, 7, 2, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(5134), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 217", 0, 0, "Ticket 217" },
                    { new Guid("f1de93db-eabd-47a1-8a3e-41a8cced0354"), new Guid("2c48c132-38e2-43d7-bf83-2e78dc062be2"), null, 2, new DateTime(2023, 7, 14, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(4692), new DateTime(2023, 7, 13, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(4690), new DateTime(2023, 7, 12, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(4693), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 207", 2, 2, "Ticket 207" },
                    { new Guid("f30e3b7a-4f26-4ae9-9f6b-28b0cd71e17c"), new Guid("d8cd2124-fd7a-46ad-8feb-0df7b06c412e"), null, 3, null, null, new DateTime(2023, 7, 3, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(5095), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 216", 2, 3, "Ticket 216" },
                    { new Guid("f5a528ad-a755-41ad-8b9e-ae83045d420f"), new Guid("bbae71f3-a79a-4426-9918-bdb57bb58806"), null, 0, new DateTime(2023, 6, 26, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(5451), new DateTime(2023, 6, 25, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(5449), new DateTime(2023, 6, 24, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(5454), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 225", 2, 0, "Ticket 225" },
                    { new Guid("f6bf61e6-2bcb-4166-bdab-5f477c677501"), new Guid("b2f07e84-6d04-42ab-8f9a-5c95ba4329c9"), null, 2, new DateTime(2023, 7, 2, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(5212), new DateTime(2023, 7, 1, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(5209), new DateTime(2023, 6, 30, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(5215), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 219", 2, 2, "Ticket 219" },
                    { new Guid("f8ddaa23-a519-4d2c-9d35-3f0e6b6f6e94"), new Guid("63092697-3fcc-4e41-9969-c783a15e768f"), null, 2, new DateTime(2023, 8, 11, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(3617), new DateTime(2023, 8, 10, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(3616), new DateTime(2023, 8, 9, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(3619), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 179", 1, 2, "Ticket 179" },
                    { new Guid("f91bfab7-0175-4a9e-bd86-291efa067693"), new Guid("a5c99e92-69fc-4047-bcaf-f2ce22dfffbd"), null, 1, null, null, new DateTime(2023, 7, 29, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(4058), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 190", 0, 1, "Ticket 190" },
                    { new Guid("fc371362-fe16-4280-b6c3-1b8184658e8c"), new Guid("b65a3653-e9ea-43b7-83a6-715eeb60b5bd"), null, 3, null, null, new DateTime(2023, 9, 5, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(2664), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 152", 1, 3, "Ticket 152" },
                    { new Guid("fd36f5a8-a5d6-46db-a0d0-73f41b3e9c1f"), new Guid("2069b475-a494-48bb-8f1e-5077e9fc0c29"), null, 2, new DateTime(2024, 1, 18, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(8283), new DateTime(2024, 1, 17, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(8282), new DateTime(2024, 1, 16, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(8285), "auth0|65b7dee72e02f54da98cd265", "Description for Ticket 19", 0, 2, "Ticket 19" },
                    { new Guid("ff0c42fd-3ed2-4639-8dbe-ae33fdc68f52"), new Guid("c420b659-be54-4a28-b131-5344c7ac07f3"), null, 1, null, null, new DateTime(2023, 7, 1, 15, 13, 12, 225, DateTimeKind.Local).AddTicks(5170), "auth0|65a4f8d7364ff592a0792a42", "Description for Ticket 218", 1, 1, "Ticket 218" }
                });

            migrationBuilder.InsertData(
                table: "WorkItems",
                columns: new[] { "WorkItemId", "AssetId", "Category", "CreatedAt", "CreatorUserID", "Description", "Priority", "Status", "Title" },
                values: new object[,]
                {
                    { new Guid("00274522-6779-4670-aa2e-1b5e398cbada"), new Guid("bbae71f3-a79a-4426-9918-bdb57bb58806"), 2, new DateTime(2023, 4, 15, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(3722), null, "Description for WorkItem 295", 0, 0, "WorkItem 295" },
                    { new Guid("0066af0c-85b9-45b8-a320-b8f6b6f4871a"), new Guid("b65a3653-e9ea-43b7-83a6-715eeb60b5bd"), 1, new DateTime(2023, 6, 27, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(1532), null, "Description for WorkItem 222", 2, 2, "WorkItem 222" },
                    { new Guid("020197b7-0f27-40ca-b596-7fee9c2936c1"), new Guid("fb548886-ac24-4da8-9730-6e47711de250"), 2, new DateTime(2023, 10, 20, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(8327), null, "Description for WorkItem 107", 1, 1, "WorkItem 107" },
                    { new Guid("04d64fc0-737b-4d36-a1d6-dd288a6f88aa"), new Guid("c414843f-d8ec-4c9e-a0be-9d9d2443f8bb"), 0, new DateTime(2023, 4, 9, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(3875), null, "Description for WorkItem 301", 0, 0, "WorkItem 301" },
                    { new Guid("04dd1eef-d934-48a9-82ef-197d7d965573"), new Guid("e706872a-f6f2-4693-b445-2dd37bc26b0e"), 2, new DateTime(2023, 9, 26, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(8995), null, "Description for WorkItem 131", 1, 1, "WorkItem 131" },
                    { new Guid("056af4b4-6dbf-4f86-a312-d7352ba2cb06"), new Guid("8567c826-3630-44ef-9744-6f70d74b335f"), 1, new DateTime(2023, 3, 27, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(4258), null, "Description for WorkItem 314", 1, 1, "WorkItem 314" },
                    { new Guid("06b30e34-fcaf-4aa1-b0ba-9735652e1ac2"), new Guid("2e7474a0-28d5-4c9e-b838-61db8782cc92"), 2, new DateTime(2023, 10, 12, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(8593), null, "Description for WorkItem 115", 0, 0, "WorkItem 115" },
                    { new Guid("06f4d678-58d4-4e62-b1b0-7fd3bec1b601"), new Guid("1ad928bb-4612-4cbd-b795-f4d9e05d0b73"), 1, new DateTime(2023, 9, 3, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(9641), null, "Description for WorkItem 154", 0, 0, "WorkItem 154" },
                    { new Guid("096406ff-e537-4633-9025-39af89c2991f"), new Guid("6246fb7d-c2f9-425b-a185-98350aa9da3e"), 0, new DateTime(2023, 11, 19, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(7508), null, "Description for WorkItem 77", 1, 1, "WorkItem 77" },
                    { new Guid("0a0c4470-4ba9-439a-a3dd-1cd23b718b44"), new Guid("c681cf14-e1ff-4bfe-bacb-07eb14d4729d"), 3, new DateTime(2023, 4, 10, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(3850), null, "Description for WorkItem 300", 2, 2, "WorkItem 300" },
                    { new Guid("0ae39b71-3c93-4586-a114-8bd1fee62b9e"), new Guid("1df30ac9-724a-4ace-a5bd-cbb579e7ca2c"), 0, new DateTime(2023, 1, 19, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(6176), null, "Description for WorkItem 381", 2, 2, "WorkItem 381" },
                    { new Guid("0af4cd0c-8196-40e8-9e88-361003f23f39"), new Guid("2069b475-a494-48bb-8f1e-5077e9fc0c29"), 0, new DateTime(2023, 6, 20, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(1855), null, "Description for WorkItem 229", 0, 0, "WorkItem 229" },
                    { new Guid("0b0f7114-7fd2-4aed-a7b9-799aa35fd865"), new Guid("84376aa5-1faa-43c2-bdc9-2a5d90a4cabc"), 2, new DateTime(2023, 12, 31, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(6259), null, "Description for WorkItem 35", 1, 1, "WorkItem 35" },
                    { new Guid("0b58a7fb-dc38-4d66-ab3a-9cafb3ad7273"), new Guid("be6f513b-8ff6-422e-902e-4adb53186100"), 2, new DateTime(2023, 11, 21, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(7454), null, "Description for WorkItem 75", 2, 2, "WorkItem 75" },
                    { new Guid("0b6c05a9-f8df-47ad-83fe-6b518f7b5ddd"), new Guid("c27af898-42af-4eff-bf56-a4377b6e09a6"), 3, new DateTime(2024, 1, 31, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(5330), null, "Description for WorkItem 4", 0, 0, "WorkItem 4" },
                    { new Guid("0b8b0283-cc85-45bc-ba45-1bef6ca17b42"), new Guid("84376aa5-1faa-43c2-bdc9-2a5d90a4cabc"), 0, new DateTime(2023, 10, 22, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(8278), null, "Description for WorkItem 105", 2, 2, "WorkItem 105" },
                    { new Guid("0d01acb6-ed11-42b5-9cc4-b1b2faebeef6"), new Guid("05f24951-e653-4a66-bf9c-a7fc974790af"), 3, new DateTime(2024, 1, 7, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(6084), null, "Description for WorkItem 28", 0, 0, "WorkItem 28" },
                    { new Guid("0d1790c4-3942-40a8-b32a-2799c3ad9e63"), new Guid("6246fb7d-c2f9-425b-a185-98350aa9da3e"), 2, new DateTime(2024, 1, 28, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(5502), null, "Description for WorkItem 7", 0, 0, "WorkItem 7" },
                    { new Guid("0d4463e6-ecf2-41ff-bbf0-ad23bc7675f4"), new Guid("b450cb81-decd-48e5-96c6-109074706ea9"), 0, new DateTime(2023, 4, 17, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(3673), null, "Description for WorkItem 293", 1, 1, "WorkItem 293" },
                    { new Guid("0d58bd0e-118b-42a3-b4de-64d6bbdc3db0"), new Guid("d044d52f-3014-43fb-9b7a-6e27125b6c47"), 2, new DateTime(2023, 12, 19, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(6562), null, "Description for WorkItem 47", 1, 1, "WorkItem 47" },
                    { new Guid("0d93413d-ea17-4399-b682-39728b5efc32"), new Guid("c420b659-be54-4a28-b131-5344c7ac07f3"), 1, new DateTime(2023, 7, 1, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(1430), null, "Description for WorkItem 218", 1, 1, "WorkItem 218" },
                    { new Guid("0d9b7335-fc5b-4773-b60f-4f1bd2882e0e"), new Guid("6246fb7d-c2f9-425b-a185-98350aa9da3e"), 0, new DateTime(2023, 7, 2, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(1405), null, "Description for WorkItem 217", 0, 0, "WorkItem 217" },
                    { new Guid("0dcfe411-3434-4579-9250-959d6e5251ea"), new Guid("e0c1a02a-4bc4-48cb-9556-a617e2c84023"), 2, new DateTime(2023, 10, 28, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(8125), null, "Description for WorkItem 99", 2, 2, "WorkItem 99" },
                    { new Guid("0dea9af7-5032-4d51-b92e-1af6a465b599"), new Guid("e3a2cf71-676b-4685-9fee-de6a276c9e35"), 1, new DateTime(2023, 5, 18, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(2823), null, "Description for WorkItem 262", 0, 0, "WorkItem 262" },
                    { new Guid("0dff5e84-a5e6-42d2-8190-e447256b96f9"), new Guid("b2f07e84-6d04-42ab-8f9a-5c95ba4329c9"), 0, new DateTime(2024, 1, 26, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(5549), null, "Description for WorkItem 9", 2, 2, "WorkItem 9" },
                    { new Guid("0eba909c-8826-4435-8f48-d039f2f858aa"), new Guid("63092697-3fcc-4e41-9969-c783a15e768f"), 2, new DateTime(2023, 3, 22, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(4386), null, "Description for WorkItem 319", 0, 0, "WorkItem 319" },
                    { new Guid("0fabf1e9-6d71-470c-b2c9-a85e4816345f"), new Guid("2e7474a0-28d5-4c9e-b838-61db8782cc92"), 2, new DateTime(2023, 5, 25, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(2576), null, "Description for WorkItem 255", 2, 2, "WorkItem 255" },
                    { new Guid("10e5a9f6-32fe-4c87-9cd7-61cf96dc8611"), new Guid("c681cf14-e1ff-4bfe-bacb-07eb14d4729d"), 3, new DateTime(2024, 1, 15, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(5841), null, "Description for WorkItem 20", 1, 1, "WorkItem 20" },
                    { new Guid("1119bd10-4014-4a33-9e4a-8cf945687e2c"), new Guid("fb548886-ac24-4da8-9730-6e47711de250"), 0, new DateTime(2023, 12, 29, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(6314), null, "Description for WorkItem 37", 0, 0, "WorkItem 37" },
                    { new Guid("11608204-5fff-44d6-acaa-36dbfdf2393d"), new Guid("ac8bf8bb-b749-4e5f-803e-8ad389810274"), 1, new DateTime(2023, 8, 10, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(372), null, "Description for WorkItem 178", 0, 0, "WorkItem 178" },
                    { new Guid("11dd19d1-e254-4f4b-87b1-f5baeea457e1"), new Guid("fb548886-ac24-4da8-9730-6e47711de250"), 0, new DateTime(2023, 3, 24, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(4338), null, "Description for WorkItem 317", 1, 1, "WorkItem 317" },
                    { new Guid("1249e2a5-0bf9-4068-b9c4-c31dd0ad6161"), new Guid("2e7474a0-28d5-4c9e-b838-61db8782cc92"), 2, new DateTime(2023, 1, 5, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(6524), null, "Description for WorkItem 395", 1, 1, "WorkItem 395" },
                    { new Guid("13532568-80b7-45a9-bfd0-c8502e513c46"), new Guid("2918bf65-e859-411e-85cf-4dee00fe7f73"), 0, new DateTime(2023, 4, 29, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(3301), null, "Description for WorkItem 281", 1, 1, "WorkItem 281" },
                    { new Guid("13c11abb-70a0-44f6-ab20-1df2a10ced33"), new Guid("ac8bf8bb-b749-4e5f-803e-8ad389810274"), 1, new DateTime(2023, 12, 28, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(6338), null, "Description for WorkItem 38", 1, 1, "WorkItem 38" },
                    { new Guid("14da849f-0971-4f0e-ab32-799c2dd25266"), new Guid("bcdc779a-4026-43d3-83d9-aee099e3c6f5"), 0, new DateTime(2023, 7, 30, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(656), null, "Description for WorkItem 189", 2, 2, "WorkItem 189" },
                    { new Guid("1629497b-eef7-4f47-8f1b-307ea94e1b8f"), new Guid("be6f513b-8ff6-422e-902e-4adb53186100"), 2, new DateTime(2023, 7, 4, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(1357), null, "Description for WorkItem 215", 1, 1, "WorkItem 215" },
                    { new Guid("166fef83-8a0c-4051-ac97-a029245a1fba"), new Guid("0186db38-7113-4142-a1e1-9dee806daeb2"), 2, new DateTime(2024, 1, 12, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(5916), null, "Description for WorkItem 23", 1, 1, "WorkItem 23" },
                    { new Guid("176a6f54-1ecd-44f2-83a4-fd0e494f3e25"), new Guid("c0fe8045-0fce-443f-aadb-845cf60f63e2"), 3, new DateTime(2023, 11, 28, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(7281), null, "Description for WorkItem 68", 1, 1, "WorkItem 68" },
                    { new Guid("18714ebd-cb5a-49ed-803c-5e19bb37965e"), new Guid("81faf274-2a02-4780-82ef-53dbf6359121"), 0, new DateTime(2023, 7, 22, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(859), null, "Description for WorkItem 197", 1, 1, "WorkItem 197" },
                    { new Guid("1890b4fa-47c0-454b-8e24-8d600ddf9556"), new Guid("81faf274-2a02-4780-82ef-53dbf6359121"), 2, new DateTime(2023, 9, 30, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(8895), null, "Description for WorkItem 127", 0, 0, "WorkItem 127" },
                    { new Guid("199a5ded-c2df-4b46-af76-2f11087f1d1a"), new Guid("d8cd2124-fd7a-46ad-8feb-0df7b06c412e"), 3, new DateTime(2023, 11, 20, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(7484), null, "Description for WorkItem 76", 0, 0, "WorkItem 76" },
                    { new Guid("1a5a523c-dc4f-4fce-aa18-4981aa515c4a"), new Guid("4fb29223-242d-434d-9437-2927203619ea"), 1, new DateTime(2023, 1, 10, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(6401), null, "Description for WorkItem 390", 2, 2, "WorkItem 390" },
                    { new Guid("1a81a92e-3f5c-4dbb-b46e-3efb25b18636"), new Guid("05f24951-e653-4a66-bf9c-a7fc974790af"), 1, new DateTime(2023, 6, 11, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(2082), null, "Description for WorkItem 238", 0, 0, "WorkItem 238" },
                    { new Guid("1adbe246-4441-4521-813c-44f04691e6f1"), new Guid("b2f07e84-6d04-42ab-8f9a-5c95ba4329c9"), 2, new DateTime(2023, 6, 30, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(1453), null, "Description for WorkItem 219", 2, 2, "WorkItem 219" },
                    { new Guid("1e0e05ad-c8e8-46cf-b4a0-790b78940fee"), new Guid("8b6d3ded-2544-419e-ade6-a9fa14d48681"), 1, new DateTime(2023, 3, 3, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(4957), null, "Description for WorkItem 338", 1, 1, "WorkItem 338" },
                    { new Guid("1f452251-1333-457d-b620-8d4f29ac79c4"), new Guid("c27af898-42af-4eff-bf56-a4377b6e09a6"), 3, new DateTime(2023, 4, 26, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(3442), null, "Description for WorkItem 284", 1, 1, "WorkItem 284" },
                    { new Guid("1f80429f-de08-4363-99e9-72ded19328ab"), new Guid("ec1afd48-270c-4eae-9b2f-1938e675a234"), 1, new DateTime(2023, 11, 2, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(8000), null, "Description for WorkItem 94", 0, 0, "WorkItem 94" },
                    { new Guid("1fd28826-e1f3-40f2-9225-c1e684066ba2"), new Guid("c420b659-be54-4a28-b131-5344c7ac07f3"), 1, new DateTime(2023, 2, 11, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(5509), null, "Description for WorkItem 358", 0, 0, "WorkItem 358" },
                    { new Guid("201bfd80-79d8-4d91-a0a6-9e6ffa357dff"), new Guid("d94f2c8e-c9b2-4bff-8c53-c86cc41b5a26"), 0, new DateTime(2024, 1, 18, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(5758), null, "Description for WorkItem 17", 1, 1, "WorkItem 17" },
                    { new Guid("21e7236b-09e7-41d9-a620-084950372123"), new Guid("bcdc779a-4026-43d3-83d9-aee099e3c6f5"), 2, new DateTime(2023, 5, 21, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(2743), null, "Description for WorkItem 259", 0, 0, "WorkItem 259" },
                    { new Guid("226a686d-6014-4f8c-8b78-be3f2760a464"), new Guid("cad7fa03-3cbb-46f0-ae04-daa69d04a856"), 1, new DateTime(2023, 11, 26, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(7332), null, "Description for WorkItem 70", 0, 0, "WorkItem 70" },
                    { new Guid("2277f968-bc13-4caf-a1f4-5e1889225679"), new Guid("c0fe8045-0fce-443f-aadb-845cf60f63e2"), 1, new DateTime(2023, 5, 2, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(3227), null, "Description for WorkItem 278", 1, 1, "WorkItem 278" },
                    { new Guid("22d035b3-290c-4b54-8e32-dd81d70d5ffd"), new Guid("82d28eab-12af-4ad5-bc6f-ca265703df62"), 0, new DateTime(2023, 7, 10, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(1205), null, "Description for WorkItem 209", 1, 1, "WorkItem 209" },
                    { new Guid("235c18e9-06dd-44c0-8b23-fa1e5c603538"), new Guid("c420b659-be54-4a28-b131-5344c7ac07f3"), 3, new DateTime(2023, 4, 22, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(3543), null, "Description for WorkItem 288", 2, 2, "WorkItem 288" },
                    { new Guid("239dfef3-c58a-4929-ae57-e05539033664"), new Guid("82d28eab-12af-4ad5-bc6f-ca265703df62"), 2, new DateTime(2023, 5, 1, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(3252), null, "Description for WorkItem 279", 2, 2, "WorkItem 279" },
                    { new Guid("2495f995-c510-4d1a-b75b-e69bfe4ef746"), new Guid("d8f28655-14fd-4a8c-8276-d4a4b7d8e952"), 2, new DateTime(2023, 9, 6, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(9568), null, "Description for WorkItem 151", 0, 0, "WorkItem 151" },
                    { new Guid("26704d99-897d-47c0-bc74-673bc0435817"), new Guid("e0a864e1-5e4e-48db-8bdd-64cbbefa5046"), 3, new DateTime(2023, 10, 27, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(8155), null, "Description for WorkItem 100", 0, 0, "WorkItem 100" },
                    { new Guid("2698e504-b583-40b9-b324-3a8391ba20ea"), new Guid("2e7474a0-28d5-4c9e-b838-61db8782cc92"), 0, new DateTime(2023, 8, 3, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(553), null, "Description for WorkItem 185", 1, 1, "WorkItem 185" },
                    { new Guid("26d66ea8-c714-4304-bb15-7b091fe4d5f5"), new Guid("b609c356-cb1a-4aff-b8ff-13fcd0368559"), 3, new DateTime(2023, 11, 4, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(7951), null, "Description for WorkItem 92", 1, 1, "WorkItem 92" },
                    { new Guid("27c1ffe3-90d9-4b77-94ed-4c6e71c5e120"), new Guid("a1eaf5d0-9721-4d6b-976d-10a18744d0bf"), 3, new DateTime(2023, 9, 1, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(9757), null, "Description for WorkItem 156", 2, 2, "WorkItem 156" },
                    { new Guid("28bcdaa4-a000-4881-b980-eb414e48a1e2"), new Guid("0186db38-7113-4142-a1e1-9dee806daeb2"), 0, new DateTime(2023, 1, 27, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(5887), null, "Description for WorkItem 373", 0, 0, "WorkItem 373" },
                    { new Guid("294ff628-31f5-4dda-8732-84eb4372d364"), new Guid("d8f28655-14fd-4a8c-8276-d4a4b7d8e952"), 2, new DateTime(2023, 4, 19, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(3617), null, "Description for WorkItem 291", 2, 2, "WorkItem 291" },
                    { new Guid("29cdb81f-3908-4b70-9054-3a4f64c5815d"), new Guid("bbae71f3-a79a-4426-9918-bdb57bb58806"), 0, new DateTime(2023, 2, 4, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(5684), null, "Description for WorkItem 365", 1, 1, "WorkItem 365" },
                    { new Guid("2a398d1a-d3af-43ce-8cc7-cc41b989978d"), new Guid("c7890c8e-8c49-481f-862d-0a7fdc855718"), 1, new DateTime(2023, 2, 27, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(5061), null, "Description for WorkItem 342", 2, 2, "WorkItem 342" },
                    { new Guid("2a68054f-2134-4ec2-8f9a-1f8e0d87c840"), new Guid("1df30ac9-724a-4ace-a5bd-cbb579e7ca2c"), 2, new DateTime(2023, 3, 30, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(4184), null, "Description for WorkItem 311", 1, 1, "WorkItem 311" },
                    { new Guid("2b3ddd32-e163-48e5-b630-d031a6be8716"), new Guid("a44ff748-7c83-4bc6-808a-4e35747cae73"), 0, new DateTime(2023, 3, 8, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(4836), null, "Description for WorkItem 333", 2, 2, "WorkItem 333" },
                    { new Guid("2be76daa-0242-4359-833b-00fc4c96883c"), new Guid("b2b37aff-c7d5-412a-9559-891792fe803d"), 1, new DateTime(2023, 10, 9, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(8672), null, "Description for WorkItem 118", 0, 0, "WorkItem 118" },
                    { new Guid("2cd9151d-c94f-4258-91dc-8f8b5390e632"), new Guid("8ab8775a-fe1e-42bb-84a8-0664c8726d13"), 0, new DateTime(2023, 5, 19, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(2798), null, "Description for WorkItem 261", 2, 2, "WorkItem 261" },
                    { new Guid("2dbd02b3-965a-444d-8aec-b619929235cc"), new Guid("ec1afd48-270c-4eae-9b2f-1938e675a234"), 3, new DateTime(2023, 8, 24, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(9959), null, "Description for WorkItem 164", 1, 1, "WorkItem 164" },
                    { new Guid("2e0420dc-bd4a-4c8e-9884-989e08449596"), new Guid("bbae71f3-a79a-4426-9918-bdb57bb58806"), 2, new DateTime(2023, 9, 2, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(9726), null, "Description for WorkItem 155", 1, 1, "WorkItem 155" },
                    { new Guid("2e3292a4-4780-4274-80df-35b5e8ee3173"), new Guid("6ccb1d85-1dbd-465d-a425-f22ec75c4b85"), 0, new DateTime(2023, 9, 24, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(9111), null, "Description for WorkItem 133", 0, 0, "WorkItem 133" },
                    { new Guid("2e8f7740-abf2-4521-a6d9-8b4951ef576f"), new Guid("e89c0901-ee96-4e2d-a2f4-f558336276e9"), 3, new DateTime(2023, 9, 21, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(9186), null, "Description for WorkItem 136", 0, 0, "WorkItem 136" },
                    { new Guid("2ec8f860-6329-4544-8a3a-51abf86e4bbc"), new Guid("a1eaf5d0-9721-4d6b-976d-10a18744d0bf"), 3, new DateTime(2024, 1, 19, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(5734), null, "Description for WorkItem 16", 0, 0, "WorkItem 16" },
                    { new Guid("2f0e5432-b50a-493a-bf5d-919a4fb4d49c"), new Guid("2448cee6-eacf-4b8c-b35f-47e61b43d7cf"), 0, new DateTime(2023, 3, 20, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(4436), null, "Description for WorkItem 321", 2, 2, "WorkItem 321" },
                    { new Guid("315dd608-9778-4e0d-a265-fe603530160b"), new Guid("fe51f92f-b49f-4cfb-a98d-739e4f57503e"), 3, new DateTime(2023, 1, 24, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(6048), null, "Description for WorkItem 376", 0, 0, "WorkItem 376" },
                    { new Guid("3210e13b-33a9-4288-977c-9da195191518"), new Guid("b884b195-1fa6-434a-b3a0-af1ac1de7c60"), 2, new DateTime(2023, 3, 2, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(4982), null, "Description for WorkItem 339", 2, 2, "WorkItem 339" },
                    { new Guid("324b080e-ffc0-4e63-90f7-f77e5bcbf97c"), new Guid("87f80008-d28d-4881-986c-34fecb6c962a"), 0, new DateTime(2024, 1, 2, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(6205), null, "Description for WorkItem 33", 2, 2, "WorkItem 33" },
                    { new Guid("32622a76-a823-4b9c-8b2e-e150fd25e23d"), new Guid("a50f16ea-c203-4219-bb6b-3b9c5a789348"), 3, new DateTime(2023, 8, 4, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(528), null, "Description for WorkItem 184", 0, 0, "WorkItem 184" },
                    { new Guid("3280208b-7883-4684-9f49-471543084270"), new Guid("a50f16ea-c203-4219-bb6b-3b9c5a789348"), 3, new DateTime(2023, 3, 17, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(4516), null, "Description for WorkItem 324", 2, 2, "WorkItem 324" },
                    { new Guid("32b6831c-5caf-4f63-b42c-f35eaa83d14c"), new Guid("bcdc779a-4026-43d3-83d9-aee099e3c6f5"), 0, new DateTime(2023, 12, 17, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(6709), null, "Description for WorkItem 49", 0, 0, "WorkItem 49" },
                    { new Guid("3315e88c-e2c5-4146-a405-7725574d8d25"), new Guid("1ad928bb-4612-4cbd-b795-f4d9e05d0b73"), 3, new DateTime(2023, 2, 5, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(5659), null, "Description for WorkItem 364", 0, 0, "WorkItem 364" },
                    { new Guid("342ccf5d-5747-4cd5-a6e4-9e0a1cefb0c0"), new Guid("94e65e9f-ade5-41ea-b16d-73b1823d0d7a"), 1, new DateTime(2023, 12, 24, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(6435), null, "Description for WorkItem 42", 2, 2, "WorkItem 42" },
                    { new Guid("342e0e11-feb2-476c-aac6-e5e691626f5d"), new Guid("d044d52f-3014-43fb-9b7a-6e27125b6c47"), 0, new DateTime(2023, 5, 23, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(2623), null, "Description for WorkItem 257", 1, 1, "WorkItem 257" },
                    { new Guid("35c96b87-99aa-4364-abc3-1ccab16384b8"), new Guid("c8ad0841-4379-47b7-b33e-dd6e0806faeb"), 3, new DateTime(2023, 6, 29, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(1484), null, "Description for WorkItem 220", 0, 0, "WorkItem 220" },
                    { new Guid("3697126e-a6b6-4a7d-b479-b84f08c089f0"), new Guid("cad7fa03-3cbb-46f0-ae04-daa69d04a856"), 3, new DateTime(2023, 9, 17, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(9292), null, "Description for WorkItem 140", 1, 1, "WorkItem 140" },
                    { new Guid("36b958c4-a68e-4a38-910e-7d1802ab084b"), new Guid("2918bf65-e859-411e-85cf-4dee00fe7f73"), 2, new DateTime(2023, 11, 25, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(7357), null, "Description for WorkItem 71", 1, 1, "WorkItem 71" },
                    { new Guid("36f3ad56-bf22-4f6e-8254-12e13a2814d6"), new Guid("d8cd2124-fd7a-46ad-8feb-0df7b06c412e"), 1, new DateTime(2024, 1, 29, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(5475), null, "Description for WorkItem 6", 2, 2, "WorkItem 6" },
                    { new Guid("3756340b-c93f-434f-b940-c89df27ee4f3"), new Guid("bbae71f3-a79a-4426-9918-bdb57bb58806"), 2, new DateTime(2024, 1, 20, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(5709), null, "Description for WorkItem 15", 2, 2, "WorkItem 15" },
                    { new Guid("3777fccf-cc40-41f3-bcca-21e98c0e37fb"), new Guid("b65a3653-e9ea-43b7-83a6-715eeb60b5bd"), 3, new DateTime(2023, 4, 18, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(3648), null, "Description for WorkItem 292", 0, 0, "WorkItem 292" },
                    { new Guid("3797fc94-6de9-439a-8304-e281b48c0a52"), new Guid("63092697-3fcc-4e41-9969-c783a15e768f"), 0, new DateTime(2023, 1, 11, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(6377), null, "Description for WorkItem 389", 1, 1, "WorkItem 389" },
                    { new Guid("383beebd-60e0-49b5-a4c7-1fa58c2b5b79"), new Guid("a1eaf5d0-9721-4d6b-976d-10a18744d0bf"), 3, new DateTime(2023, 4, 14, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(3747), null, "Description for WorkItem 296", 1, 1, "WorkItem 296" },
                    { new Guid("3860d915-6743-4d6e-8de1-b022dd7646a1"), new Guid("ec1afd48-270c-4eae-9b2f-1938e675a234"), 3, new DateTime(2024, 1, 11, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(5941), null, "Description for WorkItem 24", 2, 2, "WorkItem 24" },
                    { new Guid("386aa0c8-a16a-4e00-9d5b-e99bf0406fe6"), new Guid("2918bf65-e859-411e-85cf-4dee00fe7f73"), 0, new DateTime(2023, 9, 16, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(9316), null, "Description for WorkItem 141", 2, 2, "WorkItem 141" },
                    { new Guid("3883cc0c-3de5-4d99-9e87-da8ac3b9fefc"), new Guid("65aa9a7c-d370-42ae-bfd4-c73044970716"), 3, new DateTime(2023, 5, 24, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(2599), null, "Description for WorkItem 256", 0, 0, "WorkItem 256" },
                    { new Guid("39790876-34df-4d5b-92de-99050ad68a9a"), new Guid("2e7474a0-28d5-4c9e-b838-61db8782cc92"), 0, new DateTime(2023, 3, 16, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(4539), null, "Description for WorkItem 325", 0, 0, "WorkItem 325" },
                    { new Guid("3a633fc4-33d6-4e30-b9dd-1f1fe7eec93e"), new Guid("4fb29223-242d-434d-9437-2927203619ea"), 3, new DateTime(2023, 3, 21, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(4410), null, "Description for WorkItem 320", 1, 1, "WorkItem 320" },
                    { new Guid("3ada162a-5b77-4fa4-bcdf-e09ff91275f7"), new Guid("b2f07e84-6d04-42ab-8f9a-5c95ba4329c9"), 2, new DateTime(2023, 11, 17, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(7556), null, "Description for WorkItem 79", 0, 0, "WorkItem 79" },
                    { new Guid("3b46f5f9-149b-41d4-a1de-a4851c815493"), new Guid("fb548886-ac24-4da8-9730-6e47711de250"), 2, new DateTime(2023, 6, 2, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(2311), null, "Description for WorkItem 247", 0, 0, "WorkItem 247" },
                    { new Guid("3b8786fa-ae3a-4d6a-9b69-ec548206991c"), new Guid("81faf274-2a02-4780-82ef-53dbf6359121"), 2, new DateTime(2023, 5, 13, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(2944), null, "Description for WorkItem 267", 2, 2, "WorkItem 267" },
                    { new Guid("3cf36022-48bc-499f-8dea-4a7ae2fac61d"), new Guid("05f24951-e653-4a66-bf9c-a7fc974790af"), 3, new DateTime(2023, 8, 20, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(57), null, "Description for WorkItem 168", 2, 2, "WorkItem 168" },
                    { new Guid("40db7cba-ee70-4d23-8b86-011dddd65b93"), new Guid("734b123e-c217-49d1-8478-561ba7973cab"), 1, new DateTime(2023, 6, 7, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(2183), null, "Description for WorkItem 242", 1, 1, "WorkItem 242" },
                    { new Guid("41a38dde-84b0-4b1c-b644-7a9801f2218c"), new Guid("a1eaf5d0-9721-4d6b-976d-10a18744d0bf"), 1, new DateTime(2023, 6, 23, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(1776), null, "Description for WorkItem 226", 0, 0, "WorkItem 226" },
                    { new Guid("41f4d36a-b74a-4b4b-aad6-533a604635e6"), new Guid("c420b659-be54-4a28-b131-5344c7ac07f3"), 3, new DateTime(2023, 9, 9, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(9493), null, "Description for WorkItem 148", 0, 0, "WorkItem 148" },
                    { new Guid("41f91d78-d799-4c7b-b9e6-9d25f7fa8840"), new Guid("2c48c132-38e2-43d7-bf83-2e78dc062be2"), 2, new DateTime(2023, 7, 12, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(1156), null, "Description for WorkItem 207", 2, 2, "WorkItem 207" },
                    { new Guid("431f58d0-45b7-4293-b960-dca5e2d96cb5"), new Guid("d8f28655-14fd-4a8c-8276-d4a4b7d8e952"), 0, new DateTime(2023, 2, 8, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(5581), null, "Description for WorkItem 361", 0, 0, "WorkItem 361" },
                    { new Guid("437656cf-7854-4c4e-851a-d2189053128e"), new Guid("a44ff748-7c83-4bc6-808a-4e35747cae73"), 0, new DateTime(2023, 12, 13, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(6811), null, "Description for WorkItem 53", 1, 1, "WorkItem 53" },
                    { new Guid("43c651d7-837f-413d-a25d-43f3f7295ce7"), new Guid("63092697-3fcc-4e41-9969-c783a15e768f"), 0, new DateTime(2023, 10, 18, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(8381), null, "Description for WorkItem 109", 0, 0, "WorkItem 109" },
                    { new Guid("43c99d57-375a-4113-a4cd-1a43386f6ffa"), new Guid("c7890c8e-8c49-481f-862d-0a7fdc855718"), 1, new DateTime(2023, 12, 4, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(7038), null, "Description for WorkItem 62", 1, 1, "WorkItem 62" },
                    { new Guid("43cfc99e-fb26-467f-b04a-15c7ae4113ce"), new Guid("cad7fa03-3cbb-46f0-ae04-daa69d04a856"), 3, new DateTime(2023, 4, 30, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(3276), null, "Description for WorkItem 280", 0, 0, "WorkItem 280" },
                    { new Guid("446b6b31-abe9-41ad-80c6-bcbcb6c194f3"), new Guid("2069b475-a494-48bb-8f1e-5077e9fc0c29"), 2, new DateTime(2024, 1, 16, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(5810), null, "Description for WorkItem 19", 0, 0, "WorkItem 19" },
                    { new Guid("446e7b1e-7684-468a-8e97-9e39dfd97797"), new Guid("d8cd2124-fd7a-46ad-8feb-0df7b06c412e"), 3, new DateTime(2023, 2, 13, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(5460), null, "Description for WorkItem 356", 1, 1, "WorkItem 356" },
                    { new Guid("450a0c7c-475b-4e5f-90f9-10b85f656e3b"), new Guid("c681cf14-e1ff-4bfe-bacb-07eb14d4729d"), 1, new DateTime(2023, 1, 30, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(5806), null, "Description for WorkItem 370", 0, 0, "WorkItem 370" },
                    { new Guid("4515606e-cda1-4710-8903-d01b9870e341"), new Guid("8b6d3ded-2544-419e-ade6-a9fa14d48681"), 3, new DateTime(2023, 9, 29, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(8920), null, "Description for WorkItem 128", 1, 1, "WorkItem 128" },
                    { new Guid("468aa9e2-d39c-4347-a4f9-e801bb47c3f2"), new Guid("c681cf14-e1ff-4bfe-bacb-07eb14d4729d"), 3, new DateTime(2023, 8, 28, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(9855), null, "Description for WorkItem 160", 0, 0, "WorkItem 160" },
                    { new Guid("48156b26-8979-46f7-a924-8093219623d7"), new Guid("e8ddd435-2464-4c9d-a43f-388b1975f901"), 1, new DateTime(2023, 6, 3, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(2287), null, "Description for WorkItem 246", 2, 2, "WorkItem 246" },
                    { new Guid("488a517c-0d66-4ad9-ac6e-c5642df56ad0"), new Guid("071c3cc5-02b0-432f-8f41-ba673225e1c8"), 1, new DateTime(2023, 7, 25, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(778), null, "Description for WorkItem 194", 1, 1, "WorkItem 194" },
                    { new Guid("4aaf4435-e8aa-4b2e-bd8c-433b4b1bed42"), new Guid("a911f2dc-8c99-42ea-a817-d1b909d08b9e"), 3, new DateTime(2023, 7, 23, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(834), null, "Description for WorkItem 196", 0, 0, "WorkItem 196" },
                    { new Guid("4bac4888-e6db-4048-9853-f35c0018fd17"), new Guid("b2b37aff-c7d5-412a-9559-891792fe803d"), 1, new DateTime(2023, 1, 2, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(6689), null, "Description for WorkItem 398", 1, 1, "WorkItem 398" },
                    { new Guid("4c181510-b402-4bf1-a4dc-67f417135546"), new Guid("a44ff748-7c83-4bc6-808a-4e35747cae73"), 2, new DateTime(2023, 10, 4, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(8792), null, "Description for WorkItem 123", 2, 2, "WorkItem 123" },
                    { new Guid("4dbd766e-0096-4786-88eb-1d3dd292e17b"), new Guid("b65a3653-e9ea-43b7-83a6-715eeb60b5bd"), 1, new DateTime(2023, 11, 14, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(7630), null, "Description for WorkItem 82", 0, 0, "WorkItem 82" },
                    { new Guid("4e04f705-bd09-48fc-aff8-428d57ae3fcb"), new Guid("c27af898-42af-4eff-bf56-a4377b6e09a6"), 1, new DateTime(2023, 2, 15, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(5404), null, "Description for WorkItem 354", 2, 2, "WorkItem 354" },
                    { new Guid("4e0def21-8b27-455f-a6a6-0706c3c8d620"), new Guid("b2b37aff-c7d5-412a-9559-891792fe803d"), 3, new DateTime(2023, 7, 31, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(632), null, "Description for WorkItem 188", 1, 1, "WorkItem 188" },
                    { new Guid("4e5ef874-4766-45a5-9717-1c68c00da7ff"), new Guid("63092697-3fcc-4e41-9969-c783a15e768f"), 2, new DateTime(2023, 8, 9, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(399), null, "Description for WorkItem 179", 1, 1, "WorkItem 179" },
                    { new Guid("4eac4aa7-26b2-4a90-b43a-6f9f67634f9c"), new Guid("e706872a-f6f2-4693-b445-2dd37bc26b0e"), 0, new DateTime(2023, 2, 28, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(5036), null, "Description for WorkItem 341", 1, 1, "WorkItem 341" },
                    { new Guid("4f0e1649-9639-4856-8991-da31125a1e69"), new Guid("1ad928bb-4612-4cbd-b795-f4d9e05d0b73"), 3, new DateTime(2023, 11, 12, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(7685), null, "Description for WorkItem 84", 2, 2, "WorkItem 84" },
                    { new Guid("4fd20eaf-260a-468c-88c0-9d5b653becf3"), new Guid("8ab8775a-fe1e-42bb-84a8-0664c8726d13"), 2, new DateTime(2023, 12, 15, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(6758), null, "Description for WorkItem 51", 2, 2, "WorkItem 51" },
                    { new Guid("50635bc7-48d6-44d9-ac51-4a60f52b79a3"), new Guid("0d968db3-960d-4fda-8ebb-adc1a3a50999"), 0, new DateTime(2023, 7, 6, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(1308), null, "Description for WorkItem 213", 2, 2, "WorkItem 213" },
                    { new Guid("50e0104f-67d0-465c-b577-98347b50287b"), new Guid("e8ddd435-2464-4c9d-a43f-388b1975f901"), 1, new DateTime(2023, 1, 14, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(6297), null, "Description for WorkItem 386", 1, 1, "WorkItem 386" },
                    { new Guid("5414dd47-5a42-4058-95b6-788af615e506"), new Guid("d17c1c16-81a0-419e-80b9-7d6c871843d6"), 3, new DateTime(2023, 2, 17, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(5352), null, "Description for WorkItem 352", 0, 0, "WorkItem 352" },
                    { new Guid("54e06e6f-1033-4790-b7cf-0e3ee2ff79dc"), new Guid("d17c1c16-81a0-419e-80b9-7d6c871843d6"), 3, new DateTime(2023, 11, 24, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(7381), null, "Description for WorkItem 72", 2, 2, "WorkItem 72" },
                    { new Guid("55a0b64d-ac3b-4ba7-a97e-42453eaff262"), new Guid("a911f2dc-8c99-42ea-a817-d1b909d08b9e"), 1, new DateTime(2023, 10, 1, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(8871), null, "Description for WorkItem 126", 2, 2, "WorkItem 126" },
                    { new Guid("55c019f2-c86a-4844-9d28-f566c162c8bb"), new Guid("8276c361-4485-4daa-b78b-a41b042d9dde"), 0, new DateTime(2023, 7, 14, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(1107), null, "Description for WorkItem 205", 0, 0, "WorkItem 205" },
                    { new Guid("55c93e6c-c2a2-4ce5-9cfa-ed4de1301143"), new Guid("05f24951-e653-4a66-bf9c-a7fc974790af"), 1, new DateTime(2023, 10, 29, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(8099), null, "Description for WorkItem 98", 1, 1, "WorkItem 98" },
                    { new Guid("55d6e6df-0dbf-4d4e-9651-48993adb5840"), new Guid("8567c826-3630-44ef-9744-6f70d74b335f"), 1, new DateTime(2023, 8, 14, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(210), null, "Description for WorkItem 174", 2, 2, "WorkItem 174" },
                    { new Guid("55e3d923-0509-4921-bbd9-4b953613b3b6"), new Guid("d8cd2124-fd7a-46ad-8feb-0df7b06c412e"), 1, new DateTime(2023, 4, 24, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(3491), null, "Description for WorkItem 286", 0, 0, "WorkItem 286" },
                    { new Guid("5628a8a8-a1aa-432e-9b51-591b12a846d2"), new Guid("be6f513b-8ff6-422e-902e-4adb53186100"), 0, new DateTime(2024, 1, 30, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(5446), null, "Description for WorkItem 5", 1, 1, "WorkItem 5" },
                    { new Guid("579546a8-3cc2-4ec6-b9b0-ba4c11a2d155"), new Guid("2069b475-a494-48bb-8f1e-5077e9fc0c29"), 0, new DateTime(2023, 11, 7, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(7808), null, "Description for WorkItem 89", 1, 1, "WorkItem 89" },
                    { new Guid("57ad8e2b-ce67-4080-becc-c4bfb215c5e8"), new Guid("c7890c8e-8c49-481f-862d-0a7fdc855718"), 3, new DateTime(2023, 9, 25, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(9087), null, "Description for WorkItem 132", 2, 2, "WorkItem 132" },
                    { new Guid("57f0de39-d91e-4648-8ef9-09130c194dc4"), new Guid("3f747ed7-980b-4e92-acdf-ec1102d4a0af"), 1, new DateTime(2023, 5, 6, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(3123), null, "Description for WorkItem 274", 0, 0, "WorkItem 274" },
                    { new Guid("57f768c3-f82d-40cb-a02e-189f8e932f03"), new Guid("e89c0901-ee96-4e2d-a2f4-f558336276e9"), 1, new DateTime(2023, 2, 23, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(5160), null, "Description for WorkItem 346", 0, 0, "WorkItem 346" },
                    { new Guid("58686e24-0f2c-47ce-843f-1b67423fe31d"), new Guid("b884b195-1fa6-434a-b3a0-af1ac1de7c60"), 0, new DateTime(2023, 5, 11, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(2999), null, "Description for WorkItem 269", 1, 1, "WorkItem 269" },
                    { new Guid("5881ae92-1013-4480-b56b-cb3f84f4af47"), new Guid("e0a864e1-5e4e-48db-8bdd-64cbbefa5046"), 1, new DateTime(2023, 3, 31, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(4161), null, "Description for WorkItem 310", 0, 0, "WorkItem 310" },
                    { new Guid("5894bc69-ae07-4ba7-974e-ceb3a7e845fd"), new Guid("be6f513b-8ff6-422e-902e-4adb53186100"), 2, new DateTime(2023, 2, 14, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(5429), null, "Description for WorkItem 355", 0, 0, "WorkItem 355" },
                    { new Guid("58e53507-c56d-412d-8b06-e51c67547c60"), new Guid("c0fe8045-0fce-443f-aadb-845cf60f63e2"), 1, new DateTime(2023, 9, 19, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(9236), null, "Description for WorkItem 138", 2, 2, "WorkItem 138" },
                    { new Guid("5910680a-cfd1-49ae-891f-0f15e0a59a7c"), new Guid("a50f16ea-c203-4219-bb6b-3b9c5a789348"), 1, new DateTime(2023, 1, 6, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(6500), null, "Description for WorkItem 394", 0, 0, "WorkItem 394" },
                    { new Guid("595fe7a4-5790-424e-8cea-a1deb88c419d"), new Guid("071c3cc5-02b0-432f-8f41-ba673225e1c8"), 1, new DateTime(2023, 12, 12, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(6836), null, "Description for WorkItem 54", 2, 2, "WorkItem 54" },
                    { new Guid("597c30fd-a873-4094-854e-df28643aa4ae"), new Guid("d044d52f-3014-43fb-9b7a-6e27125b6c47"), 0, new DateTime(2023, 1, 3, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(6579), null, "Description for WorkItem 397", 0, 0, "WorkItem 397" },
                    { new Guid("5984b5ee-e077-4302-81d7-09c44ee941e3"), new Guid("d17c1c16-81a0-419e-80b9-7d6c871843d6"), 3, new DateTime(2023, 7, 7, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(1282), null, "Description for WorkItem 212", 1, 1, "WorkItem 212" },
                    { new Guid("5a2e070e-1fe9-4fc7-beaa-3438ca82be33"), new Guid("b609c356-cb1a-4aff-b8ff-13fcd0368559"), 3, new DateTime(2023, 6, 17, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(1929), null, "Description for WorkItem 232", 0, 0, "WorkItem 232" },
                    { new Guid("5a565365-98b9-4e44-ab3b-9c72ccedb5a9"), new Guid("c8ad0841-4379-47b7-b33e-dd6e0806faeb"), 1, new DateTime(2023, 4, 20, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(3591), null, "Description for WorkItem 290", 1, 1, "WorkItem 290" },
                    { new Guid("5a748229-4529-4d4b-b860-bcb60f58344d"), new Guid("b609c356-cb1a-4aff-b8ff-13fcd0368559"), 1, new DateTime(2024, 1, 13, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(5891), null, "Description for WorkItem 22", 0, 0, "WorkItem 22" },
                    { new Guid("5ab59726-f5b6-485a-83d9-a8a7dc51cb90"), new Guid("798f6fce-fb81-402f-b76e-33049b892820"), 2, new DateTime(2023, 11, 1, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(8025), null, "Description for WorkItem 95", 1, 1, "WorkItem 95" },
                    { new Guid("5bb18418-87fb-46c3-af3f-70c01c9d76f5"), new Guid("2069b475-a494-48bb-8f1e-5077e9fc0c29"), 0, new DateTime(2023, 1, 31, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(5782), null, "Description for WorkItem 369", 2, 2, "WorkItem 369" },
                    { new Guid("5de2db75-31b8-49df-bb44-a828c5471126"), new Guid("87f80008-d28d-4881-986c-34fecb6c962a"), 0, new DateTime(2023, 8, 15, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(187), null, "Description for WorkItem 173", 1, 1, "WorkItem 173" },
                    { new Guid("5e15b07c-a3fb-4837-b454-68f20ca882b5"), new Guid("4fb29223-242d-434d-9437-2927203619ea"), 1, new DateTime(2023, 5, 30, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(2446), null, "Description for WorkItem 250", 0, 0, "WorkItem 250" },
                    { new Guid("5e1de1bb-5d31-4571-933e-4140ba369709"), new Guid("6ccb1d85-1dbd-465d-a425-f22ec75c4b85"), 2, new DateTime(2023, 2, 26, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(5086), null, "Description for WorkItem 343", 0, 0, "WorkItem 343" },
                    { new Guid("5e6b06e4-4722-43a4-b5ca-3f2ed134c65c"), new Guid("0186db38-7113-4142-a1e1-9dee806daeb2"), 0, new DateTime(2023, 11, 3, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(7976), null, "Description for WorkItem 93", 2, 2, "WorkItem 93" },
                    { new Guid("5e6d8637-b3d8-4554-a552-572d1dd3036f"), new Guid("bbae71f3-a79a-4426-9918-bdb57bb58806"), 0, new DateTime(2023, 11, 11, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(7708), null, "Description for WorkItem 85", 0, 0, "WorkItem 85" },
                    { new Guid("5fc83abf-9f14-4284-9eb8-5247d091ca78"), new Guid("e706872a-f6f2-4693-b445-2dd37bc26b0e"), 0, new DateTime(2023, 12, 5, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(7014), null, "Description for WorkItem 61", 0, 0, "WorkItem 61" },
                    { new Guid("6146a8b4-67fd-4a7d-bbbc-1b5eb2db9451"), new Guid("6246fb7d-c2f9-425b-a185-98350aa9da3e"), 2, new DateTime(2023, 4, 23, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(3516), null, "Description for WorkItem 287", 1, 1, "WorkItem 287" },
                    { new Guid("622dc443-2d06-4cd9-bb17-551b962bfe49"), new Guid("734b123e-c217-49d1-8478-561ba7973cab"), 3, new DateTime(2024, 1, 3, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(6181), null, "Description for WorkItem 32", 1, 1, "WorkItem 32" },
                    { new Guid("631be7e5-ac5b-4044-91b0-40aee8d80850"), new Guid("ac8bf8bb-b749-4e5f-803e-8ad389810274"), 1, new DateTime(2023, 3, 23, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(4362), null, "Description for WorkItem 318", 2, 2, "WorkItem 318" },
                    { new Guid("636b37df-a598-407a-821e-d2f916e4eb91"), new Guid("a911f2dc-8c99-42ea-a817-d1b909d08b9e"), 3, new DateTime(2023, 3, 5, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(4908), null, "Description for WorkItem 336", 2, 2, "WorkItem 336" },
                    { new Guid("645e1fdd-2255-40fc-b85e-515ecb84b61b"), new Guid("c8ad0841-4379-47b7-b33e-dd6e0806faeb"), 3, new DateTime(2023, 11, 16, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(7581), null, "Description for WorkItem 80", 1, 1, "WorkItem 80" },
                    { new Guid("64897f68-be95-4a4e-b42a-70dca56cb57a"), new Guid("fe51f92f-b49f-4cfb-a98d-739e4f57503e"), 3, new DateTime(2023, 6, 13, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(2032), null, "Description for WorkItem 236", 1, 1, "WorkItem 236" },
                    { new Guid("64b30c79-2c22-42a6-8eb6-12636a74b7e8"), new Guid("734b123e-c217-49d1-8478-561ba7973cab"), 3, new DateTime(2023, 8, 16, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(162), null, "Description for WorkItem 172", 0, 0, "WorkItem 172" },
                    { new Guid("65184fa4-8146-43ab-acb6-3df1dd30c492"), new Guid("c2700fff-b0f8-4e3f-9450-3a0e8b523083"), 2, new DateTime(2023, 3, 18, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(4485), null, "Description for WorkItem 323", 1, 1, "WorkItem 323" },
                    { new Guid("65fe4f07-6c31-45b0-8bfa-7d3397435a3a"), new Guid("c7890c8e-8c49-481f-862d-0a7fdc855718"), 1, new DateTime(2023, 7, 17, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(1027), null, "Description for WorkItem 202", 0, 0, "WorkItem 202" },
                    { new Guid("6818cbb2-8d88-421e-aa6a-a0cba054ddfb"), new Guid("c27af898-42af-4eff-bf56-a4377b6e09a6"), 1, new DateTime(2023, 11, 22, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(7430), null, "Description for WorkItem 74", 1, 1, "WorkItem 74" },
                    { new Guid("6917903b-bcd1-42f7-ab95-20bcdff6c564"), new Guid("6246fb7d-c2f9-425b-a185-98350aa9da3e"), 2, new DateTime(2023, 9, 10, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(9463), null, "Description for WorkItem 147", 2, 2, "WorkItem 147" },
                    { new Guid("69b4a0ba-8f2f-4531-a067-f65844b36adc"), new Guid("3f747ed7-980b-4e92-acdf-ec1102d4a0af"), 3, new DateTime(2023, 2, 25, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(5110), null, "Description for WorkItem 344", 1, 1, "WorkItem 344" },
                    { new Guid("6ac20a66-55c7-4cf9-8076-684420ecc365"), new Guid("87f80008-d28d-4881-986c-34fecb6c962a"), 2, new DateTime(2023, 10, 24, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(8229), null, "Description for WorkItem 103", 0, 0, "WorkItem 103" },
                    { new Guid("6b8dbe55-ea2b-414d-b43d-3990e06c05d8"), new Guid("e8ddd435-2464-4c9d-a43f-388b1975f901"), 3, new DateTime(2023, 3, 25, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(4314), null, "Description for WorkItem 316", 0, 0, "WorkItem 316" },
                    { new Guid("6c5ddc94-4bab-410e-88e0-4eb23ff30eac"), new Guid("d8f28655-14fd-4a8c-8276-d4a4b7d8e952"), 0, new DateTime(2023, 6, 28, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(1507), null, "Description for WorkItem 221", 1, 1, "WorkItem 221" },
                    { new Guid("6c97aa50-73f7-421e-998d-ce143594e51a"), new Guid("8ab8775a-fe1e-42bb-84a8-0664c8726d13"), 0, new DateTime(2023, 10, 6, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(8744), null, "Description for WorkItem 121", 0, 0, "WorkItem 121" },
                    { new Guid("6df6a8f4-536b-4051-94ab-e5c2a62fb567"), new Guid("ec1afd48-270c-4eae-9b2f-1938e675a234"), 1, new DateTime(2023, 1, 26, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(5911), null, "Description for WorkItem 374", 1, 1, "WorkItem 374" },
                    { new Guid("6eb8b968-3b5e-4c43-a7ce-0b9dbd15fa4d"), new Guid("c420b659-be54-4a28-b131-5344c7ac07f3"), 1, new DateTime(2023, 11, 18, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(7532), null, "Description for WorkItem 78", 2, 2, "WorkItem 78" },
                    { new Guid("6ef355f9-1ad2-4f12-bdc1-842835c9f52e"), new Guid("e0c1a02a-4bc4-48cb-9556-a617e2c84023"), 0, new DateTime(2023, 8, 19, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(82), null, "Description for WorkItem 169", 0, 0, "WorkItem 169" },
                    { new Guid("6f0a0ad0-6763-4000-bd57-87c15507cb03"), new Guid("c414843f-d8ec-4c9e-a0be-9d9d2443f8bb"), 2, new DateTime(2023, 11, 5, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(7919), null, "Description for WorkItem 91", 0, 0, "WorkItem 91" },
                    { new Guid("6f245011-eeea-445a-ad76-33b00dda25df"), new Guid("65aa9a7c-d370-42ae-bfd4-c73044970716"), 3, new DateTime(2023, 10, 11, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(8623), null, "Description for WorkItem 116", 1, 1, "WorkItem 116" },
                    { new Guid("70dba8e8-7f96-4db2-ae79-8d14b1c529a5"), new Guid("ac8bf8bb-b749-4e5f-803e-8ad389810274"), 3, new DateTime(2023, 6, 1, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(2398), null, "Description for WorkItem 248", 1, 1, "WorkItem 248" },
                    { new Guid("724827b0-8f75-4248-ada7-97e092e03e5e"), new Guid("2448cee6-eacf-4b8c-b35f-47e61b43d7cf"), 0, new DateTime(2023, 8, 7, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(454), null, "Description for WorkItem 181", 0, 0, "WorkItem 181" },
                    { new Guid("7300ef28-baad-4c18-8109-c695785f960f"), new Guid("d94f2c8e-c9b2-4bff-8c53-c86cc41b5a26"), 2, new DateTime(2023, 2, 2, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(5732), null, "Description for WorkItem 367", 0, 0, "WorkItem 367" },
                    { new Guid("7466a019-e51f-48b0-834d-c7d4978bc83b"), new Guid("e706872a-f6f2-4693-b445-2dd37bc26b0e"), 2, new DateTime(2023, 5, 9, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(3048), null, "Description for WorkItem 271", 0, 0, "WorkItem 271" },
                    { new Guid("74b0890c-f96e-45bb-8c91-53e73f651cc0"), new Guid("b884b195-1fa6-434a-b3a0-af1ac1de7c60"), 2, new DateTime(2023, 7, 20, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(909), null, "Description for WorkItem 199", 0, 0, "WorkItem 199" },
                    { new Guid("74e662d2-878c-4f39-b1b1-117447419145"), new Guid("e1c16561-23d0-410f-88c4-f687d0c550e3"), 2, new DateTime(2023, 8, 21, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(32), null, "Description for WorkItem 167", 1, 1, "WorkItem 167" },
                    { new Guid("76cc983f-46ab-435b-9636-98100db4a565"), new Guid("8567c826-3630-44ef-9744-6f70d74b335f"), 3, new DateTime(2023, 6, 5, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(2238), null, "Description for WorkItem 244", 0, 0, "WorkItem 244" },
                    { new Guid("79905e01-57e1-4ddc-b566-eaca3b2ae35d"), new Guid("2448cee6-eacf-4b8c-b35f-47e61b43d7cf"), 0, new DateTime(2023, 12, 25, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(6411), null, "Description for WorkItem 41", 1, 1, "WorkItem 41" },
                    { new Guid("7a418217-4f10-49e5-af8b-766b9a7db121"), new Guid("cad7fa03-3cbb-46f0-ae04-daa69d04a856"), 1, new DateTime(2023, 2, 19, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(5266), null, "Description for WorkItem 350", 1, 1, "WorkItem 350" },
                    { new Guid("7aabbe74-be86-47bc-b6fa-0025e5ddcbc5"), new Guid("63092697-3fcc-4e41-9969-c783a15e768f"), 0, new DateTime(2023, 5, 31, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(2422), null, "Description for WorkItem 249", 2, 2, "WorkItem 249" },
                    { new Guid("7ba235e7-6826-42c6-8346-573b95df8cd3"), new Guid("071c3cc5-02b0-432f-8f41-ba673225e1c8"), 1, new DateTime(2023, 3, 7, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(4861), null, "Description for WorkItem 334", 0, 0, "WorkItem 334" },
                    { new Guid("7bf5fb7e-830e-44ef-858c-c1f625fa7bac"), new Guid("c706c8cd-d2c5-400a-8aa8-3b537e7cb9c6"), 1, new DateTime(2023, 5, 10, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(3023), null, "Description for WorkItem 270", 2, 2, "WorkItem 270" },
                    { new Guid("7df7b948-adcf-4142-bfec-0af6749e84dd"), new Guid("a5c99e92-69fc-4047-bcaf-f2ce22dfffbd"), 3, new DateTime(2022, 12, 31, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(6738), null, "Description for WorkItem 400", 0, 0, "WorkItem 400" },
                    { new Guid("7e20e104-49c7-4580-b3c3-b07d20e3a898"), new Guid("2c48c132-38e2-43d7-bf83-2e78dc062be2"), 2, new DateTime(2023, 2, 22, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(5184), null, "Description for WorkItem 347", 1, 1, "WorkItem 347" },
                    { new Guid("7eab2bf3-d421-4e9c-879d-4380cb932ce3"), new Guid("b609c356-cb1a-4aff-b8ff-13fcd0368559"), 3, new DateTime(2023, 1, 28, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(5861), null, "Description for WorkItem 372", 2, 2, "WorkItem 372" },
                    { new Guid("7ee7a27a-2eb3-480c-825d-978c47a15fb4"), new Guid("b450cb81-decd-48e5-96c6-109074706ea9"), 0, new DateTime(2023, 9, 4, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(9616), null, "Description for WorkItem 153", 2, 2, "WorkItem 153" },
                    { new Guid("7f738a52-8b29-49fc-850e-68f5a31e8896"), new Guid("d8f28655-14fd-4a8c-8276-d4a4b7d8e952"), 2, new DateTime(2024, 1, 24, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(5603), null, "Description for WorkItem 11", 1, 1, "WorkItem 11" },
                    { new Guid("7fba2447-841a-41dc-b16f-7db6447af801"), new Guid("e0c1a02a-4bc4-48cb-9556-a617e2c84023"), 0, new DateTime(2023, 4, 1, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(4137), null, "Description for WorkItem 309", 2, 2, "WorkItem 309" },
                    { new Guid("80913a3a-374a-4928-bada-bcdcc17ffc43"), new Guid("c420b659-be54-4a28-b131-5344c7ac07f3"), 3, new DateTime(2024, 1, 27, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(5525), null, "Description for WorkItem 8", 1, 1, "WorkItem 8" },
                    { new Guid("81b5be4e-1da8-4dd5-8098-26f6f6fdad44"), new Guid("d044d52f-3014-43fb-9b7a-6e27125b6c47"), 0, new DateTime(2023, 10, 10, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(8648), null, "Description for WorkItem 117", 2, 2, "WorkItem 117" },
                    { new Guid("82e63caf-efcc-4134-953f-cfde75603c01"), new Guid("e688f1d2-81f7-4b8f-812c-06edd73834a0"), 2, new DateTime(2023, 12, 11, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(6860), null, "Description for WorkItem 55", 0, 0, "WorkItem 55" },
                    { new Guid("83e41a5d-7a67-42e4-bd41-01536e5528d0"), new Guid("0d968db3-960d-4fda-8ebb-adc1a3a50999"), 0, new DateTime(2023, 11, 23, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(7405), null, "Description for WorkItem 73", 0, 0, "WorkItem 73" },
                    { new Guid("84c0623b-cf4d-4e74-b6fa-69029db0933a"), new Guid("c8ad0841-4379-47b7-b33e-dd6e0806faeb"), 1, new DateTime(2024, 1, 25, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(5579), null, "Description for WorkItem 10", 0, 0, "WorkItem 10" },
                    { new Guid("851129b0-b2d9-4fda-b3ec-cefa55a5d319"), new Guid("be6f513b-8ff6-422e-902e-4adb53186100"), 0, new DateTime(2023, 4, 25, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(3467), null, "Description for WorkItem 285", 2, 2, "WorkItem 285" },
                    { new Guid("85155185-b17b-41da-aa17-b267c6f10784"), new Guid("e0c1a02a-4bc4-48cb-9556-a617e2c84023"), 2, new DateTime(2023, 6, 10, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(2107), null, "Description for WorkItem 239", 1, 1, "WorkItem 239" },
                    { new Guid("86f91357-24d3-4758-abb9-3d028622fbef"), new Guid("e3a2cf71-676b-4685-9fee-de6a276c9e35"), 3, new DateTime(2023, 7, 27, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(730), null, "Description for WorkItem 192", 2, 2, "WorkItem 192" },
                    { new Guid("87d022d2-9996-4ed4-bc57-17360d958c1f"), new Guid("1df30ac9-724a-4ace-a5bd-cbb579e7ca2c"), 0, new DateTime(2023, 6, 8, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(2157), null, "Description for WorkItem 241", 0, 0, "WorkItem 241" },
                    { new Guid("87e4ef4a-9172-46fb-b249-80e1ccc53a6e"), new Guid("87f80008-d28d-4881-986c-34fecb6c962a"), 2, new DateTime(2023, 6, 6, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(2208), null, "Description for WorkItem 243", 2, 2, "WorkItem 243" },
                    { new Guid("8814a4b7-101d-4dba-9f36-f70582b938d5"), new Guid("e89c0901-ee96-4e2d-a2f4-f558336276e9"), 3, new DateTime(2023, 5, 4, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(3178), null, "Description for WorkItem 276", 2, 2, "WorkItem 276" },
                    { new Guid("8836d170-eadf-4694-9e90-5fc2ff52393f"), new Guid("bcdc779a-4026-43d3-83d9-aee099e3c6f5"), 2, new DateTime(2023, 10, 8, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(8696), null, "Description for WorkItem 119", 1, 1, "WorkItem 119" },
                    { new Guid("886cdef3-cc84-4aee-9a0b-a868f80e7ac8"), new Guid("c0fe8045-0fce-443f-aadb-845cf60f63e2"), 3, new DateTime(2023, 7, 11, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(1180), null, "Description for WorkItem 208", 0, 0, "WorkItem 208" },
                    { new Guid("8882e419-ae78-4256-917f-283457920410"), new Guid("a5c99e92-69fc-4047-bcaf-f2ce22dfffbd"), 1, new DateTime(2023, 3, 11, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(4758), null, "Description for WorkItem 330", 2, 2, "WorkItem 330" },
                    { new Guid("88f75e65-aee7-459b-a520-5ae58d7db047"), new Guid("82d28eab-12af-4ad5-bc6f-ca265703df62"), 0, new DateTime(2023, 11, 27, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(7307), null, "Description for WorkItem 69", 2, 2, "WorkItem 69" },
                    { new Guid("895defd0-abaf-45a2-8045-f52dcd2ca82b"), new Guid("a1eaf5d0-9721-4d6b-976d-10a18744d0bf"), 1, new DateTime(2023, 2, 3, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(5707), null, "Description for WorkItem 366", 2, 2, "WorkItem 366" },
                    { new Guid("8a4a905b-9d54-43ef-82b6-4144e7deb477"), new Guid("84376aa5-1faa-43c2-bdc9-2a5d90a4cabc"), 2, new DateTime(2023, 3, 26, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(4283), null, "Description for WorkItem 315", 2, 2, "WorkItem 315" },
                    { new Guid("8a84391c-3eb8-4a3d-b4ba-0339f1d55e6d"), new Guid("a911f2dc-8c99-42ea-a817-d1b909d08b9e"), 3, new DateTime(2023, 12, 10, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(6884), null, "Description for WorkItem 56", 1, 1, "WorkItem 56" },
                    { new Guid("8b086f92-3cdf-4df5-acc1-4b21f3844501"), new Guid("4fb29223-242d-434d-9437-2927203619ea"), 1, new DateTime(2023, 10, 17, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(8406), null, "Description for WorkItem 110", 1, 1, "WorkItem 110" },
                    { new Guid("8b8552bb-6fb7-44d1-bd93-3e4e30616932"), new Guid("6ccb1d85-1dbd-465d-a425-f22ec75c4b85"), 2, new DateTime(2023, 12, 3, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(7061), null, "Description for WorkItem 63", 2, 2, "WorkItem 63" },
                    { new Guid("8b9a2f2c-c1c5-42bb-9ce2-fc22afa29ffe"), new Guid("1df30ac9-724a-4ace-a5bd-cbb579e7ca2c"), 2, new DateTime(2023, 8, 17, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(131), null, "Description for WorkItem 171", 2, 2, "WorkItem 171" },
                    { new Guid("8c2e0277-530d-4469-9864-545173569ea6"), new Guid("a50f16ea-c203-4219-bb6b-3b9c5a789348"), 1, new DateTime(2023, 5, 26, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(2551), null, "Description for WorkItem 254", 1, 1, "WorkItem 254" },
                    { new Guid("8c79a4ef-4d0b-478e-b7a0-91c61367179b"), new Guid("3f747ed7-980b-4e92-acdf-ec1102d4a0af"), 3, new DateTime(2023, 7, 15, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(1081), null, "Description for WorkItem 204", 2, 2, "WorkItem 204" },
                    { new Guid("8caf2e9a-f328-4313-8c26-7cc4a8e7eda5"), new Guid("a5c99e92-69fc-4047-bcaf-f2ce22dfffbd"), 1, new DateTime(2023, 7, 29, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(680), null, "Description for WorkItem 190", 0, 0, "WorkItem 190" },
                    { new Guid("8cd1d299-a456-4135-90c6-854e2a1a860f"), new Guid("c8ad0841-4379-47b7-b33e-dd6e0806faeb"), 1, new DateTime(2023, 9, 7, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(9543), null, "Description for WorkItem 150", 2, 2, "WorkItem 150" },
                    { new Guid("8dd4131b-5afb-439e-afd8-0f40d20777d6"), new Guid("63092697-3fcc-4e41-9969-c783a15e768f"), 2, new DateTime(2023, 12, 27, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(6362), null, "Description for WorkItem 39", 2, 2, "WorkItem 39" },
                    { new Guid("8e8aceb0-e599-49a6-b920-e27b780cfdf1"), new Guid("3f747ed7-980b-4e92-acdf-ec1102d4a0af"), 1, new DateTime(2023, 9, 23, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(9136), null, "Description for WorkItem 134", 1, 1, "WorkItem 134" },
                    { new Guid("8ec8adcb-0489-426f-8604-44e59a8971e7"), new Guid("05f24951-e653-4a66-bf9c-a7fc974790af"), 1, new DateTime(2023, 1, 22, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(6098), null, "Description for WorkItem 378", 2, 2, "WorkItem 378" },
                    { new Guid("90232ca4-582f-4948-bcb0-4ffe777a6806"), new Guid("05f24951-e653-4a66-bf9c-a7fc974790af"), 3, new DateTime(2023, 4, 2, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(4113), null, "Description for WorkItem 308", 1, 1, "WorkItem 308" },
                    { new Guid("904bb8ab-eb00-4ae3-ab74-ea0e423d382e"), new Guid("e1c16561-23d0-410f-88c4-f687d0c550e3"), 2, new DateTime(2023, 4, 3, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(4083), null, "Description for WorkItem 307", 0, 0, "WorkItem 307" },
                    { new Guid("908ebe8b-2a7b-4240-a27a-c202eebd0368"), new Guid("b2b37aff-c7d5-412a-9559-891792fe803d"), 3, new DateTime(2023, 12, 18, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(6685), null, "Description for WorkItem 48", 2, 2, "WorkItem 48" },
                    { new Guid("913963b9-252d-47b3-ab73-12f33476e8ac"), new Guid("2918bf65-e859-411e-85cf-4dee00fe7f73"), 0, new DateTime(2024, 2, 3, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(5224), null, "Description for WorkItem 1", 0, 0, "WorkItem 1" },
                    { new Guid("92302cad-c9e6-4f0b-becd-4ecfe3d9b2b1"), new Guid("e8ddd435-2464-4c9d-a43f-388b1975f901"), 3, new DateTime(2023, 12, 30, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(6289), null, "Description for WorkItem 36", 2, 2, "WorkItem 36" },
                    { new Guid("92a40eb3-8e14-4fff-b86a-499968fbb354"), new Guid("be6f513b-8ff6-422e-902e-4adb53186100"), 0, new DateTime(2023, 9, 12, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(9414), null, "Description for WorkItem 145", 0, 0, "WorkItem 145" },
                    { new Guid("9319896a-cc8e-47a8-a1cb-82c0d36f55b0"), new Guid("8567c826-3630-44ef-9744-6f70d74b335f"), 1, new DateTime(2024, 1, 1, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(6235), null, "Description for WorkItem 34", 0, 0, "WorkItem 34" },
                    { new Guid("93d71e88-2be5-4f96-b2e0-5cd885d3e014"), new Guid("fe51f92f-b49f-4cfb-a98d-739e4f57503e"), 1, new DateTime(2023, 8, 22, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(8), null, "Description for WorkItem 166", 0, 0, "WorkItem 166" },
                    { new Guid("94139b15-56e2-433f-9e7d-1021e72f51b2"), new Guid("b65a3653-e9ea-43b7-83a6-715eeb60b5bd"), 3, new DateTime(2023, 9, 5, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(9592), null, "Description for WorkItem 152", 1, 1, "WorkItem 152" },
                    { new Guid("94c0a277-be58-4ae3-b661-76f21e40207d"), new Guid("e3a2cf71-676b-4685-9fee-de6a276c9e35"), 1, new DateTime(2023, 10, 5, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(8768), null, "Description for WorkItem 122", 1, 1, "WorkItem 122" },
                    { new Guid("94dc80f0-aba5-4e48-ac03-dcae07fa78d3"), new Guid("e1c16561-23d0-410f-88c4-f687d0c550e3"), 0, new DateTime(2023, 10, 30, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(8075), null, "Description for WorkItem 97", 0, 0, "WorkItem 97" },
                    { new Guid("9629c21e-dfd9-4bbb-8614-be41a30735b2"), new Guid("94e65e9f-ade5-41ea-b16d-73b1823d0d7a"), 1, new DateTime(2023, 3, 19, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(4461), null, "Description for WorkItem 322", 0, 0, "WorkItem 322" },
                    { new Guid("9668c1f5-f61d-440f-b2b1-82e41ecf5326"), new Guid("c2700fff-b0f8-4e3f-9450-3a0e8b523083"), 0, new DateTime(2023, 5, 27, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(2527), null, "Description for WorkItem 253", 0, 0, "WorkItem 253" },
                    { new Guid("9670e5d3-9890-4f23-95a0-7d2b2164d228"), new Guid("1ad928bb-4612-4cbd-b795-f4d9e05d0b73"), 1, new DateTime(2023, 4, 16, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(3697), null, "Description for WorkItem 294", 2, 2, "WorkItem 294" },
                    { new Guid("97ea3c81-acb5-4503-9543-e64273c6cdfe"), new Guid("8276c361-4485-4daa-b78b-a41b042d9dde"), 0, new DateTime(2023, 12, 1, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(7111), null, "Description for WorkItem 65", 1, 1, "WorkItem 65" },
                    { new Guid("97fd09c3-7a17-4dce-bed2-fc12fd62e482"), new Guid("fb548886-ac24-4da8-9730-6e47711de250"), 2, new DateTime(2023, 1, 13, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(6320), null, "Description for WorkItem 387", 2, 2, "WorkItem 387" },
                    { new Guid("996ce3ff-4f18-43a8-9034-45e7befabac9"), new Guid("6ccb1d85-1dbd-465d-a425-f22ec75c4b85"), 2, new DateTime(2023, 7, 16, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(1051), null, "Description for WorkItem 203", 1, 1, "WorkItem 203" },
                    { new Guid("9a7f4e95-40ae-4ff9-afb6-ab9da06adb04"), new Guid("94e65e9f-ade5-41ea-b16d-73b1823d0d7a"), 3, new DateTime(2023, 10, 15, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(8455), null, "Description for WorkItem 112", 0, 0, "WorkItem 112" },
                    { new Guid("9af5aa24-ad68-402a-8d9e-a8c32cd06184"), new Guid("e0a864e1-5e4e-48db-8bdd-64cbbefa5046"), 1, new DateTime(2024, 1, 5, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(6132), null, "Description for WorkItem 30", 2, 2, "WorkItem 30" },
                    { new Guid("9b3fe80f-07d0-4375-9b6e-d1a619e8c285"), new Guid("2918bf65-e859-411e-85cf-4dee00fe7f73"), 2, new DateTime(2023, 2, 18, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(5291), null, "Description for WorkItem 351", 2, 2, "WorkItem 351" },
                    { new Guid("9b49fa98-c944-4254-bcc9-b2e287468cb8"), new Guid("ac8bf8bb-b749-4e5f-803e-8ad389810274"), 3, new DateTime(2023, 1, 12, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(6352), null, "Description for WorkItem 388", 0, 0, "WorkItem 388" },
                    { new Guid("9cd9c4c3-c94c-4680-9034-2779e5013ec7"), new Guid("c706c8cd-d2c5-400a-8aa8-3b537e7cb9c6"), 3, new DateTime(2023, 12, 6, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(6989), null, "Description for WorkItem 60", 2, 2, "WorkItem 60" },
                    { new Guid("9e8a3d8f-62c8-4b10-b2e7-7a2f5d39afd7"), new Guid("c706c8cd-d2c5-400a-8aa8-3b537e7cb9c6"), 1, new DateTime(2023, 9, 27, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(8971), null, "Description for WorkItem 130", 0, 0, "WorkItem 130" },
                    { new Guid("9f6382a8-ec6d-4f8f-b7ad-4fa83730f24e"), new Guid("ec1afd48-270c-4eae-9b2f-1938e675a234"), 3, new DateTime(2023, 4, 6, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(3949), null, "Description for WorkItem 304", 0, 0, "WorkItem 304" },
                    { new Guid("9f8e4b2f-e1df-465f-960c-1c26d0aa1817"), new Guid("c414843f-d8ec-4c9e-a0be-9d9d2443f8bb"), 2, new DateTime(2023, 6, 18, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(1904), null, "Description for WorkItem 231", 2, 2, "WorkItem 231" },
                    { new Guid("9ff0514d-0e55-4bf4-b2a8-f4d6f9b00770"), new Guid("fe51f92f-b49f-4cfb-a98d-739e4f57503e"), 1, new DateTime(2023, 4, 4, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(4058), null, "Description for WorkItem 306", 2, 2, "WorkItem 306" },
                    { new Guid("a2522926-1fbc-4db8-83c2-7923a7be88a2"), new Guid("ac8bf8bb-b749-4e5f-803e-8ad389810274"), 3, new DateTime(2023, 10, 19, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(8357), null, "Description for WorkItem 108", 2, 2, "WorkItem 108" },
                    { new Guid("a254365a-1e7e-4be7-9f54-99fc0d530e52"), new Guid("a5c99e92-69fc-4047-bcaf-f2ce22dfffbd"), 3, new DateTime(2023, 10, 7, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(8721), null, "Description for WorkItem 120", 2, 2, "WorkItem 120" },
                    { new Guid("a254f2bf-b71a-4678-8e4b-3838f26982b2"), new Guid("4fb29223-242d-434d-9437-2927203619ea"), 3, new DateTime(2023, 8, 8, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(429), null, "Description for WorkItem 180", 2, 2, "WorkItem 180" },
                    { new Guid("a27288fe-ef5f-4861-9e47-d2a546a04678"), new Guid("e688f1d2-81f7-4b8f-812c-06edd73834a0"), 2, new DateTime(2023, 7, 24, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(803), null, "Description for WorkItem 195", 2, 2, "WorkItem 195" },
                    { new Guid("a28f6e01-0a4c-41fb-9fb2-0995f54b82ba"), new Guid("798f6fce-fb81-402f-b76e-33049b892820"), 0, new DateTime(2024, 1, 10, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(5965), null, "Description for WorkItem 25", 0, 0, "WorkItem 25" },
                    { new Guid("a2c2b5a5-7abb-4755-8846-a09762b00467"), new Guid("b450cb81-decd-48e5-96c6-109074706ea9"), 2, new DateTime(2023, 6, 26, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(1557), null, "Description for WorkItem 223", 0, 0, "WorkItem 223" },
                    { new Guid("a43e81e6-cd3c-451d-802c-78f52b46b415"), new Guid("a5c99e92-69fc-4047-bcaf-f2ce22dfffbd"), 3, new DateTime(2023, 5, 20, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(2773), null, "Description for WorkItem 260", 1, 1, "WorkItem 260" },
                    { new Guid("a45833dc-275d-46be-9951-e1e6fead2eb0"), new Guid("e8ddd435-2464-4c9d-a43f-388b1975f901"), 1, new DateTime(2023, 10, 21, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(8303), null, "Description for WorkItem 106", 0, 0, "WorkItem 106" },
                    { new Guid("a51dc3d2-2e24-43c3-8213-99855d719851"), new Guid("0d968db3-960d-4fda-8ebb-adc1a3a50999"), 2, new DateTime(2023, 4, 27, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(3411), null, "Description for WorkItem 283", 0, 0, "WorkItem 283" },
                    { new Guid("a6688d56-4c9a-4a16-bf65-b195036e67f1"), new Guid("c706c8cd-d2c5-400a-8aa8-3b537e7cb9c6"), 3, new DateTime(2023, 7, 19, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(934), null, "Description for WorkItem 200", 1, 1, "WorkItem 200" },
                    { new Guid("a675faa5-bc04-4e0e-bf9c-38eefce4ccc6"), new Guid("a44ff748-7c83-4bc6-808a-4e35747cae73"), 2, new DateTime(2023, 5, 17, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(2847), null, "Description for WorkItem 263", 1, 1, "WorkItem 263" },
                    { new Guid("a6b607cb-6d62-41da-b99b-4ff2f85af88e"), new Guid("bcdc779a-4026-43d3-83d9-aee099e3c6f5"), 0, new DateTime(2023, 3, 12, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(4734), null, "Description for WorkItem 329", 1, 1, "WorkItem 329" },
                    { new Guid("a6b86e2d-8872-4487-ada8-36fbf8f440a8"), new Guid("798f6fce-fb81-402f-b76e-33049b892820"), 0, new DateTime(2023, 4, 5, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(3974), null, "Description for WorkItem 305", 1, 1, "WorkItem 305" },
                    { new Guid("a6f4e97f-aa31-47a8-83f5-591e32b3cad5"), new Guid("2448cee6-eacf-4b8c-b35f-47e61b43d7cf"), 2, new DateTime(2023, 5, 29, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(2470), null, "Description for WorkItem 251", 1, 1, "WorkItem 251" },
                    { new Guid("a707827f-3e0f-42af-ba73-d46687998892"), new Guid("82d28eab-12af-4ad5-bc6f-ca265703df62"), 0, new DateTime(2023, 2, 20, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(5240), null, "Description for WorkItem 349", 0, 0, "WorkItem 349" },
                    { new Guid("a7308067-bdce-4812-8ef5-c12f340a2977"), new Guid("b609c356-cb1a-4aff-b8ff-13fcd0368559"), 1, new DateTime(2023, 4, 8, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(3900), null, "Description for WorkItem 302", 1, 1, "WorkItem 302" },
                    { new Guid("a744497f-667d-416e-adb8-f8e03a5b2d79"), new Guid("1df30ac9-724a-4ace-a5bd-cbb579e7ca2c"), 2, new DateTime(2024, 1, 4, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(6157), null, "Description for WorkItem 31", 0, 0, "WorkItem 31" },
                    { new Guid("a7d972df-5361-437c-a534-571033ad35ec"), new Guid("8ab8775a-fe1e-42bb-84a8-0664c8726d13"), 2, new DateTime(2023, 7, 28, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(706), null, "Description for WorkItem 191", 1, 1, "WorkItem 191" },
                    { new Guid("a9031e83-2c32-441e-abdd-a35c63eb66e0"), new Guid("0d968db3-960d-4fda-8ebb-adc1a3a50999"), 2, new DateTime(2023, 9, 14, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(9366), null, "Description for WorkItem 143", 1, 1, "WorkItem 143" },
                    { new Guid("a950a7d6-2b21-4b31-ac57-16249242d95d"), new Guid("b2f07e84-6d04-42ab-8f9a-5c95ba4329c9"), 2, new DateTime(2023, 2, 10, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(5533), null, "Description for WorkItem 359", 1, 1, "WorkItem 359" },
                    { new Guid("a9899a80-688f-498c-bcff-1a426371a55d"), new Guid("e688f1d2-81f7-4b8f-812c-06edd73834a0"), 0, new DateTime(2023, 10, 2, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(8845), null, "Description for WorkItem 125", 1, 1, "WorkItem 125" },
                    { new Guid("abba923a-a264-4b50-b9d5-cbf38da49349"), new Guid("c2700fff-b0f8-4e3f-9450-3a0e8b523083"), 0, new DateTime(2023, 10, 14, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(8479), null, "Description for WorkItem 113", 1, 1, "WorkItem 113" },
                    { new Guid("ac0ef4e2-de04-476c-a082-9f30aaf4a95c"), new Guid("0d968db3-960d-4fda-8ebb-adc1a3a50999"), 0, new DateTime(2023, 2, 16, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(5379), null, "Description for WorkItem 353", 1, 1, "WorkItem 353" },
                    { new Guid("ac3df463-e8c1-43b0-9471-61958d047fe6"), new Guid("fb548886-ac24-4da8-9730-6e47711de250"), 0, new DateTime(2023, 8, 11, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(284), null, "Description for WorkItem 177", 2, 2, "WorkItem 177" },
                    { new Guid("adb3d9be-126e-48c4-83a8-9993f5da86f3"), new Guid("3f747ed7-980b-4e92-acdf-ec1102d4a0af"), 3, new DateTime(2023, 12, 2, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(7087), null, "Description for WorkItem 64", 0, 0, "WorkItem 64" },
                    { new Guid("aeb97e9f-8c1f-4c32-bc76-a44d0180a34d"), new Guid("bcdc779a-4026-43d3-83d9-aee099e3c6f5"), 2, new DateTime(2023, 1, 1, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(6714), null, "Description for WorkItem 399", 2, 2, "WorkItem 399" },
                    { new Guid("afa39378-027e-4fce-856a-735085af8440"), new Guid("c2700fff-b0f8-4e3f-9450-3a0e8b523083"), 0, new DateTime(2023, 1, 7, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(6474), null, "Description for WorkItem 393", 2, 2, "WorkItem 393" },
                    { new Guid("b1473a3f-6b78-4620-bab9-150d67e3dbe0"), new Guid("d94f2c8e-c9b2-4bff-8c53-c86cc41b5a26"), 0, new DateTime(2023, 4, 13, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(3772), null, "Description for WorkItem 297", 2, 2, "WorkItem 297" },
                    { new Guid("b152efb5-792c-42ba-9578-9d64c6dbc761"), new Guid("e1c16561-23d0-410f-88c4-f687d0c550e3"), 2, new DateTime(2024, 1, 8, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(6054), null, "Description for WorkItem 27", 2, 2, "WorkItem 27" },
                    { new Guid("b1560388-7654-4f10-b7ce-ed24b66662b5"), new Guid("6d8e062e-c71e-4b72-bcc6-a7066bc54f25"), 1, new DateTime(2023, 8, 30, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(9806), null, "Description for WorkItem 158", 1, 1, "WorkItem 158" },
                    { new Guid("b15d8daf-deae-4551-8f85-fa077ab30517"), new Guid("d8cd2124-fd7a-46ad-8feb-0df7b06c412e"), 3, new DateTime(2023, 7, 3, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(1381), null, "Description for WorkItem 216", 2, 2, "WorkItem 216" },
                    { new Guid("b2583228-61c7-45ec-bf3d-03b97e648442"), new Guid("65aa9a7c-d370-42ae-bfd4-c73044970716"), 1, new DateTime(2023, 8, 2, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(578), null, "Description for WorkItem 186", 2, 2, "WorkItem 186" },
                    { new Guid("b41c22f8-0623-4762-b970-126a267ded60"), new Guid("071c3cc5-02b0-432f-8f41-ba673225e1c8"), 3, new DateTime(2023, 5, 16, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(2871), null, "Description for WorkItem 264", 2, 2, "WorkItem 264" },
                    { new Guid("b4313a35-5a1d-4f8b-b978-0f347d13625c"), new Guid("d94f2c8e-c9b2-4bff-8c53-c86cc41b5a26"), 2, new DateTime(2023, 11, 9, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(7758), null, "Description for WorkItem 87", 2, 2, "WorkItem 87" },
                    { new Guid("b507d958-3afd-488b-91fa-d6c71f9e862a"), new Guid("84376aa5-1faa-43c2-bdc9-2a5d90a4cabc"), 0, new DateTime(2023, 1, 15, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(6273), null, "Description for WorkItem 385", 0, 0, "WorkItem 385" },
                    { new Guid("b5414af7-4c0e-4d27-9fd4-2f9aa73fa6c2"), new Guid("d8f28655-14fd-4a8c-8276-d4a4b7d8e952"), 0, new DateTime(2023, 11, 15, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(7605), null, "Description for WorkItem 81", 2, 2, "WorkItem 81" },
                    { new Guid("b57e747a-2e04-4206-96f9-87e3dad3788c"), new Guid("c414843f-d8ec-4c9e-a0be-9d9d2443f8bb"), 0, new DateTime(2023, 8, 27, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(9879), null, "Description for WorkItem 161", 1, 1, "WorkItem 161" },
                    { new Guid("b5b2afe4-aa6b-4ce0-ba6c-eec6e215269a"), new Guid("b609c356-cb1a-4aff-b8ff-13fcd0368559"), 1, new DateTime(2023, 8, 26, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(9904), null, "Description for WorkItem 162", 2, 2, "WorkItem 162" },
                    { new Guid("b5fe1bd1-1d5b-4250-b83c-ae7a5093003b"), new Guid("c681cf14-e1ff-4bfe-bacb-07eb14d4729d"), 1, new DateTime(2023, 6, 19, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(1880), null, "Description for WorkItem 230", 1, 1, "WorkItem 230" },
                    { new Guid("b915ba37-d534-4824-89a2-29d16bc65a01"), new Guid("8276c361-4485-4daa-b78b-a41b042d9dde"), 0, new DateTime(2023, 2, 24, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(5136), null, "Description for WorkItem 345", 2, 2, "WorkItem 345" },
                    { new Guid("b9196348-618f-4d02-88f4-53272d95ca00"), new Guid("d044d52f-3014-43fb-9b7a-6e27125b6c47"), 2, new DateTime(2023, 8, 1, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(602), null, "Description for WorkItem 187", 0, 0, "WorkItem 187" },
                    { new Guid("b91addce-0524-454f-a5c0-387bfa6633e8"), new Guid("e3a2cf71-676b-4685-9fee-de6a276c9e35"), 3, new DateTime(2023, 3, 9, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(4812), null, "Description for WorkItem 332", 1, 1, "WorkItem 332" },
                    { new Guid("baa4652d-e252-48cb-b384-9dbc22e7c670"), new Guid("b2b37aff-c7d5-412a-9559-891792fe803d"), 3, new DateTime(2023, 3, 13, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(4613), null, "Description for WorkItem 328", 0, 0, "WorkItem 328" },
                    { new Guid("bb35a898-b03b-4ff9-b527-9408860f5dce"), new Guid("87f80008-d28d-4881-986c-34fecb6c962a"), 2, new DateTime(2023, 1, 17, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(6224), null, "Description for WorkItem 383", 1, 1, "WorkItem 383" },
                    { new Guid("bba8b411-30a5-4002-88f6-f019318c355a"), new Guid("87f80008-d28d-4881-986c-34fecb6c962a"), 0, new DateTime(2023, 3, 28, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(4234), null, "Description for WorkItem 313", 0, 0, "WorkItem 313" },
                    { new Guid("bc83ac07-791e-444a-ac68-4e62ed90cd41"), new Guid("84376aa5-1faa-43c2-bdc9-2a5d90a4cabc"), 0, new DateTime(2023, 6, 4, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(2262), null, "Description for WorkItem 245", 1, 1, "WorkItem 245" },
                    { new Guid("bc99cf60-7daa-4e97-bdb5-603dd5d82214"), new Guid("798f6fce-fb81-402f-b76e-33049b892820"), 0, new DateTime(2023, 8, 23, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(9983), null, "Description for WorkItem 165", 2, 2, "WorkItem 165" },
                    { new Guid("bd2afcac-dfc2-4665-a3ff-f38b6009aeca"), new Guid("8b6d3ded-2544-419e-ade6-a9fa14d48681"), 1, new DateTime(2023, 12, 8, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(6935), null, "Description for WorkItem 58", 0, 0, "WorkItem 58" },
                    { new Guid("be639491-bd40-4af4-881a-16eda1d11b89"), new Guid("c414843f-d8ec-4c9e-a0be-9d9d2443f8bb"), 2, new DateTime(2023, 1, 29, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(5831), null, "Description for WorkItem 371", 1, 1, "WorkItem 371" },
                    { new Guid("bf31b651-8b94-48da-a521-bc2bc01b636a"), new Guid("c27af898-42af-4eff-bf56-a4377b6e09a6"), 3, new DateTime(2023, 9, 13, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(9390), null, "Description for WorkItem 144", 2, 2, "WorkItem 144" },
                    { new Guid("bf525c40-57b7-4ab8-9454-0a0a4caf33ac"), new Guid("94e65e9f-ade5-41ea-b16d-73b1823d0d7a"), 3, new DateTime(2023, 1, 8, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(6450), null, "Description for WorkItem 392", 1, 1, "WorkItem 392" },
                    { new Guid("bf70c38f-5130-4a4b-b3c7-6f15475245b6"), new Guid("a50f16ea-c203-4219-bb6b-3b9c5a789348"), 1, new DateTime(2023, 10, 13, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(8566), null, "Description for WorkItem 114", 2, 2, "WorkItem 114" },
                    { new Guid("bf9cf5f9-4577-49b2-aa84-d4d4763fd6d8"), new Guid("c27af898-42af-4eff-bf56-a4377b6e09a6"), 1, new DateTime(2023, 7, 5, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(1333), null, "Description for WorkItem 214", 0, 0, "WorkItem 214" },
                    { new Guid("c0b5aa31-0aed-4038-b277-0e11fd063de5"), new Guid("6d8e062e-c71e-4b72-bcc6-a7066bc54f25"), 3, new DateTime(2023, 6, 21, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(1831), null, "Description for WorkItem 228", 2, 2, "WorkItem 228" },
                    { new Guid("c12e274b-cb6d-4bbd-8c3f-b43d47ebf851"), new Guid("798f6fce-fb81-402f-b76e-33049b892820"), 2, new DateTime(2023, 1, 25, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(6022), null, "Description for WorkItem 375", 2, 2, "WorkItem 375" },
                    { new Guid("c139846f-d0ce-45a7-801b-c3eb30f46260"), new Guid("0186db38-7113-4142-a1e1-9dee806daeb2"), 2, new DateTime(2023, 4, 7, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(3924), null, "Description for WorkItem 303", 2, 2, "WorkItem 303" },
                    { new Guid("c16be343-0871-4f13-9e0e-71dd619e1e4b"), new Guid("fe51f92f-b49f-4cfb-a98d-739e4f57503e"), 3, new DateTime(2023, 10, 31, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(8050), null, "Description for WorkItem 96", 2, 2, "WorkItem 96" },
                    { new Guid("c2122e77-5732-403e-abb2-efa857e4e352"), new Guid("d94f2c8e-c9b2-4bff-8c53-c86cc41b5a26"), 2, new DateTime(2023, 6, 22, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(1800), null, "Description for WorkItem 227", 1, 1, "WorkItem 227" },
                    { new Guid("c2689b2c-ebb2-4b33-9d78-0014b6d6d37b"), new Guid("8276c361-4485-4daa-b78b-a41b042d9dde"), 2, new DateTime(2023, 9, 22, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(9161), null, "Description for WorkItem 135", 2, 2, "WorkItem 135" },
                    { new Guid("c29f4783-6369-4104-b8b6-85b484455faf"), new Guid("2918bf65-e859-411e-85cf-4dee00fe7f73"), 2, new DateTime(2023, 7, 8, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(1253), null, "Description for WorkItem 211", 0, 0, "WorkItem 211" },
                    { new Guid("c2bb90b3-60c8-4ef9-9ecf-90bade59117a"), new Guid("2448cee6-eacf-4b8c-b35f-47e61b43d7cf"), 2, new DateTime(2023, 1, 9, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(6425), null, "Description for WorkItem 391", 0, 0, "WorkItem 391" },
                    { new Guid("c3c60f5c-c7a5-43bf-9a97-789201f266bf"), new Guid("b65a3653-e9ea-43b7-83a6-715eeb60b5bd"), 1, new DateTime(2023, 2, 7, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(5605), null, "Description for WorkItem 362", 1, 1, "WorkItem 362" },
                    { new Guid("c41918d3-dd02-47af-8a5a-70ebc1100716"), new Guid("e3a2cf71-676b-4685-9fee-de6a276c9e35"), 3, new DateTime(2023, 12, 14, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(6787), null, "Description for WorkItem 52", 0, 0, "WorkItem 52" },
                    { new Guid("c425b139-2113-47cf-bb7c-3b2fffa92422"), new Guid("d94f2c8e-c9b2-4bff-8c53-c86cc41b5a26"), 0, new DateTime(2023, 8, 31, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(9782), null, "Description for WorkItem 157", 0, 0, "WorkItem 157" },
                    { new Guid("c4855a58-f9e2-4365-96e4-63a1dee12d90"), new Guid("e89c0901-ee96-4e2d-a2f4-f558336276e9"), 1, new DateTime(2023, 7, 13, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(1131), null, "Description for WorkItem 206", 1, 1, "WorkItem 206" },
                    { new Guid("c4d6f83e-db60-4919-b7f4-da5c6a5ed4d6"), new Guid("734b123e-c217-49d1-8478-561ba7973cab"), 1, new DateTime(2023, 10, 25, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(8204), null, "Description for WorkItem 102", 2, 2, "WorkItem 102" },
                    { new Guid("c5266161-90c6-46c9-a773-c5444c9d9849"), new Guid("81faf274-2a02-4780-82ef-53dbf6359121"), 0, new DateTime(2023, 3, 4, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(4933), null, "Description for WorkItem 337", 0, 0, "WorkItem 337" },
                    { new Guid("c57ad425-3b49-49c9-bf6e-b5a346ac4391"), new Guid("c8ad0841-4379-47b7-b33e-dd6e0806faeb"), 3, new DateTime(2023, 2, 9, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(5557), null, "Description for WorkItem 360", 2, 2, "WorkItem 360" },
                    { new Guid("c5917cb4-4ffb-4e46-81bf-cdaf74833a10"), new Guid("a5c99e92-69fc-4047-bcaf-f2ce22dfffbd"), 1, new DateTime(2023, 12, 16, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(6733), null, "Description for WorkItem 50", 1, 1, "WorkItem 50" },
                    { new Guid("c65ba102-001f-4a00-8b0e-d93ba8afcee6"), new Guid("8276c361-4485-4daa-b78b-a41b042d9dde"), 2, new DateTime(2023, 5, 5, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(3148), null, "Description for WorkItem 275", 1, 1, "WorkItem 275" },
                    { new Guid("c6633c0a-38dc-4fcb-b28d-afa0143b211a"), new Guid("c414843f-d8ec-4c9e-a0be-9d9d2443f8bb"), 0, new DateTime(2024, 1, 14, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(5866), null, "Description for WorkItem 21", 2, 2, "WorkItem 21" },
                    { new Guid("c74015ca-a7f9-4dfe-8193-fdb4ff7d4c8b"), new Guid("4fb29223-242d-434d-9437-2927203619ea"), 3, new DateTime(2023, 12, 26, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(6386), null, "Description for WorkItem 40", 0, 0, "WorkItem 40" },
                    { new Guid("cad5299b-d095-4c17-ae7d-4ba0bae0f9e4"), new Guid("e0a864e1-5e4e-48db-8bdd-64cbbefa5046"), 3, new DateTime(2023, 6, 9, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(2132), null, "Description for WorkItem 240", 2, 2, "WorkItem 240" },
                    { new Guid("cb31d85a-8b41-4b5a-adb1-f101f800c046"), new Guid("734b123e-c217-49d1-8478-561ba7973cab"), 1, new DateTime(2023, 1, 18, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(6200), null, "Description for WorkItem 382", 0, 0, "WorkItem 382" },
                    { new Guid("cb87dd91-eb88-41ee-93cc-d761f8b5cfc6"), new Guid("94e65e9f-ade5-41ea-b16d-73b1823d0d7a"), 1, new DateTime(2023, 8, 6, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(479), null, "Description for WorkItem 182", 1, 1, "WorkItem 182" },
                    { new Guid("cc71c4d4-fe85-4f84-8f9b-6d837d8e93eb"), new Guid("e8ddd435-2464-4c9d-a43f-388b1975f901"), 3, new DateTime(2023, 8, 12, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(258), null, "Description for WorkItem 176", 1, 1, "WorkItem 176" },
                    { new Guid("cd629872-694c-44ce-b8d7-0483e2c65404"), new Guid("1ad928bb-4612-4cbd-b795-f4d9e05d0b73"), 1, new DateTime(2024, 1, 21, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(5683), null, "Description for WorkItem 14", 1, 1, "WorkItem 14" },
                    { new Guid("ce5d5868-e36c-4e1a-9c08-d1d30679a276"), new Guid("6d8e062e-c71e-4b72-bcc6-a7066bc54f25"), 3, new DateTime(2023, 2, 1, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(5756), null, "Description for WorkItem 368", 1, 1, "WorkItem 368" },
                    { new Guid("cf761fc2-d38c-4d04-b768-1ba292275640"), new Guid("a50f16ea-c203-4219-bb6b-3b9c5a789348"), 3, new DateTime(2023, 12, 22, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(6489), null, "Description for WorkItem 44", 1, 1, "WorkItem 44" },
                    { new Guid("cf8c50aa-815b-45e1-94d6-b563e0666b29"), new Guid("6ccb1d85-1dbd-465d-a425-f22ec75c4b85"), 0, new DateTime(2023, 5, 7, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(3098), null, "Description for WorkItem 273", 2, 2, "WorkItem 273" },
                    { new Guid("d1a98a9c-356a-4702-99de-2adeb3291d3e"), new Guid("8b6d3ded-2544-419e-ade6-a9fa14d48681"), 1, new DateTime(2023, 7, 21, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(884), null, "Description for WorkItem 198", 2, 2, "WorkItem 198" },
                    { new Guid("d26a0b86-f69b-419a-a7cf-c32fa90cf29d"), new Guid("65aa9a7c-d370-42ae-bfd4-c73044970716"), 3, new DateTime(2023, 1, 4, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(6554), null, "Description for WorkItem 396", 2, 2, "WorkItem 396" },
                    { new Guid("d27a3e16-f443-4e76-80e8-676de9980e85"), new Guid("b2f07e84-6d04-42ab-8f9a-5c95ba4329c9"), 0, new DateTime(2023, 4, 21, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(3567), null, "Description for WorkItem 289", 0, 0, "WorkItem 289" },
                    { new Guid("d2b9cc1a-b4de-4343-b8cc-b5acd47f7377"), new Guid("8ab8775a-fe1e-42bb-84a8-0664c8726d13"), 2, new DateTime(2023, 3, 10, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(4781), null, "Description for WorkItem 331", 0, 0, "WorkItem 331" },
                    { new Guid("d2f8ec68-65c9-4c0e-a5dc-a0f2343f49b7"), new Guid("071c3cc5-02b0-432f-8f41-ba673225e1c8"), 3, new DateTime(2023, 10, 3, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(8821), null, "Description for WorkItem 124", 0, 0, "WorkItem 124" },
                    { new Guid("d31811f9-c3be-410e-b7db-3691f40d431e"), new Guid("e89c0901-ee96-4e2d-a2f4-f558336276e9"), 1, new DateTime(2023, 11, 30, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(7137), null, "Description for WorkItem 66", 2, 2, "WorkItem 66" },
                    { new Guid("d36a18d1-915c-4293-935c-af24ac616bff"), new Guid("fe51f92f-b49f-4cfb-a98d-739e4f57503e"), 1, new DateTime(2024, 1, 9, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(6026), null, "Description for WorkItem 26", 1, 1, "WorkItem 26" },
                    { new Guid("d4836b55-a0f2-44a5-90b7-5550830a07c1"), new Guid("e0c1a02a-4bc4-48cb-9556-a617e2c84023"), 2, new DateTime(2023, 1, 21, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(6122), null, "Description for WorkItem 379", 0, 0, "WorkItem 379" },
                    { new Guid("d4bb26ed-25e1-4bfd-8c16-e7d79c8edfdb"), new Guid("b2b37aff-c7d5-412a-9559-891792fe803d"), 1, new DateTime(2023, 5, 22, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(2655), null, "Description for WorkItem 258", 2, 2, "WorkItem 258" },
                    { new Guid("d5e144f0-d057-46fd-8ecf-acd3792947da"), new Guid("e0c1a02a-4bc4-48cb-9556-a617e2c84023"), 0, new DateTime(2024, 1, 6, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(6108), null, "Description for WorkItem 29", 1, 1, "WorkItem 29" },
                    { new Guid("d69da735-62db-4303-b4d4-3bd7e77ddf98"), new Guid("2069b475-a494-48bb-8f1e-5077e9fc0c29"), 2, new DateTime(2023, 4, 11, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(3821), null, "Description for WorkItem 299", 1, 1, "WorkItem 299" },
                    { new Guid("d75822bc-a73e-4bf5-a3f7-fccd9110745d"), new Guid("8567c826-3630-44ef-9744-6f70d74b335f"), 3, new DateTime(2023, 1, 16, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(6249), null, "Description for WorkItem 384", 2, 2, "WorkItem 384" },
                    { new Guid("d79be886-df4f-4896-8f34-e5486e1638f3"), new Guid("e1c16561-23d0-410f-88c4-f687d0c550e3"), 0, new DateTime(2023, 1, 23, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(6073), null, "Description for WorkItem 377", 1, 1, "WorkItem 377" },
                    { new Guid("d8fe5dcc-b310-403c-9825-355af589257b"), new Guid("c7890c8e-8c49-481f-862d-0a7fdc855718"), 3, new DateTime(2023, 5, 8, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(3072), null, "Description for WorkItem 272", 1, 1, "WorkItem 272" },
                    { new Guid("d9637d08-906d-470f-8dfe-f0cd778d58da"), new Guid("e688f1d2-81f7-4b8f-812c-06edd73834a0"), 2, new DateTime(2023, 3, 6, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(4884), null, "Description for WorkItem 335", 1, 1, "WorkItem 335" },
                    { new Guid("d9f01300-c7b8-4da6-aefb-f9c3f1e06069"), new Guid("ec1afd48-270c-4eae-9b2f-1938e675a234"), 1, new DateTime(2023, 6, 15, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(1978), null, "Description for WorkItem 234", 2, 2, "WorkItem 234" },
                    { new Guid("da1400f3-6519-46bc-9d74-e3f696f2cc67"), new Guid("e706872a-f6f2-4693-b445-2dd37bc26b0e"), 0, new DateTime(2023, 7, 18, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(959), null, "Description for WorkItem 201", 2, 2, "WorkItem 201" },
                    { new Guid("dad8040e-d302-4bfe-b7db-0d51ff21eb96"), new Guid("1ad928bb-4612-4cbd-b795-f4d9e05d0b73"), 3, new DateTime(2023, 6, 25, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(1725), null, "Description for WorkItem 224", 1, 1, "WorkItem 224" },
                    { new Guid("db21371a-3b47-4383-8ce6-c11d34274a72"), new Guid("a1eaf5d0-9721-4d6b-976d-10a18744d0bf"), 1, new DateTime(2023, 11, 10, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(7733), null, "Description for WorkItem 86", 1, 1, "WorkItem 86" },
                    { new Guid("dbd6940e-cfc1-460b-a82b-41b379a941e6"), new Guid("0186db38-7113-4142-a1e1-9dee806daeb2"), 2, new DateTime(2023, 8, 25, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(9928), null, "Description for WorkItem 163", 0, 0, "WorkItem 163" },
                    { new Guid("dc1158a0-6d35-4b3b-8b69-04488515230f"), new Guid("6d8e062e-c71e-4b72-bcc6-a7066bc54f25"), 3, new DateTime(2023, 11, 8, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(7782), null, "Description for WorkItem 88", 0, 0, "WorkItem 88" },
                    { new Guid("dc13ed98-3271-47ff-b080-6513afdfed49"), new Guid("c681cf14-e1ff-4bfe-bacb-07eb14d4729d"), 1, new DateTime(2023, 11, 6, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(7832), null, "Description for WorkItem 90", 2, 2, "WorkItem 90" },
                    { new Guid("dd133657-4a83-4231-9b80-e63b5024094e"), new Guid("c706c8cd-d2c5-400a-8aa8-3b537e7cb9c6"), 3, new DateTime(2023, 3, 1, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(5012), null, "Description for WorkItem 340", 0, 0, "WorkItem 340" },
                    { new Guid("dd3e52a4-9f54-46bc-8f9d-9b0b1569c29d"), new Guid("84376aa5-1faa-43c2-bdc9-2a5d90a4cabc"), 2, new DateTime(2023, 8, 13, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(234), null, "Description for WorkItem 175", 0, 0, "WorkItem 175" },
                    { new Guid("df25a9b6-3b96-492e-baa3-616aecb54fb0"), new Guid("b65a3653-e9ea-43b7-83a6-715eeb60b5bd"), 3, new DateTime(2024, 1, 23, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(5634), null, "Description for WorkItem 12", 2, 2, "WorkItem 12" },
                    { new Guid("dfc0ab9b-5b88-49d2-be56-bbb540c3a540"), new Guid("94e65e9f-ade5-41ea-b16d-73b1823d0d7a"), 3, new DateTime(2023, 5, 28, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(2501), null, "Description for WorkItem 252", 2, 2, "WorkItem 252" },
                    { new Guid("e0d6666f-348d-4484-ad61-ab6d1886d7bd"), new Guid("2069b475-a494-48bb-8f1e-5077e9fc0c29"), 2, new DateTime(2023, 8, 29, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(9830), null, "Description for WorkItem 159", 2, 2, "WorkItem 159" },
                    { new Guid("e2e45766-78a1-4e3a-9b3b-3be9abbd6b52"), new Guid("65aa9a7c-d370-42ae-bfd4-c73044970716"), 1, new DateTime(2023, 12, 20, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(6538), null, "Description for WorkItem 46", 0, 0, "WorkItem 46" },
                    { new Guid("e2edd2c6-159b-4660-8f18-181cf52c5bcf"), new Guid("8567c826-3630-44ef-9744-6f70d74b335f"), 3, new DateTime(2023, 10, 23, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(8253), null, "Description for WorkItem 104", 1, 1, "WorkItem 104" },
                    { new Guid("e3f4ceac-0aff-456e-9193-8e1a4b7031a5"), new Guid("6246fb7d-c2f9-425b-a185-98350aa9da3e"), 0, new DateTime(2023, 2, 12, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(5484), null, "Description for WorkItem 357", 2, 2, "WorkItem 357" },
                    { new Guid("e434429d-d913-4e66-8889-5f98210e29ac"), new Guid("1df30ac9-724a-4ace-a5bd-cbb579e7ca2c"), 0, new DateTime(2023, 10, 26, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(8180), null, "Description for WorkItem 101", 1, 1, "WorkItem 101" },
                    { new Guid("e5ada032-63bd-4421-9f1b-55dec00d612b"), new Guid("cad7fa03-3cbb-46f0-ae04-daa69d04a856"), 1, new DateTime(2023, 7, 9, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(1229), null, "Description for WorkItem 210", 2, 2, "WorkItem 210" },
                    { new Guid("e754636f-6d24-46aa-b33d-e5d67fa512e1"), new Guid("2c48c132-38e2-43d7-bf83-2e78dc062be2"), 0, new DateTime(2023, 5, 3, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(3202), null, "Description for WorkItem 277", 0, 0, "WorkItem 277" },
                    { new Guid("e754c6fb-c258-4914-ab11-62726e4a16a1"), new Guid("d17c1c16-81a0-419e-80b9-7d6c871843d6"), 1, new DateTime(2023, 4, 28, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(3385), null, "Description for WorkItem 282", 2, 2, "WorkItem 282" },
                    { new Guid("e86a8008-5d5b-40c8-8d09-305e14e82375"), new Guid("82d28eab-12af-4ad5-bc6f-ca265703df62"), 2, new DateTime(2023, 9, 18, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(9260), null, "Description for WorkItem 139", 0, 0, "WorkItem 139" },
                    { new Guid("e8e06c13-43d1-4ce7-a172-dc8c5a9682c5"), new Guid("a911f2dc-8c99-42ea-a817-d1b909d08b9e"), 1, new DateTime(2023, 5, 14, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(2920), null, "Description for WorkItem 266", 1, 1, "WorkItem 266" },
                    { new Guid("eabb2552-b7f3-4247-8a34-b2133c88c114"), new Guid("b2f07e84-6d04-42ab-8f9a-5c95ba4329c9"), 0, new DateTime(2023, 9, 8, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(9518), null, "Description for WorkItem 149", 1, 1, "WorkItem 149" },
                    { new Guid("eb109f43-7ce4-4719-8fe4-be6e4491be5d"), new Guid("d044d52f-3014-43fb-9b7a-6e27125b6c47"), 2, new DateTime(2023, 3, 14, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(4588), null, "Description for WorkItem 327", 2, 2, "WorkItem 327" },
                    { new Guid("ec51efb8-fdb7-420d-abc0-da5e8edce576"), new Guid("6d8e062e-c71e-4b72-bcc6-a7066bc54f25"), 1, new DateTime(2024, 1, 17, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(5785), null, "Description for WorkItem 18", 2, 2, "WorkItem 18" },
                    { new Guid("ecd6f40a-b3c8-461b-ba37-8d36bf14a546"), new Guid("d8cd2124-fd7a-46ad-8feb-0df7b06c412e"), 1, new DateTime(2023, 9, 11, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(9439), null, "Description for WorkItem 146", 1, 1, "WorkItem 146" },
                    { new Guid("ed7469ab-bb4d-41f1-b490-a9e85676da97"), new Guid("734b123e-c217-49d1-8478-561ba7973cab"), 3, new DateTime(2023, 3, 29, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(4209), null, "Description for WorkItem 312", 2, 2, "WorkItem 312" },
                    { new Guid("ed76db1d-d4a9-4edf-979d-119488978dc1"), new Guid("6d8e062e-c71e-4b72-bcc6-a7066bc54f25"), 1, new DateTime(2023, 4, 12, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(3797), null, "Description for WorkItem 298", 0, 0, "WorkItem 298" },
                    { new Guid("eda0c6b1-5a0a-424a-b188-663115156722"), new Guid("8b6d3ded-2544-419e-ade6-a9fa14d48681"), 3, new DateTime(2023, 5, 12, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(2974), null, "Description for WorkItem 268", 0, 0, "WorkItem 268" },
                    { new Guid("ef45c622-2132-40b8-9ca2-061d8f8cc396"), new Guid("d17c1c16-81a0-419e-80b9-7d6c871843d6"), 1, new DateTime(2023, 9, 15, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(9341), null, "Description for WorkItem 142", 0, 0, "WorkItem 142" },
                    { new Guid("f095015b-6566-46f0-890c-63517e4c15d2"), new Guid("b450cb81-decd-48e5-96c6-109074706ea9"), 2, new DateTime(2023, 11, 13, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(7654), null, "Description for WorkItem 83", 1, 1, "WorkItem 83" },
                    { new Guid("f0aec23a-aebc-4ffc-b751-0df87ebc693e"), new Guid("b450cb81-decd-48e5-96c6-109074706ea9"), 0, new DateTime(2024, 1, 22, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(5659), null, "Description for WorkItem 13", 0, 0, "WorkItem 13" },
                    { new Guid("f153ed32-81f3-43b5-8836-28d974518cbc"), new Guid("798f6fce-fb81-402f-b76e-33049b892820"), 2, new DateTime(2023, 6, 14, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(2002), null, "Description for WorkItem 235", 0, 0, "WorkItem 235" },
                    { new Guid("f164f61c-9cef-4384-972b-af564c37ce77"), new Guid("e0a864e1-5e4e-48db-8bdd-64cbbefa5046"), 1, new DateTime(2023, 8, 18, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(106), null, "Description for WorkItem 170", 1, 1, "WorkItem 170" },
                    { new Guid("f1b5977b-999b-4ffa-a2a4-7fdee62ddfee"), new Guid("2c48c132-38e2-43d7-bf83-2e78dc062be2"), 0, new DateTime(2023, 9, 20, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(9211), null, "Description for WorkItem 137", 1, 1, "WorkItem 137" },
                    { new Guid("f3065cf0-0735-45a2-be39-7d7986ef77e5"), new Guid("c0fe8045-0fce-443f-aadb-845cf60f63e2"), 3, new DateTime(2023, 2, 21, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(5215), null, "Description for WorkItem 348", 2, 2, "WorkItem 348" },
                    { new Guid("f3416b54-6169-4d1c-a8b5-bfd22fcefad9"), new Guid("81faf274-2a02-4780-82ef-53dbf6359121"), 0, new DateTime(2023, 12, 9, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(6909), null, "Description for WorkItem 57", 2, 2, "WorkItem 57" },
                    { new Guid("f34878fb-5512-4a6d-8e13-107d6e62a8cd"), new Guid("b450cb81-decd-48e5-96c6-109074706ea9"), 2, new DateTime(2023, 2, 6, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(5629), null, "Description for WorkItem 363", 2, 2, "WorkItem 363" },
                    { new Guid("f414bfdf-98b9-494c-bf84-b0bf1f421574"), new Guid("e1c16561-23d0-410f-88c4-f687d0c550e3"), 0, new DateTime(2023, 6, 12, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(2056), null, "Description for WorkItem 237", 2, 2, "WorkItem 237" },
                    { new Guid("f8730b62-f8ab-48c5-bfbb-464974a225b1"), new Guid("c2700fff-b0f8-4e3f-9450-3a0e8b523083"), 2, new DateTime(2023, 12, 23, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(6460), null, "Description for WorkItem 43", 0, 0, "WorkItem 43" },
                    { new Guid("f8ab6715-ac6e-4e96-a217-e9b699b32a16"), new Guid("c2700fff-b0f8-4e3f-9450-3a0e8b523083"), 2, new DateTime(2023, 8, 5, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(504), null, "Description for WorkItem 183", 2, 2, "WorkItem 183" },
                    { new Guid("f9620e33-0f00-4dd6-b7a8-a27ed1107e8b"), new Guid("e688f1d2-81f7-4b8f-812c-06edd73834a0"), 0, new DateTime(2023, 5, 15, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(2895), null, "Description for WorkItem 265", 0, 0, "WorkItem 265" },
                    { new Guid("f96e2f9d-826a-4515-a7cd-56ed1e05a129"), new Guid("bbae71f3-a79a-4426-9918-bdb57bb58806"), 0, new DateTime(2023, 6, 24, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(1751), null, "Description for WorkItem 225", 2, 2, "WorkItem 225" },
                    { new Guid("f9a59d7b-a82d-4555-a039-d7dac38cc7cf"), new Guid("2e7474a0-28d5-4c9e-b838-61db8782cc92"), 0, new DateTime(2023, 12, 21, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(6514), null, "Description for WorkItem 45", 2, 2, "WorkItem 45" },
                    { new Guid("f9fce8f1-9876-4561-9b56-c84e8a920f33"), new Guid("b884b195-1fa6-434a-b3a0-af1ac1de7c60"), 2, new DateTime(2023, 12, 7, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(6959), null, "Description for WorkItem 59", 1, 1, "WorkItem 59" },
                    { new Guid("fab2d0e0-9f7a-42cc-a4a7-212c892c0bfd"), new Guid("0d968db3-960d-4fda-8ebb-adc1a3a50999"), 2, new DateTime(2024, 2, 1, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(5293), null, "Description for WorkItem 3", 2, 2, "WorkItem 3" },
                    { new Guid("fb5e3f6a-3319-42f3-bd1b-78252d70e670"), new Guid("a44ff748-7c83-4bc6-808a-4e35747cae73"), 0, new DateTime(2023, 7, 26, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(754), null, "Description for WorkItem 193", 0, 0, "WorkItem 193" },
                    { new Guid("fd7ad9f8-eee9-4d63-9fa8-bb7a1fcd3dc5"), new Guid("2448cee6-eacf-4b8c-b35f-47e61b43d7cf"), 2, new DateTime(2023, 10, 16, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(8431), null, "Description for WorkItem 111", 2, 2, "WorkItem 111" },
                    { new Guid("fdb42e9c-2e94-4958-b5f1-1ebd656e1a98"), new Guid("b884b195-1fa6-434a-b3a0-af1ac1de7c60"), 0, new DateTime(2023, 9, 28, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(8944), null, "Description for WorkItem 129", 2, 2, "WorkItem 129" },
                    { new Guid("fdcaf659-53db-4414-b26b-e6baed64989b"), new Guid("0186db38-7113-4142-a1e1-9dee806daeb2"), 0, new DateTime(2023, 6, 16, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(1953), null, "Description for WorkItem 233", 1, 1, "WorkItem 233" },
                    { new Guid("ff67aab0-6b5f-4504-9357-65ca6e1d5e4d"), new Guid("65aa9a7c-d370-42ae-bfd4-c73044970716"), 1, new DateTime(2023, 3, 15, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(4564), null, "Description for WorkItem 326", 1, 1, "WorkItem 326" },
                    { new Guid("ff73c887-edb1-4797-801b-3f3573319a70"), new Guid("e0a864e1-5e4e-48db-8bdd-64cbbefa5046"), 3, new DateTime(2023, 1, 20, 15, 13, 12, 224, DateTimeKind.Local).AddTicks(6151), null, "Description for WorkItem 380", 1, 1, "WorkItem 380" },
                    { new Guid("ff87768f-c581-437e-afe9-af29569d366b"), new Guid("d17c1c16-81a0-419e-80b9-7d6c871843d6"), 1, new DateTime(2024, 2, 2, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(5267), null, "Description for WorkItem 2", 1, 1, "WorkItem 2" },
                    { new Guid("ffac674b-3d6a-472e-9d5a-a587fc283ca4"), new Guid("2c48c132-38e2-43d7-bf83-2e78dc062be2"), 2, new DateTime(2023, 11, 29, 15, 13, 12, 223, DateTimeKind.Local).AddTicks(7162), null, "Description for WorkItem 67", 0, 0, "WorkItem 67" }
                });
        }
    }
}
