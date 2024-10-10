



using OfficeOpenXml;
using ThreePeaks.Interfaces;
using ThreePeaks.Models;

namespace ThreePeaks.Services
{
    public class StoreRepository : IStoreRepository
    {
        private static List<StoreModel> _store = new();
        public IEnumerable<StoreModel> GetStoreList()
        {
            return _store;
        }

        public void ImportData(IFormFile excelFile)
        {
            if (excelFile != null && excelFile.Length > 0)
            {
                using (var stream = new MemoryStream())
                {
                    ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                    _store = new();
                    // Load the file into a memory stream
                    excelFile.CopyTo(stream);
                    using (var package = new ExcelPackage(stream))
                    {
                        // Load the first worksheet in the workbook
                        ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                        int rowCount = worksheet.Dimension.Rows;

                        // Iterate over the rows (starting from 2 to skip the header)
                        for (int row = 2; row <= rowCount; row++)
                        {
                            if (!string.IsNullOrEmpty(worksheet.Cells[row, 1].Text))
                            {
                                _store.Add(new StoreModel
                                {
                                    OrderType = worksheet.Cells[row, 1].Text,
                                    Import = ConvertToInt(worksheet.Cells[row, 2].Text),
                                    PickUpStoreNo = worksheet.Cells[row, 3].Text,
                                    PickUpStoreName = worksheet.Cells[row, 4].Text,
                                    PickupLat = ConvertToDecimal(worksheet.Cells[row, 5].Text),
                                    PickupLong = ConvertToDecimal(worksheet.Cells[row, 6].Text),
                                    PickUpAddress = worksheet.Cells[row, 7].Text,
                                    PickUpFirstName = worksheet.Cells[row, 8].Text,
                                    PickUpLastName = worksheet.Cells[row, 9].Text,
                                    PickUpEmail = worksheet.Cells[row, 10].Text,
                                    PickUpMobileNo = worksheet.Cells[row, 11].Text,
                                    PickUpNotification = ConvertToInt(worksheet.Cells[row, 12].Text),
                                    PickUpTime = worksheet.Cells[row, 11].Text,
                                    PickUpTolerance = ConvertToDecimal(worksheet.Cells[row, 11].Text),
                                    PickUpServiceTime = ConvertToDecimal(worksheet.Cells[row, 11].Text),
                                    DeliveryStoreNo = worksheet.Cells[row, 11].Text,
                                    DeliveryStoreName = worksheet.Cells[row, 11].Text,
                                    DeliveryLat = ConvertToDecimal(worksheet.Cells[row, 11].Text),
                                    DeliveryLong = ConvertToDecimal(worksheet.Cells[row, 11].Text),
                                    DeliveryAddress = worksheet.Cells[row, 11].Text,
                                    DeliveryFirstName = worksheet.Cells[row, 11].Text,
                                    DeliveryLastName = worksheet.Cells[row, 11].Text,
                                    DeliveryEmail = worksheet.Cells[row, 11].Text,
                                    DelivertMobileNo = worksheet.Cells[row, 11].Text,
                                    DelivertNotification = ConvertToInt(worksheet.Cells[row, 11].Text),
                                    DelivertTime = ConvertToInt(worksheet.Cells[row, 11].Text),
                                    DelivertTolerance = ConvertToDecimal(worksheet.Cells[row, 11].Text),
                                    DelivertService = ConvertToDecimal(worksheet.Cells[row, 11].Text),
                                    AssignedDriver = worksheet.Cells[row, 11].Text,
                                    CustomerReference = worksheet.Cells[row, 11].Text,
                                    Payer = worksheet.Cells[row, 11].Text,
                                    Vehicle = worksheet.Cells[row, 11].Text,
                                    Weight = ConvertToDecimal(worksheet.Cells[row, 11].Text),
                                    OrderPrice = ConvertToDecimal(worksheet.Cells[row, 11].Text)
                                });
                            }
                        }
                    }
                }

                
            }
        }


        private decimal ConvertToDecimal(string value)
        {
            return !string.IsNullOrEmpty(value) ? Convert.ToDecimal(value) : 0;
        }
        private int ConvertToInt(string value)
        {
            return !string.IsNullOrEmpty(value) ? Convert.ToInt32(value) : 0;
        }
    }
}
