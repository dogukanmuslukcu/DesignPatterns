

// Stock Control => Payment Control => Invoice Control => Shipping Control

var order = new Order();

var stockControl = new StockControl();
var paymentControl = new PaymentControl();
var invoiceControl = new InvoiceControl();
var shippingControl = new ShippingControl();

stockControl.SetNext(paymentControl);
paymentControl.SetNext(invoiceControl);
invoiceControl.SetNext(shippingControl);

stockControl.Handle(order);
