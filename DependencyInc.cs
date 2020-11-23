using System.IO;
using System;
using System.Collections.Generic;

/*public class Email {

  public void sendEmail() {
   //Send emeail
  }
}
public class SMS {
  public void sendSMS() {
  //Send sms
  }
}
public class Notification {

  private Email email = new Email();
  private SMS sms = new SMS();

  public void sender() {

    email.sendEmail();
    sms.sendSMS();
  }

}*/

public interface Message {
  void sendMessage();
}
public class Email : Message {

  //@Override
  public void sendMessage() {
    sendEmail();
  }

   private void sendEmail() {
   //Send email
   }
}
public class SMS : Message {

  //@Override
  public void sendMessage() {
   sendSMS();
  }

  private void sendSMS() {
  //Send sms
  }
}
//Dependency injection

public class Notification 
{

  private List<Message> messages;

  public Notification(List<Message> messages) {
   this.messages = messages;
  }

  public void sender() 
  {
   foreach (Message message in messages) 
   {
     message.sendMessage();
   }
  }
 
}

