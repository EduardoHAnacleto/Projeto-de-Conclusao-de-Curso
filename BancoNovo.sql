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
        payment_fees decimal (10,2) not null,
        fine_value decimal (10,2) not null,
        discount_perc decimal (10,2) null,
        instalment_quantity int not null,
        date_creation datetime not null,
        date_last_update datetime not null
    );
	
    create table BILLSINSTALMENTS(
        paycondition_id int not null references PAYMENTCONDITIONS(id_paycondition) ON DELETE CASCADE,
        instalment_number int not null,
        paymethod_id int not null references PaymentMethods(id_payment_method),
        total_days int not null,
        value_percentage decimal (5,2) not null,
        date_creation datetime not null,
        date_last_update datetime not null,
        primary key (paycondition_id, instalment_number)
    );


    create table PHONECLASSIFICATIONS(
	    id_phoneClassification int identity(2,1) primary key,
	    phoneClassification_name varchar(15) not null,
	    date_creation datetime not null,
	    date_last_update datetime not null
	);

    Insert into PHONECLASSIFICATIONS (phoneClassification_name, date_creation,date_last_update) values ('NULO','01/01/2000','01/01/2000');

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
        date_last_update datetime not null,
        payCond_id int not null foreign key references PAYMENTCONDITIONS(id_paycondition)
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
		baseSalary decimal (10,2) not null,
		weeklyHours int not null,
        employee_status int not null,
		admission_date datetime not null,
		dismissed_date datetime,
        home_type varchar(15) not null,
        date_creation datetime not null,
        date_last_update datetime not null,		
	);

	    create table USERS(
        id_user int identity(2,1) primary key,
        userLogin varchar(15) not null,
		userPassword varchar(15) not null,
        levelAccess int not null,
        date_creation datetime not null,
        date_last_update datetime not null
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
        payCond_id int not null foreign key references PAYMENTCONDITIONS(id_paycondition)
    );

    create table PRODUCTS(
        id_product int identity(2,1) primary key,
        product_name varchar(50) not null,
        product_sale_price decimal (10,2) not null,
        product_group_id int references ProductGroups(id_product_group),        
        brand_id int references Brands(id_brand),
        stock int not null default 0,
        product_cost decimal (10,2) not null,
        product_barcode bigint,
        date_creation datetime not null,
        date_last_update datetime not null,
        product_und varchar(5) not null,
        age_restricted int not null
    );

    create table SERVICES(
        id_service int identity(2,1) primary key,
        desc_service varchar(100) not null,
        service_value decimal (10,2) not null,
        date_creation datetime not null,
        date_last_update datetime not null
    );

    create table SALES(
        id_sale int identity(2,1) primary key,
        CLIENT_ID int not null references CLIENTS(id_client),
        user_id int not null references USERS(id_user),        
        sale_total_cost decimal (10,2) not null,
        sale_total_value decimal (10,2) not null,
        total_Items_Quantity int not null,      
        paycondition_id int not null references PAYMENTCONDITIONS(id_paycondition),
        sale_cancel_date datetime DEFAULT NULL,
        cancel_motive varchar[50] DEFAULT NULL,
        date_creation datetime not null,
    );

	create table BILLSTORECEIVE(
        id_bill int not null,
        sale_id int not null,
        instalmentNumber int not null, 
        instalmentValue decimal (10,2) not null,
        isPaid int not null,
        paidDate datetime,
        client_id int not null foreign key references CLIENTS(id_client),
        payMethod_id int not null foreign key references PAYMENTMETHODS(id_payment_method),
        payCond_id int not null foreign key references PAYMENTCONDITIONS(id_paycondition),
        instalmentsQtd int not null,
        dueDate date not null,
        emissionDate date not null,
        date_creation date not null,
        DATE_CANCELLED date,
        MOTIVE_CANCELLED varchar(150),
        date_last_update date not null,
        user_id int not null,
        primary key(id_bill,instalmentNumber),
        foreign key(user_id) references USERS(id_user)
    );

    create table SALEITEMS(
		SALE_ID int REFERENCES Sales(id_sale),
        PRODUCT_ID int not null references Products(id_product),
        QUANTITY int not null,
        ITEM_VALUE decimal (10,2)not null,
        ITEM_COST decimal (10,2) not null,
        DISCOUNT_CASH decimal (10,2) not null,
        TOTAL_VALUE decimal (10,2) not null,
        CANCEL_DATE date,
        DATE_CREATION date not null,
        DATE_LAST_UPDATE date not null,
        primary key(SALE_ID, PRODUCT_ID)
    );

        create table PURCHASES(
        billModel int not null,
        billNumber int not null,
        billSeries int not null,
        emissionDate date not null,
        arrivalDate date,
        freightCost decimal (10,2),
        purchase_TotalCost decimal (10,2) not null,
        purchase_ExtraExpenses decimal (10,2),
        purchase_InsuranceCost decimal (10,2),
        cancelledDate date,
        cancelledMotive varchar[50],
        paidDate date,
        paycondition_id int not null references PAYMENTCONDITIONS(id_paycondition),
        supplier_id int not null references SUPPLIERS(id_supplier),
        user_id int not null references USERS (id_user),
        date_creation datetime not null,
        date_last_update datetime not null,
        primary key(billModel, billNumber, billSeries, supplier_id)
    );

	    create table BILLSTOPAY(
        billNumber int not null,
        billModel int not null,
        billSeries int not null ,
		instalmentNumber int not null,
        dueDate date not null,
        emissionDate date not null,
        billStatus int not null,
        paidDate date,
        BillValue decimal (10,2) not null,
        payMethod_id int not null references PaymentMethods(id_payment_method),
        supplier_id int not null references Suppliers(id_supplier),
        payCond_id int not null foreign key references PAYMENTCONDITIONS(id_paycondition),
        date_creation datetime not null,
        date_last_update datetime not null,
        date_cancelled datetime,
        MOTIVE_CANCELLED varchar(150),
        user_id int not null references USERS(id_user),
        primary key (billNumber, billModel, billSeries, instalmentNumber, supplier_id)
    );

        CREATE TABLE PURCHASEBILLS (
        billNumber int not null,
        billModel int not null,
        billSeries int not null,
        supplier_id int not null,
		instalmentNumber int not null,
        PRIMARY KEY (supplier_id, billNumber, billModel, billSeries, instalmentNumber),
        FOREIGN KEY (billNumber, billModel, billSeries, instalmentNumber, supplier_id)
        REFERENCES BILLSTOPAY (billNumber, billModel, billSeries, instalmentNumber, supplier_id)
    );

    	create table PURCHASEITEMS(
        billModel int not null,
        billNumber int not null,
        billSeries int not null,
        supplier_id int not null,
        PRODUCT_ID int not null references PRODUCTS(id_product),
        QUANTITY int not null,
        PRODUCT_COST decimal (10,2)  not null,
        PURCHASE_PERCENTAGE decimal (10,2) not null,
        DISCOUNT_CASH decimal (10,2) not null,
        WEIGHTED_AVG decimal (10,2) not null,
        PRE_ITEMCOST decimal (10,2) not null,
        DATE_CREATION date not null,
        DATE_CANCELLED date,
        primary key (billModel, billNumber, billSeries, supplier_id, PRODUCT_ID),
		FOREIGN KEY (billModel, billNumber, billSeries, supplier_id)
        REFERENCES PURCHASES (billModel, billNumber, billSeries, supplier_id)
    );

    INSERT INTO PHONECLASSIFICATIONS ( PHONECLASSIFICATION_NAME, DATE_CREATION, DATE_LAST_UPDATE) VALUES ('PESSOAL', '01/01/2020', '01/01/2020');
    INSERT INTO USERS ( USERLOGIN, USERPASSWORD, LEVELACCESS , DATE_CREATION, DATE_LAST_UPDATE) VALUES ('admin', 'admin', 3, '10/10/2020', '10/10/2020');
    INSERT INTO PAYMENTMETHODS ( PAYMENT_METHOD, DATE_CREATION, DATE_LAST_UPDATE) VALUES ('DINHEIRO', '10/10/2020', '10/10/2020');
    INSERT INTO PAYMENTCONDITIONS ( CONDITION_NAME, PAYMENT_FEES, FINE_VALUE, DISCOUNT_PERC, INSTALMENT_QUANTITY , DATE_CREATION, DATE_LAST_UPDATE ) VALUES ('A VISTA', 0, 0, 0, 1, '01/01/2020', '01/01/2020');
    DECLARE @METHODID INT;
	SET @METHODID = IDENT_CURRENT ('PAYMENTMETHODS');
    DECLARE @PAYCONDID INT;
	SET @PAYCONDID = IDENT_CURRENT ('PAYMENTCONDITIONS');
    INSERT INTO BILLSINSTALMENTS ( PAYCONDITION_ID, INSTALMENT_NUMBER, PAYMETHOD_ID, TOTAL_DAYS, VALUE_PERCENTAGE, DATE_CREATION, DATE_LAST_UPDATE) VALUES (@PAYCONDID, 1, @METHODID, 0, 100, '10/10/2020', '10/10/2020');
