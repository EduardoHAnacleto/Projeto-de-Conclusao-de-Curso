    create table COUNTRIES(
        id_country int identity(2,1) primary key,
        country_name varchar(50) not null,
        country_acronym varchar(3) not null,
        country_phonePrefix varchar(4),
        country_currency varchar(10),
        date_creation datetime not null,
        date_last_update datetime not null
    );

    create table STATES(
        id_state int identity(2,1) primary key,
        state_name varchar(50) not null,
        state_fed_unit varchar(3) not null,
        id_country int foreign key references Countries(id_country),
        date_creation datetime not null,
        date_last_update datetime not null
    );

    create table CITIES(
        id_city int identity(2,1) primary key,
        city_name varchar(50) not null,
        city_phone_prefix varchar(4),
        state_id int foreign key references States(id_state),
        date_creation datetime not null,
        date_last_update datetime not null
    );

    create table BRANDS(
        id_brand int identity(2,1) primary key,
        brand_name varchar(30) not null,
        date_creation datetime not null,
        date_last_update datetime not null
    );

    create table PRODUCTGROUPS(
        id_product_group int identity(2,1) primary key,
        product_group varchar(30) not null,
        description_product_group varchar(30),
        date_creation datetime not null,
        date_last_update datetime not null
    );

    create table PAYMENTMETHODS(
        id_payment_method int identity(2,1) primary key,
        payment_method varchar(30) not null,
        date_creation datetime not null,
        date_last_update datetime not null
    );

    create table PAYMENTCONDITIONS(
        id_paycondition int identity(2,1) primary key,
        condition_name varchar(30) not null,
        payment_fees decimal(10,2) not null,
        fine_value decimal(10,2) not null,
        discount_perc decimal(10,2) null,
        instalment_quantity int not null,
        date_creation datetime not null,
        date_last_update datetime not null
    );

    create table PAYCONDITIONINSTALMENTS(
		paycondition_id int not null references PAYMENTCONDITIONS(id_paycondition) ON DELETE CASCADE,
		instalment_number int not null,
		days_count int not null,
        value_percentage decimal(10,2) not null,	
		method_id int not null references PAYMENTMETHODS(id_payment_method)
	);

    create table PHONECLASSIFICATIONS(
	    id_phoneClassification int identity(2,1) primary key,
	    phoneClassification_name varchar(20) not null,
	    date_creation datetime not null,
	    date_last_update datetime not null
	);

    Insert into PHONECLASSIFICATIONS (phoneClassification_name, date_creation,date_last_update) values ('NULL','01/01/2000','01/01/2000');

    create table CLIENTS(
        id_client int identity(2,1) primary key,
        client_name varchar(50) not null,
        client_gender int not null,
        client_registration varchar(14),
        client_age int not null,
        client_dob DateTime not null,
        client_email varchar(30) not null,
        client_phone1 varchar(12) not null,
        client_phone2 varchar(12),
        client_phone3 varchar(12),
        client_phone_class1 int not null references PHONECLASSIFICATIONS(id_phoneClassification),
        client_phone_class2 int references PHONECLASSIFICATIONS(id_phoneClassification),
        client_phone_class3 int references PHONECLASSIFICATIONS(id_phoneClassification),
		CLIENT_STREET_NAME varchar(50) not null,
        CLIENT_DISTRICT varchar(50) not null,
        CLIENT_HOUSE_NUMBER varchar(10) not null,
        CLIENT_HOME_TYPE varchar(15) not null,
        CLIENT_COMPLEMENT varchar(30),
        CLIENT_ZIP_CODE varchar(10) not null,
        city_id int not null foreign key references CITIES(id_city),
        client_type int not null,
        date_creation datetime not null,
        date_last_update datetime not null
    );
	
		create table EMPLOYEES(
        id_employee int identity(2,1) primary key,
        employee_name varchar(50) not null,
        employee_gender int not null,
        employee_age int not null,
        employee_registration varchar(14),
        employee_dob DateTime not null,
        employee_email varchar(30) not null,
        employee_phone1 varchar(12) not null,
        employee_phone2 varchar(12),
        employee_phone3 varchar(12),
        employee_phone_class1 int not null references PHONECLASSIFICATIONS(id_phoneClassification),
        employee_phone_class2 int references PHONECLASSIFICATIONS(id_phoneClassification),
        employee_phone_class3 int references PHONECLASSIFICATIONS(id_phoneClassification),
		street_name varchar(50) not null,
        district varchar(50) not null,
        house_number varchar(10) not null,
        complement varchar(30),
        zipcode varchar(10) not null,
        id_city int foreign key references Cities(id_city),
		jobRole varchar(30) not null,
		baseSalary decimal(10,2) not null,
		weeklyHours int not null,
        employee_status int not null,
		admission_date datetime not null,
		dismissed_date datetime,
        home_type varchar(15) not null,
        date_creation datetime not null,
        date_last_update datetime not null,		
	);

    create table SUPPLIERS(
        id_supplier int identity(2,1) primary key,
        supplier_registration varchar(14),
        supplier_name varchar(50) not null,
		supplier_social_reason varchar(50),
        supplier_state_inscription varchar(9) not null,
        supplier_email varchar(30) not null,
        supplier_phone1 varchar(12) not null,
        supplier_phone2 varchar(12),
        supplier_phone3 varchar(12),
        supplier_phone_class1 int not null references PHONECLASSIFICATIONS(id_phoneClassification),
        supplier_phone_class2 int references PHONECLASSIFICATIONS(id_phoneClassification),
        supplier_phone_class3 int references PHONECLASSIFICATIONS(id_phoneClassification),
		supplier_STREET_NAME varchar(50) not null,
        supplier_DISTRICT varchar(50) not null,
        supplier_HOUSE_NUMBER varchar(10) not null,
        supplier_HOME_TYPE varchar(15) not null,
        supplier_COMPLEMENT varchar(30),
        supplier_ZIP_CODE varchar(10) not null,
        city_id int not null foreign key references Cities(id_city),
        date_creation datetime not null,
        date_last_update datetime not null,
    );

    create table PRODUCTS(
        id_product int identity(2,1) primary key,
        product_name varchar(50) not null,
        product_sale_price decimal(10,2) not null,
        product_group_id int references ProductGroups(id_product_group),        
        brand_id int references Brands(id_brand),
        stock int not null,
        product_cost decimal (10,2) not null,
        product_barcode bigint,
        date_creation datetime not null,
        date_last_update datetime not null
    );

    create table SUPPLIERPRODUCTS(
        id_product int not null references Products(id_product),
        id_supplier int not null references Suppliers(id_supplier),
        primary key (id_product, id_supplier)
    );

    create table BILLSTOPAY(
        num_danfe int not null,
        tipo_danfe int not null,
        serie_danfe int not null ,
        pag_danfe int not null,
		num_parc int not null,
        vencFatura date not null,
        valorFatura decimal(10,2) not null,
        formaPagto_id int not null references PaymentMethods(id_payment_method),
        fornecedor_id int not null references Suppliers(id_supplier),
        date_creation datetime not null,
        date_last_update datetime not null,
    );

    create table BILLSINSTALMENTS(
        instalment_number int not null,
        paycondition_id int not null references PaymentConditions(id_paycondition),
        paymethod_id int not null references PaymentMethods(id_payment_method),
        total_days int not null,
        value_percentage decimal(3,2),
        date_creation datetime not null,
        date_last_update datetime not null,
        CONSTRAINT PK_BILLSINSTALMENTS Primary Key (instalment_number, paycondition_id, paymethod_id)
    );

    create table SERVICES(
        id_service int identity(2,1) primary key,
        desc_service varchar(100) not null,
        service_value decimal(10,2) not null,
        date_creation datetime not null,
        date_last_update datetime not null
    );

    create table SERVICEORDERS(
        id_serviceOrder int identity(2,1) primary key,
        so_DateTime date not null,
        so_equipment varchar(50) not null,
        service_id int references Services(id_service),
        client_id int references CLIENTS(id_client),
        extra_details varchar(255),
        date_creation datetime not null,
        date_last_update datetime not null
    );

    create table SERVICEORDERSPRODUCTS(
        SONumber_id int not null references ServiceOrders(id_serviceOrder),
        product_id int not null references Products(id_product)
    );

    create table BILLSTORECEIVE(
        id_bill_to_receive int identity(2,1) primary key,
        instalment_value decimal not null,
        is_paid int not null,
        client_id int not null foreign key references CLIENTS(id_client),
        payform_id int not null foreign key references PaymentMethods(id_payment_method),
        instalment_number int not null, 
        due_date date not null,
        emission_date date not null,
        date_creation date not null,
        date_last_update date not null
    );

    create table SALES(
        id_sale int identity(2,1) primary key,
        CLIENT_ID int not null references CLIENTS(id_client),        
        sale_total_cost decimal not null,
        sale_total_value decimal not null,
        sale_discount decimal not null,
        total_Items_Quantity int not null,
        emission_date date not null,
        cancel_date date,
        date_creation datetime not null,
        date_last_update datetime not null,
        bill_to_receive_id int foreign key references BillsToReceive(id_bill_to_receive)
    );

    create table SALEITEMS(
        ID_SALEITEM int identity(2,1) primary key,
		SALE_ID int REFERENCES Sales(id_sale),
        PRODUCT_ID int not null references Products(id_product),
        QUANTITY int not null,
        SALE_VALUE decimal not null,
        DISCOUNT decimal not null,
        TOTAL_VALUE decimal not null,
        DATE_CREATION date not null,
        DATE_LAST_UPDATE date not null
    );

	    create table PURCHASEITEMS(
        id_purchaseitems int identity(2,1) primary key,
        total_value decimal not null,
        discount decimal not null,
        date_creation date not null,
        date_last_update date not null
    );

    create table PURCHASES(
        id_purchase int identity(2,1) primary key,
        purchase_status int not null,
        emission_date date not null,
        arrival_date date,
        freight_cost decimal,
        purchase_total_cost decimal not null,
        purchase_cost_expenses decimal,
        purchase_discount decimal,
        purchase_insurance decimal,
        paycondition_id int not null references PaymentConditions(id_paycondition),
        purchase_items_id int not null references PurchaseItems(id_purchaseitems),
        supplier_id int not null,
        date_creation datetime not null,
        date_last_update datetime not null,
    );

    create table USERS(
        id_user int identity(2,1) primary key,
        employee_id int FOREIGN KEY references EMPLOYEES(id_employee),
        userLogin varchar(15) not null,
		userPassword varchar(15) not null,
        levelAccess int not null,
        date_creation datetime not null,
        date_last_update datetime not null
    );