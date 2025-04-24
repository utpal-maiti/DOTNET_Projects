using System;
using System.Linq;

using Microsoft.AspNetCore.Mvc;

namespace Codility.WarehouseApi
{
    public class WarehouseController : Controller
    {
        private readonly IWarehouseRepository _warehouseRepository;

        public WarehouseController(IWarehouseRepository warehouseRepository)
        {
            _warehouseRepository = warehouseRepository;
        }

        // Return OkObjectResult(IEnumerable<WarehouseEntry>)
        public IActionResult GetProducts()
        {
            // Console.WriteLine("Sample debug output");
            //throw new NotImplementedException();
            var result = this._warehouseRepository.GetProductRecords();
            return new OkObjectResult(result);
        }

        // Return OkResult, BadRequestObjectResult(NotPositiveQuantityMessage), or BadRequestObjectResult(QuantityTooLowMessage)
        //public IActionResult SetProductCapacity(int productId, int capacity)
        //{
        //    //throw new NotImplementedException();

        //    if (productId < 1)
        //    {
        //        return new BadRequestObjectResult(error: NotPositiveQuantityMessage);
        //    }

        //    var product = this._warehouseRepository.GetCapacityRecords(x => x.ProductId == productId);

        //    if (capacity < product.Capacity)
        //    {
        //        return new BadRequestObjectResult(QuantityTooLowMessage);
        //    }

        //    this._warehouseRepository.SetCapacityRecord(productId, capacity);

        //    return OkResult();

        //}

        //// Return OkResult, BadRequestObjectResult(NotPositiveQuantityMessage), or BadRequestObjectResult(QuantityTooHighMessage)
        //public IActionResult ReceiveProduct(int productId, int qty)
        //{
        //    if (productId < 1)
        //    {
        //        return BadRequestObjectResult(NotPositiveQuantityMessage);
        //    }

        //    var product = this._warehouseRepository.GetProductRecords(x => x.ProductId == productId);

        //    if (qty > product.Quantity)
        //    {
        //        return BadRequestObjectResult(QuantityTooHighMessage);
        //    }

        //    this._warehouseRepository.SetProductRecord(productId, qty);

        //    return OkResult();
        //}

        //// Return OkResult, BadRequestObjectResult(NotPositiveQuantityMessage), or BadRequestObjectResult(QuantityTooHighMessage)
        //public IActionResult DispatchProduct(int productId, int qty)
        //{
        //    if (productId < 1)
        //    {
        //        return BadRequestObjectResult(NotPositiveQuantityMessage);
        //    }

        //    var product = this._warehouseRepository.GetProductRecords(x => x.ProductId == productId);

        //    if (qty > product.Quantity)
        //    {
        //        return BadRequestObjectResult(QuantityTooHighMessage);
        //    }

        //    this._warehouseRepository.SetProductRecord(productId, qty);

        //    return OkResult();
        //}
    }

    public interface IWarehouseRepository
    {
        void SetCapacityRecord(int productId, int capacity);
        IEnumerable<CapacityRecord> GetCapacityRecords();
        IEnumerable<CapacityRecord> GetCapacityRecords(Func<CapacityRecord, bool> filter);

        void SetProductRecord(int productId, int quantity);
        IEnumerable<ProductRecord> GetProductRecords();
        IEnumerable<ProductRecord> GetProductRecords(Func<ProductRecord, bool> filter);
    }

    public class CapacityRecord
    {
        public int ProductId { get; set; }
        public int Capacity { get; set; }
    }

    public class ProductRecord
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }

    // IEnumerable<WarehouseEntry> should be returned by GetProducts method.
    // It can be mapped from ProductRecord
    public class WarehouseEntry
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }

    // NotPositiveQuantityMessage should be returned by
    // SetProductCapacity, ReceiveProduct and DispatchProduct methods
    public class NotPositiveQuantityMessage
    {
        public string Message => "A positive quantity was not provided";
    }

    // QuantityTooLowMessage should be returned by
    // SetProductCapacity, ReceiveProduct and DispatchProduct methods
    public class QuantityTooLowMessage
    {
        public string Message => "Too low a quantity was provided";
    }

    // QuantityTooHighMessage should be returned by
    // SetProductCapacity, ReceiveProduct and DispatchProduct methods
    public class QuantityTooHighMessage
    {
        public string Message => "Too high a quantity was provided";
    }


}
