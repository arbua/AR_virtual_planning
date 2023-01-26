﻿using UnityEngine;

using System.Collections.Generic;

using System;


[Serializable]

public class SubMeshes 

{

    public MeshRenderer meshRenderer;

    public Vector3 originalPosition;

    public Vector3 explodedPosition;

}


public class ThreeDModelFunctions : MonoBehaviour

{

    #region Variables


    public List<SubMeshes> childMeshRenderers;

    bool isInExplodedView = false;

    public float explosionSpeed = 0.1f;

    bool isMoving = false;


    #endregion


    #region UnityFunctions


    private void Awake()

    {

        childMeshRenderers = new List<SubMeshes>();


        foreach (var item in GetComponentsInChildren<MeshRenderer>())

        {

            SubMeshes mesh = new SubMeshes();

            mesh.meshRenderer = item;

            mesh.originalPosition = item.transform.position;

            mesh.explodedPosition = item.bounds.center * 1.5f;

            childMeshRenderers.Add(mesh);

        }

    }


    private void Update()

    {

        if (isMoving)

        {

            if (isInExplodedView)

            {

                foreach (var item in childMeshRenderers)

                {

                    item.meshRenderer.transform.position = Vector3.Lerp(item.meshRenderer.transform.position, item.explodedPosition, explosionSpeed);


                    if (Vector3.Distance(item.meshRenderer.transform.position, item.explodedPosition) < 0.001f)

                    {

                        isMoving = false;

                    }

                }

            }

            else

            {

                foreach (var item in childMeshRenderers)

                {

                    item.meshRenderer.transform.position = Vector3.Lerp(item.meshRenderer.transform.position, item.originalPosition, explosionSpeed);


                    if (Vector3.Distance(item.meshRenderer.transform.position, item.originalPosition) < 0.001f)

                    {

                        isMoving = false;

                    }

                }

            }

        }

    }


    #endregion


    #region CustomFunctions


    public void ToggleExplodedView()

    {

        if (isInExplodedView)

        {

            isInExplodedView = false;

            isMoving = true;

        }

        else

        {

            isInExplodedView = true;

            isMoving = true;

        }

    }


    #endregion

}