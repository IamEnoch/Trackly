﻿using TracklyApi.DTOs.ResponseDTOs;

namespace TracklyApi.DTOs.RequestDTOs
{
    public class AssetRequestDto
    {
        public string BarcodeNumber { get; set; }
        public string AssetName { get; set; }
        public string Category { get; set; }
        public string DepartmentName { get; set; }
        public string LocationName { get; set; }
    }
}
