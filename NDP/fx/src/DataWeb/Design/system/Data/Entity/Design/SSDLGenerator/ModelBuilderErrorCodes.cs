//---------------------------------------------------------------------
// <copyright file="ModelBuilderErrorCode.cs" company="Microsoft">
//      Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
//
// @owner       [....]
// @backupOwner [....]
//---------------------------------------------------------------------

namespace System.Data.Services.Design
{
    internal enum ModelBuilderErrorCode
    {
        BaseValue = 6000,

        /// <summary>
        /// was unable to find an entity container that 
        /// the the type should go into
        /// </summary>
        RelationshipSpansSchemas = BaseValue + 1,

        /// <summary>
        /// No primary key is defined for the table
        /// </summary>
        NoPrimaryKeyDefined = BaseValue + 2,
        
        /// <summary>
        /// Unknown error
        /// </summary>
        UnknownError = BaseValue + 3,

        /// <summary>
        /// The entity referenced by the relationship was
        /// not found in database
        /// </summary>
        MissingEntity = BaseValue + 4,
        /// <summary>
        /// The entity referenced by the relationship was
        /// not found in database
        /// </summary>
        UnsupportedType = BaseValue + 5,
        /// <summary>
        /// The value given for the facet does not 
        /// fit in the range given by the facet description
        /// </summary>
        FacetValueOutOfRange = BaseValue + 6,
        /// <summary>
        /// The association must be skipped because a neede key column
        /// is missing
        /// </summary>
        AssociationMissingKeyColumn = BaseValue + 7,
                /// <summary>
        /// PrimaryKey of a table cannot be the foreignKey in a relationship
        /// </summary>
        PrimaryKeyCannotBeForeignKey = BaseValue + 8,
        /// <summary>
        /// Found an usupported one to one association
        /// </summary>
        OneToOneAssociationFound = BaseValue + 9,
        /// <summary>
        /// The ClientAutoGenerated facet can only be set true on properties of type int16, int32, or in64.
        /// All other types that have the ServerGeneratedPattern on the store property will not 
        /// get the ClientAutoGenerated facet set.
        /// </summary>
        ClientAutoGenNotAllowed = BaseValue + 10,
        /// <summary>
        /// concepts that model generator can't handle
        /// </summary>
        UnsupportedModelGenerationConcept = BaseValue + 11,
        /// <summary>A value other than IN, OUT, or INOUT was given</summary>
        ParameterDirectionNotValid = BaseValue + 12,
        /// <summary>
        /// Cannot create entity type without keys. The system tried to infer a candidate key from the existing columns 
        /// and create a read-only view but there are no combination of existing columns that could be used to make 
        /// a candidate key. 
        /// </summary>
        CannotCreateEntityWithoutPrimaryKey = BaseValue + 13,
        /// <summary>No types were available to determine the namespace from</summary>
        CodeGenNamespaceCannotBeDetermined = BaseValue + 14,
        /// <summary>There is a problem with the sourceFilePath provided to codegen</summary>
        CodeGenSourceFilePathIsInvalid = BaseValue + 15,
        /// <summary>There is a problem with the sourceFilePath provided to codegen</summary>
        CodeGenAdditionalEdmSchemaIsInvalid = BaseValue + 16,
        /// <summary>The navigation property created a generated property name that conflicts with a real property</summary>
        GeneratedNavigationPropertyNameConflict = BaseValue + 17,
        /// <summary>Invalid Attribute Supplied For Property</summary>
        InvalidAttributeSuppliedForProperty = BaseValue + 18,
        SecurityError = BaseValue + 19,
        FileNotFound = BaseValue + 20,
        DirectoryNotFound = BaseValue + 21,
        IOException = BaseValue + 22,
        IncompatibleSettingForCaseSensitiveOption = BaseValue + 23,
        InvalidAttributeSuppliedForType = BaseValue + 24,
        InvalidMemberSuppliedForType = BaseValue + 25,
        InvalidInterfaceSuppliedForType = BaseValue + 26,
        InvalidGetStatementSuppliedForProperty = BaseValue + 27,
        InvalidSetStatementSuppliedForProperty = BaseValue + 28,
        GeneratedFactoryMethodNameConflict = BaseValue + 29,
        UnsupportedForeinKeyPattern = BaseValue + 30,
        ExcludedColumnWasAKeyColumn = BaseValue + 31,
        InvalidKeyTypeFound = BaseValue + 32,
        GeneratedPropertyAccessibilityConflict = BaseValue + 33,
        DuplicateClassName = BaseValue + 34,
        UnsupportedDbRelationship = BaseValue + 35,
        EntityTypeAndSetAccessibilityConflict = BaseValue + 36
    }
}
