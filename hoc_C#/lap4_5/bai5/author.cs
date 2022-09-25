public class Author {
   private string name;
   private string email;
   private string gender;
 
   public Author(string name, string email, string gender) {
      this.name = name;
      this.email = email;
      this.gender = gender;
   }
 
   public string getName() {
      return name;
   }
   public string getGender() {
      return gender;
   }
   public string getEmail() {
      return email;
   }
   public void setEmail(string email) {
      this.email = email;
   }
 
   public string toString() {
      return name + " (" + gender + ") at " + email;
   }
}