This is a Windows Forms application used to view, edit, and delete client information stored in a Microsoft Access database (Clients.mdb). It uses typed datasets and data binding to connect UI controls to database tables. (CRUD implementation in C#)


Key Features and Behavior:
Data Loading on Startup
-On form load (Form1_Load method), it fetches data from two tables: tb_Client & tb_ClientType
-These are filled into a dataset (clientsDataSet) and bound to controls on the form.

Saving Changes
-The app includes a "Save" button (tb_ClientBindingNavigatorSaveItem_Click) that validates the form, ends the current edit operation, saves all changes from the dataset back to the database, and deletes a Client Record. A button named btn_del_Click handles record deletion.


Database Interaction
-Uses TableAdapters for CRUD operations.
-Primary tables:
  tb_Client: Holds client records (name, contact info, etc.).
  tb_ClientType: Stores different categories/types of clients.

was created for Fundamentals of Programming semester 1 in 2023-2024 academic year
