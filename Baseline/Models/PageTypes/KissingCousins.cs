﻿//--------------------------------------------------------------------------------------------------
// <auto-generated>
//
//     This code was generated by code generator tool.
//
//     To customize the code use your own partial class. For more info about how to use and customize
//     the generated code see the documentation at http://docs.kentico.com.
//
// </auto-generated>
//--------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

using CMS;
using CMS.Base;
using CMS.Helpers;
using CMS.DataEngine;
using CMS.DocumentEngine.Types.NEWCC;
using CMS.DocumentEngine;

[assembly: RegisterDocumentType(KissingCousins.CLASS_NAME, typeof(KissingCousins))]

namespace CMS.DocumentEngine.Types.NEWCC
{
    /// <summary>
    /// Represents a content item of type KissingCousins.
    /// </summary>
    public partial class KissingCousins : TreeNode
    {
        #region "Constants and variables"

        /// <summary>
        /// The name of the data class.
        /// </summary>
        public const string CLASS_NAME = "NEWCC.KissingCousins";


        /// <summary>
        /// The instance of the class that provides extended API for working with KissingCousins fields.
        /// </summary>
        private readonly KissingCousinsFields mFields;

        #endregion


        #region "Properties"

        /// <summary>
        /// KissingCousinsID.
        /// </summary>
        [DatabaseIDField]
        public int KissingCousinsID
        {
            get
            {
                return ValidationHelper.GetInteger(GetValue("KissingCousinsID"), 0);
            }
            set
            {
                SetValue("KissingCousinsID", value);
            }
        }


        /// <summary>
        /// Menu Name.
        /// </summary>
        [DatabaseField]
        public string MenuName
        {
            get
            {
                return ValidationHelper.GetString(GetValue("MenuName"), @"");
            }
            set
            {
                SetValue("MenuName", value);
            }
        }


        /// <summary>
        /// Meta Data.
        /// </summary>
        [DatabaseField]
        public string MetaData
        {
            get
            {
                return ValidationHelper.GetString(GetValue("MetaData"), @"");
            }
            set
            {
                SetValue("MetaData", value);
            }
        }


        /// <summary>
        /// Banners.
        /// </summary>
        [DatabaseField]
        public string Banners
        {
            get
            {
                return ValidationHelper.GetString(GetValue("Banners"), @"");
            }
            set
            {
                SetValue("Banners", value);
            }
        }


        /// <summary>
        /// Gets an object that provides extended API for working with KissingCousins fields.
        /// </summary>
        [RegisterProperty]
        public KissingCousinsFields Fields
        {
            get
            {
                return mFields;
            }
        }


        /// <summary>
        /// Provides extended API for working with KissingCousins fields.
        /// </summary>
        [RegisterAllProperties]
        public partial class KissingCousinsFields : AbstractHierarchicalObject<KissingCousinsFields>
        {
            /// <summary>
            /// The content item of type KissingCousins that is a target of the extended API.
            /// </summary>
            private readonly KissingCousins mInstance;


            /// <summary>
            /// Initializes a new instance of the <see cref="KissingCousinsFields" /> class with the specified content item of type KissingCousins.
            /// </summary>
            /// <param name="instance">The content item of type KissingCousins that is a target of the extended API.</param>
            public KissingCousinsFields(KissingCousins instance)
            {
                mInstance = instance;
            }


            /// <summary>
            /// KissingCousinsID.
            /// </summary>
            public int ID
            {
                get
                {
                    return mInstance.KissingCousinsID;
                }
                set
                {
                    mInstance.KissingCousinsID = value;
                }
            }


            /// <summary>
            /// Menu Name.
            /// </summary>
            public string MenuName
            {
                get
                {
                    return mInstance.MenuName;
                }
                set
                {
                    mInstance.MenuName = value;
                }
            }


            /// <summary>
            /// Meta Data.
            /// </summary>
            public string MetaData
            {
                get
                {
                    return mInstance.MetaData;
                }
                set
                {
                    mInstance.MetaData = value;
                }
            }


            /// <summary>
            /// Banners.
            /// </summary>
            public string Banners
            {
                get
                {
                    return mInstance.Banners;
                }
                set
                {
                    mInstance.Banners = value;
                }
            }
        }

        #endregion


        #region "Constructors"

        /// <summary>
        /// Initializes a new instance of the <see cref="KissingCousins" /> class.
        /// </summary>
        public KissingCousins() : base(CLASS_NAME)
        {
            mFields = new KissingCousinsFields(this);
        }

        #endregion
    }
}