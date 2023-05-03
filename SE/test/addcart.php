<?php
session_start();
include('connect.php');
    //them sl
    //tru sl
    //xoa sp
    //them sp

    if(isset($_POST['addcart']))
    
    {
        // session_destroy();
        $id=$_GET['idItem'];
        $number = 1;
        $sql = "SELECT *from item WHERE idItem='".$id."' LIMIT 1";
        $query = mysqli_query($conn,$sql);
        $row = mysqli_fetch_array($query);
        if($row) {
            $new_product=array(array('nameItem'=>$row['nameItem'], 'id'=>$id,'numberItem'=>$number,'priceItem'=>$row['priceItem'], 'image'=>$row['image']));
            if(isset($_SESSION['cart'])) {
                $found = false;
                foreach($_SESSION['cart'] as $cart_item){
                    if($cart_item['id']==$id){
                        $product[] = array(
                            'nameItem'=> $cart_item['nameItem'], 
                            'id'=>$cart_item['id'], 
                            'numberItem'=> $cart_item['number'], 
                            'priceItem'=> $cart_item['priceItem'], 
                            'image'=>$cart_item['image']
                        );
                        $found = true;
                    }else{
                        $product[] = array(
                            'nameItem'=> $cart_item['nameItem'], 
                            'id'=>$cart_item['id'], 
                            'numberItem'=> $cart_item['number'], 
                            'priceItem'=> $cart_item['priceItem'], 
                            'image'=>$cart_item['image']
                        );                 
                    }
                }
                if($found == false) {
                    $_SESSION['cart'] = array_merge($product,$new_product);
                }
                else{
                    $_SESSION['cart'] = $new_product;
                }
            }
            else{
                $_SESSION['cart'] = $new_product;
            }
        }
        header('Location: cart.php');
    }
?>