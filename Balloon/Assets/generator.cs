using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using System.Threading;

public class generator : MonoBehaviour {
    //public static generator instance;
    public static int timer_i = 0;

    public static double square = 0;
    double std_dev;

    // Use this for initialization
    private GameObject temp_cube, temp_sphere, temp_red, temp_black, temp_third, temp_banana, temp_apple;
    public GameObject train_cube, train_sphere;
    public GameObject red, black, third;
    public GameObject banana, apple;
    double temp = 0;


    void Update () {

        // Press "T" to display cube training scene
        if (Input.GetKeyUp(KeyCode.T))
        {
            float x_train_cube = UnityEngine.Random.Range(0.4f, 0.4f);
            temp_cube = Instantiate(train_cube, new Vector3(x_train_cube, 1, -1.5f), Quaternion.identity);

            x_train_cube = UnityEngine.Random.Range(-0.2f, -0.2f);
            temp_cube = Instantiate(train_cube, new Vector3(x_train_cube, 1.5f, -1.5f), Quaternion.identity);

            x_train_cube = UnityEngine.Random.Range(0.2f, 0.2f);
            temp_cube = Instantiate(train_cube, new Vector3(x_train_cube, 1, -2.0f), Quaternion.identity);

            x_train_cube = UnityEngine.Random.Range(0.0f, 0.0f);
            temp_cube = Instantiate(train_cube, new Vector3(x_train_cube, 1, -1.0f), Quaternion.identity);

            x_train_cube = UnityEngine.Random.Range(0.8f, 0.8f);
            temp_cube = Instantiate(train_cube, new Vector3(x_train_cube, 2, -1.5f), Quaternion.identity);
        }

        // Press "Y" to display sphere training scene
        if (Input.GetKeyUp(KeyCode.Y))
        {
            float x_train_sphere = UnityEngine.Random.Range(0.5f, 0.5f);
            temp_cube = Instantiate(train_sphere, new Vector3(x_train_sphere, 2.3f, -1.5f), Quaternion.identity);

            x_train_sphere = UnityEngine.Random.Range(-0.1f, -0.1f);
            temp_cube = Instantiate(train_sphere, new Vector3(x_train_sphere, 2.5f, -2f), Quaternion.identity);

            x_train_sphere = UnityEngine.Random.Range(0.1f, 0.1f);
            temp_cube = Instantiate(train_sphere, new Vector3(x_train_sphere, 1.5f, -2f), Quaternion.identity);

            x_train_sphere = UnityEngine.Random.Range(-0.1f, -0.1f);
            temp_cube = Instantiate(train_sphere, new Vector3(x_train_sphere, 1, -1.5f), Quaternion.identity);

            x_train_sphere = UnityEngine.Random.Range(1f, 1f);
            temp_cube = Instantiate(train_sphere, new Vector3(x_train_sphere, 2, -1f), Quaternion.identity);
        }


        //InvokeRepeating(a,b,c) -> Invokes the method "a" in "b" seconds, then repeatedly every "c" seconds.

        if (Input.GetKeyUp(KeyCode.A))
        {
            CancelInvoke();
            timer_i = 0;
            InvokeRepeating("timer_one_color", 0, .4f);
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            CancelInvoke();
            timer_i = 0;
            InvokeRepeating("timer_0", 0, .4f);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            CancelInvoke();
            timer_i = 0;
            InvokeRepeating("timer_faster", 0, .4f);
        }
        if (Input.GetKeyUp(KeyCode.F))
        {
            CancelInvoke();
            timer_i = 0;
            InvokeRepeating("timer_third", 0, .4f);
        }
        /*
        if (Input.GetKeyUp(KeyCode.F))
        {
            CancelInvoke();
            timer_i = 0;
            InvokeRepeating("timer_fruit", 0, .4f);
        }
        */
    }

    void timer_one_color()
    {
        timer_i += 1;

        if (timer_i <= 40)
        {
            float x_red = UnityEngine.Random.Range(-0.7f, 1.5f);
            float drag_red = UnityEngine.Random.Range(13.0f, 17.0f);
            red.GetComponent<Rigidbody>().drag = drag_red;
            temp_red = Instantiate(red, new Vector3(x_red, 5, -1.5f), Quaternion.identity);
        }
        else if (timer_i == 65)
        {
            string path = "C:/Users/user/Desktop/record_txt/one_color.txt";

            temp = velocity.avg / velocity.num;

            for (int i = 0; i < velocity.num; i++)
            {
                square += (velocity.vel[i] - temp) * (velocity.vel[i] - temp);
            }

            std_dev = Math.Sqrt(square / (velocity.num - 1));

            //Write some text to the test.txt file
            StreamWriter writer = new StreamWriter(path, true);
            writer.WriteLine("Average= " + temp);
            writer.WriteLine("Max= " + velocity.max);
            writer.WriteLine("Standard Deviation= " + std_dev);
            writer.WriteLine("Right: " + GameManager.gameScore_right + "    Miss: " + (40-GameManager.gameScore_right) );
            writer.Close();


            print("average= " + temp);
            print("Max= " + velocity.max);
            print("std_dev = " + std_dev);

        }

    }

    void timer_0()
    {
        timer_i += 1;

        if (timer_i <= 30)
        {
            float x_red = UnityEngine.Random.Range(-0.7f, 1.5f);
            float drag_red = UnityEngine.Random.Range(13.0f, 17.0f);
            red.GetComponent<Rigidbody>().drag = drag_red;
            temp_red = Instantiate(red, new Vector3(x_red, 5, -1.5f), Quaternion.identity);

            float x_black = UnityEngine.Random.Range(-0.7f, 1.5f);
            float drag_black = UnityEngine.Random.Range(10.0f, 20.0f);
            black.GetComponent<Rigidbody>().drag = drag_black;
            temp_black = Instantiate(black, new Vector3(x_black, 5, -1.5f), Quaternion.identity);
        }
        else if (timer_i == 60)
        {
            string path = "C:/Users/user/Desktop/record_txt/normal.txt";

            temp = velocity.avg / velocity.num;

            for (int i = 0; i < velocity.num; i++)
            {
                square += (velocity.vel[i] - temp) * (velocity.vel[i] - temp);
            }

            std_dev = Math.Sqrt(square / (velocity.num - 1));

            //Write some text to the test.txt file
            StreamWriter writer = new StreamWriter(path, true);
            writer.WriteLine("Average= " + temp);
            writer.WriteLine("Max= " + velocity.max);
            writer.WriteLine("Standard Deviation= " + std_dev);
            writer.WriteLine("Right: " + GameManager.gameScore_right + "    Wrong: " + GameManager.gameScore_wrong);
            writer.Close();

            
            print("average= " + temp);
            print("Max= " + velocity.max);
            print("std_dev = " + std_dev);


        }
        
    }

    
    void timer_faster()
    {
        timer_i += 1;

        if (timer_i <= 30)
        {
            float x_red = UnityEngine.Random.Range(-0.7f, 1.5f);
            float drag_red = UnityEngine.Random.Range(7.0f, 11.0f);
            red.GetComponent<Rigidbody>().drag = drag_red;
            temp_red = Instantiate(red, new Vector3(x_red, 5, -1.5f), Quaternion.identity);

            float x_black = UnityEngine.Random.Range(-0.7f, 1.5f);
            float drag_sphere = UnityEngine.Random.Range(4.0f, 11.0f);
            black.GetComponent<Rigidbody>().drag = drag_sphere;
            temp_sphere = Instantiate(black, new Vector3(x_black, 5, -1.5f), Quaternion.identity);
            
        }
        else if (timer_i == 45)
        {

            string path = "C:/Users/user/Desktop/record_txt/faster.txt";

            temp = velocity.avg / velocity.num;

            for (int i = 0; i < velocity.num; i++)
            {
                square += (velocity.vel[i] - temp) * (velocity.vel[i] - temp);
            }

            std_dev = Math.Sqrt(square / (velocity.num - 1));

            //Write some text to the test.txt file
            StreamWriter writer = new StreamWriter(path, true);
            writer.WriteLine("Average= " + temp);
            writer.WriteLine("Max= " + velocity.max);
            writer.WriteLine("Standard Deviation= " + std_dev);
            writer.WriteLine("Right: " + GameManager.gameScore_right + "    Wrong: " + GameManager.gameScore_wrong);
            writer.Close();

            print("average= " + temp);
            print("Max= " + velocity.max);
            print("std_dev = " + std_dev);

        }

    }

    void timer_third()
    {
        timer_i += 1;

        if (timer_i <= 20)
        {

            float x_red = UnityEngine.Random.Range(-0.7f, 1.5f);
            float drag_red = UnityEngine.Random.Range(13.0f, 17.0f);
            red.GetComponent<Rigidbody>().drag = drag_red;
            temp_red = Instantiate(red, new Vector3(x_red, 5, -1.5f), Quaternion.identity);
            var yellow_ball = temp_red.GetComponent<Renderer>();
            yellow_ball.material.SetColor("_Color", Color.yellow);

            float x_black = UnityEngine.Random.Range(-0.7f, 1.5f);
            float drag_black = UnityEngine.Random.Range(10.0f, 20.0f);
            black.GetComponent<Rigidbody>().drag = drag_black;
            temp_black = Instantiate(black, new Vector3(x_black, 5, -1.5f), Quaternion.identity);
            var purple_ball = temp_black.GetComponent<Renderer>();
            Color purple = new Color(0.5f, 0, 0.65f, 0.9f);
            purple_ball.material.SetColor("_Color", purple);

            float x_third = UnityEngine.Random.Range(-0.7f, 1.5f);
            float drag_third = UnityEngine.Random.Range(10.0f, 20.0f);
            third.GetComponent<Rigidbody>().drag = drag_third;
            temp_third = Instantiate(third, new Vector3(x_third, 5, -1.5f), Quaternion.identity);
            
        }
        else if (timer_i == 55)
        {

            string path = "C:/Users/user/Desktop/record_txt/third.txt";

            // used to coupute standard deviation
            temp = velocity.avg / velocity.num;
            for (int i = 0; i < velocity.num; i++)
            {
                square += (velocity.vel[i] - temp) * (velocity.vel[i] - temp);
            }
            std_dev = Math.Sqrt(square / (velocity.num - 1));

            //Write some text to the test.txt file
            StreamWriter writer = new StreamWriter(path, true);
            writer.WriteLine("Average= " + temp);
            writer.WriteLine("Max= " + velocity.max);
            writer.WriteLine("Standard Deviation= " + std_dev);
            writer.WriteLine("Right: " + GameManager.gameScore_right + "    Wrong: " + GameManager.gameScore_wrong);
            writer.Close();

            print("average= " + temp);
            print("Max= " + velocity.max);
            print("std_dev = " + std_dev);

        }

    }

    /*
    void timer_fruit()
    {
        timer_i += 1;

        if (timer_i <= 30)
        {
            float x_cube = UnityEngine.Random.Range(-0.7f, 1.5f);
            float drag_cube = UnityEngine.Random.Range(13.0f, 17.0f);
            apple.GetComponent<Rigidbody>().drag = drag_cube;
            temp_apple = Instantiate(apple, new Vector3(x_cube, 5, -1.5f), Quaternion.identity);
            cube_count++;

            float x_sphere = UnityEngine.Random.Range(-0.7f, 1.5f);
            float drag_sphere = UnityEngine.Random.Range(10.0f, 20.0f);
            banana.GetComponent<Rigidbody>().drag = drag_sphere;
            temp_banana = Instantiate(banana, new Vector3(x_sphere, 5, -1.5f), Quaternion.identity);
            sphere_count++;
        }
        else if (timer_i >= 60)
        {

            temp = velocity.avg / velocity.num;
            print("average= " + temp);
            print("Max= " + velocity.max);


        }

    }
    */



    // Update is called once per frame
    /*
	void Update () {

        //UnityEngine.Random.Range(最小值, 最大值);
        //temp = Instantiate(cube, transform.position, Quaternion.identity);
        //temp.transform.position = new Vector3(5, 5, 5);

    }
    */


}
