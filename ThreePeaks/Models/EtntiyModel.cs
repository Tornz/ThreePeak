namespace ThreePeaks.Models
{
    public class StoreModel
    {
        public string OrderType { get; set; }
        public int Import { get; set; }
        public string PickUpStoreNo { get; set; }
        public string PickUpPrice { get; set; }
        public string PickUpStoreName { get; set; }
        public decimal? PickupLat { get; set; }
        public decimal? PickupLong { get; set; }
        public string PickUpAddress { get; set; }
        public string PickUpFirstName { get; set; }
        public string PickUpLastName { get; set; }
        public string PickUpMobileNo { get; set; }
        public string PickUpEmail { get; set; }
        public int? PickUpNotification { get; set; }
        public string PickUpTime { get; set; }
        public decimal? PickUpTolerance { get; set; }
        public decimal? PickUpServiceTime { get; set; }

        public string DeliveryStoreNo { get; set; }

        public string DeliveryStoreName { get; set; }

        public decimal? DeliveryLat { get; set; }
        public decimal DeliveryLong { get; set; }
        public string DeliveryAddress { get; set; }
        public string DeliveryFirstName { get; set; }
        public string DeliveryLastName { get; set; }
        public string DeliveryEmail { get; set; }

        public string? DelivertMobileNo { get; set; }
        public int? DelivertNotification { get; set; }
        public int? DelivertTime { get; set; }

        public decimal? DelivertTolerance { get; set; }
        public decimal? DelivertService { get; set; }
        public string AssignedDriver { get; set; }


        public string OrderDetails { get; set; }

        public string CustomerReference { get; set; }
        public string Payer { get; set; }

        public string Vehicle { get; set; }
        public decimal? Weight { get; set; }

        public decimal? OrderPrice { get; set; }


    }

}
