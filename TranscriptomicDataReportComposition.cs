// Generated using tdo-csharp.xsl v1.5 ($Revision: 4422 $)  
using System;
using System.Collections.Generic;
using OceanEhr.EhrGate.TemplateObjects;
using OceanEhr.EhrGate.TemplateObjects.Base;
using OceanEhr.OpenEhrV1;
using OceanEhr.OpenEhrV1.Common.Generic;
using OceanEhr.OpenEhrV1.DataTypes.Basic;
using OceanEhr.OpenEhrV1.DataTypes.Uri;
using OceanEhr.OpenEhrV1.DataTypes.Text;
using OceanEhr.OpenEhrV1.DataTypes.Quantity;
using OceanEhr.OpenEhrV1.DataTypes.Quantity.DateTime;
using OceanEhr.OpenEhrV1.DataTypes.Encapsulated;

namespace OceanInformatics.TemplateObjects
{    
    
        
    [Template("Gene Expression Lab Report_Template_v7")]
    [Archetype("openEHR-EHR-COMPOSITION.report-result.v1", "Result Report")]        
    public partial class  TranscriptomicDataReportComposition
        : CompositionBase, IEventComposition
    {
        
        public TranscriptomicDataReportComposition()
            : this(null)
        { }
        
        public TranscriptomicDataReportComposition(OceanEhr.OpenEhrV1.Common.Generic.PartyProxy composer)
            : base(composer, "Transcriptomic Data Report")
        {
            
			_context = new EventContext();
			
        }                  
            	
        #region Event Context

        private EventContext _context;
        
        public EventContext Context
        {
            get { return _context; }
            set { _context = value; }
        }

        IEventContext IEventComposition.Context
        {
            get { return this.Context; }
            set { this.Context = value as EventContext; }
        }
        
        public class EventContext : EventContextBase
        {
            private DvText reportId;
        
            [Element("/other_context/items", "at0002", "Report ID")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText ReportId            
            {
                get { return reportId; }
                set { reportId = value; }
            }

            private DvText reportStatus;
        
            [Element("/other_context/items", "at0005", "Status")]
            [AttributeConstraint("value", "DV_TEXT")]
            [TextAttribute("name", "Report Status")]
            
            public DvText ReportStatus            
            {
                get { return reportStatus; }
                set { reportStatus = value; }
            }

                    
        private PatientDemographicsCluster patientDemographics;
                
        [Cluster("/other_context/items")]
        [TextAttribute("name", "Patient Demographics")]                
        public PatientDemographicsCluster PatientDemographics            
        {
            get { return patientDemographics; }
            set  { patientDemographics = value; }
        }
        
    	
        [Archetype("openEHR-EHR-CLUSTER.individual_personal.v1", "Individual's personal demographics")]                
        public partial  class  PatientDemographicsCluster : LocatableBase, ICluster
        {             
        private PatientNameCluster patientName;
                
        [Cluster("/items")]
        [TextAttribute("name", "Patient Name")]                
        public PatientNameCluster PatientName            
        {
            get { return patientName; }
            set  { patientName = value; }
        }
        
    	
        [Archetype("openEHR-EHR-CLUSTER.person_name.v1", "Person name")]                
        public partial  class  PatientNameCluster : LocatableBase, ICluster
        {     private DvCodedText nameType;
        
            [Element("/items", "at0006", "Name type")]
            [AttributeConstraint("value", "DV_CODED_TEXT")]
            public DvCodedText NameType            
            {
                get { return nameType; }
                set { nameType = value; }
            }

            private DvBoolean preferredName;
        
            [Element("/items", "at0022", "Preferred name")]
            [AttributeConstraint("value", "DV_BOOLEAN")]
            public DvBoolean PreferredName            
            {
                get { return preferredName; }
                set { preferredName = value; }
            }

            private DvText unstructuredName;
        
            [Element("/items", "at0001", "Unstructured name")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText UnstructuredName            
            {
                get { return unstructuredName; }
                set { unstructuredName = value; }
            }

                    
        private StructuredNameCluster structuredName;
                
        [Cluster("/items", "at0002", "Structured name")]                
        public StructuredNameCluster StructuredName            
        {
            get
            {
                if(structuredName == null)
                    StructuredName = new StructuredNameCluster();
                return structuredName; 
            }
            set 
            {
                structuredName = value;
                base.SetChildNode(value, "at0002");
            }
        }

        public partial class  StructuredNameCluster : LocatableBase, ICluster
        {
                        private DvText title;
        
            [Element("/items", "at0017", "Title")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText Title            
            {
                get { return title; }
                set { title = value; }
            }

            private DvText givenName;
        
            [Element("/items", "at0003", "Given name")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText GivenName            
            {
                get { return givenName; }
                set { givenName = value; }
            }

                    
            private List<DvCodedText> middleName;
        
            [Element("/items", "at0004", "Middle name")]
            [AttributeConstraint("value", "DV_CODED_TEXT")]            
            public List<DvCodedText> MiddleName            
            {
                get { return middleName; }
                set { middleName = value; }
            }

            private DvText familyName;
        
            [Element("/items", "at0005", "Family name")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText FamilyName            
            {
                get { return familyName; }
                set { familyName = value; }
            }

            private DvText suffix;
        
            [Element("/items", "at0018", "Suffix")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText Suffix            
            {
                get { return suffix; }
                set { suffix = value; }
            }

             
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        				
            Dictionary<string, string> middleNameMap = new Dictionary<string, string>();
        	objectConstraints.Add("MiddleNameMap", middleNameMap);
            
            List<DvCodedText> middleName = new List<DvCodedText>();
            objectConstraints.Add("MiddleName", middleName);
        }
        #endregion
    
        
        }
        private DvInterval<DvDateTime> validityPeriod;
        
            [Element("/items", "at0014", "Validity period")]
            [AttributeConstraint("value", "DV_INTERVAL<DV_DATE_TIME>")]
            public DvInterval<DvDateTime> ValidityPeriod            
            {
                get { return validityPeriod; }
                set { validityPeriod = value; }
            }

             
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        				
            Dictionary<string, string> nameTypeMap = new Dictionary<string, string>();
        	nameTypeMap.Add("at0020", "Registered name");
            nameTypeMap.Add("at0008", "Previous name");
            nameTypeMap.Add("at0009", "Birth name");
            nameTypeMap.Add("at0010", "AKA");
            nameTypeMap.Add("at0011", "Alias");
            nameTypeMap.Add("at0012", "Maiden name");
            nameTypeMap.Add("at0019", "Professional name");
            nameTypeMap.Add("at0021", "Reporting name");
            objectConstraints.Add("NameTypeMap", nameTypeMap);
            
            List<DvCodedText> nameType = new List<DvCodedText>();
            nameType.Add(OpenEhrFactory.DvCodedText("Registered name", "at0020", "local"));
            nameType.Add(OpenEhrFactory.DvCodedText("Previous name", "at0008", "local"));
            nameType.Add(OpenEhrFactory.DvCodedText("Birth name", "at0009", "local"));
            nameType.Add(OpenEhrFactory.DvCodedText("AKA", "at0010", "local"));
            nameType.Add(OpenEhrFactory.DvCodedText("Alias", "at0011", "local"));
            nameType.Add(OpenEhrFactory.DvCodedText("Maiden name", "at0012", "local"));
            nameType.Add(OpenEhrFactory.DvCodedText("Professional name", "at0019", "local"));
            nameType.Add(OpenEhrFactory.DvCodedText("Reporting name", "at0021", "local"));
            objectConstraints.Add("NameType", nameType);
        }
        #endregion
            
        }        
        private DvText identifier;
        
            [Element("/items", "at0016", "Identifier")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText Identifier            
            {
                get { return identifier; }
                set { identifier = value; }
            }

            private DvDateTime dateOfBirth;
        
            [Element("/items", "at0007", "Date of Birth")]
            [AttributeConstraint("value", "DV_DATE_TIME")]
            public DvDateTime DateOfBirth            
            {
                get { return dateOfBirth; }
                set { dateOfBirth = value; }
            }

            private DvCodedText sex;
        
            [Element("/items", "at0017", "Sex")]
            [AttributeConstraint("value", "DV_CODED_TEXT")]
            public DvCodedText Sex            
            {
                get { return sex; }
                set { sex = value; }
            }

                    
                private LocatableList<AddressCluster> address;
                
        [Cluster("/items")]
                
        public LocatableList<AddressCluster> Address            
        {
            get { return address; }
            set  { address = value; }
        }
        
    	
        [Archetype("openEHR-EHR-CLUSTER.address.v1", "Address")]                
        public partial  class  AddressCluster : LocatableBase, ICluster
        {             
        private LocatableList<AddressCluster> address;
        
        [Cluster("/items", "at0001", "Address")]
        public LocatableList<AddressCluster> Address            
        {
            get
            {
                return address; 
            }
            set 
            {
                address = value;
                base.SetChildNode(value, "at0001");
            }
        }

        public partial class  AddressCluster : LocatableBase, ICluster
        {
                        private DvCodedText addressType;
        
            [Element("/items", "at0006", "Address Type")]
            [AttributeConstraint("value", "DV_CODED_TEXT")]
            public DvCodedText AddressType            
            {
                get { return addressType; }
                set { addressType = value; }
            }

            private DvText unstructuredAddress;
        
            [Element("/items", "at0002", "Unstructured address")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText UnstructuredAddress            
            {
                get { return unstructuredAddress; }
                set { unstructuredAddress = value; }
            }

                    
        private StructuredAddressCluster structuredAddress;
                
        [Cluster("/items", "at0003", "Structured address")]                
        public StructuredAddressCluster StructuredAddress            
        {
            get
            {
                if(structuredAddress == null)
                    StructuredAddress = new StructuredAddressCluster();
                return structuredAddress; 
            }
            set 
            {
                structuredAddress = value;
                base.SetChildNode(value, "at0003");
            }
        }

        public partial class  StructuredAddressCluster : LocatableBase, ICluster
        {
                        private DvText propertyNumber;
        
            [Element("/items", "at0005", "Property number")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText PropertyNumber            
            {
                get { return propertyNumber; }
                set { propertyNumber = value; }
            }

                    
            private List<DvText> addressLine;
        
            [Element("/items", "at0009", "Address line")]
            [AttributeConstraint("value", "DV_TEXT")]            
            public List<DvText> AddressLine            
            {
                get { return addressLine; }
                set { addressLine = value; }
            }

             
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        }
        #endregion
    
        
        }
        private DvText postCode;
        
            [Element("/items", "at0004", "Post code")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText PostCode            
            {
                get { return postCode; }
                set { postCode = value; }
            }

                    
        private AddressvalidPeriodCluster addressvalidPeriod;
                
        [Cluster("/items", "at0015", "AddressValid Period")]                
        public AddressvalidPeriodCluster AddressvalidPeriod            
        {
            get
            {
                if(addressvalidPeriod == null)
                    AddressvalidPeriod = new AddressvalidPeriodCluster();
                return addressvalidPeriod; 
            }
            set 
            {
                addressvalidPeriod = value;
                base.SetChildNode(value, "at0015");
            }
        }

        public partial class  AddressvalidPeriodCluster : LocatableBase, ICluster
        {
                        private DvDateTime validFrom;
        
            [Element("/items", "at0007", "Valid from")]
            [AttributeConstraint("value", "DV_DATE_TIME")]
            public DvDateTime ValidFrom            
            {
                get { return validFrom; }
                set { validFrom = value; }
            }

            private DvDateTime validTo;
        
            [Element("/items", "at0008", "Valid to")]
            [AttributeConstraint("value", "DV_DATE_TIME")]
            public DvDateTime ValidTo            
            {
                get { return validTo; }
                set { validTo = value; }
            }

             
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        }
        #endregion
    
        
        }
         
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        				
            Dictionary<string, string> addressTypeMap = new Dictionary<string, string>();
        	addressTypeMap.Add("at0011", "Residential");
            addressTypeMap.Add("at0012", "Correspondence");
            addressTypeMap.Add("at0013", "Business");
            addressTypeMap.Add("at0014", "Temporary");
            objectConstraints.Add("AddressTypeMap", addressTypeMap);
            
            List<DvCodedText> addressType = new List<DvCodedText>();
            addressType.Add(OpenEhrFactory.DvCodedText("Residential", "at0011", "local"));
            addressType.Add(OpenEhrFactory.DvCodedText("Correspondence", "at0012", "local"));
            addressType.Add(OpenEhrFactory.DvCodedText("Business", "at0013", "local"));
            addressType.Add(OpenEhrFactory.DvCodedText("Temporary", "at0014", "local"));
            objectConstraints.Add("AddressType", addressType);
        }
        #endregion
    
        
        }
         
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        }
        #endregion
            
        }        
                
                private LocatableList<TelecomDetailsCluster> telecomDetails;
                
        [Cluster("/items")]
                
        public LocatableList<TelecomDetailsCluster> TelecomDetails            
        {
            get { return telecomDetails; }
            set  { telecomDetails = value; }
        }
        
    	
        [Archetype("openEHR-EHR-CLUSTER.telecom_details.v1", "Telecom details")]                
        public partial  class  TelecomDetailsCluster : LocatableBase, ICluster
        {             
            private List<DvCodedText> mode;
        
            [Element("/items", "at0010", "Mode")]
            [AttributeConstraint("value", "DV_CODED_TEXT")]            
            public List<DvCodedText> Mode            
            {
                get { return mode; }
                set { mode = value; }
            }

                    
        private LocatableList<TelecomsCluster> telecoms;
        
        [Cluster("/items", "at0001", "Telecoms")]
        public LocatableList<TelecomsCluster> Telecoms            
        {
            get
            {
                return telecoms; 
            }
            set 
            {
                telecoms = value;
                base.SetChildNode(value, "at0001");
            }
        }

        public partial class  TelecomsCluster : LocatableBase, ICluster
        {
                        private DvCodedText telecomsType;
        
            [Element("/items", "at0004", "Telecoms type")]
            [AttributeConstraint("value", "DV_CODED_TEXT")]
            public DvCodedText TelecomsType            
            {
                get { return telecomsType; }
                set { telecomsType = value; }
            }

            private DvText unstucturedTelecoms;
        
            [Element("/items", "at0002", "Unstuctured telecoms")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText UnstucturedTelecoms            
            {
                get { return unstucturedTelecoms; }
                set { unstucturedTelecoms = value; }
            }

                    
        private StructuredTelecomsCluster structuredTelecoms;
                
        [Cluster("/items", "at0003", "Structured telecoms")]                
        public StructuredTelecomsCluster StructuredTelecoms            
        {
            get
            {
                if(structuredTelecoms == null)
                    StructuredTelecoms = new StructuredTelecomsCluster();
                return structuredTelecoms; 
            }
            set 
            {
                structuredTelecoms = value;
                base.SetChildNode(value, "at0003");
            }
        }

        public partial class  StructuredTelecomsCluster : LocatableBase, ICluster
        {
                        private DvText countryCode;
        
            [Element("/items", "at0005", "Country code")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText CountryCode            
            {
                get { return countryCode; }
                set { countryCode = value; }
            }

            private DvText areaCode;
        
            [Element("/items", "at0006", "Area code")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText AreaCode            
            {
                get { return areaCode; }
                set { areaCode = value; }
            }

            private DvText number;
        
            [Element("/items", "at0007", "Number")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText Number            
            {
                get { return number; }
                set { number = value; }
            }

            private DvText extension;
        
            [Element("/items", "at0019", "Extension")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText Extension            
            {
                get { return extension; }
                set { extension = value; }
            }

             
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        }
        #endregion
    
        
        }
         
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        				
            Dictionary<string, string> telecomsTypeMap = new Dictionary<string, string>();
        	telecomsTypeMap.Add("at0013", "Telephone");
            telecomsTypeMap.Add("at0014", "Fax");
            telecomsTypeMap.Add("at0015", "Mobile phone");
            telecomsTypeMap.Add("at0016", "Pager");
            objectConstraints.Add("TelecomsTypeMap", telecomsTypeMap);
            
            List<DvCodedText> telecomsType = new List<DvCodedText>();
            telecomsType.Add(OpenEhrFactory.DvCodedText("Telephone", "at0013", "local"));
            telecomsType.Add(OpenEhrFactory.DvCodedText("Fax", "at0014", "local"));
            telecomsType.Add(OpenEhrFactory.DvCodedText("Mobile phone", "at0015", "local"));
            telecomsType.Add(OpenEhrFactory.DvCodedText("Pager", "at0016", "local"));
            objectConstraints.Add("TelecomsType", telecomsType);
        }
        #endregion
    
        
        }
                
            private List<DvText> emailAddress;
        
            [Element("/items", "at0009", "Email address")]
            [AttributeConstraint("value", "DV_TEXT")]            
            public List<DvText> EmailAddress            
            {
                get { return emailAddress; }
                set { emailAddress = value; }
            }

             
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        				
            Dictionary<string, string> modeMap = new Dictionary<string, string>();
        	modeMap.Add("at0011", "Home");
            modeMap.Add("at0012", "Work");
            modeMap.Add("at0018", "Contact");
            objectConstraints.Add("ModeMap", modeMap);
            
            List<DvCodedText> mode = new List<DvCodedText>();
            mode.Add(OpenEhrFactory.DvCodedText("Home", "at0011", "local"));
            mode.Add(OpenEhrFactory.DvCodedText("Work", "at0012", "local"));
            mode.Add(OpenEhrFactory.DvCodedText("Contact", "at0018", "local"));
            objectConstraints.Add("Mode", mode);
        }
        #endregion
            
        }        
         
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        				
            Dictionary<string, string> sexMap = new Dictionary<string, string>();
        	sexMap.Add("at0020", "Male");
            sexMap.Add("at0021", "Female");
            sexMap.Add("at0022", "Indeterminate");
            objectConstraints.Add("SexMap", sexMap);
            
            List<DvCodedText> sex = new List<DvCodedText>();
            sex.Add(OpenEhrFactory.DvCodedText("Male", "at0020", "local"));
            sex.Add(OpenEhrFactory.DvCodedText("Female", "at0021", "local"));
            sex.Add(OpenEhrFactory.DvCodedText("Indeterminate", "at0022", "local"));
            objectConstraints.Add("Sex", sex);
        }
        #endregion
            
        }        
                
        private AuthorCluster author;
                
        [Cluster("/other_context/items")]
        [TextAttribute("name", "Author")]                
        public AuthorCluster Author            
        {
            get { return author; }
            set  { author = value; }
        }
        
    	
        [Archetype("openEHR-EHR-CLUSTER.individual_professional.v1", "Professional Individual demographics")]                
        public partial  class  AuthorCluster : LocatableBase, ICluster
        {             
        private AuthorsNameCluster authorsName;
                
        [Cluster("/items")]
        [TextAttribute("name", "Author's Name")]                
        public AuthorsNameCluster AuthorsName            
        {
            get { return authorsName; }
            set  { authorsName = value; }
        }
        
    	
        [Archetype("openEHR-EHR-CLUSTER.person_name.v1", "Person name")]                
        public partial  class  AuthorsNameCluster : LocatableBase, ICluster
        {     private DvCodedText nameType;
        
            [Element("/items", "at0006", "Name type")]
            [AttributeConstraint("value", "DV_CODED_TEXT")]
            public DvCodedText NameType            
            {
                get { return nameType; }
                set { nameType = value; }
            }

            private DvBoolean preferredName;
        
            [Element("/items", "at0022", "Preferred name")]
            [AttributeConstraint("value", "DV_BOOLEAN")]
            public DvBoolean PreferredName            
            {
                get { return preferredName; }
                set { preferredName = value; }
            }

            private DvText unstructuredName;
        
            [Element("/items", "at0001", "Unstructured name")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText UnstructuredName            
            {
                get { return unstructuredName; }
                set { unstructuredName = value; }
            }

                    
        private StructuredNameCluster structuredName;
                
        [Cluster("/items", "at0002", "Structured name")]                
        public StructuredNameCluster StructuredName            
        {
            get
            {
                if(structuredName == null)
                    StructuredName = new StructuredNameCluster();
                return structuredName; 
            }
            set 
            {
                structuredName = value;
                base.SetChildNode(value, "at0002");
            }
        }

        public partial class  StructuredNameCluster : LocatableBase, ICluster
        {
                        private DvText title;
        
            [Element("/items", "at0017", "Title")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText Title            
            {
                get { return title; }
                set { title = value; }
            }

            private DvText givenName;
        
            [Element("/items", "at0003", "Given name")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText GivenName            
            {
                get { return givenName; }
                set { givenName = value; }
            }

                    
            private List<DvCodedText> middleName;
        
            [Element("/items", "at0004", "Middle name")]
            [AttributeConstraint("value", "DV_CODED_TEXT")]            
            public List<DvCodedText> MiddleName            
            {
                get { return middleName; }
                set { middleName = value; }
            }

            private DvText familyName;
        
            [Element("/items", "at0005", "Family name")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText FamilyName            
            {
                get { return familyName; }
                set { familyName = value; }
            }

            private DvText suffix;
        
            [Element("/items", "at0018", "Suffix")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText Suffix            
            {
                get { return suffix; }
                set { suffix = value; }
            }

             
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        				
            Dictionary<string, string> middleNameMap = new Dictionary<string, string>();
        	objectConstraints.Add("MiddleNameMap", middleNameMap);
            
            List<DvCodedText> middleName = new List<DvCodedText>();
            objectConstraints.Add("MiddleName", middleName);
        }
        #endregion
    
        
        }
        private DvInterval<DvDateTime> validityPeriod;
        
            [Element("/items", "at0014", "Validity period")]
            [AttributeConstraint("value", "DV_INTERVAL<DV_DATE_TIME>")]
            public DvInterval<DvDateTime> ValidityPeriod            
            {
                get { return validityPeriod; }
                set { validityPeriod = value; }
            }

             
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        				
            Dictionary<string, string> nameTypeMap = new Dictionary<string, string>();
        	nameTypeMap.Add("at0020", "Registered name");
            nameTypeMap.Add("at0008", "Previous name");
            nameTypeMap.Add("at0009", "Birth name");
            nameTypeMap.Add("at0010", "AKA");
            nameTypeMap.Add("at0011", "Alias");
            nameTypeMap.Add("at0012", "Maiden name");
            nameTypeMap.Add("at0019", "Professional name");
            nameTypeMap.Add("at0021", "Reporting name");
            objectConstraints.Add("NameTypeMap", nameTypeMap);
            
            List<DvCodedText> nameType = new List<DvCodedText>();
            nameType.Add(OpenEhrFactory.DvCodedText("Registered name", "at0020", "local"));
            nameType.Add(OpenEhrFactory.DvCodedText("Previous name", "at0008", "local"));
            nameType.Add(OpenEhrFactory.DvCodedText("Birth name", "at0009", "local"));
            nameType.Add(OpenEhrFactory.DvCodedText("AKA", "at0010", "local"));
            nameType.Add(OpenEhrFactory.DvCodedText("Alias", "at0011", "local"));
            nameType.Add(OpenEhrFactory.DvCodedText("Maiden name", "at0012", "local"));
            nameType.Add(OpenEhrFactory.DvCodedText("Professional name", "at0019", "local"));
            nameType.Add(OpenEhrFactory.DvCodedText("Reporting name", "at0021", "local"));
            objectConstraints.Add("NameType", nameType);
        }
        #endregion
            
        }        
                
        private ProfessionalDetailsCluster professionalDetails;
                
        [Cluster("/items", "at0003", "Professional details")]                
        public ProfessionalDetailsCluster ProfessionalDetails            
        {
            get
            {
                if(professionalDetails == null)
                    ProfessionalDetails = new ProfessionalDetailsCluster();
                return professionalDetails; 
            }
            set 
            {
                professionalDetails = value;
                base.SetChildNode(value, "at0003");
            }
        }

        public partial class  ProfessionalDetailsCluster : LocatableBase, ICluster
        {
                                
                private LocatableList<ProfessionalRoleCluster> professionalRole;
                
        [Cluster("/items")]
                
        public LocatableList<ProfessionalRoleCluster> ProfessionalRole            
        {
            get { return professionalRole; }
            set  { professionalRole = value; }
        }
        
    	
        [Archetype("openEHR-EHR-CLUSTER.professional_role.v1", "Professional role")]                
        public partial  class  ProfessionalRoleCluster : LocatableBase, ICluster
        {     private DvText unstructuredRole;
        
            [Element("/items", "at0001", "Unstructured role")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText UnstructuredRole            
            {
                get { return unstructuredRole; }
                set { unstructuredRole = value; }
            }

             
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        }
        #endregion
            
        }        
        private DvInterval<DvDateTime> periodOfInvolvement;
        
            [Element("/items", "at0013", "Period of involvement")]
            [AttributeConstraint("value", "DV_INTERVAL<DV_DATE_TIME>")]
            public DvInterval<DvDateTime> PeriodOfInvolvement            
            {
                get { return periodOfInvolvement; }
                set { periodOfInvolvement = value; }
            }

            private DvText grade;
        
            [Element("/items", "at0005", "Grade")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText Grade            
            {
                get { return grade; }
                set { grade = value; }
            }

            private DvText specialty;
        
            [Element("/items", "at0006", "Specialty")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText Specialty            
            {
                get { return specialty; }
                set { specialty = value; }
            }

            private DvText team;
        
            [Element("/items", "at0012", "Team")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText Team            
            {
                get { return team; }
                set { team = value; }
            }

            private DvText professionalIdentifier;
        
            [Element("/items", "at0011", "Professional Identifier")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText ProfessionalIdentifier            
            {
                get { return professionalIdentifier; }
                set { professionalIdentifier = value; }
            }

                    
                private LocatableList<TelecomDetailsCluster> telecomDetails;
                
        [Cluster("/items")]
                
        public LocatableList<TelecomDetailsCluster> TelecomDetails            
        {
            get { return telecomDetails; }
            set  { telecomDetails = value; }
        }
        
    	
        [Archetype("openEHR-EHR-CLUSTER.telecom_details.v1", "Telecom details")]                
        public partial  class  TelecomDetailsCluster : LocatableBase, ICluster
        {             
            private List<DvCodedText> mode;
        
            [Element("/items", "at0010", "Mode")]
            [AttributeConstraint("value", "DV_CODED_TEXT")]            
            public List<DvCodedText> Mode            
            {
                get { return mode; }
                set { mode = value; }
            }

                    
        private LocatableList<TelecomsCluster> telecoms;
        
        [Cluster("/items", "at0001", "Telecoms")]
        public LocatableList<TelecomsCluster> Telecoms            
        {
            get
            {
                return telecoms; 
            }
            set 
            {
                telecoms = value;
                base.SetChildNode(value, "at0001");
            }
        }

        public partial class  TelecomsCluster : LocatableBase, ICluster
        {
                        private DvCodedText telecomsType;
        
            [Element("/items", "at0004", "Telecoms type")]
            [AttributeConstraint("value", "DV_CODED_TEXT")]
            public DvCodedText TelecomsType            
            {
                get { return telecomsType; }
                set { telecomsType = value; }
            }

            private DvText unstucturedTelecoms;
        
            [Element("/items", "at0002", "Unstuctured telecoms")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText UnstucturedTelecoms            
            {
                get { return unstucturedTelecoms; }
                set { unstucturedTelecoms = value; }
            }

                    
        private StructuredTelecomsCluster structuredTelecoms;
                
        [Cluster("/items", "at0003", "Structured telecoms")]                
        public StructuredTelecomsCluster StructuredTelecoms            
        {
            get
            {
                if(structuredTelecoms == null)
                    StructuredTelecoms = new StructuredTelecomsCluster();
                return structuredTelecoms; 
            }
            set 
            {
                structuredTelecoms = value;
                base.SetChildNode(value, "at0003");
            }
        }

        public partial class  StructuredTelecomsCluster : LocatableBase, ICluster
        {
                        private DvText countryCode;
        
            [Element("/items", "at0005", "Country code")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText CountryCode            
            {
                get { return countryCode; }
                set { countryCode = value; }
            }

            private DvText areaCode;
        
            [Element("/items", "at0006", "Area code")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText AreaCode            
            {
                get { return areaCode; }
                set { areaCode = value; }
            }

            private DvText number;
        
            [Element("/items", "at0007", "Number")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText Number            
            {
                get { return number; }
                set { number = value; }
            }

            private DvText extension;
        
            [Element("/items", "at0019", "Extension")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText Extension            
            {
                get { return extension; }
                set { extension = value; }
            }

             
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        }
        #endregion
    
        
        }
         
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        				
            Dictionary<string, string> telecomsTypeMap = new Dictionary<string, string>();
        	telecomsTypeMap.Add("at0013", "Telephone");
            telecomsTypeMap.Add("at0014", "Fax");
            telecomsTypeMap.Add("at0015", "Mobile phone");
            telecomsTypeMap.Add("at0016", "Pager");
            objectConstraints.Add("TelecomsTypeMap", telecomsTypeMap);
            
            List<DvCodedText> telecomsType = new List<DvCodedText>();
            telecomsType.Add(OpenEhrFactory.DvCodedText("Telephone", "at0013", "local"));
            telecomsType.Add(OpenEhrFactory.DvCodedText("Fax", "at0014", "local"));
            telecomsType.Add(OpenEhrFactory.DvCodedText("Mobile phone", "at0015", "local"));
            telecomsType.Add(OpenEhrFactory.DvCodedText("Pager", "at0016", "local"));
            objectConstraints.Add("TelecomsType", telecomsType);
        }
        #endregion
    
        
        }
                
            private List<DvText> emailAddress;
        
            [Element("/items", "at0009", "Email address")]
            [AttributeConstraint("value", "DV_TEXT")]            
            public List<DvText> EmailAddress            
            {
                get { return emailAddress; }
                set { emailAddress = value; }
            }

             
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        				
            Dictionary<string, string> modeMap = new Dictionary<string, string>();
        	modeMap.Add("at0011", "Home");
            modeMap.Add("at0012", "Work");
            modeMap.Add("at0018", "Contact");
            objectConstraints.Add("ModeMap", modeMap);
            
            List<DvCodedText> mode = new List<DvCodedText>();
            mode.Add(OpenEhrFactory.DvCodedText("Home", "at0011", "local"));
            mode.Add(OpenEhrFactory.DvCodedText("Work", "at0012", "local"));
            mode.Add(OpenEhrFactory.DvCodedText("Contact", "at0018", "local"));
            objectConstraints.Add("Mode", mode);
        }
        #endregion
            
        }        
                
                private LocatableList<AddressCluster> address;
                
        [Cluster("/items")]
                
        public LocatableList<AddressCluster> Address            
        {
            get { return address; }
            set  { address = value; }
        }
        
    	
        [Archetype("openEHR-EHR-CLUSTER.address.v1", "Address")]                
        public partial  class  AddressCluster : LocatableBase, ICluster
        {             
        private LocatableList<AddressCluster> address;
        
        [Cluster("/items", "at0001", "Address")]
        public LocatableList<AddressCluster> Address            
        {
            get
            {
                return address; 
            }
            set 
            {
                address = value;
                base.SetChildNode(value, "at0001");
            }
        }

        public partial class  AddressCluster : LocatableBase, ICluster
        {
                        private DvCodedText addressType;
        
            [Element("/items", "at0006", "Address Type")]
            [AttributeConstraint("value", "DV_CODED_TEXT")]
            public DvCodedText AddressType            
            {
                get { return addressType; }
                set { addressType = value; }
            }

            private DvText unstructuredAddress;
        
            [Element("/items", "at0002", "Unstructured address")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText UnstructuredAddress            
            {
                get { return unstructuredAddress; }
                set { unstructuredAddress = value; }
            }

                    
        private StructuredAddressCluster structuredAddress;
                
        [Cluster("/items", "at0003", "Structured address")]                
        public StructuredAddressCluster StructuredAddress            
        {
            get
            {
                if(structuredAddress == null)
                    StructuredAddress = new StructuredAddressCluster();
                return structuredAddress; 
            }
            set 
            {
                structuredAddress = value;
                base.SetChildNode(value, "at0003");
            }
        }

        public partial class  StructuredAddressCluster : LocatableBase, ICluster
        {
                        private DvText propertyNumber;
        
            [Element("/items", "at0005", "Property number")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText PropertyNumber            
            {
                get { return propertyNumber; }
                set { propertyNumber = value; }
            }

                    
            private List<DvText> addressLine;
        
            [Element("/items", "at0009", "Address line")]
            [AttributeConstraint("value", "DV_TEXT")]            
            public List<DvText> AddressLine            
            {
                get { return addressLine; }
                set { addressLine = value; }
            }

             
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        }
        #endregion
    
        
        }
        private DvText postCode;
        
            [Element("/items", "at0004", "Post code")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText PostCode            
            {
                get { return postCode; }
                set { postCode = value; }
            }

                    
        private AddressvalidPeriodCluster addressvalidPeriod;
                
        [Cluster("/items", "at0015", "AddressValid Period")]                
        public AddressvalidPeriodCluster AddressvalidPeriod            
        {
            get
            {
                if(addressvalidPeriod == null)
                    AddressvalidPeriod = new AddressvalidPeriodCluster();
                return addressvalidPeriod; 
            }
            set 
            {
                addressvalidPeriod = value;
                base.SetChildNode(value, "at0015");
            }
        }

        public partial class  AddressvalidPeriodCluster : LocatableBase, ICluster
        {
                        private DvDateTime validFrom;
        
            [Element("/items", "at0007", "Valid from")]
            [AttributeConstraint("value", "DV_DATE_TIME")]
            public DvDateTime ValidFrom            
            {
                get { return validFrom; }
                set { validFrom = value; }
            }

            private DvDateTime validTo;
        
            [Element("/items", "at0008", "Valid to")]
            [AttributeConstraint("value", "DV_DATE_TIME")]
            public DvDateTime ValidTo            
            {
                get { return validTo; }
                set { validTo = value; }
            }

             
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        }
        #endregion
    
        
        }
         
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        				
            Dictionary<string, string> addressTypeMap = new Dictionary<string, string>();
        	addressTypeMap.Add("at0011", "Residential");
            addressTypeMap.Add("at0012", "Correspondence");
            addressTypeMap.Add("at0013", "Business");
            addressTypeMap.Add("at0014", "Temporary");
            objectConstraints.Add("AddressTypeMap", addressTypeMap);
            
            List<DvCodedText> addressType = new List<DvCodedText>();
            addressType.Add(OpenEhrFactory.DvCodedText("Residential", "at0011", "local"));
            addressType.Add(OpenEhrFactory.DvCodedText("Correspondence", "at0012", "local"));
            addressType.Add(OpenEhrFactory.DvCodedText("Business", "at0013", "local"));
            addressType.Add(OpenEhrFactory.DvCodedText("Temporary", "at0014", "local"));
            objectConstraints.Add("AddressType", addressType);
        }
        #endregion
    
        
        }
         
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        }
        #endregion
            
        }        
                
                private LocatableList<OrganisationCluster> organisation;
                
        [Cluster("/items")]
                
        public LocatableList<OrganisationCluster> Organisation            
        {
            get { return organisation; }
            set  { organisation = value; }
        }
        
    	
        [Archetype("openEHR-EHR-CLUSTER.organisation.v1", "Organisation")]                
        public partial  class  OrganisationCluster : LocatableBase, ICluster
        {     private DvText nameOfOrganisation;
        
            [Element("/items", "at0001", "Name of Organisation")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText NameOfOrganisation            
            {
                get { return nameOfOrganisation; }
                set { nameOfOrganisation = value; }
            }

            private DvText identifier;
        
            [Element("/items", "at0011", "Identifier")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText Identifier            
            {
                get { return identifier; }
                set { identifier = value; }
            }

                    
        private AddressCluster address;
                
        [Cluster("/items")]                
        public AddressCluster Address            
        {
            get { return address; }
            set  { address = value; }
        }
        
    	
        [Archetype("openEHR-EHR-CLUSTER.address.v1", "Address")]                
        public partial  class  AddressCluster : LocatableBase, ICluster
        {             
        private LocatableList<AddressCluster> address;
        
        [Cluster("/items", "at0001", "Address")]
        public LocatableList<AddressCluster> Address            
        {
            get
            {
                return address; 
            }
            set 
            {
                address = value;
                base.SetChildNode(value, "at0001");
            }
        }

        public partial class  AddressCluster : LocatableBase, ICluster
        {
                        private DvCodedText addressType;
        
            [Element("/items", "at0006", "Address Type")]
            [AttributeConstraint("value", "DV_CODED_TEXT")]
            public DvCodedText AddressType            
            {
                get { return addressType; }
                set { addressType = value; }
            }

            private DvText unstructuredAddress;
        
            [Element("/items", "at0002", "Unstructured address")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText UnstructuredAddress            
            {
                get { return unstructuredAddress; }
                set { unstructuredAddress = value; }
            }

                    
        private StructuredAddressCluster structuredAddress;
                
        [Cluster("/items", "at0003", "Structured address")]                
        public StructuredAddressCluster StructuredAddress            
        {
            get
            {
                if(structuredAddress == null)
                    StructuredAddress = new StructuredAddressCluster();
                return structuredAddress; 
            }
            set 
            {
                structuredAddress = value;
                base.SetChildNode(value, "at0003");
            }
        }

        public partial class  StructuredAddressCluster : LocatableBase, ICluster
        {
                        private DvText propertyNumber;
        
            [Element("/items", "at0005", "Property number")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText PropertyNumber            
            {
                get { return propertyNumber; }
                set { propertyNumber = value; }
            }

                    
            private List<DvText> addressLine;
        
            [Element("/items", "at0009", "Address line")]
            [AttributeConstraint("value", "DV_TEXT")]            
            public List<DvText> AddressLine            
            {
                get { return addressLine; }
                set { addressLine = value; }
            }

             
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        }
        #endregion
    
        
        }
        private DvText postCode;
        
            [Element("/items", "at0004", "Post code")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText PostCode            
            {
                get { return postCode; }
                set { postCode = value; }
            }

                    
        private AddressvalidPeriodCluster addressvalidPeriod;
                
        [Cluster("/items", "at0015", "AddressValid Period")]                
        public AddressvalidPeriodCluster AddressvalidPeriod            
        {
            get
            {
                if(addressvalidPeriod == null)
                    AddressvalidPeriod = new AddressvalidPeriodCluster();
                return addressvalidPeriod; 
            }
            set 
            {
                addressvalidPeriod = value;
                base.SetChildNode(value, "at0015");
            }
        }

        public partial class  AddressvalidPeriodCluster : LocatableBase, ICluster
        {
                        private DvDateTime validFrom;
        
            [Element("/items", "at0007", "Valid from")]
            [AttributeConstraint("value", "DV_DATE_TIME")]
            public DvDateTime ValidFrom            
            {
                get { return validFrom; }
                set { validFrom = value; }
            }

            private DvDateTime validTo;
        
            [Element("/items", "at0008", "Valid to")]
            [AttributeConstraint("value", "DV_DATE_TIME")]
            public DvDateTime ValidTo            
            {
                get { return validTo; }
                set { validTo = value; }
            }

             
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        }
        #endregion
    
        
        }
         
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        				
            Dictionary<string, string> addressTypeMap = new Dictionary<string, string>();
        	addressTypeMap.Add("at0011", "Residential");
            addressTypeMap.Add("at0012", "Correspondence");
            addressTypeMap.Add("at0013", "Business");
            addressTypeMap.Add("at0014", "Temporary");
            objectConstraints.Add("AddressTypeMap", addressTypeMap);
            
            List<DvCodedText> addressType = new List<DvCodedText>();
            addressType.Add(OpenEhrFactory.DvCodedText("Residential", "at0011", "local"));
            addressType.Add(OpenEhrFactory.DvCodedText("Correspondence", "at0012", "local"));
            addressType.Add(OpenEhrFactory.DvCodedText("Business", "at0013", "local"));
            addressType.Add(OpenEhrFactory.DvCodedText("Temporary", "at0014", "local"));
            objectConstraints.Add("AddressType", addressType);
        }
        #endregion
    
        
        }
         
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        }
        #endregion
            
        }        
                
        private TelecomDetailsCluster telecomDetails;
                
        [Cluster("/items")]                
        public TelecomDetailsCluster TelecomDetails            
        {
            get { return telecomDetails; }
            set  { telecomDetails = value; }
        }
        
    	
        [Archetype("openEHR-EHR-CLUSTER.telecom_details.v1", "Telecom details")]                
        public partial  class  TelecomDetailsCluster : LocatableBase, ICluster
        {             
            private List<DvCodedText> mode;
        
            [Element("/items", "at0010", "Mode")]
            [AttributeConstraint("value", "DV_CODED_TEXT")]            
            public List<DvCodedText> Mode            
            {
                get { return mode; }
                set { mode = value; }
            }

                    
        private LocatableList<TelecomsCluster> telecoms;
        
        [Cluster("/items", "at0001", "Telecoms")]
        public LocatableList<TelecomsCluster> Telecoms            
        {
            get
            {
                return telecoms; 
            }
            set 
            {
                telecoms = value;
                base.SetChildNode(value, "at0001");
            }
        }

        public partial class  TelecomsCluster : LocatableBase, ICluster
        {
                        private DvCodedText telecomsType;
        
            [Element("/items", "at0004", "Telecoms type")]
            [AttributeConstraint("value", "DV_CODED_TEXT")]
            public DvCodedText TelecomsType            
            {
                get { return telecomsType; }
                set { telecomsType = value; }
            }

            private DvText unstucturedTelecoms;
        
            [Element("/items", "at0002", "Unstuctured telecoms")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText UnstucturedTelecoms            
            {
                get { return unstucturedTelecoms; }
                set { unstucturedTelecoms = value; }
            }

                    
        private StructuredTelecomsCluster structuredTelecoms;
                
        [Cluster("/items", "at0003", "Structured telecoms")]                
        public StructuredTelecomsCluster StructuredTelecoms            
        {
            get
            {
                if(structuredTelecoms == null)
                    StructuredTelecoms = new StructuredTelecomsCluster();
                return structuredTelecoms; 
            }
            set 
            {
                structuredTelecoms = value;
                base.SetChildNode(value, "at0003");
            }
        }

        public partial class  StructuredTelecomsCluster : LocatableBase, ICluster
        {
                        private DvText countryCode;
        
            [Element("/items", "at0005", "Country code")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText CountryCode            
            {
                get { return countryCode; }
                set { countryCode = value; }
            }

            private DvText areaCode;
        
            [Element("/items", "at0006", "Area code")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText AreaCode            
            {
                get { return areaCode; }
                set { areaCode = value; }
            }

            private DvText number;
        
            [Element("/items", "at0007", "Number")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText Number            
            {
                get { return number; }
                set { number = value; }
            }

            private DvText extension;
        
            [Element("/items", "at0019", "Extension")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText Extension            
            {
                get { return extension; }
                set { extension = value; }
            }

             
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        }
        #endregion
    
        
        }
         
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        				
            Dictionary<string, string> telecomsTypeMap = new Dictionary<string, string>();
        	telecomsTypeMap.Add("at0013", "Telephone");
            telecomsTypeMap.Add("at0014", "Fax");
            telecomsTypeMap.Add("at0015", "Mobile phone");
            telecomsTypeMap.Add("at0016", "Pager");
            objectConstraints.Add("TelecomsTypeMap", telecomsTypeMap);
            
            List<DvCodedText> telecomsType = new List<DvCodedText>();
            telecomsType.Add(OpenEhrFactory.DvCodedText("Telephone", "at0013", "local"));
            telecomsType.Add(OpenEhrFactory.DvCodedText("Fax", "at0014", "local"));
            telecomsType.Add(OpenEhrFactory.DvCodedText("Mobile phone", "at0015", "local"));
            telecomsType.Add(OpenEhrFactory.DvCodedText("Pager", "at0016", "local"));
            objectConstraints.Add("TelecomsType", telecomsType);
        }
        #endregion
    
        
        }
                
            private List<DvText> emailAddress;
        
            [Element("/items", "at0009", "Email address")]
            [AttributeConstraint("value", "DV_TEXT")]            
            public List<DvText> EmailAddress            
            {
                get { return emailAddress; }
                set { emailAddress = value; }
            }

             
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        				
            Dictionary<string, string> modeMap = new Dictionary<string, string>();
        	modeMap.Add("at0011", "Home");
            modeMap.Add("at0012", "Work");
            modeMap.Add("at0018", "Contact");
            objectConstraints.Add("ModeMap", modeMap);
            
            List<DvCodedText> mode = new List<DvCodedText>();
            mode.Add(OpenEhrFactory.DvCodedText("Home", "at0011", "local"));
            mode.Add(OpenEhrFactory.DvCodedText("Work", "at0012", "local"));
            mode.Add(OpenEhrFactory.DvCodedText("Contact", "at0018", "local"));
            objectConstraints.Add("Mode", mode);
        }
        #endregion
            
        }        
                
        private LocatableList<ContactPersonDetailsCluster> contactPersonDetails;
        
        [Cluster("/items", "at0005", "Contact Person Details")]
        public LocatableList<ContactPersonDetailsCluster> ContactPersonDetails            
        {
            get
            {
                return contactPersonDetails; 
            }
            set 
            {
                contactPersonDetails = value;
                base.SetChildNode(value, "at0005");
            }
        }

        public partial class  ContactPersonDetailsCluster : LocatableBase, ICluster
        {
                                
                private LocatableList<PersonNameCluster> personName;
                
        [Cluster("/items")]
                
        public LocatableList<PersonNameCluster> PersonName            
        {
            get { return personName; }
            set  { personName = value; }
        }
        
    	
        [Archetype("openEHR-EHR-CLUSTER.person_name.v1", "Person name")]                
        public partial  class  PersonNameCluster : LocatableBase, ICluster
        {     private DvCodedText nameType;
        
            [Element("/items", "at0006", "Name type")]
            [AttributeConstraint("value", "DV_CODED_TEXT")]
            public DvCodedText NameType            
            {
                get { return nameType; }
                set { nameType = value; }
            }

            private DvBoolean preferredName;
        
            [Element("/items", "at0022", "Preferred name")]
            [AttributeConstraint("value", "DV_BOOLEAN")]
            public DvBoolean PreferredName            
            {
                get { return preferredName; }
                set { preferredName = value; }
            }

            private DvText unstructuredName;
        
            [Element("/items", "at0001", "Unstructured name")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText UnstructuredName            
            {
                get { return unstructuredName; }
                set { unstructuredName = value; }
            }

                    
        private StructuredNameCluster structuredName;
                
        [Cluster("/items", "at0002", "Structured name")]                
        public StructuredNameCluster StructuredName            
        {
            get
            {
                if(structuredName == null)
                    StructuredName = new StructuredNameCluster();
                return structuredName; 
            }
            set 
            {
                structuredName = value;
                base.SetChildNode(value, "at0002");
            }
        }

        public partial class  StructuredNameCluster : LocatableBase, ICluster
        {
                        private DvText title;
        
            [Element("/items", "at0017", "Title")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText Title            
            {
                get { return title; }
                set { title = value; }
            }

            private DvText givenName;
        
            [Element("/items", "at0003", "Given name")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText GivenName            
            {
                get { return givenName; }
                set { givenName = value; }
            }

                    
            private List<DvCodedText> middleName;
        
            [Element("/items", "at0004", "Middle name")]
            [AttributeConstraint("value", "DV_CODED_TEXT")]            
            public List<DvCodedText> MiddleName            
            {
                get { return middleName; }
                set { middleName = value; }
            }

            private DvText familyName;
        
            [Element("/items", "at0005", "Family name")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText FamilyName            
            {
                get { return familyName; }
                set { familyName = value; }
            }

            private DvText suffix;
        
            [Element("/items", "at0018", "Suffix")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText Suffix            
            {
                get { return suffix; }
                set { suffix = value; }
            }

             
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        				
            Dictionary<string, string> middleNameMap = new Dictionary<string, string>();
        	objectConstraints.Add("MiddleNameMap", middleNameMap);
            
            List<DvCodedText> middleName = new List<DvCodedText>();
            objectConstraints.Add("MiddleName", middleName);
        }
        #endregion
    
        
        }
        private DvInterval<DvDateTime> validityPeriod;
        
            [Element("/items", "at0014", "Validity period")]
            [AttributeConstraint("value", "DV_INTERVAL<DV_DATE_TIME>")]
            public DvInterval<DvDateTime> ValidityPeriod            
            {
                get { return validityPeriod; }
                set { validityPeriod = value; }
            }

             
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        				
            Dictionary<string, string> nameTypeMap = new Dictionary<string, string>();
        	nameTypeMap.Add("at0020", "Registered name");
            nameTypeMap.Add("at0008", "Previous name");
            nameTypeMap.Add("at0009", "Birth name");
            nameTypeMap.Add("at0010", "AKA");
            nameTypeMap.Add("at0011", "Alias");
            nameTypeMap.Add("at0012", "Maiden name");
            nameTypeMap.Add("at0019", "Professional name");
            nameTypeMap.Add("at0021", "Reporting name");
            objectConstraints.Add("NameTypeMap", nameTypeMap);
            
            List<DvCodedText> nameType = new List<DvCodedText>();
            nameType.Add(OpenEhrFactory.DvCodedText("Registered name", "at0020", "local"));
            nameType.Add(OpenEhrFactory.DvCodedText("Previous name", "at0008", "local"));
            nameType.Add(OpenEhrFactory.DvCodedText("Birth name", "at0009", "local"));
            nameType.Add(OpenEhrFactory.DvCodedText("AKA", "at0010", "local"));
            nameType.Add(OpenEhrFactory.DvCodedText("Alias", "at0011", "local"));
            nameType.Add(OpenEhrFactory.DvCodedText("Maiden name", "at0012", "local"));
            nameType.Add(OpenEhrFactory.DvCodedText("Professional name", "at0019", "local"));
            nameType.Add(OpenEhrFactory.DvCodedText("Reporting name", "at0021", "local"));
            objectConstraints.Add("NameType", nameType);
        }
        #endregion
            
        }        
        private DvText roleInOrganisation;
        
            [Element("/items", "at0007", "Role in organisation")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText RoleInOrganisation            
            {
                get { return roleInOrganisation; }
                set { roleInOrganisation = value; }
            }

             
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        }
        #endregion
    
        
        }
         
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        }
        #endregion
            
        }        
         
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        }
        #endregion
    
        
        }
         
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        }
        #endregion
            
        }        
         
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        }
        #endregion
                    
        }
        #endregion        
                
        private LocatableList<LaboratoryTestObservation> laboratoryTest;
                
        [Observation("/content")]
        public LocatableList<LaboratoryTestObservation> LaboratoryTest   
        {
            get { return laboratoryTest; }
            set { laboratoryTest = value; }
        }
        
    	
        [Archetype("openEHR-EHR-OBSERVATION.lab_test.v1", "Laboratory test")]        
        public partial class  LaboratoryTestObservation : CareEntryBase, IObservation
        {
                    
                private LocatableList<AnyEventEvent> anyEvent;
                
                [Event("/data/events", "at0002", "Any event")]
                public LocatableList<AnyEventEvent> AnyEvent            
        {
        get { return anyEvent; }
        set 
        {
        anyEvent = value;
        base.SetChildNode(value, "at0002");
        }
        }
        
        public partial class  AnyEventEvent : EventBase
        {
            private DvText testName;
        
            [Element("/data/items", "at0005", "Test name")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText TestName            
            {
                get { return testName; }
                set { testName = value; }
            }

            private DvText diagnosticService;
        
            [Element("/data/items", "at0077", "Diagnostic service")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText DiagnosticService            
            {
                get { return diagnosticService; }
                set { diagnosticService = value; }
            }

            private DvCodedText testStatus;
        
            [Element("/data/items", "at0073", "Test status")]
            [AttributeConstraint("value", "DV_CODED_TEXT")]
            public DvCodedText TestStatus            
            {
                get { return testStatus; }
                set { testStatus = value; }
            }

                    
                private LocatableList<SpecimenCluster> specimen;
                
        [Cluster("/data/items")]
                
        public LocatableList<SpecimenCluster> Specimen            
        {
            get { return specimen; }
            set  { specimen = value; }
        }
        
    	
        [Archetype("openEHR-EHR-CLUSTER.specimen.v1", "Specimen")]                
        public partial  class  SpecimenCluster : LocatableBase, ICluster
        {     private DvText specimenTissueType;
        
            [Element("/items", "at0029", "Specimen tissue type")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText SpecimenTissueType            
            {
                get { return specimenTissueType; }
                set { specimenTissueType = value; }
            }

            private DvText collectionProcedure;
        
            [Element("/items", "at0007", "Collection procedure")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText CollectionProcedure            
            {
                get { return collectionProcedure; }
                set { collectionProcedure = value; }
            }

                    
                private LocatableList<PreciseAnatomicalLocationCluster> preciseAnatomicalLocation;
                
        [Cluster("/items")]
                
        public LocatableList<PreciseAnatomicalLocationCluster> PreciseAnatomicalLocation            
        {
            get { return preciseAnatomicalLocation; }
            set  { preciseAnatomicalLocation = value; }
        }
        
    	
        [Archetype("openEHR-EHR-CLUSTER.anatomical_location-precise.v1", "Precise anatomical location")]                
        public partial  class  PreciseAnatomicalLocationCluster : LocatableBase, ICluster
        {             
        private SpecificLocationCluster specificLocation;
                
        [Cluster("/items", "at0005", "Specific location")]                
        public SpecificLocationCluster SpecificLocation            
        {
            get
            {
                if(specificLocation == null)
                    SpecificLocation = new SpecificLocationCluster();
                return specificLocation; 
            }
            set 
            {
                specificLocation = value;
                base.SetChildNode(value, "at0005");
            }
        }

        public partial class  SpecificLocationCluster : LocatableBase, ICluster
        {
                        private DvText nameOfLocation;
        
            [Element("/items", "at0001", "Name of location")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText NameOfLocation            
            {
                get { return nameOfLocation; }
                set { nameOfLocation = value; }
            }

            private DvCodedText side;
        
            [Element("/items", "at0002", "Side")]
            [AttributeConstraint("value", "DV_CODED_TEXT")]
            public DvCodedText Side            
            {
                get { return side; }
                set { side = value; }
            }

            private DvCodedText numericalIdentifier;
        
            [Element("/items", "at0028", "Numerical identifier")]
            [AttributeConstraint("value", "DV_CODED_TEXT")]
            public DvCodedText NumericalIdentifier            
            {
                get { return numericalIdentifier; }
                set { numericalIdentifier = value; }
            }

            private DvCodedText anatomicalPlane;
        
            [Element("/items", "at0024", "Anatomical plane")]
            [AttributeConstraint("value", "DV_CODED_TEXT")]
            public DvCodedText AnatomicalPlane            
            {
                get { return anatomicalPlane; }
                set { anatomicalPlane = value; }
            }

             
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        				
            Dictionary<string, string> sideMap = new Dictionary<string, string>();
        	sideMap.Add("at0003", "Left");
            sideMap.Add("at0004", "Right");
            sideMap.Add("at0051", "Bilateral");
            objectConstraints.Add("SideMap", sideMap);
            
            List<DvCodedText> side = new List<DvCodedText>();
            side.Add(OpenEhrFactory.DvCodedText("Left", "at0003", "local"));
            side.Add(OpenEhrFactory.DvCodedText("Right", "at0004", "local"));
            side.Add(OpenEhrFactory.DvCodedText("Bilateral", "at0051", "local"));
            objectConstraints.Add("Side", side);
        				
            Dictionary<string, string> numericalIdentifierMap = new Dictionary<string, string>();
        	numericalIdentifierMap.Add("at0029", "First");
            numericalIdentifierMap.Add("at0030", "Second");
            numericalIdentifierMap.Add("at0031", "Third");
            numericalIdentifierMap.Add("at0032", "Fourth");
            numericalIdentifierMap.Add("at0033", "Fifth");
            numericalIdentifierMap.Add("at0034", "Sixth");
            numericalIdentifierMap.Add("at0035", "Seventh");
            numericalIdentifierMap.Add("at0036", "Eighth");
            numericalIdentifierMap.Add("at0037", "Ninth");
            numericalIdentifierMap.Add("at0038", "Tenth");
            numericalIdentifierMap.Add("at0039", "Eleventh");
            numericalIdentifierMap.Add("at0040", "Twelfth");
            numericalIdentifierMap.Add("at0041", "Thirteenth");
            numericalIdentifierMap.Add("at0042", "Fourteenth");
            numericalIdentifierMap.Add("at0043", "Fifteenth");
            numericalIdentifierMap.Add("at0044", "Sixteenth");
            numericalIdentifierMap.Add("at0045", "Seventeenth");
            numericalIdentifierMap.Add("at0046", "Eighteenth");
            objectConstraints.Add("NumericalIdentifierMap", numericalIdentifierMap);
            
            List<DvCodedText> numericalIdentifier = new List<DvCodedText>();
            numericalIdentifier.Add(OpenEhrFactory.DvCodedText("First", "at0029", "local"));
            numericalIdentifier.Add(OpenEhrFactory.DvCodedText("Second", "at0030", "local"));
            numericalIdentifier.Add(OpenEhrFactory.DvCodedText("Third", "at0031", "local"));
            numericalIdentifier.Add(OpenEhrFactory.DvCodedText("Fourth", "at0032", "local"));
            numericalIdentifier.Add(OpenEhrFactory.DvCodedText("Fifth", "at0033", "local"));
            numericalIdentifier.Add(OpenEhrFactory.DvCodedText("Sixth", "at0034", "local"));
            numericalIdentifier.Add(OpenEhrFactory.DvCodedText("Seventh", "at0035", "local"));
            numericalIdentifier.Add(OpenEhrFactory.DvCodedText("Eighth", "at0036", "local"));
            numericalIdentifier.Add(OpenEhrFactory.DvCodedText("Ninth", "at0037", "local"));
            numericalIdentifier.Add(OpenEhrFactory.DvCodedText("Tenth", "at0038", "local"));
            numericalIdentifier.Add(OpenEhrFactory.DvCodedText("Eleventh", "at0039", "local"));
            numericalIdentifier.Add(OpenEhrFactory.DvCodedText("Twelfth", "at0040", "local"));
            numericalIdentifier.Add(OpenEhrFactory.DvCodedText("Thirteenth", "at0041", "local"));
            numericalIdentifier.Add(OpenEhrFactory.DvCodedText("Fourteenth", "at0042", "local"));
            numericalIdentifier.Add(OpenEhrFactory.DvCodedText("Fifteenth", "at0043", "local"));
            numericalIdentifier.Add(OpenEhrFactory.DvCodedText("Sixteenth", "at0044", "local"));
            numericalIdentifier.Add(OpenEhrFactory.DvCodedText("Seventeenth", "at0045", "local"));
            numericalIdentifier.Add(OpenEhrFactory.DvCodedText("Eighteenth", "at0046", "local"));
            objectConstraints.Add("NumericalIdentifier", numericalIdentifier);
        				
            Dictionary<string, string> anatomicalPlaneMap = new Dictionary<string, string>();
        	anatomicalPlaneMap.Add("at0011", "Midline");
            anatomicalPlaneMap.Add("at0025", "Midclavicular line");
            anatomicalPlaneMap.Add("at0026", "Midaxillary line");
            anatomicalPlaneMap.Add("at0027", "Midscapular line");
            objectConstraints.Add("AnatomicalPlaneMap", anatomicalPlaneMap);
            
            List<DvCodedText> anatomicalPlane = new List<DvCodedText>();
            anatomicalPlane.Add(OpenEhrFactory.DvCodedText("Midline", "at0011", "local"));
            anatomicalPlane.Add(OpenEhrFactory.DvCodedText("Midclavicular line", "at0025", "local"));
            anatomicalPlane.Add(OpenEhrFactory.DvCodedText("Midaxillary line", "at0026", "local"));
            anatomicalPlane.Add(OpenEhrFactory.DvCodedText("Midscapular line", "at0027", "local"));
            objectConstraints.Add("AnatomicalPlane", anatomicalPlane);
        }
        #endregion
    
        
        }
                
        private LocatableList<RelativeLocationCluster> relativeLocation;
        
        [Cluster("/items", "at0020", "Relative location")]
        public LocatableList<RelativeLocationCluster> RelativeLocation            
        {
            get
            {
                return relativeLocation; 
            }
            set 
            {
                relativeLocation = value;
                base.SetChildNode(value, "at0020");
            }
        }

        public partial class  RelativeLocationCluster : LocatableBase, ICluster
        {
                        private DvText identifiedLandmark;
        
            [Element("/items", "at0021", "Identified landmark")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText IdentifiedLandmark            
            {
                get { return identifiedLandmark; }
                set { identifiedLandmark = value; }
            }

            private DvCodedText aspect;
        
            [Element("/items", "at0006", "Aspect")]
            [AttributeConstraint("value", "DV_CODED_TEXT")]
            public DvCodedText Aspect            
            {
                get { return aspect; }
                set { aspect = value; }
            }

            private DvQuantity distanceFromLandmark;
        
            [Element("/items", "at0022", "Distance from landmark")]
            [AttributeConstraint("value", "DV_QUANTITY")]
            public DvQuantity DistanceFromLandmark            
            {
                get { return distanceFromLandmark; }
                set { distanceFromLandmark = value; }
            }

             
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        				
            Dictionary<string, string> aspectMap = new Dictionary<string, string>();
        	aspectMap.Add("at0015", "Above");
            aspectMap.Add("at0014", "Below");
            aspectMap.Add("at0007", "Medial to");
            aspectMap.Add("at0008", "Lateral to");
            aspectMap.Add("at0009", "Superior to");
            aspectMap.Add("at0010", "Inferior to");
            aspectMap.Add("at0012", "Anterior to");
            aspectMap.Add("at0013", "Posterior to");
            aspectMap.Add("at0016", "Inferolateral to");
            aspectMap.Add("at0017", "Superolateral to");
            aspectMap.Add("at0018", "Inferomedial to");
            aspectMap.Add("at0019", "Superomedial to");
            objectConstraints.Add("AspectMap", aspectMap);
            
            List<DvCodedText> aspect = new List<DvCodedText>();
            aspect.Add(OpenEhrFactory.DvCodedText("Above", "at0015", "local"));
            aspect.Add(OpenEhrFactory.DvCodedText("Below", "at0014", "local"));
            aspect.Add(OpenEhrFactory.DvCodedText("Medial to", "at0007", "local"));
            aspect.Add(OpenEhrFactory.DvCodedText("Lateral to", "at0008", "local"));
            aspect.Add(OpenEhrFactory.DvCodedText("Superior to", "at0009", "local"));
            aspect.Add(OpenEhrFactory.DvCodedText("Inferior to", "at0010", "local"));
            aspect.Add(OpenEhrFactory.DvCodedText("Anterior to", "at0012", "local"));
            aspect.Add(OpenEhrFactory.DvCodedText("Posterior to", "at0013", "local"));
            aspect.Add(OpenEhrFactory.DvCodedText("Inferolateral to", "at0016", "local"));
            aspect.Add(OpenEhrFactory.DvCodedText("Superolateral to", "at0017", "local"));
            aspect.Add(OpenEhrFactory.DvCodedText("Inferomedial to", "at0018", "local"));
            aspect.Add(OpenEhrFactory.DvCodedText("Superomedial to", "at0019", "local"));
            objectConstraints.Add("Aspect", aspect);
        }
        #endregion
    
        
        }
                
        private CoordinatesCluster coordinates;
                
        [Cluster("/items", "at0.51", "Coordinates")]                
        public CoordinatesCluster Coordinates            
        {
            get
            {
                if(coordinates == null)
                    Coordinates = new CoordinatesCluster();
                return coordinates; 
            }
            set 
            {
                coordinates = value;
                base.SetChildNode(value, "at0.51");
            }
        }

        public partial class  CoordinatesCluster : LocatableBase, ICluster
        {
                        private DvText positionFrameOfReference;
        
            [Element("/items", "at0.52", "Position frame of reference")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText PositionFrameOfReference            
            {
                get { return positionFrameOfReference; }
                set { positionFrameOfReference = value; }
            }

            private DataValue xOffset;
        
            [Element("/items", "at0.53", "X offset")]
            [AttributeConstraint("value", "DV_QUANTITY")]
            [AttributeConstraint("value", "DV_COUNT")]
            public DataValue XOffset            
            {
                get { return xOffset; }
                set { xOffset = value; }
            }

            private DataValue yOffset;
        
            [Element("/items", "at0.54", "Y offset")]
            [AttributeConstraint("value", "DV_QUANTITY")]
            [AttributeConstraint("value", "DV_COUNT")]
            public DataValue YOffset            
            {
                get { return yOffset; }
                set { yOffset = value; }
            }

            private DataValue zOffset;
        
            [Element("/items", "at0.56", "Z offset")]
            [AttributeConstraint("value", "DV_QUANTITY")]
            [AttributeConstraint("value", "DV_COUNT")]
            public DataValue ZOffset            
            {
                get { return zOffset; }
                set { zOffset = value; }
            }

             
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        }
        #endregion
    
        
        }
                
            private List<DvText> visualMarkingsorientation;
        
            [Element("/items", "at0053", "Visual markings/orientation")]
            [AttributeConstraint("value", "DV_TEXT")]            
            public List<DvText> VisualMarkingsorientation            
            {
                get { return visualMarkingsorientation; }
                set { visualMarkingsorientation = value; }
            }

                    
            private List<DvText> description;
        
            [Element("/items", "at0023", "Description")]
            [AttributeConstraint("value", "DV_TEXT")]            
            public List<DvText> Description            
            {
                get { return description; }
                set { description = value; }
            }

                    
            private List<DvMultimedia> image;
        
            [Element("/items", "at0052", "Image")]
            [AttributeConstraint("value", "DV_MULTIMEDIA")]            
            public List<DvMultimedia> Image            
            {
                get { return image; }
                set { image = value; }
            }

             
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        }
        #endregion
            
        }        
                
                private LocatableList<AnatomicalLocationCluster> anatomicalLocation;
                
        [Cluster("/items")]
                
        public LocatableList<AnatomicalLocationCluster> AnatomicalLocation            
        {
            get { return anatomicalLocation; }
            set  { anatomicalLocation = value; }
        }
        
    	
        [Archetype("openEHR-EHR-CLUSTER.anatomical_location.v1", "Anatomical Location")]                
        public partial  class  AnatomicalLocationCluster : LocatableBase, ICluster
        {     private DvText locationName;
        
            [Element("/items", "at0001", "Location name")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText LocationName            
            {
                get { return locationName; }
                set { locationName = value; }
            }

            private DvCodedText laterality;
        
            [Element("/items", "at0002", "Laterality")]
            [AttributeConstraint("value", "DV_CODED_TEXT")]
            public DvCodedText Laterality            
            {
                get { return laterality; }
                set { laterality = value; }
            }

            private DvText description;
        
            [Element("/items", "at0023", "Description")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText Description            
            {
                get { return description; }
                set { description = value; }
            }

                    
            private List<DvMultimedia> multimediaRepresentation;
        
            [Element("/items", "at0052", "Multimedia representation")]
            [AttributeConstraint("value", "DV_MULTIMEDIA")]            
            public List<DvMultimedia> MultimediaRepresentation            
            {
                get { return multimediaRepresentation; }
                set { multimediaRepresentation = value; }
            }

             
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        				
            Dictionary<string, string> lateralityMap = new Dictionary<string, string>();
        	lateralityMap.Add("at0003", "Left");
            lateralityMap.Add("at0004", "Right");
            lateralityMap.Add("at0051", "Bilateral");
            objectConstraints.Add("LateralityMap", lateralityMap);
            
            List<DvCodedText> laterality = new List<DvCodedText>();
            laterality.Add(OpenEhrFactory.DvCodedText("Left", "at0003", "local"));
            laterality.Add(OpenEhrFactory.DvCodedText("Right", "at0004", "local"));
            laterality.Add(OpenEhrFactory.DvCodedText("Bilateral", "at0051", "local"));
            objectConstraints.Add("Laterality", laterality);
        }
        #endregion
            
        }        
                
                private LocatableList<PhysicalPropertiesOfAnObjectCluster> physicalPropertiesOfAnObject;
                
        [Cluster("/items")]
                
        public LocatableList<PhysicalPropertiesOfAnObjectCluster> PhysicalPropertiesOfAnObject            
        {
            get { return physicalPropertiesOfAnObject; }
            set  { physicalPropertiesOfAnObject = value; }
        }
        
    	
        [Archetype("openEHR-EHR-CLUSTER.physical_properties.v1", "Physical properties of an object")]                
        public partial  class  PhysicalPropertiesOfAnObjectCluster : LocatableBase, ICluster
        {     private DvText physicalObjectName;
        
            [Element("/items", "at0036", "Physical object name")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText PhysicalObjectName            
            {
                get { return physicalObjectName; }
                set { physicalObjectName = value; }
            }

            private DvQuantity weight;
        
            [Element("/items", "at0020", "Weight")]
            [AttributeConstraint("value", "DV_QUANTITY")]
            public DvQuantity Weight            
            {
                get { return weight; }
                set { weight = value; }
            }

                    
        private DimensionsCluster dimensions;
                
        [Cluster("/items", "at0037", "Dimensions")]                
        public DimensionsCluster Dimensions            
        {
            get
            {
                if(dimensions == null)
                    Dimensions = new DimensionsCluster();
                return dimensions; 
            }
            set 
            {
                dimensions = value;
                base.SetChildNode(value, "at0037");
            }
        }

        public partial class  DimensionsCluster : LocatableBase, ICluster
        {
                        private DvQuantity radius;
        
            [Element("/items", "at0039", "Radius")]
            [AttributeConstraint("value", "DV_QUANTITY")]
            public DvQuantity Radius            
            {
                get { return radius; }
                set { radius = value; }
            }

            private DvQuantity diameter;
        
            [Element("/items", "at0034", "Diameter")]
            [AttributeConstraint("value", "DV_QUANTITY")]
            public DvQuantity Diameter            
            {
                get { return diameter; }
                set { diameter = value; }
            }

            private DvQuantity circumference;
        
            [Element("/items", "at0032", "Circumference")]
            [AttributeConstraint("value", "DV_QUANTITY")]
            public DvQuantity Circumference            
            {
                get { return circumference; }
                set { circumference = value; }
            }

            private DvQuantity length;
        
            [Element("/items", "at0029", "Length")]
            [AttributeConstraint("value", "DV_QUANTITY")]
            public DvQuantity Length            
            {
                get { return length; }
                set { length = value; }
            }

            private DvQuantity breadth;
        
            [Element("/items", "at0031", "Breadth")]
            [AttributeConstraint("value", "DV_QUANTITY")]
            public DvQuantity Breadth            
            {
                get { return breadth; }
                set { breadth = value; }
            }

            private DvQuantity depth;
        
            [Element("/items", "at0030", "Depth")]
            [AttributeConstraint("value", "DV_QUANTITY")]
            public DvQuantity Depth            
            {
                get { return depth; }
                set { depth = value; }
            }

            private DvQuantity area;
        
            [Element("/items", "at0035", "Area")]
            [AttributeConstraint("value", "DV_QUANTITY")]
            public DvQuantity Area            
            {
                get { return area; }
                set { area = value; }
            }

            private DvQuantity volume;
        
            [Element("/items", "at0033", "Volume")]
            [AttributeConstraint("value", "DV_QUANTITY")]
            public DvQuantity Volume            
            {
                get { return volume; }
                set { volume = value; }
            }

             
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        }
        #endregion
    
        
        }
        private DvText description;
        
            [Element("/items", "at0023", "Description")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText Description            
            {
                get { return description; }
                set { description = value; }
            }

            private DvMultimedia image;
        
            [Element("/items", "at0038", "Image")]
            [AttributeConstraint("value", "DV_MULTIMEDIA")]
            public DvMultimedia Image            
            {
                get { return image; }
                set { image = value; }
            }

             
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        }
        #endregion
            
        }        
                
        private NeedleBiopsyCoreDetailsCluster needleBiopsyCoreDetails;
                
        [Cluster("/items", "at0073", "Needle biopsy core details")]                
        public NeedleBiopsyCoreDetailsCluster NeedleBiopsyCoreDetails            
        {
            get
            {
                if(needleBiopsyCoreDetails == null)
                    NeedleBiopsyCoreDetails = new NeedleBiopsyCoreDetailsCluster();
                return needleBiopsyCoreDetails; 
            }
            set 
            {
                needleBiopsyCoreDetails = value;
                base.SetChildNode(value, "at0073");
            }
        }

        public partial class  NeedleBiopsyCoreDetailsCluster : LocatableBase, ICluster
        {
                        private DvText biopsyCoreNeedleGauge;
        
            [Element("/items", "at0074", "Biopsy core needle gauge")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText BiopsyCoreNeedleGauge            
            {
                get { return biopsyCoreNeedleGauge; }
                set { biopsyCoreNeedleGauge = value; }
            }

            private DvQuantity maximumBiopsyCoreLength;
        
            [Element("/items", "at0075", "Maximum biopsy core length")]
            [AttributeConstraint("value", "DV_QUANTITY")]
            public DvQuantity MaximumBiopsyCoreLength            
            {
                get { return maximumBiopsyCoreLength; }
                set { maximumBiopsyCoreLength = value; }
            }

            private DvCount numberOfCoresReceived;
        
            [Element("/items", "at0076", "Number of cores received")]
            [AttributeConstraint("value", "DV_COUNT")]
            public DvCount NumberOfCoresReceived            
            {
                get { return numberOfCoresReceived; }
                set { numberOfCoresReceived = value; }
            }

             
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        }
        #endregion
    
        
        }
                
        private CollectionAndHandlingCluster collectionAndHandling;
                
        [Cluster("/items", "at0050", "Collection and handling")]                
        public CollectionAndHandlingCluster CollectionAndHandling            
        {
            get
            {
                if(collectionAndHandling == null)
                    CollectionAndHandling = new CollectionAndHandlingCluster();
                return collectionAndHandling; 
            }
            set 
            {
                collectionAndHandling = value;
                base.SetChildNode(value, "at0050");
            }
        }

        public partial class  CollectionAndHandlingCluster : LocatableBase, ICluster
        {
                        private DvText potentialRiskBiohazard;
        
            [Element("/items", "at0005", "Potential risk / biohazard")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText PotentialRiskBiohazard            
            {
                get { return potentialRiskBiohazard; }
                set { potentialRiskBiohazard = value; }
            }

            private DvText samplingPreconditions;
        
            [Element("/items", "at0008", "Sampling preconditions")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText SamplingPreconditions            
            {
                get { return samplingPreconditions; }
                set { samplingPreconditions = value; }
            }

            private DvCount numberOfContainers;
        
            [Element("/items", "at0080", "Number of containers")]
            [AttributeConstraint("value", "DV_COUNT")]
            public DvCount NumberOfContainers            
            {
                get { return numberOfContainers; }
                set { numberOfContainers = value; }
            }

            private DvText collectionProcedureDetails;
        
            [Element("/items", "at0079", "Collection procedure details")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText CollectionProcedureDetails            
            {
                get { return collectionProcedureDetails; }
                set { collectionProcedureDetails = value; }
            }

            private DvText transportMedium;
        
            [Element("/items", "at0025", "Transport medium")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText TransportMedium            
            {
                get { return transportMedium; }
                set { transportMedium = value; }
            }

            private DvText testingMethod;
        
            [Element("/items", "at0078", "Testing method")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText TestingMethod            
            {
                get { return testingMethod; }
                set { testingMethod = value; }
            }

             
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        }
        #endregion
    
        
        }
                
        private HandlingAndProcessingCluster handlingAndProcessing;
                
        [Cluster("/items", "at0046", "Handling and processing")]                
        public HandlingAndProcessingCluster HandlingAndProcessing            
        {
            get
            {
                if(handlingAndProcessing == null)
                    HandlingAndProcessing = new HandlingAndProcessingCluster();
                return handlingAndProcessing; 
            }
            set 
            {
                handlingAndProcessing = value;
                base.SetChildNode(value, "at0046");
            }
        }

        public partial class  HandlingAndProcessingCluster : LocatableBase, ICluster
        {
                        private DvDateTime dateAndTimeOfCollection;
        
            [Element("/items", "at0015", "Date and time of collection")]
            [AttributeConstraint("value", "DV_DATE_TIME")]
            public DvDateTime DateAndTimeOfCollection            
            {
                get { return dateAndTimeOfCollection; }
                set { dateAndTimeOfCollection = value; }
            }

            private DvText collectionSetting;
        
            [Element("/items", "at0067", "Collection setting")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText CollectionSetting            
            {
                get { return collectionSetting; }
                set { collectionSetting = value; }
            }

            private DvDateTime dateAndTimeOfReceipt;
        
            [Element("/items", "at0034", "Date and time of receipt")]
            [AttributeConstraint("value", "DV_DATE_TIME")]
            public DvDateTime DateAndTimeOfReceipt            
            {
                get { return dateAndTimeOfReceipt; }
                set { dateAndTimeOfReceipt = value; }
            }

            private DvDateTime dateAndTimeProcessed;
        
            [Element("/items", "at0035", "Date and time processed")]
            [AttributeConstraint("value", "DV_DATE_TIME")]
            public DvDateTime DateAndTimeProcessed            
            {
                get { return dateAndTimeProcessed; }
                set { dateAndTimeProcessed = value; }
            }

             
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        }
        #endregion
    
        
        }
                
        private SpecimenQualityCluster specimenQuality;
                
        [Cluster("/items", "at0039", "Specimen quality")]                
        public SpecimenQualityCluster SpecimenQuality            
        {
            get
            {
                if(specimenQuality == null)
                    SpecimenQuality = new SpecimenQualityCluster();
                return specimenQuality; 
            }
            set 
            {
                specimenQuality = value;
                base.SetChildNode(value, "at0039");
            }
        }

        public partial class  SpecimenQualityCluster : LocatableBase, ICluster
        {
                                
            private List<DataValue> specimenReceivedIssues;
        
            [Element("/items", "at0042", "Specimen received issues")]
            [AttributeConstraint("value", "DV_CODED_TEXT")]
            [AttributeConstraint("value", "DV_TEXT")]            
            public List<DataValue> SpecimenReceivedIssues            
            {
                get { return specimenReceivedIssues; }
                set { specimenReceivedIssues = value; }
            }

                    
            private List<DataValue> laboratoryHandlingIssues;
        
            [Element("/items", "at0044", "Laboratory handling issues")]
            [AttributeConstraint("value", "DV_CODED_TEXT")]
            [AttributeConstraint("value", "DV_TEXT")]            
            public List<DataValue> LaboratoryHandlingIssues            
            {
                get { return laboratoryHandlingIssues; }
                set { laboratoryHandlingIssues = value; }
            }

            private DataValue adequacyForTesting;
        
            [Element("/items", "at0041", "Adequacy for testing")]
            [AttributeConstraint("value", "DV_CODED_TEXT")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DataValue AdequacyForTesting            
            {
                get { return adequacyForTesting; }
                set { adequacyForTesting = value; }
            }

            private DvText comment;
        
            [Element("/items", "at0045", "Comment")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText Comment            
            {
                get { return comment; }
                set { comment = value; }
            }

             
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        				
            Dictionary<string, string> specimenReceivedIssuesMap = new Dictionary<string, string>();
        	specimenReceivedIssuesMap.Add("at0052", "Haemolysed");
            specimenReceivedIssuesMap.Add("at0053", "Lipaemic");
            specimenReceivedIssuesMap.Add("at0054", "Incorrect transport medium");
            specimenReceivedIssuesMap.Add("at0055", "Insufficient sample");
            objectConstraints.Add("SpecimenReceivedIssuesMap", specimenReceivedIssuesMap);
            
            List<DvCodedText> specimenReceivedIssues = new List<DvCodedText>();
            specimenReceivedIssues.Add(OpenEhrFactory.DvCodedText("Haemolysed", "at0052", "local"));
            specimenReceivedIssues.Add(OpenEhrFactory.DvCodedText("Lipaemic", "at0053", "local"));
            specimenReceivedIssues.Add(OpenEhrFactory.DvCodedText("Incorrect transport medium", "at0054", "local"));
            specimenReceivedIssues.Add(OpenEhrFactory.DvCodedText("Insufficient sample", "at0055", "local"));
            objectConstraints.Add("SpecimenReceivedIssues", specimenReceivedIssues);
        				
            Dictionary<string, string> laboratoryHandlingIssuesMap = new Dictionary<string, string>();
        	laboratoryHandlingIssuesMap.Add("at0056", "Handling error");
            laboratoryHandlingIssuesMap.Add("at0057", "Age");
            laboratoryHandlingIssuesMap.Add("at0058", "Laboratory accident");
            laboratoryHandlingIssuesMap.Add("at0059", "Technical failure");
            objectConstraints.Add("LaboratoryHandlingIssuesMap", laboratoryHandlingIssuesMap);
            
            List<DvCodedText> laboratoryHandlingIssues = new List<DvCodedText>();
            laboratoryHandlingIssues.Add(OpenEhrFactory.DvCodedText("Handling error", "at0056", "local"));
            laboratoryHandlingIssues.Add(OpenEhrFactory.DvCodedText("Age", "at0057", "local"));
            laboratoryHandlingIssues.Add(OpenEhrFactory.DvCodedText("Laboratory accident", "at0058", "local"));
            laboratoryHandlingIssues.Add(OpenEhrFactory.DvCodedText("Technical failure", "at0059", "local"));
            objectConstraints.Add("LaboratoryHandlingIssues", laboratoryHandlingIssues);
        				
            Dictionary<string, string> adequacyForTestingMap = new Dictionary<string, string>();
        	adequacyForTestingMap.Add("at0062", "Satisfactory");
            adequacyForTestingMap.Add("at0063", "Unsatisfactory - processed");
            adequacyForTestingMap.Add("at0064", "Unsatisfactory - not processed");
            objectConstraints.Add("AdequacyForTestingMap", adequacyForTestingMap);
            
            List<DvCodedText> adequacyForTesting = new List<DvCodedText>();
            adequacyForTesting.Add(OpenEhrFactory.DvCodedText("Satisfactory", "at0062", "local"));
            adequacyForTesting.Add(OpenEhrFactory.DvCodedText("Unsatisfactory - processed", "at0063", "local"));
            adequacyForTesting.Add(OpenEhrFactory.DvCodedText("Unsatisfactory - not processed", "at0064", "local"));
            objectConstraints.Add("AdequacyForTesting", adequacyForTesting);
        }
        #endregion
    
        
        }
                
        private IdentifiersCluster identifiers;
                
        [Cluster("/items", "at0002", "Identifiers")]                
        public IdentifiersCluster Identifiers            
        {
            get
            {
                if(identifiers == null)
                    Identifiers = new IdentifiersCluster();
                return identifiers; 
            }
            set 
            {
                identifiers = value;
                base.SetChildNode(value, "at0002");
            }
        }

        public partial class  IdentifiersCluster : LocatableBase, ICluster
        {
                        private DvText specimenIdentifier;
        
            [Element("/items", "at0001", "Specimen identifier")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText SpecimenIdentifier            
            {
                get { return specimenIdentifier; }
                set { specimenIdentifier = value; }
            }

            private DvText parentSpecimenIdentifier;
        
            [Element("/items", "at0003", "Parent specimen identifier")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText ParentSpecimenIdentifier            
            {
                get { return parentSpecimenIdentifier; }
                set { parentSpecimenIdentifier = value; }
            }

            private DvText containerIdentifier;
        
            [Element("/items", "at0072", "Container identifier")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText ContainerIdentifier            
            {
                get { return containerIdentifier; }
                set { containerIdentifier = value; }
            }

            private DvText specimenCollectorIdentifier;
        
            [Element("/items", "at0070", "Specimen collector identifier")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText SpecimenCollectorIdentifier            
            {
                get { return specimenCollectorIdentifier; }
                set { specimenCollectorIdentifier = value; }
            }

                    
        private SpecimenCollectorCluster specimenCollector;
                
        [Cluster("/items")]
        [TextAttribute("name", "Specimen Collector")]                
        public SpecimenCollectorCluster SpecimenCollector            
        {
            get { return specimenCollector; }
            set  { specimenCollector = value; }
        }
        
    	
        [Archetype("openEHR-EHR-CLUSTER.individual_professional.v1", "Professional Individual demographics")]                
        public partial  class  SpecimenCollectorCluster : LocatableBase, ICluster
        {             
        private ProfessionalDetailsCluster professionalDetails;
                
        [Cluster("/items", "at0003", "Professional details")]                
        public ProfessionalDetailsCluster ProfessionalDetails            
        {
            get
            {
                if(professionalDetails == null)
                    ProfessionalDetails = new ProfessionalDetailsCluster();
                return professionalDetails; 
            }
            set 
            {
                professionalDetails = value;
                base.SetChildNode(value, "at0003");
            }
        }

        public partial class  ProfessionalDetailsCluster : LocatableBase, ICluster
        {
                        private DvInterval<DvDateTime> periodOfInvolvement;
        
            [Element("/items", "at0013", "Period of involvement")]
            [AttributeConstraint("value", "DV_INTERVAL<DV_DATE_TIME>")]
            public DvInterval<DvDateTime> PeriodOfInvolvement            
            {
                get { return periodOfInvolvement; }
                set { periodOfInvolvement = value; }
            }

            private DvText grade;
        
            [Element("/items", "at0005", "Grade")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText Grade            
            {
                get { return grade; }
                set { grade = value; }
            }

            private DvText specialty;
        
            [Element("/items", "at0006", "Specialty")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText Specialty            
            {
                get { return specialty; }
                set { specialty = value; }
            }

            private DvText team;
        
            [Element("/items", "at0012", "Team")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText Team            
            {
                get { return team; }
                set { team = value; }
            }

            private DvText professionalIdentifier;
        
            [Element("/items", "at0011", "Professional Identifier")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText ProfessionalIdentifier            
            {
                get { return professionalIdentifier; }
                set { professionalIdentifier = value; }
            }

             
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        }
        #endregion
    
        
        }
         
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        }
        #endregion
            
        }        
         
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        }
        #endregion
    
        
        }
         
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        }
        #endregion
            
        }        
        private DvText overallInterpretation;
        
            [Element("/data/items", "at0057", "Overall interpretation")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText OverallInterpretation            
            {
                get { return overallInterpretation; }
                set { overallInterpretation = value; }
            }

                    
            private List<DvMultimedia> multimediaRepresentation;
        
            [Element("/data/items", "at0010", "Multimedia representation")]
            [AttributeConstraint("value", "DV_MULTIMEDIA")]            
            public List<DvMultimedia> MultimediaRepresentation            
            {
                get { return multimediaRepresentation; }
                set { multimediaRepresentation = value; }
            }

             
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        				
            Dictionary<string, string> testStatusMap = new Dictionary<string, string>();
        	testStatusMap.Add("at0037", "Interim");
            testStatusMap.Add("at0038", "Final");
            testStatusMap.Add("at0039", "Supplementary");
            testStatusMap.Add("at0040", "Corrected (amended)");
            testStatusMap.Add("at0074", "Aborted");
            testStatusMap.Add("at0079", "Never performed");
            objectConstraints.Add("TestStatusMap", testStatusMap);
            
            List<DvCodedText> testStatus = new List<DvCodedText>();
            testStatus.Add(OpenEhrFactory.DvCodedText("Interim", "at0037", "local"));
            testStatus.Add(OpenEhrFactory.DvCodedText("Final", "at0038", "local"));
            testStatus.Add(OpenEhrFactory.DvCodedText("Supplementary", "at0039", "local"));
            testStatus.Add(OpenEhrFactory.DvCodedText("Corrected (amended)", "at0040", "local"));
            testStatus.Add(OpenEhrFactory.DvCodedText("Aborted", "at0074", "local"));
            testStatus.Add(OpenEhrFactory.DvCodedText("Never performed", "at0079", "local"));
            objectConstraints.Add("TestStatus", testStatus);
        }
        #endregion
    
        
        }
        
        private DvText requestorOrderIdentifier;
        
            [Element("/protocol/items", "at0062", "Requestor order identifier")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText RequestorOrderIdentifier            
            {
                get { return requestorOrderIdentifier; }
                set { requestorOrderIdentifier = value; }
            }

                    
        private OrderingClinicianCluster orderingClinician;
                
        [Cluster("/protocol/items")]
        [TextAttribute("name", "Ordering Clinician")]                
        public OrderingClinicianCluster OrderingClinician            
        {
            get { return orderingClinician; }
            set  { orderingClinician = value; }
        }
        
    	
        [Archetype("openEHR-EHR-CLUSTER.individual_professional.v1", "Professional Individual demographics")]                
        public partial  class  OrderingClinicianCluster : LocatableBase, ICluster
        {             
        private OrederingClinicainNameCluster orederingClinicainName;
                
        [Cluster("/items")]
        [TextAttribute("name", "Oredering Clinicain Name")]                
        public OrederingClinicainNameCluster OrederingClinicainName            
        {
            get { return orederingClinicainName; }
            set  { orederingClinicainName = value; }
        }
        
    	
        [Archetype("openEHR-EHR-CLUSTER.person_name.v1", "Person name")]                
        public partial  class  OrederingClinicainNameCluster : LocatableBase, ICluster
        {     private DvCodedText nameType;
        
            [Element("/items", "at0006", "Name type")]
            [AttributeConstraint("value", "DV_CODED_TEXT")]
            public DvCodedText NameType            
            {
                get { return nameType; }
                set { nameType = value; }
            }

            private DvBoolean preferredName;
        
            [Element("/items", "at0022", "Preferred name")]
            [AttributeConstraint("value", "DV_BOOLEAN")]
            public DvBoolean PreferredName            
            {
                get { return preferredName; }
                set { preferredName = value; }
            }

            private DvText unstructuredName;
        
            [Element("/items", "at0001", "Unstructured name")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText UnstructuredName            
            {
                get { return unstructuredName; }
                set { unstructuredName = value; }
            }

                    
        private StructuredNameCluster structuredName;
                
        [Cluster("/items", "at0002", "Structured name")]                
        public StructuredNameCluster StructuredName            
        {
            get
            {
                if(structuredName == null)
                    StructuredName = new StructuredNameCluster();
                return structuredName; 
            }
            set 
            {
                structuredName = value;
                base.SetChildNode(value, "at0002");
            }
        }

        public partial class  StructuredNameCluster : LocatableBase, ICluster
        {
                        private DvText title;
        
            [Element("/items", "at0017", "Title")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText Title            
            {
                get { return title; }
                set { title = value; }
            }

            private DvText givenName;
        
            [Element("/items", "at0003", "Given name")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText GivenName            
            {
                get { return givenName; }
                set { givenName = value; }
            }

                    
            private List<DvCodedText> middleName;
        
            [Element("/items", "at0004", "Middle name")]
            [AttributeConstraint("value", "DV_CODED_TEXT")]            
            public List<DvCodedText> MiddleName            
            {
                get { return middleName; }
                set { middleName = value; }
            }

            private DvText familyName;
        
            [Element("/items", "at0005", "Family name")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText FamilyName            
            {
                get { return familyName; }
                set { familyName = value; }
            }

            private DvText suffix;
        
            [Element("/items", "at0018", "Suffix")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText Suffix            
            {
                get { return suffix; }
                set { suffix = value; }
            }

             
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        				
            Dictionary<string, string> middleNameMap = new Dictionary<string, string>();
        	objectConstraints.Add("MiddleNameMap", middleNameMap);
            
            List<DvCodedText> middleName = new List<DvCodedText>();
            objectConstraints.Add("MiddleName", middleName);
        }
        #endregion
    
        
        }
        private DvInterval<DvDateTime> validityPeriod;
        
            [Element("/items", "at0014", "Validity period")]
            [AttributeConstraint("value", "DV_INTERVAL<DV_DATE_TIME>")]
            public DvInterval<DvDateTime> ValidityPeriod            
            {
                get { return validityPeriod; }
                set { validityPeriod = value; }
            }

             
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        				
            Dictionary<string, string> nameTypeMap = new Dictionary<string, string>();
        	nameTypeMap.Add("at0020", "Registered name");
            nameTypeMap.Add("at0008", "Previous name");
            nameTypeMap.Add("at0009", "Birth name");
            nameTypeMap.Add("at0010", "AKA");
            nameTypeMap.Add("at0011", "Alias");
            nameTypeMap.Add("at0012", "Maiden name");
            nameTypeMap.Add("at0019", "Professional name");
            nameTypeMap.Add("at0021", "Reporting name");
            objectConstraints.Add("NameTypeMap", nameTypeMap);
            
            List<DvCodedText> nameType = new List<DvCodedText>();
            nameType.Add(OpenEhrFactory.DvCodedText("Registered name", "at0020", "local"));
            nameType.Add(OpenEhrFactory.DvCodedText("Previous name", "at0008", "local"));
            nameType.Add(OpenEhrFactory.DvCodedText("Birth name", "at0009", "local"));
            nameType.Add(OpenEhrFactory.DvCodedText("AKA", "at0010", "local"));
            nameType.Add(OpenEhrFactory.DvCodedText("Alias", "at0011", "local"));
            nameType.Add(OpenEhrFactory.DvCodedText("Maiden name", "at0012", "local"));
            nameType.Add(OpenEhrFactory.DvCodedText("Professional name", "at0019", "local"));
            nameType.Add(OpenEhrFactory.DvCodedText("Reporting name", "at0021", "local"));
            objectConstraints.Add("NameType", nameType);
        }
        #endregion
            
        }        
                
        private ProfessionalDetailsCluster professionalDetails;
                
        [Cluster("/items", "at0003", "Professional details")]                
        public ProfessionalDetailsCluster ProfessionalDetails            
        {
            get
            {
                if(professionalDetails == null)
                    ProfessionalDetails = new ProfessionalDetailsCluster();
                return professionalDetails; 
            }
            set 
            {
                professionalDetails = value;
                base.SetChildNode(value, "at0003");
            }
        }

        public partial class  ProfessionalDetailsCluster : LocatableBase, ICluster
        {
                                
                private LocatableList<ProfessionalRoleCluster> professionalRole;
                
        [Cluster("/items")]
                
        public LocatableList<ProfessionalRoleCluster> ProfessionalRole            
        {
            get { return professionalRole; }
            set  { professionalRole = value; }
        }
        
    	
        [Archetype("openEHR-EHR-CLUSTER.professional_role.v1", "Professional role")]                
        public partial  class  ProfessionalRoleCluster : LocatableBase, ICluster
        {     private DvText unstructuredRole;
        
            [Element("/items", "at0001", "Unstructured role")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText UnstructuredRole            
            {
                get { return unstructuredRole; }
                set { unstructuredRole = value; }
            }

             
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        				
            List<DvText> unstructuredRole = new List<DvText>();
            unstructuredRole.Add( new DvText("Attending Physician"));
            unstructuredRole.Add( new DvText("Resident Physician"));
            unstructuredRole.Add( new DvText("Student"));
            unstructuredRole.Add( new DvText("Oncologist"));
            unstructuredRole.Add( new DvText("Clinician"));
            objectConstraints.Add("UnstructuredRole", unstructuredRole);
        }
        #endregion
            
        }        
        private DvInterval<DvDateTime> periodOfInvolvement;
        
            [Element("/items", "at0013", "Period of involvement")]
            [AttributeConstraint("value", "DV_INTERVAL<DV_DATE_TIME>")]
            public DvInterval<DvDateTime> PeriodOfInvolvement            
            {
                get { return periodOfInvolvement; }
                set { periodOfInvolvement = value; }
            }

            private DvText grade;
        
            [Element("/items", "at0005", "Grade")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText Grade            
            {
                get { return grade; }
                set { grade = value; }
            }

            private DvText specialty;
        
            [Element("/items", "at0006", "Specialty")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText Specialty            
            {
                get { return specialty; }
                set { specialty = value; }
            }

            private DvText team;
        
            [Element("/items", "at0012", "Team")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText Team            
            {
                get { return team; }
                set { team = value; }
            }

            private DvText professionalIdentifier;
        
            [Element("/items", "at0011", "Professional Identifier")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText ProfessionalIdentifier            
            {
                get { return professionalIdentifier; }
                set { professionalIdentifier = value; }
            }

                    
                private LocatableList<TelecomDetailsCluster> telecomDetails;
                
        [Cluster("/items")]
                
        public LocatableList<TelecomDetailsCluster> TelecomDetails            
        {
            get { return telecomDetails; }
            set  { telecomDetails = value; }
        }
        
    	
        [Archetype("openEHR-EHR-CLUSTER.telecom_details.v1", "Telecom details")]                
        public partial  class  TelecomDetailsCluster : LocatableBase, ICluster
        {             
            private List<DvCodedText> mode;
        
            [Element("/items", "at0010", "Mode")]
            [AttributeConstraint("value", "DV_CODED_TEXT")]            
            public List<DvCodedText> Mode            
            {
                get { return mode; }
                set { mode = value; }
            }

                    
        private LocatableList<TelecomsCluster> telecoms;
        
        [Cluster("/items", "at0001", "Telecoms")]
        public LocatableList<TelecomsCluster> Telecoms            
        {
            get
            {
                return telecoms; 
            }
            set 
            {
                telecoms = value;
                base.SetChildNode(value, "at0001");
            }
        }

        public partial class  TelecomsCluster : LocatableBase, ICluster
        {
                        private DvCodedText telecomsType;
        
            [Element("/items", "at0004", "Telecoms type")]
            [AttributeConstraint("value", "DV_CODED_TEXT")]
            public DvCodedText TelecomsType            
            {
                get { return telecomsType; }
                set { telecomsType = value; }
            }

            private DvText unstucturedTelecoms;
        
            [Element("/items", "at0002", "Unstuctured telecoms")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText UnstucturedTelecoms            
            {
                get { return unstucturedTelecoms; }
                set { unstucturedTelecoms = value; }
            }

                    
        private StructuredTelecomsCluster structuredTelecoms;
                
        [Cluster("/items", "at0003", "Structured telecoms")]                
        public StructuredTelecomsCluster StructuredTelecoms            
        {
            get
            {
                if(structuredTelecoms == null)
                    StructuredTelecoms = new StructuredTelecomsCluster();
                return structuredTelecoms; 
            }
            set 
            {
                structuredTelecoms = value;
                base.SetChildNode(value, "at0003");
            }
        }

        public partial class  StructuredTelecomsCluster : LocatableBase, ICluster
        {
                        private DvText countryCode;
        
            [Element("/items", "at0005", "Country code")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText CountryCode            
            {
                get { return countryCode; }
                set { countryCode = value; }
            }

            private DvText areaCode;
        
            [Element("/items", "at0006", "Area code")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText AreaCode            
            {
                get { return areaCode; }
                set { areaCode = value; }
            }

            private DvText number;
        
            [Element("/items", "at0007", "Number")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText Number            
            {
                get { return number; }
                set { number = value; }
            }

            private DvText extension;
        
            [Element("/items", "at0019", "Extension")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText Extension            
            {
                get { return extension; }
                set { extension = value; }
            }

             
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        }
        #endregion
    
        
        }
         
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        				
            Dictionary<string, string> telecomsTypeMap = new Dictionary<string, string>();
        	telecomsTypeMap.Add("at0013", "Telephone");
            telecomsTypeMap.Add("at0014", "Fax");
            telecomsTypeMap.Add("at0015", "Mobile phone");
            telecomsTypeMap.Add("at0016", "Pager");
            objectConstraints.Add("TelecomsTypeMap", telecomsTypeMap);
            
            List<DvCodedText> telecomsType = new List<DvCodedText>();
            telecomsType.Add(OpenEhrFactory.DvCodedText("Telephone", "at0013", "local"));
            telecomsType.Add(OpenEhrFactory.DvCodedText("Fax", "at0014", "local"));
            telecomsType.Add(OpenEhrFactory.DvCodedText("Mobile phone", "at0015", "local"));
            telecomsType.Add(OpenEhrFactory.DvCodedText("Pager", "at0016", "local"));
            objectConstraints.Add("TelecomsType", telecomsType);
        }
        #endregion
    
        
        }
                
            private List<DvText> emailAddress;
        
            [Element("/items", "at0009", "Email address")]
            [AttributeConstraint("value", "DV_TEXT")]            
            public List<DvText> EmailAddress            
            {
                get { return emailAddress; }
                set { emailAddress = value; }
            }

             
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        				
            Dictionary<string, string> modeMap = new Dictionary<string, string>();
        	modeMap.Add("at0011", "Home");
            modeMap.Add("at0012", "Work");
            modeMap.Add("at0018", "Contact");
            objectConstraints.Add("ModeMap", modeMap);
            
            List<DvCodedText> mode = new List<DvCodedText>();
            mode.Add(OpenEhrFactory.DvCodedText("Home", "at0011", "local"));
            mode.Add(OpenEhrFactory.DvCodedText("Work", "at0012", "local"));
            mode.Add(OpenEhrFactory.DvCodedText("Contact", "at0018", "local"));
            objectConstraints.Add("Mode", mode);
        }
        #endregion
            
        }        
                
                private LocatableList<AddressCluster> address;
                
        [Cluster("/items")]
                
        public LocatableList<AddressCluster> Address            
        {
            get { return address; }
            set  { address = value; }
        }
        
    	
        [Archetype("openEHR-EHR-CLUSTER.address.v1", "Address")]                
        public partial  class  AddressCluster : LocatableBase, ICluster
        {             
        private LocatableList<AddressCluster> address;
        
        [Cluster("/items", "at0001", "Address")]
        public LocatableList<AddressCluster> Address            
        {
            get
            {
                return address; 
            }
            set 
            {
                address = value;
                base.SetChildNode(value, "at0001");
            }
        }

        public partial class  AddressCluster : LocatableBase, ICluster
        {
                        private DvCodedText addressType;
        
            [Element("/items", "at0006", "Address Type")]
            [AttributeConstraint("value", "DV_CODED_TEXT")]
            public DvCodedText AddressType            
            {
                get { return addressType; }
                set { addressType = value; }
            }

            private DvText unstructuredAddress;
        
            [Element("/items", "at0002", "Unstructured address")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText UnstructuredAddress            
            {
                get { return unstructuredAddress; }
                set { unstructuredAddress = value; }
            }

                    
        private StructuredAddressCluster structuredAddress;
                
        [Cluster("/items", "at0003", "Structured address")]                
        public StructuredAddressCluster StructuredAddress            
        {
            get
            {
                if(structuredAddress == null)
                    StructuredAddress = new StructuredAddressCluster();
                return structuredAddress; 
            }
            set 
            {
                structuredAddress = value;
                base.SetChildNode(value, "at0003");
            }
        }

        public partial class  StructuredAddressCluster : LocatableBase, ICluster
        {
                        private DvText propertyNumber;
        
            [Element("/items", "at0005", "Property number")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText PropertyNumber            
            {
                get { return propertyNumber; }
                set { propertyNumber = value; }
            }

                    
            private List<DvText> addressLine;
        
            [Element("/items", "at0009", "Address line")]
            [AttributeConstraint("value", "DV_TEXT")]            
            public List<DvText> AddressLine            
            {
                get { return addressLine; }
                set { addressLine = value; }
            }

             
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        }
        #endregion
    
        
        }
        private DvText postCode;
        
            [Element("/items", "at0004", "Post code")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText PostCode            
            {
                get { return postCode; }
                set { postCode = value; }
            }

                    
        private AddressvalidPeriodCluster addressvalidPeriod;
                
        [Cluster("/items", "at0015", "AddressValid Period")]                
        public AddressvalidPeriodCluster AddressvalidPeriod            
        {
            get
            {
                if(addressvalidPeriod == null)
                    AddressvalidPeriod = new AddressvalidPeriodCluster();
                return addressvalidPeriod; 
            }
            set 
            {
                addressvalidPeriod = value;
                base.SetChildNode(value, "at0015");
            }
        }

        public partial class  AddressvalidPeriodCluster : LocatableBase, ICluster
        {
                        private DvDateTime validFrom;
        
            [Element("/items", "at0007", "Valid from")]
            [AttributeConstraint("value", "DV_DATE_TIME")]
            public DvDateTime ValidFrom            
            {
                get { return validFrom; }
                set { validFrom = value; }
            }

            private DvDateTime validTo;
        
            [Element("/items", "at0008", "Valid to")]
            [AttributeConstraint("value", "DV_DATE_TIME")]
            public DvDateTime ValidTo            
            {
                get { return validTo; }
                set { validTo = value; }
            }

             
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        }
        #endregion
    
        
        }
         
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        				
            Dictionary<string, string> addressTypeMap = new Dictionary<string, string>();
        	addressTypeMap.Add("at0011", "Residential");
            addressTypeMap.Add("at0012", "Correspondence");
            addressTypeMap.Add("at0013", "Business");
            addressTypeMap.Add("at0014", "Temporary");
            objectConstraints.Add("AddressTypeMap", addressTypeMap);
            
            List<DvCodedText> addressType = new List<DvCodedText>();
            addressType.Add(OpenEhrFactory.DvCodedText("Residential", "at0011", "local"));
            addressType.Add(OpenEhrFactory.DvCodedText("Correspondence", "at0012", "local"));
            addressType.Add(OpenEhrFactory.DvCodedText("Business", "at0013", "local"));
            addressType.Add(OpenEhrFactory.DvCodedText("Temporary", "at0014", "local"));
            objectConstraints.Add("AddressType", addressType);
        }
        #endregion
    
        
        }
         
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        }
        #endregion
            
        }        
                
                private LocatableList<OrganisationCluster> organisation;
                
        [Cluster("/items")]
                
        public LocatableList<OrganisationCluster> Organisation            
        {
            get { return organisation; }
            set  { organisation = value; }
        }
        
    	
        [Archetype("openEHR-EHR-CLUSTER.organisation.v1", "Organisation")]                
        public partial  class  OrganisationCluster : LocatableBase, ICluster
        {     private DvText nameOfOrganisation;
        
            [Element("/items", "at0001", "Name of Organisation")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText NameOfOrganisation            
            {
                get { return nameOfOrganisation; }
                set { nameOfOrganisation = value; }
            }

            private DvText identifier;
        
            [Element("/items", "at0011", "Identifier")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText Identifier            
            {
                get { return identifier; }
                set { identifier = value; }
            }

                    
        private AddressCluster address;
                
        [Cluster("/items")]                
        public AddressCluster Address            
        {
            get { return address; }
            set  { address = value; }
        }
        
    	
        [Archetype("openEHR-EHR-CLUSTER.address.v1", "Address")]                
        public partial  class  AddressCluster : LocatableBase, ICluster
        {             
        private LocatableList<AddressCluster> address;
        
        [Cluster("/items", "at0001", "Address")]
        public LocatableList<AddressCluster> Address            
        {
            get
            {
                return address; 
            }
            set 
            {
                address = value;
                base.SetChildNode(value, "at0001");
            }
        }

        public partial class  AddressCluster : LocatableBase, ICluster
        {
                        private DvCodedText addressType;
        
            [Element("/items", "at0006", "Address Type")]
            [AttributeConstraint("value", "DV_CODED_TEXT")]
            public DvCodedText AddressType            
            {
                get { return addressType; }
                set { addressType = value; }
            }

            private DvText unstructuredAddress;
        
            [Element("/items", "at0002", "Unstructured address")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText UnstructuredAddress            
            {
                get { return unstructuredAddress; }
                set { unstructuredAddress = value; }
            }

                    
        private StructuredAddressCluster structuredAddress;
                
        [Cluster("/items", "at0003", "Structured address")]                
        public StructuredAddressCluster StructuredAddress            
        {
            get
            {
                if(structuredAddress == null)
                    StructuredAddress = new StructuredAddressCluster();
                return structuredAddress; 
            }
            set 
            {
                structuredAddress = value;
                base.SetChildNode(value, "at0003");
            }
        }

        public partial class  StructuredAddressCluster : LocatableBase, ICluster
        {
                        private DvText propertyNumber;
        
            [Element("/items", "at0005", "Property number")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText PropertyNumber            
            {
                get { return propertyNumber; }
                set { propertyNumber = value; }
            }

                    
            private List<DvText> addressLine;
        
            [Element("/items", "at0009", "Address line")]
            [AttributeConstraint("value", "DV_TEXT")]            
            public List<DvText> AddressLine            
            {
                get { return addressLine; }
                set { addressLine = value; }
            }

             
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        }
        #endregion
    
        
        }
        private DvText postCode;
        
            [Element("/items", "at0004", "Post code")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText PostCode            
            {
                get { return postCode; }
                set { postCode = value; }
            }

                    
        private AddressvalidPeriodCluster addressvalidPeriod;
                
        [Cluster("/items", "at0015", "AddressValid Period")]                
        public AddressvalidPeriodCluster AddressvalidPeriod            
        {
            get
            {
                if(addressvalidPeriod == null)
                    AddressvalidPeriod = new AddressvalidPeriodCluster();
                return addressvalidPeriod; 
            }
            set 
            {
                addressvalidPeriod = value;
                base.SetChildNode(value, "at0015");
            }
        }

        public partial class  AddressvalidPeriodCluster : LocatableBase, ICluster
        {
                        private DvDateTime validFrom;
        
            [Element("/items", "at0007", "Valid from")]
            [AttributeConstraint("value", "DV_DATE_TIME")]
            public DvDateTime ValidFrom            
            {
                get { return validFrom; }
                set { validFrom = value; }
            }

            private DvDateTime validTo;
        
            [Element("/items", "at0008", "Valid to")]
            [AttributeConstraint("value", "DV_DATE_TIME")]
            public DvDateTime ValidTo            
            {
                get { return validTo; }
                set { validTo = value; }
            }

             
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        }
        #endregion
    
        
        }
         
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        				
            Dictionary<string, string> addressTypeMap = new Dictionary<string, string>();
        	addressTypeMap.Add("at0011", "Residential");
            addressTypeMap.Add("at0012", "Correspondence");
            addressTypeMap.Add("at0013", "Business");
            addressTypeMap.Add("at0014", "Temporary");
            objectConstraints.Add("AddressTypeMap", addressTypeMap);
            
            List<DvCodedText> addressType = new List<DvCodedText>();
            addressType.Add(OpenEhrFactory.DvCodedText("Residential", "at0011", "local"));
            addressType.Add(OpenEhrFactory.DvCodedText("Correspondence", "at0012", "local"));
            addressType.Add(OpenEhrFactory.DvCodedText("Business", "at0013", "local"));
            addressType.Add(OpenEhrFactory.DvCodedText("Temporary", "at0014", "local"));
            objectConstraints.Add("AddressType", addressType);
        }
        #endregion
    
        
        }
         
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        }
        #endregion
            
        }        
                
        private LocatableList<ContactPersonDetailsCluster> contactPersonDetails;
        
        [Cluster("/items", "at0005", "Contact Person Details")]
        public LocatableList<ContactPersonDetailsCluster> ContactPersonDetails            
        {
            get
            {
                return contactPersonDetails; 
            }
            set 
            {
                contactPersonDetails = value;
                base.SetChildNode(value, "at0005");
            }
        }

        public partial class  ContactPersonDetailsCluster : LocatableBase, ICluster
        {
                                
                private LocatableList<PersonNameCluster> personName;
                
        [Cluster("/items")]
                
        public LocatableList<PersonNameCluster> PersonName            
        {
            get { return personName; }
            set  { personName = value; }
        }
        
    	
        [Archetype("openEHR-EHR-CLUSTER.person_name.v1", "Person name")]                
        public partial  class  PersonNameCluster : LocatableBase, ICluster
        {     private DvCodedText nameType;
        
            [Element("/items", "at0006", "Name type")]
            [AttributeConstraint("value", "DV_CODED_TEXT")]
            public DvCodedText NameType            
            {
                get { return nameType; }
                set { nameType = value; }
            }

            private DvBoolean preferredName;
        
            [Element("/items", "at0022", "Preferred name")]
            [AttributeConstraint("value", "DV_BOOLEAN")]
            public DvBoolean PreferredName            
            {
                get { return preferredName; }
                set { preferredName = value; }
            }

            private DvText unstructuredName;
        
            [Element("/items", "at0001", "Unstructured name")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText UnstructuredName            
            {
                get { return unstructuredName; }
                set { unstructuredName = value; }
            }

                    
        private StructuredNameCluster structuredName;
                
        [Cluster("/items", "at0002", "Structured name")]                
        public StructuredNameCluster StructuredName            
        {
            get
            {
                if(structuredName == null)
                    StructuredName = new StructuredNameCluster();
                return structuredName; 
            }
            set 
            {
                structuredName = value;
                base.SetChildNode(value, "at0002");
            }
        }

        public partial class  StructuredNameCluster : LocatableBase, ICluster
        {
                        private DvText title;
        
            [Element("/items", "at0017", "Title")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText Title            
            {
                get { return title; }
                set { title = value; }
            }

            private DvText givenName;
        
            [Element("/items", "at0003", "Given name")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText GivenName            
            {
                get { return givenName; }
                set { givenName = value; }
            }

                    
            private List<DvCodedText> middleName;
        
            [Element("/items", "at0004", "Middle name")]
            [AttributeConstraint("value", "DV_CODED_TEXT")]            
            public List<DvCodedText> MiddleName            
            {
                get { return middleName; }
                set { middleName = value; }
            }

            private DvText familyName;
        
            [Element("/items", "at0005", "Family name")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText FamilyName            
            {
                get { return familyName; }
                set { familyName = value; }
            }

            private DvText suffix;
        
            [Element("/items", "at0018", "Suffix")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText Suffix            
            {
                get { return suffix; }
                set { suffix = value; }
            }

             
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        				
            Dictionary<string, string> middleNameMap = new Dictionary<string, string>();
        	objectConstraints.Add("MiddleNameMap", middleNameMap);
            
            List<DvCodedText> middleName = new List<DvCodedText>();
            objectConstraints.Add("MiddleName", middleName);
        }
        #endregion
    
        
        }
        private DvInterval<DvDateTime> validityPeriod;
        
            [Element("/items", "at0014", "Validity period")]
            [AttributeConstraint("value", "DV_INTERVAL<DV_DATE_TIME>")]
            public DvInterval<DvDateTime> ValidityPeriod            
            {
                get { return validityPeriod; }
                set { validityPeriod = value; }
            }

             
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        				
            Dictionary<string, string> nameTypeMap = new Dictionary<string, string>();
        	nameTypeMap.Add("at0020", "Registered name");
            nameTypeMap.Add("at0008", "Previous name");
            nameTypeMap.Add("at0009", "Birth name");
            nameTypeMap.Add("at0010", "AKA");
            nameTypeMap.Add("at0011", "Alias");
            nameTypeMap.Add("at0012", "Maiden name");
            nameTypeMap.Add("at0019", "Professional name");
            nameTypeMap.Add("at0021", "Reporting name");
            objectConstraints.Add("NameTypeMap", nameTypeMap);
            
            List<DvCodedText> nameType = new List<DvCodedText>();
            nameType.Add(OpenEhrFactory.DvCodedText("Registered name", "at0020", "local"));
            nameType.Add(OpenEhrFactory.DvCodedText("Previous name", "at0008", "local"));
            nameType.Add(OpenEhrFactory.DvCodedText("Birth name", "at0009", "local"));
            nameType.Add(OpenEhrFactory.DvCodedText("AKA", "at0010", "local"));
            nameType.Add(OpenEhrFactory.DvCodedText("Alias", "at0011", "local"));
            nameType.Add(OpenEhrFactory.DvCodedText("Maiden name", "at0012", "local"));
            nameType.Add(OpenEhrFactory.DvCodedText("Professional name", "at0019", "local"));
            nameType.Add(OpenEhrFactory.DvCodedText("Reporting name", "at0021", "local"));
            objectConstraints.Add("NameType", nameType);
        }
        #endregion
            
        }        
        private DvText roleInOrganisation;
        
            [Element("/items", "at0007", "Role in organisation")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText RoleInOrganisation            
            {
                get { return roleInOrganisation; }
                set { roleInOrganisation = value; }
            }

             
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        }
        #endregion
    
        
        }
         
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        }
        #endregion
            
        }        
         
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        }
        #endregion
    
        
        }
         
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        }
        #endregion
            
        }        
        private DvText receiverOrderIdentifier;
        
            [Element("/protocol/items", "at0063", "Receiver order Identifier")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText ReceiverOrderIdentifier            
            {
                get { return receiverOrderIdentifier; }
                set { receiverOrderIdentifier = value; }
            }

                    
                private LocatableList<OrganisationCluster> organisation;
                
        [Cluster("/protocol/items")]
                
        public LocatableList<OrganisationCluster> Organisation            
        {
            get { return organisation; }
            set  { organisation = value; }
        }
        
    	
        [Archetype("openEHR-EHR-CLUSTER.organisation.v1", "Organisation")]                
        public partial  class  OrganisationCluster : LocatableBase, ICluster
        {     private DvText nameOfOrganisation;
        
            [Element("/items", "at0001", "Name of Organisation")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText NameOfOrganisation            
            {
                get { return nameOfOrganisation; }
                set { nameOfOrganisation = value; }
            }

            private DvText identifier;
        
            [Element("/items", "at0011", "Identifier")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText Identifier            
            {
                get { return identifier; }
                set { identifier = value; }
            }

                    
        private AddressCluster address;
                
        [Cluster("/items")]                
        public AddressCluster Address            
        {
            get { return address; }
            set  { address = value; }
        }
        
    	
        [Archetype("openEHR-EHR-CLUSTER.address.v1", "Address")]                
        public partial  class  AddressCluster : LocatableBase, ICluster
        {             
        private LocatableList<AddressCluster> address;
        
        [Cluster("/items", "at0001", "Address")]
        public LocatableList<AddressCluster> Address            
        {
            get
            {
                return address; 
            }
            set 
            {
                address = value;
                base.SetChildNode(value, "at0001");
            }
        }

        public partial class  AddressCluster : LocatableBase, ICluster
        {
                        private DvCodedText addressType;
        
            [Element("/items", "at0006", "Address Type")]
            [AttributeConstraint("value", "DV_CODED_TEXT")]
            public DvCodedText AddressType            
            {
                get { return addressType; }
                set { addressType = value; }
            }

            private DvText unstructuredAddress;
        
            [Element("/items", "at0002", "Unstructured address")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText UnstructuredAddress            
            {
                get { return unstructuredAddress; }
                set { unstructuredAddress = value; }
            }

                    
        private StructuredAddressCluster structuredAddress;
                
        [Cluster("/items", "at0003", "Structured address")]                
        public StructuredAddressCluster StructuredAddress            
        {
            get
            {
                if(structuredAddress == null)
                    StructuredAddress = new StructuredAddressCluster();
                return structuredAddress; 
            }
            set 
            {
                structuredAddress = value;
                base.SetChildNode(value, "at0003");
            }
        }

        public partial class  StructuredAddressCluster : LocatableBase, ICluster
        {
                        private DvText propertyNumber;
        
            [Element("/items", "at0005", "Property number")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText PropertyNumber            
            {
                get { return propertyNumber; }
                set { propertyNumber = value; }
            }

                    
            private List<DvText> addressLine;
        
            [Element("/items", "at0009", "Address line")]
            [AttributeConstraint("value", "DV_TEXT")]            
            public List<DvText> AddressLine            
            {
                get { return addressLine; }
                set { addressLine = value; }
            }

             
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        }
        #endregion
    
        
        }
        private DvText postCode;
        
            [Element("/items", "at0004", "Post code")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText PostCode            
            {
                get { return postCode; }
                set { postCode = value; }
            }

                    
        private AddressvalidPeriodCluster addressvalidPeriod;
                
        [Cluster("/items", "at0015", "AddressValid Period")]                
        public AddressvalidPeriodCluster AddressvalidPeriod            
        {
            get
            {
                if(addressvalidPeriod == null)
                    AddressvalidPeriod = new AddressvalidPeriodCluster();
                return addressvalidPeriod; 
            }
            set 
            {
                addressvalidPeriod = value;
                base.SetChildNode(value, "at0015");
            }
        }

        public partial class  AddressvalidPeriodCluster : LocatableBase, ICluster
        {
                        private DvDateTime validFrom;
        
            [Element("/items", "at0007", "Valid from")]
            [AttributeConstraint("value", "DV_DATE_TIME")]
            public DvDateTime ValidFrom            
            {
                get { return validFrom; }
                set { validFrom = value; }
            }

            private DvDateTime validTo;
        
            [Element("/items", "at0008", "Valid to")]
            [AttributeConstraint("value", "DV_DATE_TIME")]
            public DvDateTime ValidTo            
            {
                get { return validTo; }
                set { validTo = value; }
            }

             
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        }
        #endregion
    
        
        }
         
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        				
            Dictionary<string, string> addressTypeMap = new Dictionary<string, string>();
        	addressTypeMap.Add("at0011", "Residential");
            addressTypeMap.Add("at0012", "Correspondence");
            addressTypeMap.Add("at0013", "Business");
            addressTypeMap.Add("at0014", "Temporary");
            objectConstraints.Add("AddressTypeMap", addressTypeMap);
            
            List<DvCodedText> addressType = new List<DvCodedText>();
            addressType.Add(OpenEhrFactory.DvCodedText("Residential", "at0011", "local"));
            addressType.Add(OpenEhrFactory.DvCodedText("Correspondence", "at0012", "local"));
            addressType.Add(OpenEhrFactory.DvCodedText("Business", "at0013", "local"));
            addressType.Add(OpenEhrFactory.DvCodedText("Temporary", "at0014", "local"));
            objectConstraints.Add("AddressType", addressType);
        }
        #endregion
    
        
        }
         
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        }
        #endregion
            
        }        
                
        private TelecomDetailsCluster telecomDetails;
                
        [Cluster("/items")]                
        public TelecomDetailsCluster TelecomDetails            
        {
            get { return telecomDetails; }
            set  { telecomDetails = value; }
        }
        
    	
        [Archetype("openEHR-EHR-CLUSTER.telecom_details.v1", "Telecom details")]                
        public partial  class  TelecomDetailsCluster : LocatableBase, ICluster
        {             
            private List<DvCodedText> mode;
        
            [Element("/items", "at0010", "Mode")]
            [AttributeConstraint("value", "DV_CODED_TEXT")]            
            public List<DvCodedText> Mode            
            {
                get { return mode; }
                set { mode = value; }
            }

                    
        private LocatableList<TelecomsCluster> telecoms;
        
        [Cluster("/items", "at0001", "Telecoms")]
        public LocatableList<TelecomsCluster> Telecoms            
        {
            get
            {
                return telecoms; 
            }
            set 
            {
                telecoms = value;
                base.SetChildNode(value, "at0001");
            }
        }

        public partial class  TelecomsCluster : LocatableBase, ICluster
        {
                        private DvCodedText telecomsType;
        
            [Element("/items", "at0004", "Telecoms type")]
            [AttributeConstraint("value", "DV_CODED_TEXT")]
            public DvCodedText TelecomsType            
            {
                get { return telecomsType; }
                set { telecomsType = value; }
            }

            private DvText unstucturedTelecoms;
        
            [Element("/items", "at0002", "Unstuctured telecoms")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText UnstucturedTelecoms            
            {
                get { return unstucturedTelecoms; }
                set { unstucturedTelecoms = value; }
            }

                    
        private StructuredTelecomsCluster structuredTelecoms;
                
        [Cluster("/items", "at0003", "Structured telecoms")]                
        public StructuredTelecomsCluster StructuredTelecoms            
        {
            get
            {
                if(structuredTelecoms == null)
                    StructuredTelecoms = new StructuredTelecomsCluster();
                return structuredTelecoms; 
            }
            set 
            {
                structuredTelecoms = value;
                base.SetChildNode(value, "at0003");
            }
        }

        public partial class  StructuredTelecomsCluster : LocatableBase, ICluster
        {
                        private DvText countryCode;
        
            [Element("/items", "at0005", "Country code")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText CountryCode            
            {
                get { return countryCode; }
                set { countryCode = value; }
            }

            private DvText areaCode;
        
            [Element("/items", "at0006", "Area code")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText AreaCode            
            {
                get { return areaCode; }
                set { areaCode = value; }
            }

            private DvText number;
        
            [Element("/items", "at0007", "Number")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText Number            
            {
                get { return number; }
                set { number = value; }
            }

            private DvText extension;
        
            [Element("/items", "at0019", "Extension")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText Extension            
            {
                get { return extension; }
                set { extension = value; }
            }

             
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        }
        #endregion
    
        
        }
         
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        				
            Dictionary<string, string> telecomsTypeMap = new Dictionary<string, string>();
        	telecomsTypeMap.Add("at0013", "Telephone");
            telecomsTypeMap.Add("at0014", "Fax");
            telecomsTypeMap.Add("at0015", "Mobile phone");
            telecomsTypeMap.Add("at0016", "Pager");
            objectConstraints.Add("TelecomsTypeMap", telecomsTypeMap);
            
            List<DvCodedText> telecomsType = new List<DvCodedText>();
            telecomsType.Add(OpenEhrFactory.DvCodedText("Telephone", "at0013", "local"));
            telecomsType.Add(OpenEhrFactory.DvCodedText("Fax", "at0014", "local"));
            telecomsType.Add(OpenEhrFactory.DvCodedText("Mobile phone", "at0015", "local"));
            telecomsType.Add(OpenEhrFactory.DvCodedText("Pager", "at0016", "local"));
            objectConstraints.Add("TelecomsType", telecomsType);
        }
        #endregion
    
        
        }
                
            private List<DvText> emailAddress;
        
            [Element("/items", "at0009", "Email address")]
            [AttributeConstraint("value", "DV_TEXT")]            
            public List<DvText> EmailAddress            
            {
                get { return emailAddress; }
                set { emailAddress = value; }
            }

             
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        				
            Dictionary<string, string> modeMap = new Dictionary<string, string>();
        	modeMap.Add("at0011", "Home");
            modeMap.Add("at0012", "Work");
            modeMap.Add("at0018", "Contact");
            objectConstraints.Add("ModeMap", modeMap);
            
            List<DvCodedText> mode = new List<DvCodedText>();
            mode.Add(OpenEhrFactory.DvCodedText("Home", "at0011", "local"));
            mode.Add(OpenEhrFactory.DvCodedText("Work", "at0012", "local"));
            mode.Add(OpenEhrFactory.DvCodedText("Contact", "at0018", "local"));
            objectConstraints.Add("Mode", mode);
        }
        #endregion
            
        }        
                
        private LocatableList<ContactPersonDetailsCluster> contactPersonDetails;
        
        [Cluster("/items", "at0005", "Contact Person Details")]
        public LocatableList<ContactPersonDetailsCluster> ContactPersonDetails            
        {
            get
            {
                return contactPersonDetails; 
            }
            set 
            {
                contactPersonDetails = value;
                base.SetChildNode(value, "at0005");
            }
        }

        public partial class  ContactPersonDetailsCluster : LocatableBase, ICluster
        {
                                
                private LocatableList<PersonNameCluster> personName;
                
        [Cluster("/items")]
                
        public LocatableList<PersonNameCluster> PersonName            
        {
            get { return personName; }
            set  { personName = value; }
        }
        
    	
        [Archetype("openEHR-EHR-CLUSTER.person_name.v1", "Person name")]                
        public partial  class  PersonNameCluster : LocatableBase, ICluster
        {     private DvCodedText nameType;
        
            [Element("/items", "at0006", "Name type")]
            [AttributeConstraint("value", "DV_CODED_TEXT")]
            public DvCodedText NameType            
            {
                get { return nameType; }
                set { nameType = value; }
            }

            private DvBoolean preferredName;
        
            [Element("/items", "at0022", "Preferred name")]
            [AttributeConstraint("value", "DV_BOOLEAN")]
            public DvBoolean PreferredName            
            {
                get { return preferredName; }
                set { preferredName = value; }
            }

            private DvText unstructuredName;
        
            [Element("/items", "at0001", "Unstructured name")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText UnstructuredName            
            {
                get { return unstructuredName; }
                set { unstructuredName = value; }
            }

                    
        private StructuredNameCluster structuredName;
                
        [Cluster("/items", "at0002", "Structured name")]                
        public StructuredNameCluster StructuredName            
        {
            get
            {
                if(structuredName == null)
                    StructuredName = new StructuredNameCluster();
                return structuredName; 
            }
            set 
            {
                structuredName = value;
                base.SetChildNode(value, "at0002");
            }
        }

        public partial class  StructuredNameCluster : LocatableBase, ICluster
        {
                        private DvText title;
        
            [Element("/items", "at0017", "Title")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText Title            
            {
                get { return title; }
                set { title = value; }
            }

            private DvText givenName;
        
            [Element("/items", "at0003", "Given name")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText GivenName            
            {
                get { return givenName; }
                set { givenName = value; }
            }

                    
            private List<DvCodedText> middleName;
        
            [Element("/items", "at0004", "Middle name")]
            [AttributeConstraint("value", "DV_CODED_TEXT")]            
            public List<DvCodedText> MiddleName            
            {
                get { return middleName; }
                set { middleName = value; }
            }

            private DvText familyName;
        
            [Element("/items", "at0005", "Family name")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText FamilyName            
            {
                get { return familyName; }
                set { familyName = value; }
            }

            private DvText suffix;
        
            [Element("/items", "at0018", "Suffix")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText Suffix            
            {
                get { return suffix; }
                set { suffix = value; }
            }

             
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        				
            Dictionary<string, string> middleNameMap = new Dictionary<string, string>();
        	objectConstraints.Add("MiddleNameMap", middleNameMap);
            
            List<DvCodedText> middleName = new List<DvCodedText>();
            objectConstraints.Add("MiddleName", middleName);
        }
        #endregion
    
        
        }
        private DvInterval<DvDateTime> validityPeriod;
        
            [Element("/items", "at0014", "Validity period")]
            [AttributeConstraint("value", "DV_INTERVAL<DV_DATE_TIME>")]
            public DvInterval<DvDateTime> ValidityPeriod            
            {
                get { return validityPeriod; }
                set { validityPeriod = value; }
            }

             
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        				
            Dictionary<string, string> nameTypeMap = new Dictionary<string, string>();
        	nameTypeMap.Add("at0020", "Registered name");
            nameTypeMap.Add("at0008", "Previous name");
            nameTypeMap.Add("at0009", "Birth name");
            nameTypeMap.Add("at0010", "AKA");
            nameTypeMap.Add("at0011", "Alias");
            nameTypeMap.Add("at0012", "Maiden name");
            nameTypeMap.Add("at0019", "Professional name");
            nameTypeMap.Add("at0021", "Reporting name");
            objectConstraints.Add("NameTypeMap", nameTypeMap);
            
            List<DvCodedText> nameType = new List<DvCodedText>();
            nameType.Add(OpenEhrFactory.DvCodedText("Registered name", "at0020", "local"));
            nameType.Add(OpenEhrFactory.DvCodedText("Previous name", "at0008", "local"));
            nameType.Add(OpenEhrFactory.DvCodedText("Birth name", "at0009", "local"));
            nameType.Add(OpenEhrFactory.DvCodedText("AKA", "at0010", "local"));
            nameType.Add(OpenEhrFactory.DvCodedText("Alias", "at0011", "local"));
            nameType.Add(OpenEhrFactory.DvCodedText("Maiden name", "at0012", "local"));
            nameType.Add(OpenEhrFactory.DvCodedText("Professional name", "at0019", "local"));
            nameType.Add(OpenEhrFactory.DvCodedText("Reporting name", "at0021", "local"));
            objectConstraints.Add("NameType", nameType);
        }
        #endregion
            
        }        
        private DvText roleInOrganisation;
        
            [Element("/items", "at0007", "Role in organisation")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText RoleInOrganisation            
            {
                get { return roleInOrganisation; }
                set { roleInOrganisation = value; }
            }

             
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        }
        #endregion
    
        
        }
         
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        }
        #endregion
            
        }        
        private DvText laboratoryTestResultIdentifier;
        
            [Element("/protocol/items", "at0068", "Laboratory test result identifier")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText LaboratoryTestResultIdentifier            
            {
                get { return laboratoryTestResultIdentifier; }
                set { laboratoryTestResultIdentifier = value; }
            }

            private DvDateTime datetimeResultIssued;
        
            [Element("/protocol/items", "at0075", "Datetime result issued")]
            [AttributeConstraint("value", "DV_DATE_TIME")]
            public DvDateTime DatetimeResultIssued            
            {
                get { return datetimeResultIssued; }
                set { datetimeResultIssued = value; }
            }

             
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        }
        #endregion
            
        }
                
        private GeneExpressionLabSpecificationsObservation geneExpressionLabSpecifications;
                
        [Observation("/content")]
        [TextAttribute("name", "Gene Expression Lab Specifications")]                     
                                
        public GeneExpressionLabSpecificationsObservation GeneExpressionLabSpecifications   
        {
            get { return geneExpressionLabSpecifications; }
            set { geneExpressionLabSpecifications = value; }
        }
        
    	
        [Archetype("openEHR-EHR-OBSERVATION.gelab.v1", "Gelab")]        
        public partial class  GeneExpressionLabSpecificationsObservation : CareEntryBase, IObservation
        {
                    
                private AnyEventEvent anyEvent;
                
                [Event("/data/events", "at0002", "Any event")]                
                public AnyEventEvent AnyEvent            
        {
        get { return anyEvent; }
        set 
        {
        anyEvent = value;
        base.SetChildNode(value, "at0002");
        }
        }
        
        public partial class  AnyEventEvent : EventBase
        {
                    
        private ExtendedGeneExpressionTestSpecificationsCluster extendedGeneExpressionTestSpecifications;
                
        [Cluster("/data/items", "at0004", "Extended Gene Expression Test Specifications")]                
        public ExtendedGeneExpressionTestSpecificationsCluster ExtendedGeneExpressionTestSpecifications            
        {
            get
            {
                if(extendedGeneExpressionTestSpecifications == null)
                    ExtendedGeneExpressionTestSpecifications = new ExtendedGeneExpressionTestSpecificationsCluster();
                return extendedGeneExpressionTestSpecifications; 
            }
            set 
            {
                extendedGeneExpressionTestSpecifications = value;
                base.SetChildNode(value, "at0004");
            }
        }

        public partial class  ExtendedGeneExpressionTestSpecificationsCluster : LocatableBase, ICluster
        {
                                
        private PlatformCluster platform;
                
        [Cluster("/items", "at0007", "Platform")]                
        public PlatformCluster Platform            
        {
            get
            {
                if(platform == null)
                    Platform = new PlatformCluster();
                return platform; 
            }
            set 
            {
                platform = value;
                base.SetChildNode(value, "at0007");
            }
        }

        public partial class  PlatformCluster : LocatableBase, ICluster
        {
                        private DvText platformName;
        
            [Element("/items", "at0015", "Platform Name")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText PlatformName            
            {
                get { return platformName; }
                set { platformName = value; }
            }

            private DvText platformVersion;
        
            [Element("/items", "at0016", "Platform Version")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText PlatformVersion            
            {
                get { return platformVersion; }
                set { platformVersion = value; }
            }

            private DvText sequencingLocation;
        
            [Element("/items", "at0017", "Sequencing Location")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText SequencingLocation            
            {
                get { return sequencingLocation; }
                set { sequencingLocation = value; }
            }

             
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        }
        #endregion
    
        
        }
                
        private AnalysisCluster analysis;
                
        [Cluster("/items", "at0008", "Analysis")]                
        public AnalysisCluster Analysis            
        {
            get
            {
                if(analysis == null)
                    Analysis = new AnalysisCluster();
                return analysis; 
            }
            set 
            {
                analysis = value;
                base.SetChildNode(value, "at0008");
            }
        }

        public partial class  AnalysisCluster : LocatableBase, ICluster
        {
                        private DvCodedText analysisType;
        
            [Element("/items", "at0050", "Analysis Type")]
            [AttributeConstraint("value", "DV_CODED_TEXT")]
            public DvCodedText AnalysisType            
            {
                get { return analysisType; }
                set { analysisType = value; }
            }

            private DvUri rawDataReferece;
        
            [Element("/items", "at0049", "Raw Data Referece")]
            [AttributeConstraint("value", "DV_URI")]
            public DvUri RawDataReferece            
            {
                get { return rawDataReferece; }
                set { rawDataReferece = value; }
            }

                    
        private ReferenceGenomeCluster referenceGenome;
                
        [Cluster("/items", "at0020", "Reference Genome")]                
        public ReferenceGenomeCluster ReferenceGenome            
        {
            get
            {
                if(referenceGenome == null)
                    ReferenceGenome = new ReferenceGenomeCluster();
                return referenceGenome; 
            }
            set 
            {
                referenceGenome = value;
                base.SetChildNode(value, "at0020");
            }
        }

        public partial class  ReferenceGenomeCluster : LocatableBase, ICluster
        {
                        private DvText genomeName;
        
            [Element("/items", "at0026", "Genome Name")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText GenomeName            
            {
                get { return genomeName; }
                set { genomeName = value; }
            }

            private DvText genomeVersion;
        
            [Element("/items", "at0027", "Genome Version")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText GenomeVersion            
            {
                get { return genomeVersion; }
                set { genomeVersion = value; }
            }

            private DvText geneAnnotationName;
        
            [Element("/items", "at0025", "Gene Annotation Name")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText GeneAnnotationName            
            {
                get { return geneAnnotationName; }
                set { geneAnnotationName = value; }
            }

            private DvText geneAnnotationVersion;
        
            [Element("/items", "at0024", "Gene Annotation Version")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText GeneAnnotationVersion            
            {
                get { return geneAnnotationVersion; }
                set { geneAnnotationVersion = value; }
            }

             
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        }
        #endregion
    
        
        }
                
        private AnalysismethodCluster analysismethod;
                
        [Cluster("/items", "at0019", "AnalysisMethod")]                
        public AnalysismethodCluster Analysismethod            
        {
            get
            {
                if(analysismethod == null)
                    Analysismethod = new AnalysismethodCluster();
                return analysismethod; 
            }
            set 
            {
                analysismethod = value;
                base.SetChildNode(value, "at0019");
            }
        }

        public partial class  AnalysismethodCluster : LocatableBase, ICluster
        {
                                
        private AnalysisPipelineCluster analysisPipeline;
                
        [Cluster("/items", "at0045", "Analysis Pipeline")]                
        public AnalysisPipelineCluster AnalysisPipeline            
        {
            get
            {
                if(analysisPipeline == null)
                    AnalysisPipeline = new AnalysisPipelineCluster();
                return analysisPipeline; 
            }
            set 
            {
                analysisPipeline = value;
                base.SetChildNode(value, "at0045");
            }
        }

        public partial class  AnalysisPipelineCluster : LocatableBase, ICluster
        {
                        private DvText name;
        
            [Element("/items", "at0046", "Name")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText AnalysisPipelineClusterName            
            {
                get { return name; }
                set { name = value; }
            }

            private DvText version;
        
            [Element("/items", "at0047", "Version")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText Version            
            {
                get { return version; }
                set { version = value; }
            }

             
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        }
        #endregion
    
        
        }
                
        private LocatableList<AnalysisToolsCluster> analysisTools;
        
        [Cluster("/items", "at0028", "Analysis Tools")]
        public LocatableList<AnalysisToolsCluster> AnalysisTools            
        {
            get
            {
                return analysisTools; 
            }
            set 
            {
                analysisTools = value;
                base.SetChildNode(value, "at0028");
            }
        }

        public partial class  AnalysisToolsCluster : LocatableBase, ICluster
        {
                        private DvText toolName;
        
            [Element("/items", "at0029", "Tool Name")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText ToolName            
            {
                get { return toolName; }
                set { toolName = value; }
            }

            private DvText toolVersion;
        
            [Element("/items", "at0030", "Tool Version")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText ToolVersion            
            {
                get { return toolVersion; }
                set { toolVersion = value; }
            }

             
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        }
        #endregion
    
        
        }
         
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        }
        #endregion
    
        
        }
         
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        				
            Dictionary<string, string> analysisTypeMap = new Dictionary<string, string>();
        	analysisTypeMap.Add("at0051", "Absolute");
            analysisTypeMap.Add("at0052", "Differential");
            objectConstraints.Add("AnalysisTypeMap", analysisTypeMap);
            
            List<DvCodedText> analysisType = new List<DvCodedText>();
            analysisType.Add(OpenEhrFactory.DvCodedText("Absolute", "at0051", "local"));
            analysisType.Add(OpenEhrFactory.DvCodedText("Differential", "at0052", "local"));
            objectConstraints.Add("AnalysisType", analysisType);
        }
        #endregion
    
        
        }
                
        private ResultsCluster results;
                
        [Cluster("/items", "at0005", "Results")]                
        public ResultsCluster Results            
        {
            get
            {
                if(results == null)
                    Results = new ResultsCluster();
                return results; 
            }
            set 
            {
                results = value;
                base.SetChildNode(value, "at0005");
            }
        }

        public partial class  ResultsCluster : LocatableBase, ICluster
        {
                        private DvCount numberOfReportedGenes;
        
            [Element("/items", "at0043", "Number of Genes")]
            [AttributeConstraint("value", "DV_COUNT")]
            [TextAttribute("name", "Number of Reported Genes")]
            
            public DvCount NumberOfReportedGenes            
            {
                get { return numberOfReportedGenes; }
                set { numberOfReportedGenes = value; }
            }

                    
        private LocatableList<GenesCluster> genes;
        
        [Cluster("/items", "at0031", "Genes")]
        public LocatableList<GenesCluster> Genes            
        {
            get
            {
                return genes; 
            }
            set 
            {
                genes = value;
                base.SetChildNode(value, "at0031");
            }
        }

        public partial class  GenesCluster : LocatableBase, ICluster
        {
                                
        private GeneIdCluster geneId;
                
        [Cluster("/items", "at0034", "Gene ID")]                
        public GeneIdCluster GeneId            
        {
            get
            {
                if(geneId == null)
                    GeneId = new GeneIdCluster();
                return geneId; 
            }
            set 
            {
                geneId = value;
                base.SetChildNode(value, "at0034");
            }
        }

        public partial class  GeneIdCluster : LocatableBase, ICluster
        {
                        private DvIdentifier hgncSymbol;
        
            [Element("/items", "at0036", "HGNC Symbol")]
            [AttributeConstraint("value", "DV_IDENTIFIER")]
            public DvIdentifier HgncSymbol            
            {
                get { return hgncSymbol; }
                set { hgncSymbol = value; }
            }

            private DvIdentifier hgncId;
        
            [Element("/items", "at0038", "HGNC ID")]
            [AttributeConstraint("value", "DV_IDENTIFIER")]
            public DvIdentifier HgncId            
            {
                get { return hgncId; }
                set { hgncId = value; }
            }

            private DvIdentifier entrezId;
        
            [Element("/items", "at0039", "ENTREZ ID")]
            [AttributeConstraint("value", "DV_IDENTIFIER")]
            public DvIdentifier EntrezId            
            {
                get { return entrezId; }
                set { entrezId = value; }
            }

            private DvIdentifier ensemblId;
        
            [Element("/items", "at0040", "ENSEMBL ID")]
            [AttributeConstraint("value", "DV_IDENTIFIER")]
            public DvIdentifier EnsemblId            
            {
                get { return ensemblId; }
                set { ensemblId = value; }
            }

             
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        }
        #endregion
    
        
        }
                
        private NormalizedExpressionCluster normalizedExpression;
                
        [Cluster("/items", "at0035", "Normalized Expression")]                
        public NormalizedExpressionCluster NormalizedExpression            
        {
            get
            {
                if(normalizedExpression == null)
                    NormalizedExpression = new NormalizedExpressionCluster();
                return normalizedExpression; 
            }
            set 
            {
                normalizedExpression = value;
                base.SetChildNode(value, "at0035");
            }
        }

        public partial class  NormalizedExpressionCluster : LocatableBase, ICluster
        {
                        private DvQuantity value;
        
            [Element("/items", "at0041", "Value")]
            [AttributeConstraint("value", "DV_QUANTITY")]
            public DvQuantity Value            
            {
                get { return value; }
                set { value = value; }
            }

            private DvCount logBase;
        
            [Element("/items", "at0042", "Log Base")]
            [AttributeConstraint("value", "DV_COUNT")]
            public DvCount LogBase            
            {
                get { return logBase; }
                set { logBase = value; }
            }

             
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        }
        #endregion
    
        
        }
         
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        }
        #endregion
    
        
        }
         
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        }
        #endregion
    
        
        }
        private DvText notes;
        
            [Element("/items", "at0009", "Notes")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText Notes            
            {
                get { return notes; }
                set { notes = value; }
            }

             
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        }
        #endregion
    
        
        }
         
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        }
        #endregion
    
        
        }
        
         
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        }
        #endregion
            
        }
                
        private LocatableList<ProblemdiagnosisEvaluation> problemdiagnosis;
                
        [Evaluation("/content")]
        public LocatableList<ProblemdiagnosisEvaluation> Problemdiagnosis   
        {
            get { return problemdiagnosis; }
            set { problemdiagnosis = value; }
        }
            
    	
        [Archetype("openEHR-EHR-EVALUATION.problem_diagnosis.v1", "Problem/Diagnosis")]        
        public partial class  ProblemdiagnosisEvaluation : CareEntryBase, IEvaluation
        {                private DvText problemdiagnosis;
        
            [Element("/data/items", "at0002", "Problem/Diagnosis")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText Problemdiagnosis            
            {
                get { return problemdiagnosis; }
                set { problemdiagnosis = value; }
            }

            private DvText description;
        
            [Element("/data/items", "at0009", "Description")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText Description            
            {
                get { return description; }
                set { description = value; }
            }

            private DvCodedText severity;
        
            [Element("/data/items", "at0005", "Severity")]
            [AttributeConstraint("value", "DV_CODED_TEXT")]
            public DvCodedText Severity            
            {
                get { return severity; }
                set { severity = value; }
            }

            private DvDateTime dateOfOnset;
        
            [Element("/data/items", "at0003", "Date of Onset")]
            [AttributeConstraint("value", "DV_DATE_TIME")]
            public DvDateTime DateOfOnset            
            {
                get { return dateOfOnset; }
                set { dateOfOnset = value; }
            }

            private DvDuration ageAtOnset;
        
            [Element("/data/items", "at0004", "Age at Onset")]
            [AttributeConstraint("value", "DV_DURATION")]
            public DvDuration AgeAtOnset            
            {
                get { return ageAtOnset; }
                set { ageAtOnset = value; }
            }

            private DvText bodySite;
        
            [Element("/data/items", "at0012", "Body Site")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText BodySite            
            {
                get { return bodySite; }
                set { bodySite = value; }
            }

                    
        private PreviousOccurrencesCluster previousOccurrences;
                
        [Cluster("/data/items", "at0018", "Previous Occurrences")]                
        public PreviousOccurrencesCluster PreviousOccurrences            
        {
            get
            {
                if(previousOccurrences == null)
                    PreviousOccurrences = new PreviousOccurrencesCluster();
                return previousOccurrences; 
            }
            set 
            {
                previousOccurrences = value;
                base.SetChildNode(value, "at0018");
            }
        }

        public partial class  PreviousOccurrencesCluster : LocatableBase, ICluster
        {
                        private DvQuantity frequency;
        
            [Element("/items", "at0019", "Frequency")]
            [AttributeConstraint("value", "DV_QUANTITY")]
            public DvQuantity Frequency            
            {
                get { return frequency; }
                set { frequency = value; }
            }

            private DvDateTime dateOfLastOccurrence;
        
            [Element("/items", "at0020", "Date of last Occurrence")]
            [AttributeConstraint("value", "DV_DATE_TIME")]
            public DvDateTime DateOfLastOccurrence            
            {
                get { return dateOfLastOccurrence; }
                set { dateOfLastOccurrence = value; }
            }

            private DvCount number;
        
            [Element("/items", "at0025", "Number")]
            [AttributeConstraint("value", "DV_COUNT")]
            public DvCount Number            
            {
                get { return number; }
                set { number = value; }
            }

            private DvText description;
        
            [Element("/items", "at0022", "Description")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText Description            
            {
                get { return description; }
                set { description = value; }
            }

             
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        }
        #endregion
    
        
        }
                
        private LocatableList<RelatedItemCluster> relatedItem;
        
        [Cluster("/data/items", "at0027", "Related Item")]
        public LocatableList<RelatedItemCluster> RelatedItem            
        {
            get
            {
                return relatedItem; 
            }
            set 
            {
                relatedItem = value;
                base.SetChildNode(value, "at0027");
            }
        }

        public partial class  RelatedItemCluster : LocatableBase, ICluster
        {
                        private DvCodedText relationshipType;
        
            [Element("/items", "at0029", "Relationship Type")]
            [AttributeConstraint("value", "DV_CODED_TEXT")]
            public DvCodedText RelationshipType            
            {
                get { return relationshipType; }
                set { relationshipType = value; }
            }

            private DataValue item;
        
            [Element("/items", "at0028", "Item")]
            [AttributeConstraint("value", "DV_TEXT")]
            [AttributeConstraint("value", "DV_URI")]
            public DataValue Item            
            {
                get { return item; }
                set { item = value; }
            }

            private DvText description;
        
            [Element("/items", "at0044", "Description")]
            [AttributeConstraint("value", "DV_TEXT")]
            public DvText Description            
            {
                get { return description; }
                set { description = value; }
            }

             
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        				
            Dictionary<string, string> relationshipTypeMap = new Dictionary<string, string>();
        	relationshipTypeMap.Add("at0040", "Caused by");
            relationshipTypeMap.Add("at0041", "Following");
            objectConstraints.Add("RelationshipTypeMap", relationshipTypeMap);
            
            List<DvCodedText> relationshipType = new List<DvCodedText>();
            relationshipType.Add(OpenEhrFactory.DvCodedText("Caused by", "at0040", "local"));
            relationshipType.Add(OpenEhrFactory.DvCodedText("Following", "at0041", "local"));
            objectConstraints.Add("RelationshipType", relationshipType);
        }
        #endregion
    
        
        }
        private DvDate dateOfResolution;
        
            [Element("/data/items", "at0030", "Date of Resolution")]
            [AttributeConstraint("value", "DV_DATE")]
            public DvDate DateOfResolution            
            {
                get { return dateOfResolution; }
                set { dateOfResolution = value; }
            }

            private DvDuration ageAtResolution;
        
            [Element("/data/items", "at0031", "Age at Resolution")]
            [AttributeConstraint("value", "DV_DURATION")]
            public DvDuration AgeAtResolution            
            {
                get { return ageAtResolution; }
                set { ageAtResolution = value; }
            }

                    
            private List<DvEhrUri> supportingClinicalEvidence;
        
            [Element("/protocol/items", "at0035", "Supporting clinical evidence")]
            [AttributeConstraint("value", "DV_EHR_URI")]            
            public List<DvEhrUri> SupportingClinicalEvidence            
            {
                get { return supportingClinicalEvidence; }
                set { supportingClinicalEvidence = value; }
            }

             
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        				
            Dictionary<string, string> severityMap = new Dictionary<string, string>();
        	objectConstraints.Add("SeverityMap", severityMap);
            
            List<DvCodedText> severity = new List<DvCodedText>();
            objectConstraints.Add("Severity", severity);
        }
        #endregion
    
        }
                
        private LocatableList<ReasonForEncounterEvaluation> reasonForEncounter;
                
        [Evaluation("/content")]
        public LocatableList<ReasonForEncounterEvaluation> ReasonForEncounter   
        {
            get { return reasonForEncounter; }
            set { reasonForEncounter = value; }
        }
            
    	
        [Archetype("openEHR-EHR-EVALUATION.reason_for_encounter.v1", "Reason for Encounter")]        
        public partial class  ReasonForEncounterEvaluation : CareEntryBase, IEvaluation
        {                        
            private List<DvText> presentingProblem;
        
            [Element("/data/items", "at0004", "Presenting Problem")]
            [AttributeConstraint("value", "DV_TEXT")]            
            public List<DvText> PresentingProblem            
            {
                get { return presentingProblem; }
                set { presentingProblem = value; }
            }

             
        
        #region Object Constraints
        
        private static Dictionary<string, object> objectConstraints;
        
        public static Dictionary<string, object> ObjectConstraints
        {
            get 
            {
                if (objectConstraints == null)
                {
                    objectConstraints = new Dictionary<string, object>();
                    InitialiseConstraints();
                }
                return objectConstraints;
            }
        }
        
        private static void InitialiseConstraints()
        {
            if (objectConstraints == null)
                throw new InvalidOperationException("objectConstraints not initialised");
        }
        #endregion
    
        }
           

}
    
}           

    