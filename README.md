# soap
There are 3 entity services in this architecture design studio project:
- materials service
- designs service
- inventory service

There are 3 utility services in this architecture design studio project:
- notification service
- patent sweep service
- report generation service

########################################################################

The service capabilities are as follows:

Materials service (Entity Service):

1. GetDeveloped Operation
Input: unique material identifier and
architect identifier
Output: developed material document

2. GetPurchased Operation
Input: unique material identifier
Output: purchased material document

3. ReportStockLevels Operation
Input: unique material identifier
Output: stock level value

*******************************************
Design service (Entity Service):

1. AddBase
Input: design document and architect
identifier
Output: acknowledgement code

2. Simulate
Input: materials and designs identifiers
required for this project plus an architect
identifier
Output: simulation report document

3. Get
Input: unique design identifier and
architect identifier
Output: design document

*******************************************

Inventory Service (Entity Service):

1.AddItem
Input: standard inventory item document
Output: acknowledgement code

2. GetItem
Input: unique inventory identifier
Output: standard inventory item document

3. GetItemCount
Input: unique inventory identifier
Output: stock level value

4. RemoveItems
Input: unique inventory identifier for each item
to be removed from inventory
Output: acknowledgment code

*******************************************

Notification Service (Utility Service):

1. GenerateNotification
Input: unique event identifier
Output: a notification specific to the event associated with the identifier received as input

*******************************************

Patent Sweep Service (Utility Service):

1. PerformPatentSweep
Input: Unique design identifier
Output: A report after each patent sweep, specifying the latest patent sweep status

*******************************************

Report Generation Service (Utility Service): 

1. GenerateReport 
Input: unique event identifier
Output: a report specific to the event associated with the identifier received as input

*******************************************

Run Design Studio Service (Task Service):
1. Start
Input: architect ID and unique design ID
Output: Acknowledgement code

*******************************************

Many task services can be formed through utilizing different combination of the above services, such as:

- Task Service Run Design Studio Project, utilizes the designs service. The design service utilizes the 
utility services (notification, patent sweep and report generation)

- Task Service Run Inventory Management, utilizes the inventory service. The inventory service utilizes the 
utility services (notification, patent sweep and report generation)

... and many more combinations can be performed.

I have implemented all of the above services in a contract-first approach. And then 
implemented the following scenario in the Run Design Studio Project:

The Run Design Studio Project, which is a task service, utilizes the designs service to add base designs. 
The design service utilizes the notification utility service, whenever a new base design is added.

********************************************

