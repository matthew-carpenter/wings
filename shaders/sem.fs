// $Id:$
//
// vertex to fragment shader io

varying vec3 N;
varying vec3 I;
varying vec4 Cs;
varying vec3 LightDir;

float edgefalloff = 1.0;

void main()
{
    float opac = dot(normalize(N), normalize(-LightDir));
    //float opac = dot(normalize(N), normalize(-I));
    opac = abs(opac);
    opac = 1.0-pow(opac, edgefalloff);
    //opac = 1.0 - opac;

    gl_FragColor =  opac * Cs;
    //gl_FragColor.a = opac;
}
