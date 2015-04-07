# Transcriptomics_data_model
This repository includes an XSD model for representing transcriptomics data to retain interoperability and computable meaning and an XML instance of the transcriptomics de-identified data for a patient from The Cancer Genome Atlas (TCGA). The assumption behind the proposed model is that the model represents a transcriptomics result for one patient, one sample, is performed on one sequencing platform and analyzed by one analysis platform. However, variable number of genes reporting is accommodated.

# Description of the data files
* XSD files the proposed model in  XSD model schema.
	* geneExpressionTestSchema_V5.xsd is the original XSD schema showing the elements. A complete description of the elements can be found at Model_element_description
	* Gene Expression Lab Report_Template_V7.xsd is the schema for mapped openEHR templates
* XML files are the instances using the schema.
	* Sample GE XML_Small.xml: XML instance containing a subset of gene expression from the TCGA patient sample for validation against our XSD schema. 
	* Sample GE XML_Large.xml.: Gene expression instance containing entire data from the TCGA patient sample for validation against our XSD schema.


# How to run the models
* Clone this repository to your local drive
	* In terminal type: git clone https://github.com/mumtahena/Transcriptomics_data_model
	 or
	* You may use "Clone in Desktop" or "Download ZIP" buttons on the right side panel to download the repository.
* Use an XML editor such as oXygen to view and validate the XSD models and XML model instances

# Acknowledements
* Guilherme Del Fiol, MD, PhD
* Bret Heale, PhD
* Aly Khalifa
* Mumtahena Rahman, PharmD


# Contacts
For any questions, please email
Mumtahena Rahman [moom.rahman@utah.edu] 
