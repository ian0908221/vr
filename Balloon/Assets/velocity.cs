using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Linq;
using System;

public class velocity : MonoBehaviour
{
    public static int num = 0;
    public static double avg = 0;
    public static double max = 0;
    Vector3 pos1 = new Vector3();
    Vector3 pos2 = new Vector3();
    public Rigidbody rb;
    public int timer = 0;
    int mode;
    string path;
    double x, y, z;
    public static double[] vel = new double[240];
    int count = 0;
    
    Vector3 Get(Vector3 localpos)
    {
        return rb.GetPointVelocity(transform.TransformPoint(localpos));
    }


    void timer_4()
    {
        //Debug.Log(Get(GameObject.Find("RightHand").transform.position));
        //temp2 = temp1;
        //temp1 = Time.realtimeSinceStartup;
        double time = 0.1f;

        pos2 = pos1;
        pos1 = transform.position;
        Vector3 pos = pos1 - pos2;

        double compute = (Math.Sqrt(pos.sqrMagnitude) ) / time; // velocity per 0.1 second
        compute *= 10; // convert to velocity per 1 second
        if(generator.timer_i <= timer )
        {
            num++;
            if(compute > max && num >= 5)
            {
                max = compute;
            }
            avg += compute;

            switch (mode)
            {
                case 1:
                    path = "C:/Users/user/Desktop/record_txt/one_color.txt";
                    break;
                case 2:
                    path = "C:/Users/user/Desktop/record_txt/normal.txt";
                    break;
                case 3:
                    path = "C:/Users/user/Desktop/record_txt/faster.txt";
                    break;
                case 4:
                    path = "C:/Users/user/Desktop/record_txt/third.txt";
                    break;
                default:
                    break;
            }

            x = transform.position.x;
            y = transform.position.y;
            z = transform.position.z;

            vel[count] = compute;
            count++;

            //Write some text to the test.txt file
            StreamWriter writer = new StreamWriter(path, true);
            writer.WriteLine("compute " + compute + "   (" + x + "," + y + "," + z + ")" + " " + pos1);
            writer.Close();

            print("compute " + compute);

        }
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.A))
        {
            max = 0;
            avg = 0;
            num = 0;
            timer = 60;
            generator.square = 0;
            count = 0;


            CancelInvoke();
            mode = 1;
            InvokeRepeating("timer_4", 0, .1f);

        }
        else if ( Input.GetKeyUp(KeyCode.S) )
        {
            max = 0;
            avg = 0;
            num = 0;
            timer = 55;
            generator.square = 0;
            count = 0;


            CancelInvoke();
            mode = 2;
            InvokeRepeating("timer_4", 0, .1f);
            
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            max = 0;
            avg = 0;
            num = 0;
            timer = 40;
            generator.square = 0;
            count = 0;

            CancelInvoke();
            mode = 3;
            InvokeRepeating("timer_4", 0, .1f);
        }
        else if (Input.GetKeyUp(KeyCode.F))
        {
            max = 0;
            avg = 0;
            num = 0;
            timer = 50;
            generator.square = 0;
            count = 0;

            CancelInvoke();
            mode = 4;
            InvokeRepeating("timer_4", 0, .1f);
        }
    }



}
