public class Customer {

    private string name;
    private bool member = false;
    private string memberType;

    public Customer(string name, bool member, string memberType) {
        this.name = name;
        this.member = member;
        this.memberType = memberType;
    }

    public string getName() {
        return name;
    }

    public bool isMember() {
        return member;
    }

    public string getMemberType() {
        return memberType;
    }

    public void setMemberType(string memberType) {
        this.memberType = memberType;
    }

    public string toString() {
        return "Customer{" + "name='" + name + '\'' + ", member=" + member +", memberType='" + memberType + '\'' +'}';
    }
}