INSERT INTO WMS.supplier (SupplierCode, Name, Address, Phone, Email, Note) VALUES ('SXFP', 'Brendan', '', '', '', '');
INSERT INTO WMS.inventory (InventoryCode, Description, SupplierCode, CostPerUnit) VALUES ('000025', 'Edelbrock E-Force Supercharger Kits', 'SXFP', 5400.00);

INSERT INTO WMS.supplier (SupplierCode, Name, Address, Phone, Email, Note) VALUES ('N9TT', 'Cairo', '', '', '', '');
INSERT INTO WMS.inventory (InventoryCode, Description, SupplierCode, CostPerUnit) VALUES ('000021', 'RKSport Ram Air Hoods', 'N9TT', 1785.00);

INSERT INTO WMS.supplier (SupplierCode, Name, Address, Phone, Email, Note) VALUES ('B7FQ', 'Kajol', '', '', '', '');
INSERT INTO WMS.inventory (InventoryCode, Description, SupplierCode, CostPerUnit) VALUES ('041333665665', 'Koni Front Coil-Over Kit for Volkswagen Gold V', 'B7FQ', 1243.33);

INSERT INTO WMS.supplier (SupplierCode, Name, Address, Phone, Email, Note) VALUES ('4GE4', 'Cerys', '', '', '', '');
INSERT INTO WMS.inventory (InventoryCode, Description, SupplierCode, CostPerUnit) VALUES ('000022', 'Oracle Illuminated Emblems', '4GE4', 247.00);

INSERT INTO WMS.supplier (SupplierCode, Name, Address, Phone, Email, Note) VALUES ('ETEV', 'Pittman', '', '', '', '');
INSERT INTO WMS.inventory (InventoryCode, Description, SupplierCode, CostPerUnit) VALUES ('000023', 'Street Scene Cal-Vu Signal Mirrors (Pair)', 'ETEV', 502.00);

INSERT INTO WMS.supplier (SupplierCode, Name, Address, Phone, Email, Note) VALUES ('3L4Y', 'Rogers', '', '', '', '');
INSERT INTO WMS.inventory (InventoryCode, Description, SupplierCode, CostPerUnit) VALUES ('000015', 'Vision X Optimus Square Dual LED Light', '3L4Y', 229.00);

INSERT INTO WMS.supplier (SupplierCode, Name, Address, Phone, Email, Note) VALUES ('8XTJ', 'Fahima', '', '', '', '');
INSERT INTO WMS.inventory (InventoryCode, Description, SupplierCode, CostPerUnit) VALUES ('7896594000013', 'Putco LED Headlight Bulb Conversion Kit', '8XTJ', 251.99);

INSERT INTO WMS.supplier (SupplierCode, Name, Address, Phone, Email, Note) VALUES ('7EIQ', 'Cobb', '', '', '', '');
INSERT INTO WMS.inventory (InventoryCode, Description, SupplierCode, CostPerUnit) VALUES ('000017', 'ProZ Rocker Panel Trim (KIT)', '7EIQ', 607.00);

INSERT INTO WMS.supplier (SupplierCode, Name, Address, Phone, Email, Note) VALUES ('72IU', 'Marin', '', '', '', '');
INSERT INTO WMS.inventory (InventoryCode, Description, SupplierCode, CostPerUnit) VALUES ('000010', 'Bilstein 24-144780 86 Series HD Shock Absorber', '72IU', 99.00);

INSERT INTO WMS.supplier (SupplierCode, Name, Address, Phone, Email, Note) VALUES ('E3SR', 'Cabrera', '', '', '', '');
INSERT INTO WMS.inventory (InventoryCode, Description, SupplierCode, CostPerUnit) VALUES ('000014', 'PIAA Xtreme White Bulbs', 'E3SR', 84.15);




INSERT INTO WMS.customer (FirstName, LastName, Phone) VALUES ('James', 'Smith', '0123323818');
SET @last_id_in_table1 = LAST_INSERT_ID();
INSERT INTO WMS.address(Street, City, Postcode, State, CustomerID) VALUES ('Jalan', 'Petaling Jaya', '47800', 'Selangor', @last_id_in_table1);
INSERT INTO WMS.vehicle(RegistrationNo, CustomerID2, ChassisNo, Make, Model, Year, Engine, Transmission, FuelType, Mileage) VALUES ('abRBNHzG', @last_id_in_table1, 'crivwGMBcduUN' ,'ThxtiQy5CbYhG' ,'xT75tFwXsqaMm', 2016, '', '', '', 20000);
INSERT INTO WMS.work_order(WorkOrderCode, Description, AdvisoryNote, TotalCost, CustomerID3, WorkOrderTime) VALUES ('ABC123', '', '', 311.00, @last_id_in_table1, '2018-11-23');
INSERT INTO WMS.work_order(WorkOrderCode, Description, AdvisoryNote, TotalCost, CustomerID3, WorkOrderTime) VALUES ('ABC234', '', '', 311.00, @last_id_in_table1, '2018-11-23');
INSERT INTO WMS.work_order(WorkOrderCode, Description, AdvisoryNote, TotalCost, CustomerID3, WorkOrderTime) VALUES ('ABC345', '', '', 311.00, @last_id_in_table1, '2018-11-23');
INSERT INTO WMS.work_order_inventory(WorkOrderCode, InventoryCode, NumberOfUnits) VALUES ('ABC123', '000025', 3);
INSERT INTO WMS.work_order_inventory(WorkOrderCode, InventoryCode, NumberOfUnits) VALUES ('ABC123', '041333665665', 3);
INSERT INTO WMS.work_order_inventory(WorkOrderCode, InventoryCode, NumberOfUnits) VALUES ('ABC123', '000022', 3);
INSERT INTO WMS.work_order_inventory(WorkOrderCode, InventoryCode, NumberOfUnits) VALUES ('ABC234', '000015', 1);
INSERT INTO WMS.work_order_inventory(WorkOrderCode, InventoryCode, NumberOfUnits) VALUES ('ABC234', '7896594000013', 4);
INSERT INTO WMS.work_order_inventory(WorkOrderCode, InventoryCode, NumberOfUnits) VALUES ('ABC345', '000023', 2);
INSERT INTO WMS.invoice(InvoiceCode, Date, Method) VALUES ('Q4V8-KTN2-GV68-LQYP', '2018-11-24', 'Cash');
INSERT INTO WMS.invoice_workorder(InvoiceCode2, WorkOrderCode2) VALUES ('Q4V8-KTN2-GV68-LQYP', 'ABC123');
INSERT INTO WMS.invoice_workorder(InvoiceCode2, WorkOrderCode2) VALUES ('Q4V8-KTN2-GV68-LQYP', 'ABC234');
INSERT INTO WMS.invoice_workorder(InvoiceCode2, WorkOrderCode2) VALUES ('Q4V8-KTN2-GV68-LQYP', 'ABC345');


INSERT INTO WMS.customer (FirstName, LastName, Phone) VALUES ('Robert', 'Young', '0122178076');
SET @last_id_in_table1 = LAST_INSERT_ID();
INSERT INTO WMS.address(Street, City, Postcode, State, CustomerID) VALUES ('Jalan', 'Petaling Jaya', '47800', 'Selangor', @last_id_in_table1);
INSERT INTO WMS.vehicle(RegistrationNo, CustomerID2, ChassisNo, Make, Model, Year, Engine, Transmission, FuelType, Mileage) VALUES ('cW8DEFfG', @last_id_in_table1, 'nqK42M3NfngFu' ,'QZbeqrGWjjS6m' ,'sLEpBwEwJN9bb', 2017, 'L8Ca77cWk9yMA', '9Tgj82DkqUyWA', 'pqKhdGxVDjPco', 20000);
INSERT INTO WMS.work_order(WorkOrderCode, Description, AdvisoryNote, TotalCost, CustomerID3, WorkOrderTime) VALUES ('CCC123', '', '', 311.00, @last_id_in_table1, '2018-11-23');
INSERT INTO WMS.work_order(WorkOrderCode, Description, AdvisoryNote, TotalCost, CustomerID3, WorkOrderTime) VALUES ('DDD123', '', '', 311.00, @last_id_in_table1, '2018-11-23');
INSERT INTO WMS.work_order_inventory(WorkOrderCode, InventoryCode, NumberOfUnits) VALUES ('CCC123', '7896594000013', 3);
INSERT INTO WMS.work_order_inventory(WorkOrderCode, InventoryCode, NumberOfUnits) VALUES ('CCC123', '000023', 3);
INSERT INTO WMS.work_order_inventory(WorkOrderCode, InventoryCode, NumberOfUnits) VALUES ('CCC123', '000022', 3);
INSERT INTO WMS.work_order_inventory(WorkOrderCode, InventoryCode, NumberOfUnits) VALUES ('DDD123', '041333665665', 3);
INSERT INTO WMS.work_order_inventory(WorkOrderCode, InventoryCode, NumberOfUnits) VALUES ('DDD123', '000021', 2);
INSERT INTO WMS.invoice(InvoiceCode, Date, Method) VALUES ('9ZE8-BH87-KAL9-TUUJ', '2018-11-23', 'Cash');
INSERT INTO WMS.invoice_workorder(InvoiceCode2, WorkOrderCode2) VALUES ('9ZE8-BH87-KAL9-TUUJ', 'CCC123');
INSERT INTO WMS.invoice_workorder(InvoiceCode2, WorkOrderCode2) VALUES ('9ZE8-BH87-KAL9-TUUJ', 'DDD123');

INSERT INTO WMS.customer (FirstName, LastName, Phone) VALUES ('Michael', 'Cook', '0122636603');
SET @last_id_in_table1 = LAST_INSERT_ID();
INSERT INTO WMS.address(Street, City, Postcode, State, CustomerID) VALUES ('Jalan', 'Petaling Jaya', '47800', 'Selangor', @last_id_in_table1);
INSERT INTO WMS.vehicle(RegistrationNo, CustomerID2, ChassisNo, Make, Model, Year, Engine, Transmission, FuelType, Mileage) VALUES ('iGsvog2o', @last_id_in_table1, 'UMtPh7diSVfcD' ,'cjZUTJfraZCjC' ,'JfF3hujdf4mUz', 1998, 'E5p7rhgCcXW4A', 'awoakweoY3PEN', 'RuKTyFEASrdg4', 10000);
INSERT INTO WMS.work_order(WorkOrderCode, Description, AdvisoryNote, TotalCost, CustomerID3, WorkOrderTime) VALUES ('FFF123', '', '', 311.00, @last_id_in_table1, '2018-11-23');
INSERT INTO WMS.work_order_inventory(WorkOrderCode, InventoryCode, NumberOfUnits) VALUES ('FFF123', '000025', 4);
INSERT INTO WMS.work_order_inventory(WorkOrderCode, InventoryCode, NumberOfUnits) VALUES ('FFF123', '041333665665', 1);
INSERT INTO WMS.work_order_inventory(WorkOrderCode, InventoryCode, NumberOfUnits) VALUES ('FFF123', '000015', 1);
INSERT INTO WMS.invoice(InvoiceCode, Date, Method) VALUES ('X9JK-SP8L-XPJE-QR9N', '2018-11-20', 'Cash');
INSERT INTO WMS.invoice_workorder(InvoiceCode2, WorkOrderCode2) VALUES ('X9JK-SP8L-XPJE-QR9N', 'FFF123');

INSERT INTO WMS.customer (FirstName, LastName, Phone) VALUES ('William', 'Henderson', '0122414337');
SET @last_id_in_table1 = LAST_INSERT_ID();
INSERT INTO WMS.address(Street, City, Postcode, State, CustomerID) VALUES ('Jalan', 'Petaling Jaya', '47800', 'Selangor', @last_id_in_table1);
INSERT INTO WMS.vehicle(RegistrationNo, CustomerID2, ChassisNo, Make, Model, Year, Engine, Transmission, FuelType, Mileage) VALUES ('QNVxuehC', @last_id_in_table1, 'ByRFCwHmowJ3t' ,'HU9NDHrqAePZT' ,'aqXxyukEFy98K', 2000, 'Van5uYAq5PabA', 'UEsJcdbpsGPbA', 'wxZD62wniNX2q', 20000);
INSERT INTO WMS.work_order(WorkOrderCode, Description, AdvisoryNote, TotalCost, CustomerID3, WorkOrderTime) VALUES ('KKC123', '', '', 311.00, @last_id_in_table1, '2018-11-23');
INSERT INTO WMS.work_order_inventory(WorkOrderCode, InventoryCode, NumberOfUnits) VALUES ('KKC123', '7896594000013', 5);
INSERT INTO WMS.work_order_inventory(WorkOrderCode, InventoryCode, NumberOfUnits) VALUES ('KKC123', '000021', 2);
INSERT INTO WMS.invoice(InvoiceCode, Date, Method) VALUES ('4PZH-MUBX-TQDW-E2TT', '2018-11-10', 'Card');
INSERT INTO WMS.invoice_workorder(InvoiceCode2, WorkOrderCode2) VALUES ('4PZH-MUBX-TQDW-E2TT', 'KKC123');

INSERT INTO WMS.customer (FirstName, LastName, Phone) VALUES ('David', 'Jenkins', '0121285082');
SET @last_id_in_table1 = LAST_INSERT_ID();
INSERT INTO WMS.address(Street, City, Postcode, State, CustomerID) VALUES ('Jalan', 'Petaling Jaya', '47800', 'Selangor', @last_id_in_table1);
INSERT INTO WMS.vehicle(RegistrationNo, CustomerID2, ChassisNo, Make, Model, Year, Engine, Transmission, FuelType, Mileage) VALUES ('drQxyJkB', @last_id_in_table1, 'qvQwqU79EDcMt' ,'crChS6ChgEG7Y' ,'jEAcD2a5yduLk', 2003, '9EkGbPmMTDw3m', '8ZK4oPwKrNrxn', 'Y7hwN8D3LZC8j', 20000);
INSERT INTO WMS.work_order(WorkOrderCode, Description, AdvisoryNote, TotalCost, CustomerID3, WorkOrderTime) VALUES ('GGC123', '', '', 311.00, @last_id_in_table1, '2018-11-23');
INSERT INTO WMS.work_order_inventory(WorkOrderCode, InventoryCode, NumberOfUnits) VALUES ('GGC123', '041333665665', 3);
INSERT INTO WMS.work_order_inventory(WorkOrderCode, InventoryCode, NumberOfUnits) VALUES ('GGC123', '000025', 2);
INSERT INTO WMS.invoice(InvoiceCode, Date, Method) VALUES ('PAGU-7H2S-PAHH-23HG', '2018-11-1', 'Card');
INSERT INTO WMS.invoice_workorder(InvoiceCode2, WorkOrderCode2) VALUES ('PAGU-7H2S-PAHH-23HG', 'GGC123');

INSERT INTO WMS.customer (FirstName, LastName, Phone) VALUES ('Joseph', 'Long', '0120968907');
SET @last_id_in_table1 = LAST_INSERT_ID();
INSERT INTO WMS.address(Street, City, Postcode, State, CustomerID) VALUES ('Jalan', 'Petaling Jaya', '47800', 'Selangor', @last_id_in_table1);
INSERT INTO WMS.vehicle(RegistrationNo, CustomerID2, ChassisNo, Make, Model, Year, Engine, Transmission, FuelType, Mileage) VALUES ('8UzNQLjK', @last_id_in_table1, 'RuEx3eqq5RKQ6' ,'PQ4BCL6o7KyUu' ,'zoABwN58ejuGx', 2005, 'oFd5gCBzVVLxA', 'tzA6rhtfKQXNL', '6oJycxSkPbD7J', 20000);
INSERT INTO WMS.work_order(WorkOrderCode, Description, AdvisoryNote, TotalCost, CustomerID3, WorkOrderTime) VALUES ('PPC123', '', '', 311.00, @last_id_in_table1, '2018-11-23');
INSERT INTO WMS.work_order_inventory(WorkOrderCode, InventoryCode, NumberOfUnits) VALUES ('PPC123', '000015', 3);
INSERT INTO WMS.work_order_inventory(WorkOrderCode, InventoryCode, NumberOfUnits) VALUES ('PPC123', '000022', 2);
INSERT INTO WMS.invoice(InvoiceCode, Date, Method) VALUES ('FVCC-F8MB-B7DA-ZUVH', '2018-10-1', 'Cash');
INSERT INTO WMS.invoice_workorder(InvoiceCode2, WorkOrderCode2) VALUES ('FVCC-F8MB-B7DA-ZUVH', 'PPC123');

INSERT INTO WMS.customer (FirstName, LastName, Phone) VALUES ('Thomas', 'Russell', '0167446870');
SET @last_id_in_table1 = LAST_INSERT_ID();
INSERT INTO WMS.address(Street, City, Postcode, State, CustomerID) VALUES ('Jalan', 'Petaling Jaya', '47800', 'Selangor', @last_id_in_table1);
INSERT INTO WMS.vehicle(RegistrationNo, CustomerID2, ChassisNo, Make, Model, Year, Engine, Transmission, FuelType, Mileage) VALUES ('Mf8aLUgY', @last_id_in_table1, '9swbjh4qWPUnH' ,'vBgiKD3AenoAf' ,'zkVQXq7Eq4NJh', 2011, 'b8W8SBYDhGzyh', 'c7yoeDcnQs7KM', '45yQJPMcn5itm', 20000);
INSERT INTO WMS.work_order(WorkOrderCode, Description, AdvisoryNote, TotalCost, CustomerID3, WorkOrderTime) VALUES ('LKC123', '', '', 311.00, @last_id_in_table1, '2018-11-23');
INSERT INTO WMS.work_order_inventory(WorkOrderCode, InventoryCode, NumberOfUnits) VALUES ('LKC123', '000017', 4);
INSERT INTO WMS.work_order_inventory(WorkOrderCode, InventoryCode, NumberOfUnits) VALUES ('LKC123', '7896594000013', 2);
INSERT INTO WMS.invoice(InvoiceCode, Date, Method) VALUES ('Y43E-DFXN-A3KN-HR3S', '2018-8-23', 'Cash');
INSERT INTO WMS.invoice_workorder(InvoiceCode2, WorkOrderCode2) VALUES ('Y43E-DFXN-A3KN-HR3S', 'LKC123');

INSERT INTO WMS.customer (FirstName, LastName, Phone) VALUES ('Charles', 'Hayes', '0169312948');
SET @last_id_in_table1 = LAST_INSERT_ID();
INSERT INTO WMS.address(Street, City, Postcode, State, CustomerID) VALUES ('Jalan', 'Petaling Jaya', '47800', 'Selangor', @last_id_in_table1);
INSERT INTO WMS.vehicle(RegistrationNo, CustomerID2, ChassisNo, Make, Model, Year, Engine, Transmission, FuelType, Mileage) VALUES ('fRgPN5MP', @last_id_in_table1, 'qiJQWG9qZnTUh' ,'q8RZ89stcqy43' ,'rb2Fk4FUYa2Eu', 2007, 'Xcu7vqaL5Z2U8', '3cwzZjkpoqJgs', 'h5t5o27kKqLC6', 20000);
INSERT INTO WMS.work_order(WorkOrderCode, Description, AdvisoryNote, TotalCost, CustomerID3, WorkOrderTime) VALUES ('YUC123', '', '', 311.00, @last_id_in_table1, '2018-11-23');
INSERT INTO WMS.work_order_inventory(WorkOrderCode, InventoryCode, NumberOfUnits) VALUES ('YUC123', '000017', 3);
INSERT INTO WMS.work_order_inventory(WorkOrderCode, InventoryCode, NumberOfUnits) VALUES ('YUC123', '000010', 2);
INSERT INTO WMS.invoice(InvoiceCode, Date, Method) VALUES ('H492-CXU6-25C3-3WT6', '2018-8-1', 'Cash');
INSERT INTO WMS.invoice_workorder(InvoiceCode2, WorkOrderCode2) VALUES ('H492-CXU6-25C3-3WT6', 'YUC123');

INSERT INTO WMS.customer (FirstName, LastName, Phone) VALUES ('Kenneth', 'Kelly', '0163333347');
SET @last_id_in_table1 = LAST_INSERT_ID();
INSERT INTO WMS.address(Street, City, Postcode, State, CustomerID) VALUES ('Jalan', 'Petaling Jaya', '47800', 'Selangor', @last_id_in_table1);
INSERT INTO WMS.vehicle(RegistrationNo, CustomerID2, ChassisNo, Make, Model, Year, Engine, Transmission, FuelType, Mileage) VALUES ('6hQymTGC', @last_id_in_table1, 'DjYFwhdz6pyLq' ,'9L9Qr8kuh2QBP' ,'48hB7E43NbShi', 2000, 'JZBLFZyayp4rN', 'BAfqyV64PcWNq', 'RyV3bkQdFJ6Th', 20000);
INSERT INTO WMS.work_order(WorkOrderCode, Description, AdvisoryNote, TotalCost, CustomerID3, WorkOrderTime) VALUES ('MNC123', '', '', 311.00, @last_id_in_table1, '2018-11-23');
INSERT INTO WMS.work_order_inventory(WorkOrderCode, InventoryCode, NumberOfUnits) VALUES ('MNC123', '000015', 3);
INSERT INTO WMS.work_order_inventory(WorkOrderCode, InventoryCode, NumberOfUnits) VALUES ('MNC123', '000014', 3);
INSERT INTO WMS.invoice(InvoiceCode, Date, Method) VALUES ('38Z3-8KTR-DFG5-YB54', '2018-7-23', 'Card');
INSERT INTO WMS.invoice_workorder(InvoiceCode2, WorkOrderCode2) VALUES ('38Z3-8KTR-DFG5-YB54', 'MNC123');

INSERT INTO WMS.customer (FirstName, LastName, Phone) VALUES ('Steven', 'Sanders', '0161999912');
SET @last_id_in_table1 = LAST_INSERT_ID();
INSERT INTO WMS.address(Street, City, Postcode, State, CustomerID) VALUES ('Jalan', 'Petaling Jaya', '47800', 'Selangor', @last_id_in_table1);
INSERT INTO WMS.vehicle(RegistrationNo, CustomerID2, ChassisNo, Make, Model, Year, Engine, Transmission, FuelType, Mileage) VALUES ('pfqGoYvP', @last_id_in_table1, 'QMho4LVuShmHK' ,'GRqTLfQjyAEe8' ,'XMEmkwDDKRUGa', 1999, 'kLxS48pHFeMa4', '7wQtmvuGFR4dU', 'm7V8rSrVs4JJT', 20000);
INSERT INTO WMS.work_order(WorkOrderCode, Description, AdvisoryNote, TotalCost, CustomerID3, WorkOrderTime) VALUES ('POL123', '', '', 311.00, @last_id_in_table1, '2018-11-23');
INSERT INTO WMS.work_order_inventory(WorkOrderCode, InventoryCode, NumberOfUnits) VALUES ('POL123', '000022', 7);
INSERT INTO WMS.invoice(InvoiceCode, Date, Method) VALUES ('E6UW-BSCL-VXDJ-ST95', '2018-1-8', 'Card');
INSERT INTO WMS.invoice_workorder(InvoiceCode2, WorkOrderCode2) VALUES ('E6UW-BSCL-VXDJ-ST95', 'POL123');
