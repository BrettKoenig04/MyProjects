<?php
    $message_sent = false;
    if (isset($_POST['submit']) && $_POST['submit'] != '') {

        if (filter_Var($_POST['submit'], FILTER_VALIDATE_EMAIL)){
            
            // Submit the form
            $name = $_POST['name'];
            $subject = $_POST['subject'];
            $mailFrom = $_POST['mail'];
            $message = $_POST['message'];

            $mailTo = "";
            $headers = "From: ".$mailFrom;
            $txt = "You have recieved an e-mail from ".$name.".\n\n".$message;

            mail($mailTo, $subject, $txt, $headers);
            header("Location: index.php?mailsend");

            $message_sent = true;
        }
    }
?>